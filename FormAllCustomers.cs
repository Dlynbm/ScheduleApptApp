using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace ScheduleApptApp
{
    public partial class FormAllCustomers : Form
    {


        public FormAllCustomers()
        {
            InitializeComponent();
            
        }

        ScheduleApptApp.Model.client_scheduleEntities1 dc = new Model.client_scheduleEntities1();

        private void FormAllCustomers_Load(object sender, EventArgs e)
        {
            this.btnSaveCustomer.Enabled = false;
            this.btnCancel.Enabled = false;
            this.custGroupBox.Enabled = false;

            dc.customers.Load();
            this.customerBindingSource.DataSource = dc.customers.Local.ToBindingList();  


        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            new_edit_del_butt_enable();


        }

        void new_edit_del_butt_enable()
        {
            this.btnEditCust.Enabled = false;
            this.btnDeleteCust.Enabled = false;
            this.btnAddCustomer.Enabled = false;

            this.btnSaveCustomer.Enabled = true;
            this.btnCancel.Enabled = true;

            this.custGroupBox.Enabled = true;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            save_cancel_btn_enable();
            txtBoxCustId.Text = txtBoxCustName.Text = txtBoxCustPhone.Text = txtBoxCustAddress.Text = txtBoxCountry.Text = "";
        }

        void save_cancel_btn_enable()
        {
            this.btnSaveCustomer.Enabled = false;
            this.btnCancel.Enabled = false;

            this.btnAddCustomer.Enabled = true;
            this.btnEditCust.Enabled = true;
            this.btnDeleteCust.Enabled = true;

            this.custGroupBox.Enabled = false;
        }

       

        private void btnEditCust_Click(object sender, EventArgs e)
        {
            new_edit_del_butt_enable();
        }

        private void btnDeleteCust_Click(object sender, EventArgs e)
        {
            new_edit_del_butt_enable();


        }

        private void btnSaveCustomer_Click(object sender, EventArgs e)
        {
            //Model.customer = txtBoxCustId.Text.Trim();
            //Model.customer = txtBoxCustName.Text.Trim();
            //Model.customer = txtBoxCountry.Text.Trim();
            //Model.customer = txtBoxCustAddress.Text.Trim();
            //Model.customer = txtBoxCustPhone.Text.Trim();

            //using (client_scheduleEntities1 db = new client_scheduleEntities1())
            //{

            //}

            //int cityId = 0;
            //switch (cityComboBox.FindString(cityComboBox.SelectedItem.ToString()))
            //{
            //    case 0:
            //        cityId = 1;
            //        break;
            //    case 1:
            //        cityId = 2;
            //        break;
            //    case 2:
            //        cityId = 3;
            //        break;
            //    case 3:
            //        cityId = 4;
            //        break;
            //    case 4:
            //        cityId = 5;
            //        break;
            //    case 5:
            //        cityId = 6;
            //        break;
            //    case 6:
            //        cityId = 7;
            //        break;
            //    case 7:
            //        cityId = 8;
            //        break;
            //    case 8:
            //        cityId = 9;
            //        break;
            //    case 9:
            //        cityId = 10;
            //        break;
            //    case 10:
            //        cityId = 11;
            //        break;
            //    case 11:
            //        cityId = 12;
            //        break;
            //    case 12:
            //        cityId = 13;
            //        break;
            //}

           //Data.Data.addCustomer(txtBoxCustName.Text, cityId, txtBoxCustPhone.Text, txtBoxCustAddress.Text, txtBoxCountry.Text);
            this.Close();
            dc.Dispose();
        }

        
    }
    }





        



