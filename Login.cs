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

        // Requirment A:  checks user location, translates log in error control messages into english and russian
        private void btnLogin_Click(object sender, EventArgs e)
        {
            CultureInfo myCultureInfo = CultureInfo.CurrentCulture;
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
                if (CultureInfo.CurrentCulture.TwoLetterISOLanguageName == "en")
                {
                    //Requirment F:  Checks for incorrect username and password
                    MessageBox.Show("Please enter a correct username and password.");
                }
                if(CultureInfo.CurrentCulture.TwoLetterISOLanguageName == "ru")
                {
                    MessageBox.Show("инкоррект узернаме ор пассуорд");
                }               

                //Requiremnt J:  track user activity by recording timestamps for user log ins in a txt file
                using (StreamWriter sw = File.AppendText("userLog.txt")) //saves to C:\Users\LabUser\source\repos\Dlynbm\ScheduleApptApp\bin\Debug
                {
                    sw.WriteLine(System.DateTime.UtcNow.ToString() + "_UTC -- Username \"" + txtBoxUser.Text + "\" login failed");
                }
                txtBoxUser.Clear();
                txtBoxUserPass.Clear();
                return;


                
            }
            else
            {
                using (StreamWriter sw = File.AppendText("userLog.txt")) //saves to C:\Users\LabUser\source\repos\Dlynbm\ScheduleApptApp\bin\Debug
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
            string culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;

            if (culture == "ru")
            {
                ex = new Exception("Неверное имя пользователя или пароль!");
                btnLogin.Text = "Авторизоваться";
                btnCancel.Text = "отмена";
                lblName.Text = "имя пользователя";
                lblPass.Text = "пароль";
                Label.Text = "уэлком";

            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      

        //Requirement H:  provide reminder and alerts 15 minutes in advance of appointment, based on user log in
        private void ApptAlert()
        {
            string user = txtBoxUser.Text;
            try
            {
                string mySqlString = $"SELECT * FROM appointment WHERE start BETWEEN NOW() AND NOW() + INTERVAL 15 MINUTE AND userId=(SELECT userId FROM user WHERE userName='{user}')";
                var upcoming = new MySqlCommand(mySqlString, DBConnection.conn);
                int upcomingIndex = Convert.ToInt32(upcoming.ExecuteScalar());

                if (upcomingIndex == 0)
                {
                }
                else
                {
                    //uses greet Lambda
                    greet("You have a meeting within the next 15 minutes.");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return;
        }
        //Requirement G: I used a Lambda here to make the code more simple and effecient to greet user of upcoming appointment
        Action<string> greet = alert =>
        {
            string greeting = $"{alert}";
            MessageBox.Show(greeting);
        };

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }




