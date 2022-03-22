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
    public partial class FormAllAppointments : Form
    {
        public FormAllAppointments()
        {
            InitializeComponent();

        }

      



        private void ViewCustomersBtn_Click(object sender, EventArgs e)
        {
            FormAllCustomers custForm = new FormAllCustomers();
            custForm.Show();
        }

        private void AddApptBtn_Click(object sender, EventArgs e)
        {
            FormAddAppointment addAppt = new FormAddAppointment(this);
            addAppt.Show();
        }

        
    }

     





        
    
}