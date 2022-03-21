using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleApptApp
{
    public partial class FormAddAppointment : Form
    {
        private readonly FormAllAppointments _parent;
        public FormAddAppointment(FormAddAppointment parent)
        {
            InitializeComponent();
            _parent = parent;
        }        

        private void SaveApptBtn_Click(object sender, EventArgs e)
        {
            if(TitleTxtBox.Text.Trim().Length < 3)
            {
                MessageBox.Show("Title is empty ( > 3).");
                return;
            }
            if (TypeTxtBox.Text.Trim().Length < 1)
            {
                MessageBox.Show("Decription is empty ( > 1). ");
                return;
                //continue the rest of the fields here
            }

        }
    }
}
