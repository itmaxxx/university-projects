using ITStep.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITStep.Services
{
	public static class SubjectsService
	{
		public static List<Subject> GetAllSubjects()
		{
			using (var db = new DatabaseContext())
			{
				return db.Subjects.ToList();
			}
		}

		public static void AddSubject(Subject subject)
		{
			using (var db = new DatabaseContext())
			{
				db.Subjects.Add(subject);
				db.SaveChanges();
			}
		}

		public static void UpdateSubject(Subject subject)
		{
			using (var db = new DatabaseContext())
			{
				var _subject = db.Subjects.FirstOrDefault(g => g.Id == subject.Id);
				_subject.Name = subject.Name;

				db.SaveChanges();
			}
		}
	}
}
