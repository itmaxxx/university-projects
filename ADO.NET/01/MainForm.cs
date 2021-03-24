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

namespace ADONET
{
	public partial class MainForm : Form
	{
		public static SqlConnection Connection { get; private set; } = new SqlConnection();

		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
            var builder = new SqlConnectionStringBuilder
            {
                DataSource = "MAX-PC\\SQLEXPRESS",
                InitialCatalog = "Shop",
                IntegratedSecurity = true
            };

            Connection.ConnectionString = builder.ConnectionString;

            try
            {
                Connection.Open();
                GetTables();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                Close();
            }
        }

        private void GetTables()
		{
            try
            {
                string sqlString = "SELECT * FROM INFORMATION_SCHEMA.TABLES";

                using (var command = new SqlCommand(sqlString, Connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        comboBox.Items.Add((string)reader["TABLE_NAME"]);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadSales()
        {
            try
            {
                listView.Items.Clear();

                listView.Columns.Clear();
                listView.Columns.Add("Client");
                listView.Columns.Add("Seller");
                listView.Columns.Add("Price");
                listView.Columns.Add("Date");

                string sqlString =
                        "SELECT Clients.Name + ' ' + Clients.Surname AS Client, Sellers.Name + ' ' + Sellers.Surname AS Seller, Sales.Price, Sales.Date " +
                        "FROM Clients, Sellers, Sales " +
                        "WHERE Clients.Id = Sales.ClientFk AND Sellers.Id = Sales.SellerFk";

                using (var command = new SqlCommand(sqlString, Connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ListViewItem item = listView.Items.Add(new ListViewItem());
                        item.Text = (string)reader["Client"];
                        item.SubItems.Add((string)reader["Seller"]);
                        item.SubItems.Add(((decimal)reader["Price"]).ToString());
                        item.SubItems.Add(((string)reader["Date"]));
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadClients()
        {
            try
            {
                listView.Items.Clear();

                listView.Columns.Clear();
                listView.Columns.Add("Name");
                listView.Columns.Add("Surname");

                string sqlString =
                        "SELECT * FROM Clients";

                using (var command = new SqlCommand(sqlString, Connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ListViewItem item = listView.Items.Add(new ListViewItem());
                        item.Text = (string)reader["Name"];
                        item.SubItems.Add((string)reader["Surname"]);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadSellers()
        {
            try
            {
                listView.Items.Clear();

                listView.Columns.Clear();
                listView.Columns.Add("Name");
                listView.Columns.Add("Surname");

                string sqlString =
                        "SELECT * FROM Sellers";

                using (var command = new SqlCommand(sqlString, Connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ListViewItem item = listView.Items.Add(new ListViewItem());
                        item.Text = (string)reader["Name"];
                        item.SubItems.Add((string)reader["Surname"]);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
		{
            if (Connection.State == ConnectionState.Open)
                Connection.Close();
        }

		private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
            string selected = comboBox.SelectedItem.ToString();

            if (selected == "Sales")
			{
                LoadSales();
			}
            else if (selected == "Clients")
			{
                LoadClients();
			}
            else if (selected == "Sellers")
            {
                LoadSellers();
            }
        }
    }
}
