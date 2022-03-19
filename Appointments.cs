//using MySql.Data.MySqlClient;
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
            
        }

        private void Appoointments_Load(object sender, EventArgs e)
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM Appointment", "server = 127.0.0.1; username = sqlUser; password = Passw0rd!; database = client_schedule");
            DataSet ds = new DataSet();
            da.Fill(ds, "Appointment");
            AppointmentGrid.DataSource = ds.Tables["Appointment"].DefaultView;
        }





        private void AddCustBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void ViewCustomersBtn_Click(object sender, EventArgs e)
        {
            Customers custForm = new Customers();
            custForm.Show();
        }

        private void AddApptBtn_Click(object sender, EventArgs e)
        {
            AddAppointment apptForm = new AddAppointment();
            apptForm.Show();
        }



        //private void AddAppt_Click(object sender, EventArgs e)
        //{
        //    AddAppointment apptForm = new Appointment();
        //    apptForm.Show();
        //}
    }
}