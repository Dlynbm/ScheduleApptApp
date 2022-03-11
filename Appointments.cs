using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using MySql.Data.MySqlClient;

namespace ScheduleApptApp
{
    public partial class Appointments : Form
    {
        public Appointments()
        {
            InitializeComponent();

        }

        

        private void AddAppt_Click(object sender, EventArgs e)
        {
            AddAppointment form = new AddAppointment();
            form.ShowDialog();


        }

    }
}