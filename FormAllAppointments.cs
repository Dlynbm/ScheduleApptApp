﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ScheduleApptApp
{
    public partial class FormAllAppointments : Form
    {
        //private int rowIndex = -1;
        DBConnection con = new DBConnection();
        private int appointmentId;

        public FormAllAppointments()
        {
            InitializeComponent();
            AppointmentGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AppointmentGrid.RowHeadersVisible = false;
            AppointmentGrid.ReadOnly = true;
            AppointmentGrid.AllowUserToAddRows = true;
            AppointmentGrid.ClearSelection();
        }


        private void FormAllAppointments_Load(object sender, EventArgs e)
        {
            AppointmentGrid.ClearSelection();
            loadAllAppointments();
            LoadListBoxCustId();
            LoadListBoxType();
            fill_userBox();
            this.apptGroupBox.Enabled = false;
            clearTextBoxes(apptGroupBox);
        }

        

        private void clearTextBoxes(GroupBox apptGroupBox)
        {
            foreach (Control ctrl in apptGroupBox.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox textBox = (TextBox)ctrl;
                    textBox.Text = null;
                }
                if(ctrl is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)ctrl;
                    comboBox.Text = null;
                }
            }
        }

        private void btnAddAppt_Click(object sender, EventArgs e)
        {
            editDelBtn();
            int count;
            string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            MySqlConnection con = null;
            con = new MySqlConnection(constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT Max(appointmentId)+1 from appointment", con);
            count = Convert.ToInt16(cmd.ExecuteScalar()) + 1;
            txtBxApptId.Text = "0" + count;
            con.Close();
        }

        void editDelBtn()
        {
            this.btnAddAppt.Enabled = false;
            this.btnEditAppt.Enabled = false;
            this.btnDeleteAppt.Enabled = false;

            this.btnSaveAppt.Enabled = true;
            this.btnCancel.Enabled = true;

            this.AppointmentGrid.Enabled = false;
            this.apptGroupBox.Enabled = true;
        }

        void saveCancelBtn()
        {
            this.btnSaveAppt.Enabled = false;
            this.btnCancel.Enabled = false;

            this.btnAddAppt.Enabled = true;
            this.btnEditAppt.Enabled = true;
            this.btnDeleteAppt.Enabled = true;

            this.apptGroupBox.Enabled = false;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            MainPage main = new MainPage();
            main.Show();
            this.Close();
        }


        private bool checkBusHours(DateTime start, DateTime end)
        {       
            string openTime = "9:00 am";
            string closeTime = "5:00 pm";
            DateTime startDateInput = Convert.ToDateTime(dateTimePicker1.Value);
            DateTime s = Convert.ToDateTime(startDateInput.ToString("MM/dd/yyyy") + " " + openTime);
            DateTime endDateInput = Convert.ToDateTime(dateTimePicker2.Value);
            DateTime e = Convert.ToDateTime(endDateInput.ToString("MM/dd/yyyy") + " " + closeTime);

            if (startDateInput < s || endDateInput > e)
            {
                MessageBox.Show("Sorry, our office is closed during this time.");
                return false;
            }
            return true;
        }

        private bool checkBusDays(DateTime start, DateTime end)
        {
            if (start.DayOfWeek == DayOfWeek.Saturday || start.DayOfWeek == DayOfWeek.Sunday)
            {
                MessageBox.Show("Sorry, the start date must be corrected, we're closed on Saturday and Sunday");
                return false;
            }

            if (end.DayOfWeek == DayOfWeek.Saturday || end.DayOfWeek == DayOfWeek.Sunday)
            {
                MessageBox.Show("Sorry, the end date must be corrected, we're closed on Saturday and Sunday");
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool checkOverlap(DateTime proposedStart, DateTime proposedEnd, int userId, int appointmentId)
        {
            try
            {
                string mySqlString = "SELECT  appointment.appointmentId, appointment.userId, customer.customerName, customer.customerId, appointment.start, appointment.end, appointment.type FROM appointment INNER JOIN customer ON appointment.customerId = customer.customerId INNER JOIN `user` ON appointment.userId = `user`.userId";
                MySqlDataAdapter da = new MySqlDataAdapter(mySqlString, DBConnection.conn);
                DataTable dtable = new DataTable();
                da.Fill(dtable);

                for (int i = 0; i < dtable.Rows.Count; i++)
                {
                    int aApptId = (int)dtable.Rows[i]["appointmentId"];
                    if(aApptId == appointmentId)
                    {
                        continue;
                    }
                    int aUserId = (int)dtable.Rows[i]["userId"];
                    
                    if(aUserId != userId)
                    {
                        continue;
                    }

                    DateTime aStart = (DateTime)dtable.Rows[i]["start"];
                    DateTime aEnd = (DateTime)dtable.Rows[i]["end"];
                    aStart = aStart.ToLocalTime();
                    aEnd = aEnd.ToLocalTime();

                    if(aStart >= proposedStart && aStart < proposedEnd)
                    {
                        return true;
                    }

                    if(aEnd > proposedStart && aEnd <= proposedEnd)
                    {
                        return true;
                    }

                    if(aStart<= proposedStart && aEnd >= proposedEnd)
                    {
                        return true;
                    }
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        private void btnSaveAppt_Click(object sender, EventArgs e)
        {
            bool busDays = checkBusDays(dateTimePicker1.Value, dateTimePicker2.Value);
            if(busDays == false)
            {
                return;
            }

            bool busHours = checkBusHours(dateTimePicker1.Value, dateTimePicker2.Value);
            if (busHours == false)
            {
                return;
            }

            string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            MySqlConnection con = null;


            if (comboId.Text == "" || comboType.Text == "" || userCombo.Text == "" || dateTimePicker1.Text == "" || dateTimePicker2.Text == "")
            {
                MessageBox.Show("Please complete all fields");
                return;
            }

            if (checkOverlap(dateTimePicker1.Value, dateTimePicker2.Value, Convert.ToInt32(userCombo.Text), 0))
            {
                MessageBox.Show("Appointments overlap");
                return;
            }

            try
            {
                DialogResult results = MessageBox.Show("Are you sure you want to add this appointment? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                appointmentId = 0;
               
                if (results == DialogResult.Yes)
                {
                    con = new MySqlConnection(constr);
                    MySqlCommand com = new MySqlCommand("INSERT INTO appointment(customerId, userId, title, description, location, contact, type, url, start, end, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES (@customerId, @userId, 'title', 'description', 'location', 'contact', @type,'url', @start, @end, NOW(), 'test', NOW(), 'test')", con);

                    //DateTime startTime = TimeZoneInfo.ConvertTimeToUtc(dateTimePicker1.Value);
                    //DateTime endTime = TimeZoneInfo.ConvertTimeToUtc(dateTimePicker2.Value);

                    
                    com.Parameters.AddWithValue("@customerId", comboId.Text);
                    com.Parameters.AddWithValue("@type", comboType.Text);
                    com.Parameters.AddWithValue("@userId", userCombo.Text);
                    com.Parameters.AddWithValue("@start", dateTimePicker1.Value.ToUniversalTime());
                    com.Parameters.AddWithValue("@end", dateTimePicker2.Value.ToUniversalTime());
                    con.Open();
                    com.ExecuteNonQuery();
                    appointmentId = (int)com.LastInsertedId;
                    con.Close();
                    MessageBox.Show("Added Successfully");
                    saveCancelBtn();
                    clearTextBoxes(apptGroupBox);
                    loadAllAppointments();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        private void LoadListBoxCustId()
        {
            try
            {
                string connString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
                MySqlConnection connection = new MySqlConnection(connString);
                string sqlString = "SELECT customerId FROM customer";
                MySqlCommand mySqlCommand = new MySqlCommand(sqlString);
                mySqlCommand.Connection = connection;

                MySqlDataAdapter cd = new MySqlDataAdapter(sqlString, DBConnection.conn);
                DataTable table = new DataTable();
                cd.Fill(table);
                comboId.DataSource = table;
                comboId.DisplayMember = "customerId";
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadListBoxType()
        {
            try
            {
                string connString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
                MySqlConnection connection = new MySqlConnection(connString);
                string sqlString = "SELECT DISTINCT type FROM appointment";
                MySqlCommand mySqlCommand = new MySqlCommand(sqlString);
                mySqlCommand.Connection = connection;

                MySqlDataAdapter cd = new MySqlDataAdapter(sqlString, DBConnection.conn);
                DataTable table = new DataTable();
                cd.Fill(table);
                comboType.DataSource = table;
                comboType.DisplayMember = "type";
            }
            
                catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        

        private void loadAllAppointments()
        {
            try
            {
                string mySqlString = "SELECT  appointment.appointmentId, customer.customerName, customer.customerId, appointment.start, appointment.end, appointment.type FROM appointment INNER JOIN customer ON appointment.customerId = customer.customerId INNER JOIN `user` ON appointment.userId = `user`.userId";
                MySqlDataAdapter da = new MySqlDataAdapter(mySqlString, DBConnection.conn);
                DataTable dtable = new DataTable();
                da.Fill(dtable);

                for (int i = 0; i < dtable.Rows.Count; i++)
                {
                    DateTime aStart = (DateTime)dtable.Rows[i]["start"];
                    DateTime aEnd = (DateTime)dtable.Rows[i]["end"];
                    aStart = aStart.ToLocalTime();
                    aEnd = aEnd.ToLocalTime();
                    dtable.Rows[i]["start"] = aStart;
                    dtable.Rows[i]["end"] = aEnd;
                }

                AppointmentGrid.DataSource = dtable;
                AppointmentGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                AppointmentGrid.ClearSelection();
                //fill_listbox();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }


        }      
        
        private void fill_userBox()
        {
            try
            {
                string connString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
                MySqlConnection connection = new MySqlConnection(connString);
                string sqlString = "SELECT userId FROM user";
                MySqlCommand mySqlCommand = new MySqlCommand(sqlString);
                mySqlCommand.Connection = connection;

                MySqlDataAdapter cd = new MySqlDataAdapter(sqlString, DBConnection.conn);
                DataTable table = new DataTable();
                cd.Fill(table);
                userCombo.DataSource = table;
                userCombo.DisplayMember = "userId";
            }

            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
           private void fill_listbox()
        {
            try
            {
                string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
                MySqlConnection con = null;
                con = new MySqlConnection(constr);
                con.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT customerId FROM customer", con);
                con.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteAppt_Click(object sender, EventArgs e)
        {
            editDelBtn();
            string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            MySqlConnection con = null;
            {
                if (AppointmentGrid.CurrentRow == null || !AppointmentGrid.CurrentRow.Selected)
                {
                    MessageBox.Show("Nothing is selected.  Please make a selection");
                    AppointmentGrid.Enabled = true;
                    this.btnDeleteAppt.Enabled = true;
                    return;
                }
                try
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this appointment? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        con = new MySqlConnection(constr);
                        var appointmentId = txtBxApptId.Text;
                        MySqlCommand com = new MySqlCommand($"DELETE FROM appointment WHERE appointmentId = '{appointmentId}'", con);
                        con.Open();
                        com.ExecuteNonQuery();
                        con.Close();
                        loadAllAppointments();
                        MessageBox.Show("Deleted Successfully");
                        clearTextBoxes(apptGroupBox);
                      
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void AppointmentGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {           
                if (AppointmentGrid.SelectedRows.Count > 0)
                {
                    var row = AppointmentGrid.SelectedRows[0];

                    txtBxApptId.Text = ((int)row.Cells[0].Value).ToString();
                    comboId.Text = ((int)row.Cells[2].Value).ToString();
                    //userCombo.Text = ((int)row.Cells[1].Value).ToString();
                    comboType.Text = (string)row.Cells[5].Value;
                    
                    dateTimePicker1.Value = (DateTime)row.Cells[3].Value;
                    dateTimePicker2.Value = (DateTime)row.Cells[4].Value;
                }
            
            
        }

        private void btnEditAppt_Click(object sender, EventArgs e)
        {
            editDelBtn();
            string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            MySqlConnection con = null;

            {
                if (AppointmentGrid.CurrentRow == null || !AppointmentGrid.CurrentRow.Selected)
                {
                    MessageBox.Show("Nothing is selected.  Please make a selection");
                    AppointmentGrid.Enabled = true;
                    return;
                }
                try
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to update this appointment? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        //var customerId = 0;
                        con = new MySqlConnection(constr);
                        MySqlCommand com = new MySqlCommand("UPDATE appointment SET customerId = @customerId, WHERE customerId = @customerId", con);
                        com.Parameters.AddWithValue("@customerId", comboId.Text);
                        com.Parameters.AddWithValue("@type", comboType.SelectedItem);
                        com.Parameters.AddWithValue("@userId", userCombo.Text);
                        com.Parameters.AddWithValue("@appointmentId", int.Parse(txtBxApptId.Text));
                        con.Open();
                        com.ExecuteNonQuery();
                        con.Close();
                        loadAllAppointments();
                        MessageBox.Show("Updated Successfully");
                        clearTextBoxes(apptGroupBox);                        
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }      

        private void btnCancel_Click(object sender, EventArgs e)
        {
            saveCancelBtn();
            clearTextBoxes(apptGroupBox);
            AppointmentGrid.ClearSelection();
        
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sqlString = "SELECT * FROM appointment where customerId like '" + txtBxSearch.Text + "%'";
            MySqlDataAdapter cd = new MySqlDataAdapter(sqlString, DBConnection.conn);
            DataTable dt = new DataTable();
            cd.Fill(dt);
            AppointmentGrid.DataSource = dt;
            AppointmentGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
    }


   


   