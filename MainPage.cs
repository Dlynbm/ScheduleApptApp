﻿using System;
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
            string sqlString = $"SELECT  appointment.appointmentId, customer.customerName, customer.customerId, appointment.start, appointment.end, appointment.type FROM appointment INNER JOIN customer ON appointment.customerId = customer.customerId INNER JOIN `user` ON appointment.userId = `user`.userId"; MySqlCommand cmd = new MySqlCommand(sqlString, con);
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

        }

        private void btnSearchMonth_Click(object sender, EventArgs e)
        {
            string mySqlString = "SELECT * FROM appointment WHERE MONTH (start) = MONTH(CURRENT_DATE()) AND YEAR (start) = YEAR(CURRENT_DATE())";
            string connString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            MySqlConnection connection = new MySqlConnection(connString);
            DataTable myDataTable = new DataTable();
            MySqlCommand mySqlCommand = new MySqlCommand(mySqlString);
            mySqlCommand.Connection = connection;        

            //fill data to datatable
            MySqlDataAdapter da = new MySqlDataAdapter(mySqlCommand);
            da.Fill(myDataTable);
            //adding datasource
            AppointmentGrid.DataSource = myDataTable;
            lblTotal.Text = $"There are a total of {AppointmentGrid.RowCount - 1} appointments for this month";
        }

        private void btnWeekSrch_Click(object sender, EventArgs e)
        {
            string mySqlString = "SELECT * FROM appointment WHERE YEARWEEK (start) = YEARWEEK(curdate())";
            string connString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            MySqlConnection connection = new MySqlConnection(connString);
            DataTable myDataTable = new DataTable();
            MySqlCommand mySqlCommand = new MySqlCommand(mySqlString);
            mySqlCommand.Connection = connection;

            //fill data to datatable
            MySqlDataAdapter da = new MySqlDataAdapter(mySqlCommand);
            da.Fill(myDataTable);
            //adding datasource
            AppointmentGrid.DataSource = myDataTable;
            lblTotal.Text = $"There are a total of {AppointmentGrid.RowCount - 1} appointments for this week";
        }
        //private void btnDateSearch_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        using (MySqlConnection con = DBConnection.conn)
        //        {
        //            if (con.State == ConnectionState.Closed)
        //                con.Open();
        //            using (DataTable dt = new DataTable("Dates"))
        //            {
        //                using (MySqlCommand cmd = new MySqlCommand("SELECT appointmentId, customerId, userId, type, start, end, createDate, createdBy, lastUpdate, lastUpdateBy  FROM appointment WHERE start BETWEEN @d1 AND @d2", con))
        //                {
        //                    //adding values
        //                    //cmd.Parameters.AddWithValue("@d1", p_StartDate.Value);
        //                    //cmd.Parameters.AddWithValue("@d2", p_EndDate.Value);
        //                    //fill data to datatable
        //                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        //                    da.Fill(dt);
        //                    //adding datasource
        //                    AppointmentGrid.DataSource = dt;
        //                    lblTotal.Text = $"Total records: {AppointmentGrid.RowCount - 1}";

        //                }
        //            }
        //        }
        //    }
        ////    catch (MySqlException ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
    }
    //}

    //private void btnWeekSrch_Click(object sender, EventArgs e)
    //{
    //    try
    //    {
    //        using (MySqlConnection con = DBConnection.conn)
    //        {
    //            if (con.State == ConnectionState.Closed)
    //                con.Open();
    //            using (DataTable dt = new DataTable("Dates"))
    //            {
    //                using (MySqlCommand cmd = new MySqlCommand("SELECT appointmentId, customerId, userId, type, start, end, createDate, createdBy, lastUpdate, lastUpdateBy from appointment where WEEK(start) = WEEK(now()) and YEAR(start) = YEAR(now());", con))
    //                {
    //                    //adding values
    //                    //cmd.Parameters.AddWithValue("@d1", p_StartDate.Value);
    //                    //cmd.Parameters.AddWithValue("@d2", p_EndDate.Value);
    //                    //fill data to datatable
    //                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
    //                    da.Fill(dt);
    //                    //adding datasource
    //                    AppointmentGrid.DataSource = dt;
    //                    lblTotal.Text = $"Total records this week: {AppointmentGrid.RowCount - 1}";

    //                }
    //            }
    //        }
    //    }
    //    catch (MySqlException ex)
    //{
    //    MessageBox.Show(ex.Message);
    //}
    //}

    //private void btnSearchMonth_Click(object sender, EventArgs e)
    //{
    //    try
    //    {
    //        using (MySqlConnection con = DBConnection.conn)
    //        {
    //            if (con.State == ConnectionState.Closed)
    //                con.Open();
    //            using (DataTable dt = new DataTable("Dates"))
    //            {
    //                using (MySqlCommand cmd = new MySqlCommand("SELECT appointmentId, customerId, userId, type, start, end, createDate, createdBy, lastUpdate, lastUpdateBy from appointment where MONTH(start) = MONTH(now())and YEAR(start) = YEAR(now()); ", con))
    //                {
    //                    //adding values
    //                    //cmd.Parameters.AddWithValue("@d1", p_StartDate.Value);
    //                    //cmd.Parameters.AddWithValue("@d2", p_EndDate.Value);
    //                    //fill data to datatable
    //                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
    //                    da.Fill(dt);
    //                    //adding datasource
    //                    AppointmentGrid.DataSource = dt;
    //                    lblTotal.Text = $"Total records this Month: {AppointmentGrid.RowCount - 1}";

    //                }
    //            }
    //        }
    //    }
    //    catch (MySqlException ex)
    //{
    //    MessageBox.Show(ex.Message);
    //}
//}

//private void btnReports_Click(object sender, EventArgs e)
//        {
//            Reports reports = new Reports();
//            reports.Show();
//        }

       
    }
        

  
 

      
//insert into appointment ( customerId, userId, title, description, location, contact, type, url, start, end, createDate, createdBy, lastUpdate, lastUpdateBy)
//values('2', '1', 'null', 'null', ' null', 'null', 'Scrum', 'null', '2021-04-01', '2021-04-01', '2018-01-01', 'test', '2020-02-04', 'test');






