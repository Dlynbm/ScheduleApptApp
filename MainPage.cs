using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ScheduleApptApp
{
    public partial class MainPage : Form
    {
        //private static string user;
        //private static int userId;

    public MainPage()
        {
            InitializeComponent();
            MySqlConnection con = Data.getConnection();
            String sqlQuery = "SELECT * from appointment";

            MySqlDataAdapter cd = new MySqlDataAdapter(sqlQuery, Data.getConnection());
            DataSet apptDataSet = new DataSet();
            Data.getConnection().Open();
            cd.Fill(apptDataSet);
            AppointmentGrid.DataSource = apptDataSet.Tables[0];
            Data.getConnection().Close();

            AppointmentGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AppointmentGrid.RowHeadersVisible = false;
            AppointmentGrid.ReadOnly = true;
            AppointmentGrid.AllowUserToAddRows = true;
            AppointmentGrid.ClearSelection();
        }

        private void ViewCustomersBtn_Click(object sender, EventArgs e)
        {
            FormAllCustomers allCust = new FormAllCustomers();
            allCust.Show();
        }

        private void AddApptBtn_Click(object sender, EventArgs e)
        {
            FormAllAppointments addAppt = new FormAllAppointments();
            addAppt.Show();
        }

        private void btnEditAppt_Click(object sender, EventArgs e)
        {
            FormAllAppointments addAppt = new FormAllAppointments();
            addAppt.Show();
        }

        private void btnDeleteAppt_Click(object sender, EventArgs e)
        {
            FormAllAppointments addAppt = new FormAllAppointments();
            addAppt.Show();
        }
    }
}









