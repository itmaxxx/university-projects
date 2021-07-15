using ITStep.Models;
using ITStep.Services;
using ITStep.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITStep.Presenters
{
	public class GroupStudentsPresenter
	{
		private readonly GroupStudentsView view;

		public GroupStudentsPresenter(GroupStudentsView view)
		{
			this.view = view;
		}

		public void GetStudents()
		{
			view.SetGroupStudents(StudentsService.GetAllStudentsByGroup(view.Group));
		}

		public void AddStudent(string firstName, string lastName)
		{
			StudentsService.AddStudent(new Student { FirstName = firstName, LastName = lastName, GroupFK = view.Group.Id });
		}

		public void UpdateStudent(int id, string firstName, string lastName)
		{
			StudentsService.UpdateStudent(new Student { Id = id, FirstName = firstName, LastName = lastName });
		}

		public void GetStudentLessonsWithMarksPresent(Student student)
		{
			view.SetGroupStudentLessons(StudentsService.GetStudentLessonsWithMarksPresent(student));
		}

		public void GetStudentLessonMarks(Student student, Lesson lesson)
		{
			view.SetGroupStudentLessonMarks(StudentsService.GetStudentLessonMarks(student, lesson));
		}

		public void AddStudentMark(Student student, Lesson lesson, int score)
		{
			MarksService.AddMark(student, lesson, score);

			// Update lesson marks
			GetStudentLessonMarks(student, lesson);
		}

		public void DeleteStudentMark(Student student, Lesson lesson, Mark mark)
		{
			MarksService.DeleteMark(mark);

			// Update lesson marks
			GetStudentLessonMarks(student, lesson);
		}
	}
}
