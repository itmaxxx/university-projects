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
	public class SubjectsPresenter
	{
		private readonly SubjectsView view;
	
		public SubjectsPresenter(SubjectsView view)
		{
			this.view = view;
		}

		public void LoadSubjects()
		{
			view.SetSubjects(SubjectsService.GetAllSubjects());
		}

		public void AddSubject(string name)
		{
			SubjectsService.AddSubject(new Subject { Name = name });
		}

		public void UpdateSubject(int id, string name)
		{
			SubjectsService.UpdateSubject(new Subject { Id = id, Name = name });
		}
	}
}
