using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPTimer
{
	public partial class Form1 : Form
	{
		private Thread t1;
		private Thread t2;
		private Thread t3;

		public Form1()
		{
			InitializeComponent();
		}

		private void ThreadProc1()
		{
			for (int i = 1; i > 0; i++)
			{
				label1.BeginInvoke((MethodInvoker)(() => label1.Text = $"{i}"));
				Thread.Sleep(500);
			}
		}

		private void ThreadProc2()
		{
			for (int i = 1; i > 0; i++)
			{
				label2.BeginInvoke((MethodInvoker)(() => label2.Text = $"{i}"));
				Thread.Sleep(1000);
			}
		}

		private void ThreadProc3()
		{
			for (int i = 1; i > 0; i++)
			{
				label3.BeginInvoke((MethodInvoker)(() => label3.Text = $"{i}"));
				Thread.Sleep(1500);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			// Start

			t1 = new Thread(new ThreadStart(ThreadProc1));
			t1.Start();

			t2 = new Thread(new ThreadStart(ThreadProc2));
			t2.Start();

			t3 = new Thread(new ThreadStart(ThreadProc3));
			t3.Start();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			// Stop

			if (t1 == null || t2 == null || t3 == null)
				MessageBox.Show("You haven't started timer yet", "Error");
			else
			{
				t1.Abort();
				t2.Abort();
				t3.Abort();
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			// Reset

			t1.Abort();
			t2.Abort();
			t3.Abort();

			label1.Text = "0";
			label2.Text = "0";
			label3.Text = "0";
		}
	}
}
