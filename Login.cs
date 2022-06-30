using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        Exception ex;
        public Login()
        {
            InitializeComponent();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //CultureInfo myCultureInfo = CultureInfo.CurrentCulture;
            string userName = txtBoxUser.Text;
            string password = txtBoxUserPass.Text;

            string mySqlString = "SELECT * FROM user where username = @UserName and password = @Password";

            string connString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            MySqlConnection connection = new MySqlConnection(connString);
            DataTable myDataTable = new DataTable();

            MySqlCommand mySqlCommand = new MySqlCommand(mySqlString);
            mySqlCommand.Connection = connection;

            mySqlCommand.Parameters.AddWithValue("@UserName", userName);
            mySqlCommand.Parameters.AddWithValue("@Password", password);

            int adapter = new MySqlDataAdapter(mySqlCommand).Fill(myDataTable);
            if (myDataTable.Rows.Count <= 0)
            {
                MessageBox.Show(@"Please enter a correct username and password.",
                    @"Incorrect Username/Password Combination", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtBoxUser.Clear();
                txtBoxUserPass.Clear();

                using (StreamWriter sw = File.AppendText("userLog.txt")) 
                {
                    sw.WriteLine(System.DateTime.UtcNow.ToString() + "_UTC -- Failed login attempt for username \"" + txtBoxUser.Text + "\"");
                }
                return;
                
            }
            else
            {
                using (StreamWriter sw = File.AppendText("userLog.txt")) 
                {
                    sw.WriteLine(System.DateTime.UtcNow.ToString() + "_UTC -- Username \"" + txtBoxUser.Text + "\" logged in successfully");
                }
                MainPage mainPage = new MainPage();
                mainPage.Show();
                ApptAlert();
                
            }
            this.Hide();

        }

       

        private void Login_Load(object sender, EventArgs e)
        {
            string connString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            string culture = CultureInfo.CurrentCulture.EnglishName;

            if(culture == "Russian (Russia)")
            {
                ex = new Exception("Неверное имя пользователя или пароль!");
                btnLogin.Text = "Авторизоваться";
                btnCancel.Text = "отмена";
                lblName.Text = "имя пользователя";
                lblPass.Text = "пароль";
            }
            else
            {
                ex = new Exception("The username or password is incorrect!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private bool ApptAlert()
        {
            string userName = txtBoxUser.Text;
            bool hasAppt = false;

            try
            {
                string mySqlString = "SELECT * FROM appointment WHERE start BETWEEN NOW() + INTERVAL 15 MINUTE AND userId=(SELECT userId FROM user WHERE userName='{userName}')";
                var cmd = new MySqlCommand(mySqlString, DBConnection.conn);
                int appt = Convert.ToInt32(cmd.ExecuteScalar());
               
                if(appt == 0)
                {
                    hasAppt = false;
                }
                else
                {
                    hasAppt = true;
                    MessageBox.Show("You have an appointment coming up in 15 minutes");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
    }




