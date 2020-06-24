namespace AsyncAwait
{
	partial class FileCopier
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.copyFile = new System.Windows.Forms.Button();
			this.selectDestination = new System.Windows.Forms.Button();
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.selectSource = new System.Windows.Forms.Button();
			this.openSourceFile = new System.Windows.Forms.OpenFileDialog();
			this.openDestinationFile = new System.Windows.Forms.OpenFileDialog();
			this.SuspendLayout();
			// 
			// copyFile
			// 
			this.copyFile.Location = new System.Drawing.Point(12, 192);
			this.copyFile.Name = "copyFile";
			this.copyFile.Size = new System.Drawing.Size(776, 53);
			this.copyFile.TabIndex = 7;
			this.copyFile.Text = "Copy";
			this.copyFile.UseVisualStyleBackColor = true;
			this.copyFile.Click += new System.EventHandler(this.copyFile_Click);
			// 
			// selectDestination
			// 
			this.selectDestination.Location = new System.Drawing.Point(12, 133);
			this.selectDestination.Name = "selectDestination";
			this.selectDestination.Size = new System.Drawing.Size(776, 53);
			this.selectDestination.TabIndex = 6;
			this.selectDestination.Text = "Destination";
			this.selectDestination.UseVisualStyleBackColor = true;
			this.selectDestination.Click += new System.EventHandler(this.selectDestination_Click);
			// 
			// progressBar
			// 
			this.progressBar.Location = new System.Drawing.Point(12, 15);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(776, 53);
			this.progressBar.TabIndex = 5;
			// 
			// selectSource
			// 
			this.selectSource.Location = new System.Drawing.Point(12, 74);
			this.selectSource.Name = "selectSource";
			this.selectSource.Size = new System.Drawing.Size(776, 53);
			this.selectSource.TabIndex = 4;
			this.selectSource.Text = "Source";
			this.selectSource.UseVisualStyleBackColor = true;
			this.selectSource.Click += new System.EventHandler(this.selectSource_Click);
			// 
			// openSourceFile
			// 
			this.openSourceFile.FileName = "C:\\Users\\dmitr\\Documents\\source.txt";
			this.openSourceFile.Filter = ".txt file|*.txt";
			// 
			// openDestinationFile
			// 
			this.openDestinationFile.FileName = "C:\\Users\\dmitr\\Documents\\destination.txt";
			this.openDestinationFile.Filter = ".txt file|*.txt";
			// 
			// FileCopier
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 259);
			this.Controls.Add(this.copyFile);
			this.Controls.Add(this.selectDestination);
			this.Controls.Add(this.progressBar);
			this.Controls.Add(this.selectSource);
			this.Name = "FileCopier";
			this.Text = "File Copier";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button copyFile;
		private System.Windows.Forms.Button selectDestination;
		private System.Windows.Forms.ProgressBar progressBar;
		private System.Windows.Forms.Button selectSource;
		private System.Windows.Forms.OpenFileDialog openSourceFile;
		private System.Windows.Forms.OpenFileDialog openDestinationFile;
	}
}

