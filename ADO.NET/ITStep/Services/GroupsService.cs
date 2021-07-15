using ITStep.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITStep.Services
{
	public static class GroupsService
	{
		public static List<Group> GetAllGroups()
		{
			using (var db = new DatabaseContext())
			{
				return db.Groups.ToList();
			}
		}

		public static void AddGroup(Group group)
		{
			using (var db = new DatabaseContext())
			{
				db.Groups.Add(group);
				db.SaveChanges();
			}
		}

		public static void UpdateGroup(Group group)
		{
			using (var db = new DatabaseContext())
			{
				var _group = db.Groups.FirstOrDefault(g => g.Id == group.Id);
				_group.Name = group.Name;

				db.SaveChanges();
			}
		}
	}
}
