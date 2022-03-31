using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;

namespace ScheduleApptApp.Data
{
    class Data
    {


        static public MySqlConnection getConnection()
        {
            MySqlConnection con = new MySqlConnection("server = 127.0.0.1; username = sqlUser; password = Passw0rd!; database = client_schedule");
            return con;
        }

        //public static void addCustomer(string name, int cityId, string phoneNum, string address, string postalCode)
        //{
        //    bool status = true;
        //    MySqlConnection con = getConnection();
        //    string add = $"INSERT INTO customer (customerId, customerName, addressId, active, createDate, createdBy, lastUpdate, lastUpdateBy)" +
        //        //$" VALUES ('{createNewId("customer")}', '{name}', '{addAddress(address, phoneNum,postalCode,cityId)}', '{status}', '{sqlFormattedDate}', 'test', '{sqlFormattedDate}', 'test')";

        //    MySqlCommand com = new MySqlCommand(add, con);
        //    con.Open();
        //    com.ExecuteNonQuery();
        //    con.Close();
        //}

        private static object addAddress(string address, string phoneNum, string postalCode, int cityId)
        {
            throw new NotImplementedException();
        }

        private static object createNewId(string table)
        {
            MySqlConnection con = getConnection();
            con.Open();
            MySqlCommand cmd = new MySqlCommand($"SELECT {table + "Id"} FROM {table}", con);
            MySqlDataReader read = cmd.ExecuteReader();
            List<int> list = new List<int>();

            while (read.Read())
            {
                list.Add(Convert.ToInt32(read[0]));
            }
            read.Close();
            con.Close();
            return newId(list);     


        }

        private static object newId(List<int> list)
        {
            int ID = 0;
            foreach(int id in list)
            {
                if (id > ID)
                {
                    ID = id;
                }
            }
            return ID + 1;
        }
    }
}
