using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace ScheduleApptApp
{
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
            MySqlConnection con = new MySqlConnection("server = 127.0.0.1; username = sqlUser; password = Passw0rd!; database = client_schedule");
            con.Open();
            String sqlString = "SELECT * FROM customer";
            MySqlCommand cmd = new MySqlCommand(sqlString, con);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable custTable = new DataTable();
            da.Fill(custTable);
            CustomersGrid.DataSource = custTable;
            CustomersGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void AddCustomerBtn_Click(object sender, EventArgs e)
        {
            AddCustomer form = new AddCustomer();
            form.Show();
        }
    }
}
