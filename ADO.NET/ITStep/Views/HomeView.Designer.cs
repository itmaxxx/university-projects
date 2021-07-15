
namespace ITStep.Views
{
	partial class HomeView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeView));
			this.buttonGroups = new System.Windows.Forms.Button();
			this.buttonSubjects = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonGroups
			// 
			this.buttonGroups.BackColor = System.Drawing.Color.WhiteSmoke;
			this.buttonGroups.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
			this.buttonGroups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonGroups.ForeColor = System.Drawing.SystemColors.ControlText;
			this.buttonGroups.Location = new System.Drawing.Point(181, 327);
			this.buttonGroups.Name = "buttonGroups";
			this.buttonGroups.Size = new System.Drawing.Size(109, 23);
			this.buttonGroups.TabIndex = 1;
			this.buttonGroups.Text = "Groups";
			this.buttonGroups.UseVisualStyleBackColor = false;
			this.buttonGroups.Click += new System.EventHandler(this.buttonGroups_Click);
			// 
			// buttonSubjects
			// 
			this.buttonSubjects.BackColor = System.Drawing.Color.WhiteSmoke;
			this.buttonSubjects.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
			this.buttonSubjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonSubjects.ForeColor = System.Drawing.SystemColors.ControlText;
			this.buttonSubjects.Location = new System.Drawing.Point(296, 327);
			this.buttonSubjects.Name = "buttonSubjects";
			this.buttonSubjects.Size = new System.Drawing.Size(110, 23);
			this.buttonSubjects.TabIndex = 2;
			this.buttonSubjects.Text = "Subjects";
			this.buttonSubjects.UseVisualStyleBackColor = false;
			this.buttonSubjects.Click += new System.EventHandler(this.buttonSubjects_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::ITStep.Properties.Resources.step_logo;
			this.pictureBox1.Location = new System.Drawing.Point(181, 51);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(225, 225);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// HomeView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(599, 450);
			this.Controls.Add(this.buttonSubjects);
			this.Controls.Add(this.buttonGroups);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "HomeView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "IT Step";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button buttonGroups;
		private System.Windows.Forms.Button buttonSubjects;
	}
}