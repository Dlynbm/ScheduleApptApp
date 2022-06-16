using System;
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
            loadAppointments();
            LoadListBoxCustId();
            LoadListBoxType();
            clearTextBoxes(apptGroupBox);
        }

        void new_edit_del_butt_enable()
        {
            this.btnEditAppt.Enabled = false;
            this.btnDeleteAppt.Enabled = false;
            this.btnAddAppt.Enabled = false;

            this.btnSaveAppt.Enabled = true;
            this.btnCancel.Enabled = true;

            this.apptGroupBox.Enabled = true;
            this.AppointmentGrid.Enabled = true;

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
            int count;
            //get connection string
            string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            MySqlConnection con = null;
            con = new MySqlConnection(constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT Max(appointmentId)+1 from appointment", con);
            count = Convert.ToInt16(cmd.ExecuteScalar()) + 1;
            txtBxApptId.Text = "0" + count;
            con.Close();
            //new_edit_del_butt_enable();
            //clearTextBoxes(apptGroupBox);

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            MainPage main = new MainPage();
            main.Show();
            this.Close();
        }

        //private void btnSaveAppt_Click(object sender, EventArgs e)
        //{
        //    string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
        //    MySqlConnection con = null;

        //    if (lstBoxCustId.Text == "" || lstBoxType.Text == "" || dateTimePicker1.Text == "" || dateTimePicker2.Text == "")
        //    {
        //        MessageBox.Show("Please complete all fields");
        //        //save_cancel_btn_enable();
        //        return;
        //    }
        //    try
        //    {
        //        DialogResult results = MessageBox.Show("Are you sure you want to add this appointment? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        //        appointmentId = 0;
        //        customerId = 0;
        //        userId = 0;
        //        if (results == DialogResult.Yes)
        //        {

        //            con = new MySqlConnection(constr);
        //            MySqlCommand com = new MySqlCommand("INSERT INTO appointment (customerId, userId, title, description, location, contact, type, url, start, end, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES(@customerId, @userId, 'xx', 'xx', 'xx', 'xx', @type, 'xx', @start, @end,  NOW(), 'xx', NOW(), 'xx')", con);
        //            com.Parameters.AddWithValue("@customerId", lstBoxCustId.Text);
        //            com.Parameters.AddWithValue("@userId", userId);
        //            con.Open();
        //            com.ExecuteNonQuery();
        //            appointmentId= (int)com.LastInsertedId;
        //            con.Close();
        //            loadAppointments();
        //            MessageBox.Show("Added Successfully");
        //        }
        //    }
        //    catch (MySqlException ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }

        //}



        private void LoadListBoxCustId()
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

        private void LoadListBoxType()
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

        private void loadAppointments()
        {
            string sqlString = "SELECT  appointment.appointmentId, customer.customerName, customer.customerId, appointment.start, appointment.end, appointment.type FROM appointment INNER JOIN customer ON appointment.customerId = customer.customerId INNER JOIN `user` ON appointment.userId = `user`.userId";
            MySqlDataAdapter da = new MySqlDataAdapter(sqlString, DBConnection.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            AppointmentGrid.DataSource = dt;
            AppointmentGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            AppointmentGrid.ClearSelection();
            fill_listbox();

            for (int idx = 0; idx < dt.Rows.Count; idx++)
            {
                dt.Rows[idx]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)dt.Rows[idx]["end"], TimeZoneInfo.Local).ToString();
            }
        }

        private void fill_listbox()
        {
            string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            MySqlConnection con = null;
            con = new MySqlConnection(constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT customerId FROM customer", con);
            con.Close();
        }

        private void btnDeleteAppt_Click(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            MySqlConnection con = null;
            {
                if (AppointmentGrid.CurrentRow == null || !AppointmentGrid.CurrentRow.Selected)
                {
                    MessageBox.Show("Nothing is selected.  Please make a selection");
                    //new_edit_del_butt_enable();
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
                        loadAppointments();
                        MessageBox.Show("Deleted Successfully");
                        clearTextBoxes(apptGroupBox);
                        //btnAddCustomer.Enabled = true;
                        //btnEditCust.Enabled = true;
                        //btnDeleteCust.Enabled = true;

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
                comboType.Text = (string)row.Cells[5].Value;
                dateTimePicker1.Value = (DateTime)row.Cells[3].Value;
                dateTimePicker2.Value = (DateTime)row.Cells[4].Value;
            }
        }

        private void btnEditAppt_Click(object sender, EventArgs e)
        {
            if (AppointmentGrid.CurrentRow == null || !AppointmentGrid.CurrentRow.Selected)
            {
                MessageBox.Show("Nothing is selected.  Please make a selection");
                //new_edit_del_butt_enable();

                return;
            }
            Appointment a = AppointmentGrid.CurrentRow.DataBoundItem as Appointment;
            var chosenAppointment = AppointmentGrid.CurrentCell.Value;
        }
    }
}

   


   