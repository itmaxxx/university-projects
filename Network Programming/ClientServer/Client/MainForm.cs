using CSC.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
	public partial class MainForm : Form
	{
		public Socket ClientSocket { get; set; } // Главный клиентский сокет
		public string ClientName { get; set; }   // Имя, под которым клиент входит в чат

		private byte[] byteData = new byte[1024];

		public MainForm()
		{
			InitializeComponent();
		}

        private void MainForm_Load(object sender, EventArgs e)
        {
            Text = $"TcpChat.Client: {ClientName}";

            var msgToSend = new Data
            {
                Command = Command.List,
                Name = ClientName,
                ToUser = null,
                Message = null
            };

			byteData = msgToSend.ToByte();

			ClientSocket.BeginSend(byteData, 0, byteData.Length, SocketFlags.None,
				new AsyncCallback(OnSend), null);

			byteData = new byte[1024];

            ClientSocket.BeginReceive(byteData, 0, byteData.Length, SocketFlags.None,
                new AsyncCallback(OnReceive), null);
        }

        private void OnSend(IAsyncResult ar)
        {
            try
            {
                ClientSocket.EndSend(ar);
            }
            catch (ObjectDisposedException)
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, $"TcpChat.Client: {ClientName}",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnReceive(IAsyncResult ar)
        {
            try
            {
                ClientSocket.EndReceive(ar);

                var msgReceived = new Data(byteData);

                switch (msgReceived.Command)
                {
                    case Command.NameChanged:
                        ClientName = msgReceived.Name;
                        Text = $"TcpChat.Client: {ClientName}";
                        listBoxUsers.Items.Remove(ClientName);
                        MessageBox.Show($"Выбраное имя уже занято, вам автоматически был присвоен номер, ваше новое имя: \"{ClientName}\"");
                        break;

                    case Command.Login:
                        listBoxUsers.Items.Add(msgReceived.Name);
                        break;

                    case Command.Logout:
                        listBoxUsers.Items.Remove(msgReceived.Name);
                        break;

                    case Command.Message:
                        break;

                    case Command.List:
                        listBoxUsers.Items.Clear();
                        listBoxUsers.Items.AddRange(msgReceived.Message.Split('|'));
                        listBoxUsers.Items.RemoveAt(listBoxUsers.Items.Count - 1);
                        textBoxChat.Text += $"{ClientName} присоединился к чату\r\n";
                        break;
                }

                if (msgReceived.Message != null && msgReceived.Command != Command.List)
                    textBoxChat.Text += $"{msgReceived.Message}\r\n";

                byteData = new byte[1024];

                ClientSocket.BeginReceive(byteData, 0, byteData.Length, SocketFlags.None,
                    new AsyncCallback(OnReceive), null);
            }
            catch (ObjectDisposedException)
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, $"TcpChat.Client: {ClientName}",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите покинуть чат?", $"TcpChat.Client: {ClientName}",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }

            try
            {
                var msgToSend = new Data
                {
                    Command = Command.Logout,
                    Name = ClientName,
                    ToUser = null,
                    Message = null
                };

                byte[] byteData = msgToSend.ToByte();

                ClientSocket.Send(byteData, 0, byteData.Length, SocketFlags.None);
                ClientSocket.Close();
            }
            catch (ObjectDisposedException)
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, $"TcpChat.Client: {ClientName}",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

		private void textBoxMessage_KeyDown(object sender, KeyEventArgs e)
		{
            if (e.KeyCode == Keys.Enter)
                buttonSend_Click(sender, null);
        }

		private void buttonSend_Click(object sender, EventArgs e)
		{
            try
            {
                bool isPM = listBoxUsers.SelectedIndex != -1;

                var msgToSend = new Data
                {
                    Command = (isPM ? Command.PMessage : Command.Message),
                    Name = ClientName,
                    ToUser = (isPM ? listBoxUsers.SelectedItem.ToString() : null),
                    Message = textBoxMessage.Text.Trim()
                };

                byte[] byteData = msgToSend.ToByte();

                ClientSocket.BeginSend(byteData, 0, byteData.Length, SocketFlags.None,
                    new AsyncCallback(OnSend), null);

                textBoxMessage.Text = null;
            }
            catch (Exception)
            {
                MessageBox.Show("Не могу отослать сообщение серверу.", $"TcpChat.Client: {ClientName}",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

		private void textBoxMessage_TextChanged(object sender, EventArgs e)
		{
            buttonSend.Enabled = textBoxMessage.Text.Trim().Length > 0;
        }
	}
}
