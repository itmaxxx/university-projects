
namespace ITStep.Views
{
	partial class GroupStudentsView
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
			this.buttonAddGroup = new System.Windows.Forms.Button();
			this.listBoxGroupStudents = new System.Windows.Forms.ListBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.textBoxStudentFirstName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBoxGroup = new System.Windows.Forms.GroupBox();
			this.buttonUpdate = new System.Windows.Forms.Button();
			this.textBoxSelectedStudentFirstName = new System.Windows.Forms.TextBox();
			this.textBoxStudentLastName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxSelectedStudentLastName = new System.Windows.Forms.TextBox();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBoxGroup.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonAddGroup
			// 
			this.buttonAddGroup.Location = new System.Drawing.Point(6, 98);
			this.buttonAddGroup.Name = "buttonAddGroup";
			this.buttonAddGroup.Size = new System.Drawing.Size(252, 23);
			this.buttonAddGroup.TabIndex = 1;
			this.buttonAddGroup.Text = "Add student";
			this.buttonAddGroup.UseVisualStyleBackColor = true;
			// 
			// listBoxGroupStudents
			// 
			this.listBoxGroupStudents.FormattingEnabled = true;
			this.listBoxGroupStudents.Location = new System.Drawing.Point(6, 19);
			this.listBoxGroupStudents.Name = "listBoxGroupStudents";
			this.listBoxGroupStudents.Size = new System.Drawing.Size(297, 394);
			this.listBoxGroupStudents.TabIndex = 0;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.textBoxStudentLastName);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.textBoxStudentFirstName);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.buttonAddGroup);
			this.groupBox2.Location = new System.Drawing.Point(327, 304);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(264, 134);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Add student";
			// 
			// textBoxStudentFirstName
			// 
			this.textBoxStudentFirstName.Location = new System.Drawing.Point(6, 36);
			this.textBoxStudentFirstName.Name = "textBoxStudentFirstName";
			this.textBoxStudentFirstName.Size = new System.Drawing.Size(252, 20);
			this.textBoxStudentFirstName.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "First name";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.listBoxGroupStudents);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(309, 426);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Students";
			// 
			// groupBoxGroup
			// 
			this.groupBoxGroup.Controls.Add(this.textBoxSelectedStudentLastName);
			this.groupBoxGroup.Controls.Add(this.buttonUpdate);
			this.groupBoxGroup.Controls.Add(this.textBoxSelectedStudentFirstName);
			this.groupBoxGroup.Location = new System.Drawing.Point(327, 12);
			this.groupBoxGroup.Name = "groupBoxGroup";
			this.groupBoxGroup.Size = new System.Drawing.Size(264, 101);
			this.groupBoxGroup.TabIndex = 7;
			this.groupBoxGroup.TabStop = false;
			this.groupBoxGroup.Text = "Student";
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(6, 71);
			this.buttonUpdate.Name = "buttonUpdate";
			this.buttonUpdate.Size = new System.Drawing.Size(252, 23);
			this.buttonUpdate.TabIndex = 1;
			this.buttonUpdate.Text = "Update student";
			this.buttonUpdate.UseVisualStyleBackColor = true;
			// 
			// textBoxSelectedStudentFirstName
			// 
			this.textBoxSelectedStudentFirstName.Location = new System.Drawing.Point(6, 19);
			this.textBoxSelectedStudentFirstName.Name = "textBoxSelectedStudentFirstName";
			this.textBoxSelectedStudentFirstName.Size = new System.Drawing.Size(252, 20);
			this.textBoxSelectedStudentFirstName.TabIndex = 0;
			// 
			// textBoxStudentLastName
			// 
			this.textBoxStudentLastName.Location = new System.Drawing.Point(6, 72);
			this.textBoxStudentLastName.Name = "textBoxStudentLastName";
			this.textBoxStudentLastName.Size = new System.Drawing.Size(252, 20);
			this.textBoxStudentLastName.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Last name";
			// 
			// textBoxSelectedStudentLastName
			// 
			this.textBoxSelectedStudentLastName.Location = new System.Drawing.Point(6, 45);
			this.textBoxSelectedStudentLastName.Name = "textBoxSelectedStudentLastName";
			this.textBoxSelectedStudentLastName.Size = new System.Drawing.Size(252, 20);
			this.textBoxSelectedStudentLastName.TabIndex = 2;
			// 
			// GroupStudentsView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(599, 450);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBoxGroup);
			this.Name = "GroupStudentsView";
			this.Text = "Group students";
			this.Load += new System.EventHandler(this.GroupStudentsView_Load);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBoxGroup.ResumeLayout(false);
			this.groupBoxGroup.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonAddGroup;
		private System.Windows.Forms.ListBox listBoxGroupStudents;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox textBoxStudentFirstName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBoxGroup;
		private System.Windows.Forms.Button buttonUpdate;
		private System.Windows.Forms.TextBox textBoxSelectedStudentFirstName;
		private System.Windows.Forms.TextBox textBoxStudentLastName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxSelectedStudentLastName;
	}
}