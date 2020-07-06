using CSC.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC.Server
{
	public partial class MainForm : Form
	{
        private struct ClientInfo
        {
            public Socket Socket { get; set; }
            public string Name { get; set; }
        }

        private readonly List<ClientInfo> clientList = new List<ClientInfo>();

        private Socket serverSocket;

        private readonly byte[] byteData = new byte[1024];

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                var ipEndPoint = new IPEndPoint(IPAddress.Any, 1111);

                serverSocket.Bind(ipEndPoint);
                serverSocket.Listen(10);

                serverSocket.BeginAccept(new AsyncCallback(OnAccept), null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TcpChat.Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnAccept(IAsyncResult ar)
        {
            try
            {
                Socket clientSocket = serverSocket.EndAccept(ar);

                serverSocket.BeginAccept(new AsyncCallback(OnAccept), null);

                clientSocket.BeginReceive(byteData, 0, byteData.Length, SocketFlags.None,
                    new AsyncCallback(OnReceive), clientSocket);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TcpChat.Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnReceive(IAsyncResult ar)
        {
            try
            {
                Socket clientSocket = (Socket)ar.AsyncState;
                clientSocket.EndReceive(ar);

                var msgReceived = new Data(byteData);

                var msgToSend = new Data
                {
                    Command = msgReceived.Command,
                    Name = msgReceived.Name
                };

                byte[] message;

                switch (msgReceived.Command)
                {
                    case Command.Login:

                        clientList.Add(new ClientInfo
                        {
                            Socket = clientSocket,
                            Name = msgReceived.Name
                        });

                        msgToSend.Message = $"<<<{msgReceived.Name} присоединился к чату>>>";
                        break;

                    case Command.Logout:

                        clientList.RemoveAt(clientList.FindIndex(c => c.Socket == clientSocket));

                        clientSocket.Close();

                        msgToSend.Message = $"<<<{msgReceived.Name} покинул чат>>>";
                        break;

                    case Command.Message:

                        msgToSend.Message = $"{msgReceived.Name}: {msgReceived.Message}";
                        break;

                    case Command.List:

                        msgToSend.Name = null;
                        msgToSend.Message = null;

                        foreach (var client in clientList)
                        {
                            msgToSend.Message += $"{client.Name}|";
                        }

                        message = msgToSend.ToByte();

                        clientSocket.BeginSend(message, 0, message.Length, SocketFlags.None,
                            new AsyncCallback(OnSend), clientSocket);
                        break;
                }

                if (msgToSend.Command != Command.List)
                {
                    message = msgToSend.ToByte();

                    foreach (var client in clientList)
                    {
                        if (client.Socket != clientSocket || msgToSend.Command != Command.Login)
                        {
                            client.Socket.BeginSend(message, 0, message.Length, SocketFlags.None,
                                new AsyncCallback(OnSend), client.Socket);
                        }
                    }

                    textBoxLog.Text += $"{msgToSend.Message}\r\n";
                }

                if (msgReceived.Command != Command.Logout)
                {
                    clientSocket.BeginReceive(byteData, 0, byteData.Length, SocketFlags.None,
                        new AsyncCallback(OnReceive), clientSocket);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TcpChat.Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void OnSend(IAsyncResult ar)
        {
            try
            {
                Socket clientSocket = (Socket)ar.AsyncState;
                clientSocket.EndSend(ar);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TcpChat.Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
