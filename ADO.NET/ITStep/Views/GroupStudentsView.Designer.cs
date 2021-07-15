
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupStudentsView));
			this.buttonAddGroupStudent = new System.Windows.Forms.Button();
			this.listBoxGroupStudents = new System.Windows.Forms.ListBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.textBoxStudentLastName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxStudentFirstName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBoxStudent = new System.Windows.Forms.GroupBox();
			this.textBoxSelectedStudentLastName = new System.Windows.Forms.TextBox();
			this.buttonUpdateStudent = new System.Windows.Forms.Button();
			this.textBoxSelectedStudentFirstName = new System.Windows.Forms.TextBox();
			this.comboBoxStudentSubjects = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.listBoxSubjectMarks = new System.Windows.Forms.ListBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxMark = new System.Windows.Forms.TextBox();
			this.buttonAddMark = new System.Windows.Forms.Button();
			this.checkBoxSubjectsWithMarks = new System.Windows.Forms.CheckBox();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBoxStudent.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonAddGroupStudent
			// 
			this.buttonAddGroupStudent.Location = new System.Drawing.Point(6, 98);
			this.buttonAddGroupStudent.Name = "buttonAddGroupStudent";
			this.buttonAddGroupStudent.Size = new System.Drawing.Size(252, 23);
			this.buttonAddGroupStudent.TabIndex = 1;
			this.buttonAddGroupStudent.Text = "Add student";
			this.buttonAddGroupStudent.UseVisualStyleBackColor = true;
			this.buttonAddGroupStudent.Click += new System.EventHandler(this.buttonAddGroupStudent_Click);
			// 
			// listBoxGroupStudents
			// 
			this.listBoxGroupStudents.FormattingEnabled = true;
			this.listBoxGroupStudents.Location = new System.Drawing.Point(6, 19);
			this.listBoxGroupStudents.Name = "listBoxGroupStudents";
			this.listBoxGroupStudents.Size = new System.Drawing.Size(297, 394);
			this.listBoxGroupStudents.TabIndex = 0;
			this.listBoxGroupStudents.SelectedIndexChanged += new System.EventHandler(this.listBoxGroupStudents_SelectedIndexChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.textBoxStudentLastName);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.textBoxStudentFirstName);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.buttonAddGroupStudent);
			this.groupBox2.Location = new System.Drawing.Point(327, 304);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(264, 134);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Add student";
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
			// groupBoxStudent
			// 
			this.groupBoxStudent.Controls.Add(this.checkBoxSubjectsWithMarks);
			this.groupBoxStudent.Controls.Add(this.buttonAddMark);
			this.groupBoxStudent.Controls.Add(this.textBoxMark);
			this.groupBoxStudent.Controls.Add(this.label4);
			this.groupBoxStudent.Controls.Add(this.listBoxSubjectMarks);
			this.groupBoxStudent.Controls.Add(this.label3);
			this.groupBoxStudent.Controls.Add(this.comboBoxStudentSubjects);
			this.groupBoxStudent.Controls.Add(this.textBoxSelectedStudentLastName);
			this.groupBoxStudent.Controls.Add(this.buttonUpdateStudent);
			this.groupBoxStudent.Controls.Add(this.textBoxSelectedStudentFirstName);
			this.groupBoxStudent.Location = new System.Drawing.Point(327, 12);
			this.groupBoxStudent.Name = "groupBoxStudent";
			this.groupBoxStudent.Size = new System.Drawing.Size(264, 277);
			this.groupBoxStudent.TabIndex = 7;
			this.groupBoxStudent.TabStop = false;
			this.groupBoxStudent.Text = "Student";
			// 
			// textBoxSelectedStudentLastName
			// 
			this.textBoxSelectedStudentLastName.Location = new System.Drawing.Point(6, 45);
			this.textBoxSelectedStudentLastName.Name = "textBoxSelectedStudentLastName";
			this.textBoxSelectedStudentLastName.Size = new System.Drawing.Size(252, 20);
			this.textBoxSelectedStudentLastName.TabIndex = 2;
			// 
			// buttonUpdateStudent
			// 
			this.buttonUpdateStudent.Location = new System.Drawing.Point(6, 71);
			this.buttonUpdateStudent.Name = "buttonUpdateStudent";
			this.buttonUpdateStudent.Size = new System.Drawing.Size(252, 23);
			this.buttonUpdateStudent.TabIndex = 1;
			this.buttonUpdateStudent.Text = "Update student";
			this.buttonUpdateStudent.UseVisualStyleBackColor = true;
			this.buttonUpdateStudent.Click += new System.EventHandler(this.buttonUpdateStudent_Click);
			// 
			// textBoxSelectedStudentFirstName
			// 
			this.textBoxSelectedStudentFirstName.Location = new System.Drawing.Point(6, 19);
			this.textBoxSelectedStudentFirstName.Name = "textBoxSelectedStudentFirstName";
			this.textBoxSelectedStudentFirstName.Size = new System.Drawing.Size(252, 20);
			this.textBoxSelectedStudentFirstName.TabIndex = 0;
			// 
			// comboBoxStudentSubjects
			// 
			this.comboBoxStudentSubjects.FormattingEnabled = true;
			this.comboBoxStudentSubjects.Location = new System.Drawing.Point(6, 117);
			this.comboBoxStudentSubjects.Name = "comboBoxStudentSubjects";
			this.comboBoxStudentSubjects.Size = new System.Drawing.Size(252, 21);
			this.comboBoxStudentSubjects.TabIndex = 3;
			this.comboBoxStudentSubjects.SelectedIndexChanged += new System.EventHandler(this.comboBoxStudentSubjects_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 101);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(46, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Subjects";
			// 
			// listBoxSubjectMarks
			// 
			this.listBoxSubjectMarks.FormattingEnabled = true;
			this.listBoxSubjectMarks.Location = new System.Drawing.Point(6, 161);
			this.listBoxSubjectMarks.Name = "listBoxSubjectMarks";
			this.listBoxSubjectMarks.Size = new System.Drawing.Size(252, 82);
			this.listBoxSubjectMarks.TabIndex = 5;
			this.listBoxSubjectMarks.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBoxSubjectMarks_KeyDown);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(9, 145);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(36, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Marks";
			// 
			// textBoxMark
			// 
			this.textBoxMark.Location = new System.Drawing.Point(6, 249);
			this.textBoxMark.Name = "textBoxMark";
			this.textBoxMark.Size = new System.Drawing.Size(165, 20);
			this.textBoxMark.TabIndex = 7;
			// 
			// buttonAddMark
			// 
			this.buttonAddMark.Location = new System.Drawing.Point(177, 247);
			this.buttonAddMark.Name = "buttonAddMark";
			this.buttonAddMark.Size = new System.Drawing.Size(81, 23);
			this.buttonAddMark.TabIndex = 8;
			this.buttonAddMark.Text = "Add mark";
			this.buttonAddMark.UseVisualStyleBackColor = true;
			this.buttonAddMark.Click += new System.EventHandler(this.buttonAddMark_Click);
			// 
			// checkBoxSubjectsWithMarks
			// 
			this.checkBoxSubjectsWithMarks.AutoSize = true;
			this.checkBoxSubjectsWithMarks.Checked = true;
			this.checkBoxSubjectsWithMarks.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxSubjectsWithMarks.Location = new System.Drawing.Point(58, 100);
			this.checkBoxSubjectsWithMarks.Name = "checkBoxSubjectsWithMarks";
			this.checkBoxSubjectsWithMarks.Size = new System.Drawing.Size(114, 17);
			this.checkBoxSubjectsWithMarks.TabIndex = 9;
			this.checkBoxSubjectsWithMarks.Text = "subjects with marks";
			this.checkBoxSubjectsWithMarks.UseVisualStyleBackColor = true;
			this.checkBoxSubjectsWithMarks.CheckedChanged += new System.EventHandler(this.checkBoxSubjectsWithMarks_CheckedChanged);
			// 
			// GroupStudentsView
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(599, 450);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBoxStudent);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "GroupStudentsView";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Group students";
			this.Load += new System.EventHandler(this.GroupStudentsView_Load);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBoxStudent.ResumeLayout(false);
			this.groupBoxStudent.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonAddGroupStudent;
		private System.Windows.Forms.ListBox listBoxGroupStudents;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox textBoxStudentFirstName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBoxStudent;
		private System.Windows.Forms.Button buttonUpdateStudent;
		private System.Windows.Forms.TextBox textBoxSelectedStudentFirstName;
		private System.Windows.Forms.TextBox textBoxStudentLastName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxSelectedStudentLastName;
		private System.Windows.Forms.ComboBox comboBoxStudentSubjects;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ListBox listBoxSubjectMarks;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button buttonAddMark;
		private System.Windows.Forms.TextBox textBoxMark;
		private System.Windows.Forms.CheckBox checkBoxSubjectsWithMarks;
	}
}