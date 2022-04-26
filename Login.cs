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
        private MySqlConnection con;
        Exception ex;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            con = Data.getConnection();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtBoxUserName.Text;
            string userPassword = txtBoxUserPass.Text;

            MySqlCommand cmd = new MySqlCommand($"SELECT * FROM user WHERE userName = '{txtBoxUserName.Text}' AND password = {txtBoxUserPass.Text}'", con);
            con.Open();
            MySqlDataReader read = cmd.ExecuteReader();

            if(read.HasRows)
            {
                while (read.Read())
            { 
                Data.setCurrentUser(Convert.ToInt32(read.GetString(0)));
            }
            MainPage main = new MainPage();
            main.ShowDialog();

            using (StreamWriter streamWriter = new StreamWriter("log.txt", true))
            {
                streamWriter.WriteLine(txtBoxUserName.Text);
                streamWriter.WriteLine(DateTime.Now.ToString());
            }
            this.Close();

        }
        else if(!read.HasRows)
            {
            MessageBox.Show(ex.Message);
            }
    con.Close();
    }
}
}
