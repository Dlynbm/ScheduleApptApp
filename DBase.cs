using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleApptApp
{
    class DBase
    {
        //static public bool calendarCheck( DateTime startOverlapCheck, DateTime endOverlapCheck, int appID)
        //{
        //    for each(DataTable)
        //}


        static public void addAppointment (int cusid, int userid, DateTime start, DateTime end, string type)
        {
            MySqlConnection con = getConnection();
        }

        //internal static void addCustomer(string name, int cityId, string pNumber, string address, string pCode)
        //{
        //    bool status = true;
        //    DateTime dateToDb = DateTime.Now;
        //    //add connection here
        //    string sqlFormattedDate = dateToDb.ToString("yyy-MM-dd HH:mm:ss,ff");
        //    string add = $"INSERT INTO customer (customerId, customerName, addressID, active, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES ('{createNewCustId("customer")}', '{name}', {addAddress(address, pNumber, pcCode, cityId)}', '{status}', '{sqlFormattedDate}', 'test', '{sqlFormattedDate}', 'test')";

        //    MySqlCommand com = new MySqlCommand(add, connection);
        //    con.Open();
        //    com.ExecuteNonQuery();
        //    con.Close();
        //}

        private static MySqlConnection getConnection()
        {
            throw new NotImplementedException();
        }
    }
}
