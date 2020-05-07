using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPExplorerThread
{
	public partial class Form1 : Form
	{
		private Spectator spectator;

		public Form1()
		{
			InitializeComponent();
		}

		private void BrowseDirectory_Click(object sender, EventArgs e)
		{
			folderBrowserDialog1.ShowDialog();

			directoryPath.Text = folderBrowserDialog1.SelectedPath;
		}

		private void Spectate_Click(object sender, EventArgs e)
		{
			if (spectator == null)
			{
				spectator = new Spectator();
				spectator.Path = folderBrowserDialog1.SelectedPath;
				spectator.Show();
			}
			else
			{
				MessageBox.Show("Another spectator already opened", "Error");
			}
		}
	}
}
