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
                return;
            }
            else
            {
                MainPage mainPage = new MainPage();
                mainPage.Show();
            }

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


        }
    }




