using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ScheduleApptApp
{
    public partial class Login : Form
    {
        //MySqlConnection con = new MySqlConnection("server = 127.0.0.1; username = sqlUser; password = Passw0rd!; database = client_schedule");

       

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'client_scheduleDataSet.user' table. You can move, or remove it, as needed.
          

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            

            //string selectUser = "SELECT userId FROM user WHERE userName = '{0}' AND password = '{1}' AND active = 1", 
            //MySqlDataAdapter da = new MySqlDataAdapter(selectUser, con);    

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void txtBoxUName_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxUName.Text.Length > 0 && txtBoxUserPass.Text.Length > 0)
            {
                btnLogin.Enabled = true;
            }
            else
            {
                btnLogin.Enabled = false;
            }
        }

        private void txtBoxUserPass_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxUName.Text.Length > 0 && txtBoxUserPass.Text.Length > 0)
            {
                btnLogin.Enabled = true;
            }
            else
            {
                btnLogin.Enabled = false;
            }
        }
    }
}
