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
            MySqlConnection con = new MySqlConnection("server=127.0.0.1; username = sqlUser; password = Passw0rd!; database = client_schedule");
            con.Open();
            String sqlString = "SELECT customer.customerId, customer.customerName, customer.addressId, customer.active, address.phone, city.city, country.country" +
                " FROM customer" +
                "INNER JOIN customer ON address.addressId=customer.customerId";

            MySqlCommand cmd = new MySqlCommand(sqlString, con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            custDataGrid.DataSource = dt;
            custDataGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        

        //private void PopulateFields(customer customer)
        //{
        //    txtBoxCustId.Text = customer.customerId.ToString();
        //    txtBoxCustName.Text = customer.customerName;
        //    txtBoxCustAddress.Text = customer.addressId.ToString();
        //    //txtBoxCustPhone.Text = address.phone.ToString();
        //    //txtBoxPostal.Text = address.postalCode.ToString();
        //}


        private void FormAllCustomers_Load(object sender, EventArgs e)
        {   
            custDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            custDataGrid.ReadOnly = true;
            custDataGrid.MultiSelect = false;
            custDataGrid.RowHeadersVisible = false;

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
            this.Close();
            //if (isEditMode == true)
            //{
            //    var custId = int.Parse(txtBoxCustId.Text);
            //    var customer = dc.customers.FirstOrDefault(q => q.customerId == custId);
            //    customer.customerName = txtBoxCustName.Text;
            //    customer.addressId = int.Parse(txtBoxCustAddress.Text);
            //    //dc.addresses.phone = (txtBoxCustPhone.Text;
            //    //address.postalCode = txtBoxPostal.Text;
            //    dc.SaveChanges();
            //}
            //else
            //{
            //    var newCustomer = new customer
            //    {
            //        customerName = txtBoxCustName.Text,
            //        addressId = int.Parse(txtBoxCustAddress.Text),
            //        //address = txtBoxCustPhone.Text,
            //        //postalCode = txtBoxPostal.Text;

            //    };
            //    dc.customers.Add(newCustomer);
            //    dc.SaveChanges();
            //}
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





        



