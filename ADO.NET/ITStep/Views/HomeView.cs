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
	public partial class HomeView : Form
	{
		public HomeView()
		{
			InitializeComponent();
		}

		private void buttonGroups_Click(object sender, EventArgs e)
		{
			var groupsView = new GroupsView();
			this.Hide();
			groupsView.ShowDialog();
			this.Show();
		}

		private void buttonSubjects_Click(object sender, EventArgs e)
		{
			var subjectsView = new SubjectsView();
			this.Hide();
			subjectsView.ShowDialog();
			this.Show();
		}
	}
}
