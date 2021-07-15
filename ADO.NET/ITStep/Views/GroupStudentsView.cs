using ITStep.Models;
using ITStep.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITStep.Views
{
	public partial class GroupStudentsView : Form
	{
		private readonly GroupStudentsPresenter presenter;
		public Group Group;

		public GroupStudentsView(Group group)
		{
			InitializeComponent();

			Group = group;

			presenter = new GroupStudentsPresenter(this);

			this.Text = group.Name;

			groupBoxStudent.Visible = false;
		}

		public void SetGroupStudents(List<Student> students)
		{
			listBoxGroupStudents.ValueMember = "Id";
			listBoxGroupStudents.DisplayMember = "FullName";
			listBoxGroupStudents.DataSource = students;
		}

		public void SetGroupStudentSubjects(List<Subject> subjects)
		{
			comboBoxStudentSubjects.ValueMember = "Id";
			comboBoxStudentSubjects.DisplayMember = "Name";
			comboBoxStudentSubjects.DataSource = subjects;
		}

		private void GroupStudentsView_Load(object sender, EventArgs e)
		{
			presenter.GetStudents();
		}

		private void buttonAddGroupStudent_Click(object sender, EventArgs e)
		{
			presenter.AddStudent(textBoxStudentFirstName.Text, textBoxStudentLastName.Text);
			presenter.GetStudents();

			textBoxStudentFirstName.Text = string.Empty;
			textBoxStudentLastName.Text = string.Empty;
		}

		private Student getSelectedStudent()
		{
			return listBoxGroupStudents.SelectedItem as Student;
		}

		private void buttonUpdateStudent_Click(object sender, EventArgs e)
		{
			presenter.UpdateStudent(getSelectedStudent().Id, textBoxSelectedStudentFirstName.Text, textBoxSelectedStudentLastName.Text);
			presenter.GetStudents();
		}

		private void listBoxGroupStudents_SelectedIndexChanged(object sender, EventArgs e)
		{
			groupBoxStudent.Visible = true;

			var student = getSelectedStudent();

			textBoxSelectedStudentFirstName.Text = student.FirstName;
			textBoxSelectedStudentLastName.Text = student.LastName;

			comboBoxStudentSubjects.DataSource = null;
			listBoxSubjectMarks.DataSource = null;

			if (checkBoxSubjectsWithMarks.Checked)
			{
				presenter.GetStudentSubjectsWithMarksPresent(student);
			}
			else
			{
				presenter.GetAllSubjects();
			}
		}

		private Subject getSelectedSubject()
		{
			return comboBoxStudentSubjects.SelectedItem as Subject;
		}

		public void SetGroupStudentSubjectMarks(List<Mark> marks)
		{
			listBoxSubjectMarks.ValueMember = "Id";
			listBoxSubjectMarks.DisplayMember = "Score";
			listBoxSubjectMarks.DataSource = marks;
		}

		private void comboBoxStudentSubjects_SelectedIndexChanged(object sender, EventArgs e)
		{
			var subject = getSelectedSubject();

			if (subject != null)
			{
				presenter.GetStudentSubjectMarks(getSelectedStudent(), subject);
			}
		}

		private void buttonAddMark_Click(object sender, EventArgs e)
		{
			var subject = getSelectedSubject();

			if (subject != null)
			{
				presenter.AddStudentMark(getSelectedStudent(), getSelectedSubject(), int.Parse(textBoxMark.Text));

				textBoxMark.Text = string.Empty;
			}
		}

		private Mark getSelectedMark()
		{
			return listBoxSubjectMarks.SelectedItem as Mark;
		}

		private void listBoxSubjectMarks_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete)
			{
				var deleteMark = MessageBox.Show(
					$"Are you sure you want to delete mark \"{getSelectedMark().Score}\" for subject {getSelectedSubject().Name}?", 
					"Confirm action",
					MessageBoxButtons.YesNo
					);

				if (deleteMark == DialogResult.Yes)
				{
					presenter.DeleteStudentMark(getSelectedStudent(), getSelectedSubject(), getSelectedMark());
				}
			}
		}

		private void checkBoxSubjectsWithMarks_CheckedChanged(object sender, EventArgs e)
		{
			comboBoxStudentSubjects.DataSource = null;
			listBoxSubjectMarks.DataSource = null;

			if (checkBoxSubjectsWithMarks.Checked)
			{
				presenter.GetStudentSubjectsWithMarksPresent(getSelectedStudent());
			}
			else
			{
				presenter.GetAllSubjects();
			}
		}
	}
}
