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
        static public MySqlConnection getConnection()
        {
            MySqlConnection con = new MySqlConnection("server = 127.0.0.1; username = sqlUser; password = Passw0rd!; database = client_schedule");
            return con;

        }

        //static public int newCustomer(string table)
        //{
        //    MySqlConnection con = getConnection();
        //    con.Open();
        //    MySqlCommand cmd = new MySqlCommand($"SELECT {table + "Id"} FROM {table}", con);
        //    MySqlDataReader rd = cmd.ExecuteReader();
        //    List <int> 1 = new List<int>();

        //    while(rd.Read())
        //    {
        //        1.Add(Convert.ToInt32(rd[0]));
        //    }
        //    rd.Close();
        //    con.Close();
        //    return newId(1);
        //}

        //static public int newId(List<int> 1)
        //{
        //    int ID = 0;
        //    foreach(int id in 1)
        //    {
        //        if(id > ID)
        //        {
        //            ID = id;
        //        }
        //    }
        //    return ID + 1;
        //}

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
