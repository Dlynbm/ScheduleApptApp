using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleApptApp
{
    class Data
    {
        static int currentUserId = 0;
        public object CustomerGrid { get; private set; }

        static public MySqlConnection getConnection()
        {
            MySqlConnection con = new MySqlConnection("server = 127.0.0.1; username = sqlUser; password = Passw0rd!; database = client_schedule");
            return con;

        }   
        
        static public void setCurrentUser(int id)
        {
            currentUserId = id;
        }

        static public int getCurrentUser()
        {
            return currentUserId;
        }

        static public void addCustomer(string name, int cityId, string phone, string address, string postal)
        {
            bool status = true;
            DateTime todayDate = DateTime.Now;
            MySqlConnection con = getConnection();
            string formattedDate = todayDate.ToString("yyyy-MM-dd HH:mm:ss.fff");
            //string addedCustomer = $"INSERT INTO customer (customerId, customerName, addressID, active, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES ('{createNewID("customer")}', '{name}', "

            //MySqlCommand cmd = new MySqlCommand(addedCustomer, con);
            con.Open();
            //cmd.ExecuteNonQuery();
            con.Close();

        }

        static public void updateCustomer(int custId, string customerName, int addressID, string phone, string address, string postal, int cityID)
        {
            MySqlConnection con = getConnection();
            DateTime updatedDate = DateTime.Now;
            string formattedDate = updatedDate.ToString("yyyy-MM-dd HH:mm:ss.fff");
            string updateCustomer = $"UPDATE customer AS c INNER JOIN address AS a ON c.addressId = c.addressId SET c.customerName = '{customerName}', c.lastUpdate = '{formattedDate}', a.address = '{address}', a.phone = '{phone}'," +
                $"a.postal = '{postal}', a.cityId. = {cityID}' WHERE c.customerId = '{custId}' AND a.addressId = '{addressID}'";

            MySqlCommand cmd = new MySqlCommand(updateCustomer, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }

        
    }
}


//private void btnLogin_Click(object sender, EventArgs e)
//{
//    string userName = txtBoxUserName.Text;
//    string password = txtBoxPass.Text;
//    MySqlCommand cmd = new MySqlCommand($"SELECT * FROM user WHERE userName = '{txtBoxUserName.Text}' AND password = '{txtBoxPass.Text}'", con);
//    con.Open();
//    MySqlDataReader rd = cmd.ExecuteReader();

//    if (rd.HasRows)
//    {
//        while (rd.Read())
//        {
//            Data.setCurrentUser(Convert.ToInt32(rd.GetString(0)));
//        }

//        MainPage mp = new MainPage();
//        mp.ShowDialog();
//        this.Close();
//    }
//    else if (!rd.HasRows)
//    {
//        MessageBox.Show(ex.Message);
//    }
//    con.Close();
//}