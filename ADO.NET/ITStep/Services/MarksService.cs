using ITStep.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITStep.Services
{
	public static class MarksService
	{
		public static void AddMark(Student student, Lesson lesson, int score)
		{
			using (var db = new DatabaseContext())
			{
				var mark = new Mark
				{
					StudentFK = student.Id,
					LessonFK = lesson.Id,
					Score = score
				};

				db.Marks.Add(mark);
				db.SaveChanges();
			}
		}

		public static void DeleteMark(Mark mark)
		{
			using (var db = new DatabaseContext())
			{
				db.Marks.Remove(db.Marks.First(m => m.Id == mark.Id));
				db.SaveChanges();
			}
		}
	}
}
