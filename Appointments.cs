﻿//using MySql.Data.MySqlClient;
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
    public partial class Appointments : Form
    {
        public Appointments()
        {
            InitializeComponent();
            MySqlConnection con = new MySqlConnection("server = 127.0.0.1; username = sqlUser; password = Passw0rd!; database = client_schedule");
            con.Open();
            String sqlString = "SELECT * FROM appointment";
            MySqlCommand cmd = new MySqlCommand(sqlString, con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            AppointmentGrid.AutoGenerateColumns = false;

            DataTable dt = new DataTable();
            adp.Fill(dt);
            AppointmentGrid.DataSource = dt;
            AppointmentGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


        }



        

        private void AddCustBtn_Click(object sender, EventArgs e)
        {
            AddCustomer form = new AddCustomer();
            form.Show();
        }

        private void ViewCustomersBtn_Click(object sender, EventArgs e)
        {
            Customers custForm = new Customers();
            custForm.Show();
        }

        //private void AddAppt_Click(object sender, EventArgs e)
        //{
        //    AddAppointment apptForm = new Appointment();
        //    apptForm.Show();
        //}
    }
}