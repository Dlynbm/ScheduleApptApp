using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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
        MySqlConnection con = new MySqlConnection("server = 127.0.0.1; username = sqlUser; password = Passw0rd!; database = client_schedule");

        public MainPage()
        {
            InitializeComponent();
            AppointmentGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AppointmentGrid.RowHeadersVisible = false;
            AppointmentGrid.ReadOnly = true;
            AppointmentGrid.AllowUserToAddRows = true;
            AppointmentGrid.ClearSelection();
        }
        private void MainPage_Load(object sender, EventArgs e)
        {
            loadAppointments();
            //this.appointmentTableAdapter.Fill(this.client_scheduleDataSet.appointment);

        }

        private void loadAppointments()
        {
            string sqlString = $"SELECT  appointment.appointmentId, customer.customerName, customer.customerId, appointment.title, appointment.description, appointment.location, appointment.contact, appointment.start, appointment.end, appointment.type FROM appointment INNER JOIN customer ON appointment.customerId = customer.customerId INNER JOIN `user` ON appointment.userId = `user`.userId"; MySqlCommand cmd = new MySqlCommand(sqlString, con);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            AppointmentGrid.DataSource = dt;
            AppointmentGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }



        private void ViewCustomersBtn_Click(object sender, EventArgs e)
        {
            FormAllCustomers allCustomers = new FormAllCustomers();
            allCustomers.Show();
        }

        private void btnAddAppt_Click(object sender, EventArgs e)
        {
            FormAllAppointments allAppointments = new FormAllAppointments();
            allAppointments.Show();
        }

        private void appointmentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.appointmentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.client_scheduleDataSet);

        }

        

        private void btnDateSearch_Click(object sender, EventArgs e)
        {
            string sqlString = "SELECT * FROM appointment WHERE start BETWEEN '" + p_StartDate.Value.ToString("yyyyMMdd") + "' AND '" +  p_EndDate.Value.ToString("yyyyMMdd") + "'";           
            MySqlDataAdapter da = new MySqlDataAdapter(sqlString, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            AppointmentGrid.DataSource = dt;
            AppointmentGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            loadAppointments();
        }
    }
}


//insert into appointment ( customerId, userId, title, description, location, contact, type, url, start, end, createDate, createdBy, lastUpdate, lastUpdateBy)
//values('2', '1', 'null', 'null', ' null', 'null', 'Scrum', 'null', '2021-04-01', '2021-04-01', '2018-01-01', 'test', '2020-02-04', 'test');






