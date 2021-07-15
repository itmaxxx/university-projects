
namespace ITStep.Views
{
	partial class SubjectsView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubjectsView));
			this.buttonAddSubject = new System.Windows.Forms.Button();
			this.listBoxSubjects = new System.Windows.Forms.ListBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.textBoxSubjectName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBoxSubject = new System.Windows.Forms.GroupBox();
			this.buttonUpdate = new System.Windows.Forms.Button();
			this.textBoxSelectedSubjectName = new System.Windows.Forms.TextBox();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBoxSubject.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonAddSubject
			// 
			this.buttonAddSubject.BackColor = System.Drawing.Color.WhiteSmoke;
			this.buttonAddSubject.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
			this.buttonAddSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAddSubject.ForeColor = System.Drawing.SystemColors.ControlText;
			this.buttonAddSubject.UseVisualStyleBackColor = true;
			this.buttonAddSubject.Location = new System.Drawing.Point(6, 62);
			this.buttonAddSubject.Name = "buttonAddSubject";
			this.buttonAddSubject.Size = new System.Drawing.Size(252, 23);
			this.buttonAddSubject.TabIndex = 1;
			this.buttonAddSubject.Text = "Add subject";
			this.buttonAddSubject.Click += new System.EventHandler(this.buttonAddSubject_Click);
			// 
			// listBoxSubjects
			// 
			this.listBoxSubjects.FormattingEnabled = true;
			this.listBoxSubjects.Location = new System.Drawing.Point(6, 19);
			this.listBoxSubjects.Name = "listBoxSubjects";
			this.listBoxSubjects.Size = new System.Drawing.Size(297, 394);
			this.listBoxSubjects.TabIndex = 0;
			this.listBoxSubjects.SelectedIndexChanged += new System.EventHandler(this.listBoxSubjects_SelectedIndexChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.textBoxSubjectName);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.buttonAddSubject);
			this.groupBox2.Location = new System.Drawing.Point(325, 344);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(264, 94);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Add subject";
			// 
			// textBoxSubjectName
			// 
			this.textBoxSubjectName.Location = new System.Drawing.Point(6, 36);
			this.textBoxSubjectName.Name = "textBoxSubjectName";
			this.textBoxSubjectName.Size = new System.Drawing.Size(252, 20);
			this.textBoxSubjectName.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Subject name";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.listBoxSubjects);
			this.groupBox1.Location = new System.Drawing.Point(10, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(309, 426);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Subjects";
			// 
			// groupBoxSubject
			// 
			this.groupBoxSubject.Controls.Add(this.buttonUpdate);
			this.groupBoxSubject.Controls.Add(this.textBoxSelectedSubjectName);
			this.groupBoxSubject.Location = new System.Drawing.Point(325, 12);
			this.groupBoxSubject.Name = "groupBoxSubject";
			this.groupBoxSubject.Size = new System.Drawing.Size(264, 75);
			this.groupBoxSubject.TabIndex = 7;
			this.groupBoxSubject.TabStop = false;
			this.groupBoxSubject.Text = "Subject";
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.BackColor = System.Drawing.Color.WhiteSmoke;
			this.buttonUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
			this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonUpdate.ForeColor = System.Drawing.SystemColors.ControlText;
			this.buttonUpdate.UseVisualStyleBackColor = true;
			this.buttonUpdate.Location = new System.Drawing.Point(6, 45);
			this.buttonUpdate.Name = "buttonUpdate";
			this.buttonUpdate.Size = new System.Drawing.Size(252, 23);
			this.buttonUpdate.TabIndex = 1;
			this.buttonUpdate.Text = "Update subject";
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// textBoxSelectedSubjectName
			// 
			this.textBoxSelectedSubjectName.Location = new System.Drawing.Point(6, 19);
			this.textBoxSelectedSubjectName.Name = "textBoxSelectedSubjectName";
			this.textBoxSelectedSubjectName.Size = new System.Drawing.Size(252, 20);
			this.textBoxSelectedSubjectName.TabIndex = 0;
			// 
			// SubjectsView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(599, 450);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBoxSubject);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "SubjectsView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Subjects";
			this.Load += new System.EventHandler(this.SubjectsView_Load);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBoxSubject.ResumeLayout(false);
			this.groupBoxSubject.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonAddSubject;
		private System.Windows.Forms.ListBox listBoxSubjects;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox textBoxSubjectName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBoxSubject;
		private System.Windows.Forms.Button buttonUpdate;
		private System.Windows.Forms.TextBox textBoxSelectedSubjectName;
	}
}