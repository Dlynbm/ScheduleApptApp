﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleApptApp
{
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }

        private void AddCustomerBtn_Click(object sender, EventArgs e)
        {
            AddCustomer form = new AddCustomer();
            form.Show();
        }
    }
}
