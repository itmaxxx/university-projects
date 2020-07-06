using Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC.Client
{
	static class Program
	{
		/// <summary>
		/// Главная точка входа для приложения.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			var loginForm = new LoginForm();

			Application.Run(loginForm);
			if (loginForm.DialogResult == DialogResult.OK)
			{
				var mainForm = new MainForm
				{
					ClientSocket = loginForm.ClientSocket,
					ClientName = loginForm.ClientName
				};

				mainForm.ShowDialog();
			}
		}
	}
}
