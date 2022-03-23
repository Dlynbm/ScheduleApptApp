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
    public partial class FormAllCustomers : Form
    {
        public FormAllCustomers()
        {
            InitializeComponent();

            MySqlConnection con = new MySqlConnection("server=127.0.0.1; username = sqlUser; password = Passw0rd!; database = client_schedule");
            con.Open();
            String sqlString = "SELECT customerId, customerName, addressId, active FROM customer";
            MySqlCommand cmd = new MySqlCommand(sqlString, con);
            MySqlDataAdapter cust = new MySqlDataAdapter(cmd);
            DataTable dataTble = new DataTable();
            cust.Fill(dataTble);
            CustomerGrid.DataSource = dataTble;
            CustomerGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            CustomerGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CustomerGrid.RowHeadersVisible = false;
            CustomerGrid.ReadOnly = true;
            CustomerGrid.AllowUserToAddRows = true;



        }



        

        private void AddCustomerBtn_Click_1(object sender, EventArgs e)
        {
            AddCustomer form = new AddCustomer();
            form.Show();
        }
    }
}


