using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using System.Threading.Tasks;

namespace ScheduleApptApp
{
    class DBAppointment
    {
        public static MySqlConnection GetConnection()
        {
            string sql = "server = 127.0.0.1; username = sqlUser; password = Passw0rd!; database = client_schedule";
            MySqlConnection con = new MySqlConnection(sql);
            try
            {
                con.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySql Connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return con;
        }

        public static void AddAppointment (Apppointment appt)
        {
            string sql = "INSERT INTO client_schedule VALUES(@AppointmentId, @CustomerId, @UserId, @Title, @Description, @Contact,  @Start, @End)";
                MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("AppointmentId", MySqlDbType.VarChar).Value = appt.AppointmentId;
            cmd.Parameters.Add("CustomerId", MySqlDbType.VarChar).Value = appt.CustomerId;
            cmd.Parameters.Add("UserId", MySqlDbType.VarChar).Value = appt.UserId;
            cmd.Parameters.Add("Title", MySqlDbType.VarChar).Value = appt.Title;
            cmd.Parameters.Add("Description", MySqlDbType.VarChar).Value = appt.Description;
            cmd.Parameters.Add("Contact", MySqlDbType.VarChar).Value = appt.Contact;
            cmd.Parameters.Add("Start", MySqlDbType.VarChar).Value = appt.Start;
            cmd.Parameters.Add("End", MySqlDbType.VarChar).Value = appt.End;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Appointment not inserted. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();


        }

    }
    }

        