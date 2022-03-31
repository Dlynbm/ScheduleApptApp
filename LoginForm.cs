
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
using 

namespace ScheduleApptApp
{
    public partial class LoginForm : Form
    {
        MySqlConnection con;
        Exception ex;
        public LoginForm()
        {      

            InitializeComponent();
            //btnLogin.Enabled = false;
        }

        string currentUserId = iD;


        private void LoginForm_Load(object sender, EventArgs e)
        { con = new MySqlConnection("server=127.0.0.1; username = sqlUser; password = Passw0rd!; database = client_schedule");
         con.Open();
        // String sqlString = "SELECT userName, password FROM user";
        //MySqlCommand cmd = new MySqlCommand(sqlString, con);
        //MySqlDataAdapter cust = new MySqlDataAdapter(cmd);
    }

    //private bool allowLogin()
    //{
    //    if (string.IsNullOrWhiteSpace(txtBoxUserName.Text)) return false;

    //    if (string.IsNullOrWhiteSpace(txtBoxPass.Text)) return false;
    //    return true;
    //}


    private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtBoxUserName.Text;
            string password = txtBoxPass.Text;

            
            MySqlCommand com new MySqlCommand($"SELECT * FROM user WHERE userName ='{ txtBoxUserName.Text}'AND password='{txtBoxPass.Text}'", con;
            con.Open();
            MySqlDataReader rd = com.ExecuteReader();
            if (rd.HasRows)
            { 
                while(rd.Read())
            }
            currentUserId == 
            {
                MessageBox.Show("Invalid login");
            }
            con.Close();
        }

        //save user data to txt file
        //    //string fn ="C:\\Users\\LabUser";
        //    //string p;
        //    //p = fn + this.txtBoxUserName.Text + "_fn.txt";
        //    //System.IO.File.WriteAllText(p, txtBoxUserName.Text, Encoding.UTF8);
    

        //private void txtBoxUserName_TextChanged(object sender, EventArgs e)
        //{
        //    int number;
        //    if(Int32.TryParse(txtBoxUserName.Text, out number) || string.IsNullOrWhiteSpace(txtBoxUserName.Text))
        //    {
        //        txtBoxUserName.BackColor = System.Drawing.Color.Cornsilk;
                
        //    }
        //    else
        //    {
        //        txtBoxUserName.BackColor = System.Drawing.Color.White;
        //    }
        //    btnLogin.Enabled = allowLogin();
        //}

        //private void txtBoxPass_TextChanged(object sender, EventArgs e)
        //{
        //    int number;
          
        //    if (Int32.TryParse(txtBoxPass.Text, out number) || string.IsNullOrWhiteSpace(txtBoxPass.Text))
        //    {
        //        txtBoxUserName.BackColor = System.Drawing.Color.Cornsilk;

        //    }
        //    else
        //    {
        //        txtBoxPass.BackColor = System.Drawing.Color.White;
        //    }
        //    btnLogin.Enabled = allowLogin();
        //}

       
    }
}
