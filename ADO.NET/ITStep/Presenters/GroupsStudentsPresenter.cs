using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITStep.Presenters
{
	public class GroupsStudentsPresenter
	{
		private readonly GroupsStudentsPresenter view;

		public GroupsStudentsPresenter(GroupsStudentsPresenter view)
		{
			this.view = view;
		}
	}
}
