using System;
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
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        

        private void SaveCustBtn_Click_1(object sender, EventArgs e)
        {
            //clear all text boxes
            this.txtBoxCustName.ResetText();
            this.txtBoxCustCity.ResetText();
            this.txtBoxCustAddress.ResetText();
            this.txtBoxCustPhone.ResetText();
            this.txtBoxCountry.ResetText();


            //save txt file of all customers
            //

            //string fn = "C:\\Users\\LabUser";
            //string p;
            //p = fn + this.txtBoxCustId.Text + "_fn.txt";
            //System.IO.File.WriteAllText(p, txtBoxCustName.Text, Encoding.UTF8);

        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {
            //this.SaveCustBtn.Enabled = false;
        }
    }
}
