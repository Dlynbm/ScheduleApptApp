using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleApptApp
{
    class Appointment
    {
        public int appointmentId { get; set; }
        public int customerId { get; set; }
        public int userId { get; set; }
        public string type { get; set; }
        public DateTime start { get; set; }






        public Appointment(int apptId, int custId, int useId, string tp, DateTime strt)
        {
            appointmentId = apptId;
            customerId = custId;
            userId = useId;
            type = tp;
            start = strt;
        }

        public Appointment(string v1, string v2, string v3, string v4, string v5)
        {
        }
    }
}
