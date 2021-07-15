using ITStep.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITStep.Services
{
	public static class LessonsService
	{
		public static List<Lesson> GetAllLessons()
		{
			using (var db = new DatabaseContext())
			{
				return db.Lessons.ToList();
			}
		}
	}
}
