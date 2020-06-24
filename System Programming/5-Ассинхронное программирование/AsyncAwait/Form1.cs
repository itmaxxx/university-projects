using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncAwait
{
	public partial class FileCopier : Form
	{
		const int bufferSize = 4096;

		static void CopyFile(Form form, OpenFileDialog openSourceFile, OpenFileDialog openDestinationFile, ProgressBar progressBar)
		{
			double oneBlockPercent;
			double progress = 0d;

			using (var sourceFileStream = File.OpenRead(openSourceFile.FileName))
			{
				oneBlockPercent = 100d / (sourceFileStream.Length / bufferSize);

				using (var streamReader = new StreamReader(sourceFileStream, Encoding.UTF8, true, bufferSize))
				{
					using (var streamWriter = new StreamWriter(openDestinationFile.FileName, false, Encoding.UTF8, bufferSize))
					{
						char[] buffer = new char[bufferSize];

						int len = 0;
						int blocks = 0;

						while ((len = streamReader.ReadBlock(buffer, 0, bufferSize)) != 0)
						{
							blocks++;

							streamWriter.Write(buffer, 0, len);

							form.Text = $"{len} {blocks}";

							if (progress + oneBlockPercent > 100)
							{
								progress = 100;
							}
							else
							{
								progress += oneBlockPercent;
							}

							progressBar.Value = (int)progress;

							Thread.Sleep(100);
						}
					}
				}
			}
		}

		static async void CopyFileHandler(Form form, OpenFileDialog openSourceFile, OpenFileDialog openDestinationFile, ProgressBar progressBar)
		{
			await Task.Run(() => CopyFile(form, openSourceFile, openDestinationFile, progressBar));
		}

		public FileCopier()
		{
			InitializeComponent();
		}

		private void selectSource_Click(object sender, EventArgs e)
		{
			openSourceFile.ShowDialog();
		}

		private void selectDestination_Click(object sender, EventArgs e)
		{
			openDestinationFile.ShowDialog();
		}

		private void copyFile_Click(object sender, EventArgs e)
		{
			if (openSourceFile.FileName == string.Empty)
			{
				MessageBox.Show("No source file selected");

				return;
			}
			if (openDestinationFile.FileName == string.Empty)
			{
				MessageBox.Show("No destination file selected");

				return;
			}

			CopyFileHandler(this, openSourceFile, openDestinationFile, progressBar);
		}
	}
}
