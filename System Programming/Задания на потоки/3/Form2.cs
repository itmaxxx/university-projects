using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace SPModalWindow
{
	public partial class Form2 : Form
	{
		private Thread thread1;

		public Form2()
		{
			InitializeComponent();
		}

		private void Timer()
		{
			for (int i = 1; i <= 20; i++)
			{
				label1.BeginInvoke((MethodInvoker)(() => label1.Text = i.ToString()));
				Thread.Sleep(500);
			}

			Close();
		}

		private void Form2_Load(object sender, EventArgs e)
		{
			thread1 = new Thread(new ThreadStart(Timer));
			thread1.Start();
		}
	}
}
