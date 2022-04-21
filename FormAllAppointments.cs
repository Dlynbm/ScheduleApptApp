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
    public partial class FormAllAppointments : Form
    {
        public FormAllAppointments()
        {
            InitializeComponent();


            MySqlConnection con = Data.getConnection();
            String sqlQuery = "";
            DataTable dt = new DataTable();


            MySqlDataAdapter cd = new MySqlDataAdapter(sqlQuery, con);
            con.Open();
            //cd.Fill(dt);
            con.Close();

            AppointmentGrid.DataSource = dt;

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
    }
}
