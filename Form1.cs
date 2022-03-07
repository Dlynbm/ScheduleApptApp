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

namespace ScheduleApptApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            String str = "server=127.0.0.1;userid=sqlUser;database=client_schedule";

            String query = "select * users";

            SqlConnection con = new SqlConnection(str);

            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();

            DataSet ds = new DataSet();

            MessageBox.Show("connect with sql server");

            con.Close();
        }
    }
}