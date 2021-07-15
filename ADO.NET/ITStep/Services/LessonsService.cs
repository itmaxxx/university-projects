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
	}
}
