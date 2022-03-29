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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if (this.txtBoxUserName.Text == "")
            {
                MessageBox.Show("You must enter a user id");
                return;
            }
            MainPage mainP = new MainPage();
            mainP.Show();



            //save user data to txt file
            //string fn ="C:\\Users\\LabUser";
            //string p;
            //p = fn + this.txtBoxUserName.Text + "_fn.txt";
            //System.IO.File.WriteAllText(p, txtBoxUserName.Text, Encoding.UTF8);
        }

        
    }
}
