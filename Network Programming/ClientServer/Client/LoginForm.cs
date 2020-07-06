using CSC.Classes;
using System;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace CSC.Client
{
	public partial class LoginForm : Form
	{
		public Socket ClientSocket { get; set; }
		public string ClientName { get; set; }

		public LoginForm()
		{
			InitializeComponent();
		}

		private void buttonLogin_Click(object sender, EventArgs e)
		{
			try
			{
				ClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

				var ipAddress = IPAddress.Parse(textBoxIP.Text.Trim());
				var ipEndPoint = new IPEndPoint(ipAddress, 1111);

				ClientSocket.BeginConnect(ipEndPoint, new AsyncCallback(OnConnect), null);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "TcpChat.Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void OnConnect(IAsyncResult ar)
		{
			try
			{
				ClientSocket.EndConnect(ar);

				var msgToSend = new Data
				{
					Command = Command.Login,
					Name = textBoxName.Text.Trim(),
					ToUser = null,
					Message = null
				};

				byte[] byteMsgToSend = msgToSend.ToByte();

				ClientSocket.BeginSend(byteMsgToSend, 0, byteMsgToSend.Length, SocketFlags.None,
					new AsyncCallback(OnSend), null);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "TcpChat.Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void OnSend(IAsyncResult ar)
		{
			try
			{
				ClientSocket.EndSend(ar);
				ClientName = textBoxName.Text.Trim();
				DialogResult = DialogResult.OK;
				Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "TcpChat.Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void LoginForm_Load(object sender, EventArgs e)
		{
			CheckForIllegalCrossThreadCalls = false;
		}

		private void textBoxes_TextChanged(object sender, EventArgs e)
		{
			buttonLogin.Enabled = textBoxName.Text.Trim().Length > 0 && textBoxIP.Text.Trim().Length > 0;
		}
	}
}
