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
using ScheduleApptApp;


namespace ScheduleApptApp
{
    public partial class FormAllCustomers : Form
    {
        //customer Customer = new customer();



        public FormAllCustomers()
        {
            InitializeComponent();
            

        }

        
        private void FormAllCustomers_Load(object sender, EventArgs e)
        {
            


            this.btnSaveCustomer.Enabled = false;
            this.btnCancel.Enabled = false;
            this.custGroupBox.Enabled = false;
          
            //custDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //custDataGrid.ReadOnly = true;
            //custDataGrid.MultiSelect = false;
            //custDataGrid.RowHeadersVisible = false;
        }

        

        private void btnSaveCustomer_Click(object sender, EventArgs e)
        {
            //this.Validate();
            //this.customerBindingSource.EndEdit();
            //this.customerTableAdapter.UpdateAll(this.client_schedule_ds);
            //this.Close();
            
        }

        
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            new_edit_del_butt_enable();
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

            //get the ID of the selected row

            //query db for record

            //show data in form
        }

        private void btnDeleteCust_Click(object sender, EventArgs e)
        {
           

           
             
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
            Clear();
        }

        void Clear()
        {
            txtBoxCustId.Text = txtBoxCustName.Text = txtBoxCustPhone.Text = txtBoxCustAddress.Text = txtBoxPostal.Text = "";

        }

        
    }
}





        



