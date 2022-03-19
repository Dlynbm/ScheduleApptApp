using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleApptApp
{
    class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public int AddressId { get; set; }
        public bool Active { get; set;  }

        public Customer(int custId, string custName, int custAdd, bool a)
        {
            CustomerId = custId;
            CustomerName = custName;
            AddressId = custAdd;
            Active = a;

        }
          
    }
}
