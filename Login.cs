using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        private Exception ex;
        private StreamReader fileReader;
        string fileName = "dlyn.txt";
        public static int counter = 1;


        public Login()
        {
            InitializeComponent();
            FileStream inp = new FileStream(fileName, FileMode.Open, FileAccess.Write);
            //fileReader = new StreamReader(inp);

        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server=127.0.0.1; username = sqlUser; password = Passw0rd!; database = client_schedule");
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from user where userName = '" + txtBoxUser.Text + "' AND password = '" + txtBoxUserPass.Text + "'", con);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {

                //MessageBox.Show("Successfully Sign In!", "Message By Me", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainPage mp = new MainPage();
                mp.Show();
                //this.Close();
            }
            else
            {
                MessageBox.Show("Username And Password Not Match!", "Message By Me", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtBoxUser.Text = string.Empty;
            txtBoxUserPass.Text = string.Empty;
            reader.Close();
            cmd.Dispose();
            con.Close(); // always close connection }
            //CreateOrAppendTxt();


        }

        private void Login_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server=127.0.0.1; username = sqlUser; password = Passw0rd!; database = client_schedule");
            con.Open();
            string language = CultureInfo.CurrentCulture.EnglishName;

            if (language == "Russian (Russia)")
            {
                //username/pass incorrect
                ex = new Exception("Неверное имя пользователя или пароль!");
                //login
                btnLogin.Text = "Авторизоваться";
                //please enter login/password
                loginLbl.Text = "Пожалуйста, введите ваш логин и пароль, чтобы войти.";
                //username
                userNameLbl.Text = "имя пользователя";
                //password
                passLbl.Text = "пароль";

            }
            else
            {
                ex = new Exception("The username or password is incorrect!");
            }
        }

        private void CreateOrAppendTxt()
        {
            //try
            //{
            //    string s = fileReader.WriteLine();
            //    if (s != null)
            //    {
            //        userNameLbl.Text = "Record: " + counter++ + "      " + s;
            //    }
            //    else
            //    {
            //        userNameLbl.Text = "No more records to read";
            //    }
            //}
            //catch (IOException ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}




        }
    }
}