using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleApptApp
{
    class Appointment
    {
        public int AppointmentId { get; set; }
        public int CustomerId { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public string Contact { get; set; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }





        public Appointment(int apptId, int custId, int useId, string t, string desc, string loc, string cont,string typ,
            DateTime strt, DateTime en, DateTime crtdBy, string lstUdBy)
        {
            AppointmentId = apptId;
            CustomerId = custId;
            UserId = useId;
            Title = t;
            Description = desc;
            Contact = cont;
            Start = strt;
            End = en;
        }
    }
}
