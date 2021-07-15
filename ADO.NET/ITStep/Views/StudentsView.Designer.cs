
namespace ITStep.Views
{
	partial class StudentsView
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
			this.buttonAddStudent = new System.Windows.Forms.Button();
			this.listBoxStudents = new System.Windows.Forms.ListBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonAddStudent
			// 
			this.buttonAddStudent.Location = new System.Drawing.Point(6, 394);
			this.buttonAddStudent.Name = "buttonAddStudent";
			this.buttonAddStudent.Size = new System.Drawing.Size(297, 23);
			this.buttonAddStudent.TabIndex = 1;
			this.buttonAddStudent.Text = "Add student";
			this.buttonAddStudent.UseVisualStyleBackColor = true;
			// 
			// listBoxStudents
			// 
			this.listBoxStudents.FormattingEnabled = true;
			this.listBoxStudents.Location = new System.Drawing.Point(6, 19);
			this.listBoxStudents.Name = "listBoxStudents";
			this.listBoxStudents.Size = new System.Drawing.Size(297, 368);
			this.listBoxStudents.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.buttonAddStudent);
			this.groupBox1.Controls.Add(this.listBoxStudents);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(309, 426);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Students";
			// 
			// StudentsView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.groupBox1);
			this.Name = "StudentsView";
			this.Text = "Students";
			this.Load += new System.EventHandler(this.StudentsView_Load);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonAddStudent;
		private System.Windows.Forms.ListBox listBoxStudents;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}