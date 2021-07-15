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
	public partial class GroupsView : Form
	{
		private readonly GroupsPresenter presenter;

		public GroupsView()
		{
			InitializeComponent();

			presenter = new GroupsPresenter(this);
		}

		private void GroupsView_Load(object sender, EventArgs e)
		{
			presenter.LoadGroups();

			groupBoxGroup.Visible = false;
		}

		public void SetGroups(List<Group> groups)
		{
			listBoxGroups.DisplayMember = "Name";
			listBoxGroups.ValueMember = "Id";
			listBoxGroups.DataSource = groups;
		}

		private void buttonAddGroup_Click(object sender, EventArgs e)
		{
			presenter.AddGroup(textBoxGroupName.Text);
			presenter.LoadGroups();
			
			textBoxGroupName.Text = string.Empty;
		}

		private Group getSelectedGroup()
		{
			return listBoxGroups.SelectedItem as Group;
		}

		private void listBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
		{
			groupBoxGroup.Visible = true;

			textBoxSelectedGroupName.Text = getSelectedGroup().Name;
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			presenter.UpdateGroup(getSelectedGroup().Id, textBoxSelectedGroupName.Text);

			presenter.LoadGroups();
		}

		private void listBoxGroups_DoubleClick(object sender, EventArgs e)
		{
			var groupStudentsView = new GroupStudentsView(getSelectedGroup());
			this.Hide();
			groupStudentsView.ShowDialog();
			this.Show();
		}

		private void buttonGroupDetails_Click(object sender, EventArgs e)
		{
			var groupStudentsView = new GroupStudentsView(getSelectedGroup());
			this.Hide();
			groupStudentsView.ShowDialog();
			this.Show();
		}
	}
}
