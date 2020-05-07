namespace SPExplorerThread
{
	partial class Spectator
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.pathLabel = new System.Windows.Forms.Label();
			this.filesCountLabel = new System.Windows.Forms.Label();
			this.filesTotalSizeLabel = new System.Windows.Forms.Label();
			this.stopButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// pathLabel
			// 
			this.pathLabel.AutoSize = true;
			this.pathLabel.Location = new System.Drawing.Point(12, 9);
			this.pathLabel.Name = "pathLabel";
			this.pathLabel.Size = new System.Drawing.Size(28, 13);
			this.pathLabel.TabIndex = 0;
			this.pathLabel.Text = "path";
			// 
			// filesCountLabel
			// 
			this.filesCountLabel.AutoSize = true;
			this.filesCountLabel.Location = new System.Drawing.Point(12, 26);
			this.filesCountLabel.Name = "filesCountLabel";
			this.filesCountLabel.Size = new System.Drawing.Size(54, 13);
			this.filesCountLabel.TabIndex = 1;
			this.filesCountLabel.Text = "Loading...";
			// 
			// filesTotalSizeLabel
			// 
			this.filesTotalSizeLabel.AutoSize = true;
			this.filesTotalSizeLabel.Location = new System.Drawing.Point(12, 39);
			this.filesTotalSizeLabel.Name = "filesTotalSizeLabel";
			this.filesTotalSizeLabel.Size = new System.Drawing.Size(54, 13);
			this.filesTotalSizeLabel.TabIndex = 2;
			this.filesTotalSizeLabel.Text = "Loading...";
			// 
			// stopButton
			// 
			this.stopButton.Location = new System.Drawing.Point(15, 56);
			this.stopButton.Name = "stopButton";
			this.stopButton.Size = new System.Drawing.Size(257, 23);
			this.stopButton.TabIndex = 3;
			this.stopButton.Text = "Stop";
			this.stopButton.UseVisualStyleBackColor = true;
			this.stopButton.Click += new System.EventHandler(this.StopButton_Click);
			// 
			// Spectator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 88);
			this.Controls.Add(this.stopButton);
			this.Controls.Add(this.filesTotalSizeLabel);
			this.Controls.Add(this.filesCountLabel);
			this.Controls.Add(this.pathLabel);
			this.Name = "Spectator";
			this.Text = "Spectator";
			this.Load += new System.EventHandler(this.Spectator_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label pathLabel;
		private System.Windows.Forms.Label filesCountLabel;
		private System.Windows.Forms.Label filesTotalSizeLabel;
		private System.Windows.Forms.Button stopButton;
	}
}