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

        private static MySqlConnection getConnection()
        {
            throw new NotImplementedException();
        }
    }
}
