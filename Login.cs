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
        


        public Login()
        {
            InitializeComponent();     

        }



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
            if (myDataTable.Rows.Count <=0)
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

            //MySqlConnection con = new MySqlConnection("server=127.0.0.1; username = sqlUser; password = Passw0rd!; database = client_schedule");
            //con.Open();
            //MySqlCommand cmd = new MySqlCommand("select * from user where userName = '" + txtBoxUser.Text + "' AND password = '" + txtBoxUserPass.Text + "'", con);
            //MySqlDataReader reader = cmd.ExecuteReader();
            //if (reader.Read())
            //{

            //    //MessageBox.Show("Successfully Sign In!", "Message By Me", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    MainPage mp = new MainPage();
            //    mp.Show();
            //    //this.Close();
            //}
            //else
            //{
            //    MessageBox.Show("Username And Password Not Match!", "Message By Me", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //txtBoxUser.Text = string.Empty;
            //txtBoxUserPass.Text = string.Empty;
            //reader.Close();
            //cmd.Dispose();
            //con.Close(); // always close connection }
            ////CreateOrAppendTxt();


        }

        //private void Login_Load(object sender, EventArgs e)
        //{
        //    MySqlConnection con = new MySqlConnection("server=127.0.0.1; username = sqlUser; password = Passw0rd!; database = client_schedule");
        //    con.Open();
        //    string language = CultureInfo.CurrentCulture.EnglishName;

        //    if (language == "Russian (Russia)")
        //    {
        //        //username/pass incorrect
        //        ex = new Exception("Неверное имя пользователя или пароль!");
        //        //login
        //        btnLogin.Text = "Авторизоваться";
        //        //please enter login/password
        //        loginLbl.Text = "Пожалуйста, введите ваш логин и пароль, чтобы войти.";
        //        //username
        //        userNameLbl.Text = "имя пользователя";
        //        //password
        //        passLbl.Text = "пароль";

        //    }
        //    else
        //    {
        //        ex = new Exception("The username or password is incorrect!");
        //    }
        //}

        //private void CreateOrAppendTxt()
        //{
        //    //try
        //    //{
        //    //    string s = fileReader.WriteLine();
        //    //    if (s != null)
        //    //    {
        //    //        userNameLbl.Text = "Record: " + counter++ + "      " + s;
        //    //    }
        //    //    else
        //    //    {
        //    //        userNameLbl.Text = "No more records to read";
        //    //    }
        //    //}
        //    //catch (IOException ex)
        //    //{
        //    //    MessageBox.Show(ex.ToString());
        //    //}




        //}
    }
}



