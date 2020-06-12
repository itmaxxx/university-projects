using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace SPExplorerThread
{
	public partial class Spectator : Form
	{
		private Thread Thread1;
		public string Path;

		public Spectator()
		{
			InitializeComponent();
		}

		private void Spectate()
		{
			while (true)
			{
				FileInfo[] files = new DirectoryInfo(Path).GetFiles();

				filesCountLabel.BeginInvoke((MethodInvoker)(() => filesCountLabel.Text = $"Files count : {files.Length.ToString()}"));

				double totalSizeInKB = 0f;

				foreach (var file in files)
				{
					totalSizeInKB += file.Length / 1024;
				}
				
				filesTotalSizeLabel.BeginInvoke((MethodInvoker)(() => filesTotalSizeLabel.Text = $"Total file size : {Math.Round((totalSizeInKB / 1024)).ToString()} MB"));

				Thread.Sleep(1000);
			}
		}

		private void Spectator_Load(object sender, EventArgs e)
		{
			pathLabel.Text = Path;

			Thread1 = new Thread(new ThreadStart(Spectate));
			Thread1.Start();
		}

		private void StopButton_Click(object sender, EventArgs e)
		{
			this.BeginInvoke((MethodInvoker)(() => this.Close()));
		}
	}
}
