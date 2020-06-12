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

namespace SPCounter
{
	public partial class Form1 : Form
	{
		private Thread thread1;
		private Thread thread2;

		public Form1()
		{
			InitializeComponent();
		}

		private void Counter1()
		{
			int destination = int.Parse(textBox1.Text);

			for (int i = 1; i <= destination; i++)
			{
				label1.BeginInvoke((MethodInvoker)(() => label1.Text = $"{destination} + {i} = {destination + i}"));

				Thread.Sleep(500);
			}
		}

		private void Counter2()
		{
			int destination = int.Parse(textBox2.Text);

			for (int i = 1; i <= destination; i++)
			{
				label2.BeginInvoke((MethodInvoker)(() => label2.Text = $"{destination} + {i} = {destination + i}"));


				Thread.Sleep(500);
			}
		}

		private bool IsNumber(TextBox tb)
		{
			int res;

			if (int.TryParse(tb.Text, out res))
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (!IsNumber(textBox1))
			{
				MessageBox.Show("Enter number first", "Error");

				textBox1.Text = "";

				return;
			}

			if (thread1 == null)
			{
				thread1 = new Thread(new ThreadStart(Counter1));
				thread1.Start();

				button1.Text = "Stop";
			}
			else
			{
				thread1.Abort();
				thread1 = null;

				button1.Text = "Start";
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (!IsNumber(textBox2))
			{
				MessageBox.Show("Enter number first", "Error");

				textBox2.Text = "";

				return;
			}

			if (thread2 == null)
			{
				thread2 = new Thread(new ThreadStart(Counter2));
				thread2.Start();

				button2.Text = "Stop";
			}
			else
			{
				thread2.Abort();
				thread2 = null;

				button2.Text = "Start";
			}
		}
	}
}
