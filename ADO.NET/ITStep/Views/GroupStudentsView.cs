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
		}

		public void SetGroupStudents(List<Student> students)
		{
			listBoxGroupStudents.ValueMember = "Id";
			listBoxGroupStudents.DisplayMember = "FullName";
			listBoxGroupStudents.DataSource = students;
		}

		public void SetGroupStudentLessons(List<Lesson> lessons)
		{
			comboBoxStudentLessons.ValueMember = "Id";
			comboBoxStudentLessons.DisplayMember = "Name";
			comboBoxStudentLessons.DataSource = lessons;
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
			var student = getSelectedStudent();

			textBoxSelectedStudentFirstName.Text = student.FirstName;
			textBoxSelectedStudentLastName.Text = student.LastName;

			comboBoxStudentLessons.DataSource = null;
			listBoxLessonMarks.DataSource = null;

			if (checkBoxLessonsWithMarks.Checked)
			{
				presenter.GetStudentLessonsWithMarksPresent(student);
			}
			else
			{
				presenter.GetAllLessons();
			}
		}

		private Lesson getSelectedLesson()
		{
			return comboBoxStudentLessons.SelectedItem as Lesson;
		}

		public void SetGroupStudentLessonMarks(List<Mark> marks)
		{
			listBoxLessonMarks.ValueMember = "Id";
			listBoxLessonMarks.DisplayMember = "Score";
			listBoxLessonMarks.DataSource = marks;
		}

		private void comboBoxStudentLessons_SelectedIndexChanged(object sender, EventArgs e)
		{
			var lesson = getSelectedLesson();

			if (lesson != null)
			{
				presenter.GetStudentLessonMarks(getSelectedStudent(), lesson);
			}
		}

		private void buttonAddMark_Click(object sender, EventArgs e)
		{
			var lesson = getSelectedLesson();

			if (lesson != null)
			{
				presenter.AddStudentMark(getSelectedStudent(), getSelectedLesson(), int.Parse(textBoxMark.Text));

				textBoxMark.Text = string.Empty;
			}
		}

		private Mark getSelectedMark()
		{
			return listBoxLessonMarks.SelectedItem as Mark;
		}

		private void listBoxLessonMarks_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete)
			{
				var deleteMark = MessageBox.Show(
					$"Are you sure you want to delete mark \"{getSelectedMark().Score}\" for lesson {getSelectedLesson().Name}?", 
					"Confirm action",
					MessageBoxButtons.YesNo
					);

				if (deleteMark == DialogResult.Yes)
				{
					presenter.DeleteStudentMark(getSelectedStudent(), getSelectedLesson(), getSelectedMark());
				}
			}
		}

		private void checkBoxLessonsWithMarks_CheckedChanged(object sender, EventArgs e)
		{
			comboBoxStudentLessons.DataSource = null;
			listBoxLessonMarks.DataSource = null;

			if (checkBoxLessonsWithMarks.Checked)
			{
				presenter.GetStudentLessonsWithMarksPresent(getSelectedStudent());
			}
			else
			{
				presenter.GetAllLessons();
			}
		}
	}
}
