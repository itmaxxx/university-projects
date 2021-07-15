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

		public void GetStudentSubjectsWithMarksPresent(Student student)
		{
			view.SetGroupStudentSubjects(StudentsService.GetStudentSubjectsWithMarksPresent(student));
		}

		public void GetAllSubjects()
		{
			view.SetGroupStudentSubjects(SubjectsService.GetAllSubjects());
		}

		public void GetStudentSubjectMarks(Student student, Subject subject)
		{
			view.SetGroupStudentSubjectMarks(StudentsService.GetStudentSubjectMarks(student, subject));
		}

		public void AddStudentMark(Student student, Subject subject, int score)
		{
			MarksService.AddMark(student, subject, score);

			// Update subject marks
			GetStudentSubjectMarks(student, subject);
		}

		public void DeleteStudentMark(Student student, Subject subject, Mark mark)
		{
			MarksService.DeleteMark(mark);

			// Update subject marks
			GetStudentSubjectMarks(student, subject);
		}
	}
}
