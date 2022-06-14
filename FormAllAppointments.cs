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
        DBConnection con = new DBConnection();
        public FormAllAppointments()
        {
            InitializeComponent();
            //MySqlConnection con = new MySqlConnection("server = 127.0.0.1; username = sqlUser; password = Passw0rd!; database = client_schedule");
            //con.Open();


            AppointmentGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AppointmentGrid.RowHeadersVisible = false;
            AppointmentGrid.ReadOnly = true;
            AppointmentGrid.AllowUserToAddRows = true;
            AppointmentGrid.ClearSelection();
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
            }
        }

        private void btnAddAppt_Click(object sender, EventArgs e)
        {
            new_edit_del_butt_enable();
            clearTextBoxes(apptGroupBox);

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            MainPage main = new MainPage();
            main.Show();
            this.Close();
        }

        private void btnSaveAppt_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    using (MySqlConnection con = Data.getConnection())
            //    {
            //        if (con.State == ConnectionState.Closed)
            //            con.Open();
            //        using (DataTable dt = new DataTable("Dates"))
            //        {
            //            using (MySqlCommand cmd = new MySqlCommand("INSERT INTO appointment ( userId, customerName, title, description, location, contact, type, url, start, end, createDate, createdBy, lastUpdate, lastUpdateBy)
            //           VALUES ('@custId', '@userId', '@title', '@desc', '@location', '@contact', '@type', '@url', '@stDate', '@endDate', '@creatD', '@creatBy', '@lastUp', '@lastUpBy')", con);
            //            {
            //                //adding values
            //                cmd.Parameters.AddWithValue("@custId", .Value);
            //                cmd.Parameters.AddWithValue("@d2", p_EndDate.Value);
            //                //fill data to datatable
            //                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            //                da.Fill(dt);
            //                //adding datasource
            //                AppointmentGrid.DataSource = dt;

        }



        private void FormAllAppointments_Load(object sender, EventArgs e)
        {
            AppointmentGrid.ClearSelection();
            loadAppointments();
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
    }

    }


   