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
	public partial class StudentsView : Form
	{
		private StudentsPresenter presenter;

		public StudentsView()
		{
			InitializeComponent();

			presenter = new StudentsPresenter(this);
		}

		private void StudentsView_Load(object sender, EventArgs e)
		{
			presenter.LoadStudents();
		}

		public void SetStudents(List<Student> students)
		{
			listBoxStudents.DisplayMember = "Fullname";
			listBoxStudents.ValueMember = "Id";
			listBoxStudents.DataSource = students;
		}
	}
}
