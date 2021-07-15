using ITStep.Models;
using ITStep.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITStep.Views
{
	public partial class SubjectsView : Form
	{
		private readonly SubjectsPresenter presenter;

		public SubjectsView()
		{
			InitializeComponent();

			presenter = new SubjectsPresenter(this);
		}

		private void SubjectsView_Load(object sender, EventArgs e)
		{
			presenter.LoadSubjects();
		}

		public void SetSubjects(List<Subject> subjects)
		{
			listBoxSubjects.DisplayMember = "Name";
			listBoxSubjects.ValueMember = "Id";
			listBoxSubjects.DataSource = subjects;
		}

		private void buttonAddSubject_Click(object sender, EventArgs e)
		{
			presenter.AddSubject(textBoxSubjectName.Text);
			presenter.LoadSubjects();

			textBoxSubjectName.Text = string.Empty;
		}

		private Subject getSelectedSubject()
		{
			return listBoxSubjects.SelectedItem as Subject;
		}

		private void listBoxSubjects_SelectedIndexChanged(object sender, EventArgs e)
		{
			groupBoxSubject.Visible = true;

			textBoxSelectedSubjectName.Text = getSelectedSubject().Name;
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			presenter.UpdateSubject(getSelectedSubject().Id, textBoxSelectedSubjectName.Text);

			presenter.LoadSubjects();
		}
	}
}
