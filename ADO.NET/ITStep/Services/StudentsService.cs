using ITStep.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITStep.Services
{
	public static class StudentsService
	{
		public static List<Student> GetAllStudents()
		{
			using (var db = new DatabaseContext())
			{
				return db.Students.ToList();
			}
		}

		public static List<Student> GetAllStudentsByGroup(Group group)
		{
			using (var db = new DatabaseContext())
			{
				return db.Students.Where(student => student.Group.Id == group.Id).ToList();
			}
		}

		public static void AddStudent(Student student)
		{
			using (var db = new DatabaseContext())
			{
				db.Students.Add(student);
				db.SaveChanges();
			}
		}

		public static void UpdateStudent(Student student)
		{
			using (var db = new DatabaseContext())
			{
				var _student = db.Students.FirstOrDefault(g => g.Id == student.Id);
				_student.FirstName = student.FirstName;
				_student.LastName = student.LastName;

				db.SaveChanges();
			}
		}

		public static List<Subject> GetStudentSubjectsWithMarksPresent(Student student)
		{
			using (var db = new DatabaseContext())
			{
				var subjects = new List<Subject>();

				foreach (var mark in db.Marks.Where(mark => mark.StudentFK == student.Id))
				{
					subjects.Add(db.Subjects.First(subject => subject.Id == mark.SubjectFK));
				}

				return subjects;
			}
		}

		public static List<Mark> GetStudentSubjectMarks(Student student, Subject subject)
		{
			using (var db = new DatabaseContext())
			{
				return db.Marks.Where(mark => mark.StudentFK == student.Id && mark.SubjectFK == subject.Id).ToList();
			}
		}
	}
}
