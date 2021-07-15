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
	}
}
