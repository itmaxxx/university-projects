namespace SPExplorerThread
{
	partial class Form1
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
			this.browseDirectory = new System.Windows.Forms.Button();
			this.spectate = new System.Windows.Forms.Button();
			this.directoryPath = new System.Windows.Forms.TextBox();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.SuspendLayout();
			// 
			// browseDirectory
			// 
			this.browseDirectory.Location = new System.Drawing.Point(197, 12);
			this.browseDirectory.Name = "browseDirectory";
			this.browseDirectory.Size = new System.Drawing.Size(75, 23);
			this.browseDirectory.TabIndex = 0;
			this.browseDirectory.Text = "Browse";
			this.browseDirectory.UseVisualStyleBackColor = true;
			this.browseDirectory.Click += new System.EventHandler(this.BrowseDirectory_Click);
			// 
			// spectate
			// 
			this.spectate.Location = new System.Drawing.Point(13, 41);
			this.spectate.Name = "spectate";
			this.spectate.Size = new System.Drawing.Size(259, 23);
			this.spectate.TabIndex = 1;
			this.spectate.Text = "Spectate";
			this.spectate.UseVisualStyleBackColor = true;
			this.spectate.Click += new System.EventHandler(this.Spectate_Click);
			// 
			// directoryPath
			// 
			this.directoryPath.Location = new System.Drawing.Point(12, 14);
			this.directoryPath.Name = "directoryPath";
			this.directoryPath.Size = new System.Drawing.Size(179, 20);
			this.directoryPath.TabIndex = 2;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 77);
			this.Controls.Add(this.directoryPath);
			this.Controls.Add(this.spectate);
			this.Controls.Add(this.browseDirectory);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button browseDirectory;
		private System.Windows.Forms.Button spectate;
		private System.Windows.Forms.TextBox directoryPath;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
	}
}

