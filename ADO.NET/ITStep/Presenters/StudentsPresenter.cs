using ITStep.Services;
using ITStep.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITStep.Presenters
{
	public class StudentsPresenter
	{
		private readonly StudentsView view;

		public StudentsPresenter(StudentsView view)
		{
			this.view = view;
		}

		public void LoadStudents()
		{
			view.SetStudents(StudentsService.GetAllStudents());
		}
	}
}
