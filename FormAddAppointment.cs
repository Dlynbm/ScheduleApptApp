using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleApptApp
{
    public partial class FormAddAppointment : Form
    {

        public FormAddAppointment()
        {
        }

        public FormAddAppointment(MainPage parent)
        {
            InitializeComponent();
        }

        private void FormAddAppointment_Load(object sender, EventArgs e)
        {
            addTimeStart.Format = DateTimePickerFormat.Time;
            addTimeStart.ShowUpDown = true;
            addTimeEnd.Format = DateTimePickerFormat.Time;
            addTimeEnd.ShowUpDown = true;
        }






        private void SaveApptBtn_Click(object sender, EventArgs e)
        {
            DateTime dateTimeStartDB = addTimeStart.Value.Date + addTimeStart.Value.TimeOfDay;
            DateTime dateTimeEndDB = addTimeStart.Value.Date + addTimeEnd.Value.TimeOfDay;

            TimeSpan busStartTime = TimeSpan.Parse("09:00");
            TimeSpan busEndTime = TimeSpan.Parse("17:00");

            //bool checkOverlap = DBase.calendarCheck(dateTimeStartDB, dateTimeEndDB, 0);


        }

        //private void SaveApptBtn_Click(object sender, EventArgs e)
        //{
        //if (txtApptId.Text == string.Empty || txtCustId.Text == string.Empty || txtUserId.Text == string.Empty || txtType.Text == string.Empty)
        //{
        //    MessageBox.Show("Empty field");
        //    return;
        //}
        //else
        //{

        //    MySqlConnection con = new MySqlConnection("server=127.0.0.1; username = sqlUser; password = Passw0rd!; database = client_schedule");
        //    con.Open();

        //    MySqlCommand cmd = new MySqlCommand("INSERT into appointment (appointmentId, customerId, userId, type, start) VALUES ('" + txtApptId.Text + "', '" + txtCustId.Text + "', '" + txtUserId.Text + "', '" + txtType.Text + "', '" + AddApptDate.Text + "')", con);
        //    cmd.ExecuteNonQuery();

        //    cmd.Dispose();
        //    int apptId = txtApptId(Convert.ToInt32);
        //    int custId = txtCustId.Text;
        //    int useId = txtUserId.Text;
        //    string tp = txtType.Text;
        //    DateTime strt = txtDate.Text;



        //    string qur = "INSERT INTO appointment VALUES ('" + txtApptId.Text + "', '" + txtCustId.Text + "', '" + txtUserId.Text + "', '" + txtType.Text + "', '" + txtDate.Text + "')";

        //    MySqlCommand cmd = new MySqlCommand(qur, con);
        //    cmd.ExecuteNonQuery();
        //    con.Close();
        //    MessageBox.Show("Successfully added!");




    }
}


