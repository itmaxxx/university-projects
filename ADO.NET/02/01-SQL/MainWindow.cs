using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_SQL
{
    public partial class MainWindow : Form
    {
        private SqlConnection sqlConnection;
        private DataSet myLibraryDataSet;

        public MainWindow()
        {
            InitializeComponent();
        }

        public List<string> GetWorkingDays(DateTime from, DateTime to, DayOfWeek dayOfWeek)
        {
            List<string> workingDays = new List<string>();

            while (from <= to)
            {
                if (from.DayOfWeek == dayOfWeek)
                    workingDays.Add(from.ToString("yyyy.MM.dd ddd"));

                from = from.AddDays(1);
            }

            return workingDays;
        }

        private void getWorkerWoringDays(string workerFullname) {
            // Get worker working days

            myLibraryDataSet = new DataSet("Schedule");

            myLibraryDataSet.Clear();

            var sqlDataAdapter = new SqlDataAdapter(
                "SELECT S.Fullname AS Fullname, " +
                       "FORMAT (S.StartDate, 'yyyy.MM.dd') AS BeginDate, " +
                       "FORMAT (S.EndDate, 'yyyy.MM.dd') AS EndDate, " +
                       "W.DayOfWeek AS DayOfWeek " +
                "FROM Schedules S, WorkingDays W " +
                "WHERE W.ScheduleFk = S.Id AND S.Fullname = N'" + workerFullname + "'",
                sqlConnection);
            sqlDataAdapter.Fill(myLibraryDataSet);

            dataGridView.Rows.Clear();

            foreach (DataRow schedule in myLibraryDataSet.Tables[0].Rows)
            {
                List<string> row = new List<string>();

                var beginDate = schedule["BeginDate"].ToString().Split('.');
                var endDate = schedule["EndDate"].ToString().Split('.');

                var workingDays = GetWorkingDays(
                    new DateTime(Int32.Parse(beginDate[0]), Int32.Parse(beginDate[1]), Int32.Parse(beginDate[2])),
                    new DateTime(Int32.Parse(endDate[0]), Int32.Parse(endDate[1]), Int32.Parse(endDate[2])),
                    (DayOfWeek)Int32.Parse(schedule["DayOfWeek"].ToString())
                    );

                foreach (var day in workingDays)
                {
                    var dayArr = new List<string>();
                    dayArr.Add(day);

                    dataGridView.Rows.Add(dayArr.ToArray());
                }
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(local);Initial Catalog=Schedule;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);

            myLibraryDataSet = new DataSet("Schedule");

            myLibraryDataSet.Clear();

            var sqlDataAdapter = new SqlDataAdapter(
                "SELECT Fullname " +
                "FROM Schedules " +
                "GROUP BY Fullname",
                sqlConnection);
            sqlDataAdapter.Fill(myLibraryDataSet);

            workerSelector.Items.Clear();

            foreach (DataRow worker in myLibraryDataSet.Tables[0].Rows)
            {
                workerSelector.Items.Add(worker["Fullname"]);
            }
        }

        private void workerSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            getWorkerWoringDays(workerSelector.SelectedItem.ToString());
        }
    }
}
