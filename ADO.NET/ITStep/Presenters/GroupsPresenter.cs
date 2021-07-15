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
	public class GroupsPresenter
	{
		private readonly GroupsView view;

		public GroupsPresenter(GroupsView view)
		{
			this.view = view;
		}

		public void LoadGroups()
		{
			view.SetGroups(GroupsService.GetAllGroups());
		}
		
		public void AddGroup(string name)
		{
			GroupsService.AddGroup(new Group { Name = name });
		}

		public void UpdateGroup(int id, string name)
		{
			GroupsService.UpdateGroup(new Group { Id = id, Name = name });
		}
	}
}
