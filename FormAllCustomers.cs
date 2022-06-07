using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
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
        private int selectedCustomer = -1;
        DBConnection con = new DBConnection();

        public FormAllCustomers()
        {
            InitializeComponent();
            CustomerGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CustomerGrid.RowHeadersVisible = false;
            CustomerGrid.ReadOnly = true;
            CustomerGrid.AllowUserToAddRows = true;
            CustomerGrid.ClearSelection();

        }

        private void FormAllCustomers_Load(object sender, EventArgs e)
        {
            //this.btnSaveCustomer.Enabled = false;
            this.btnCancel.Enabled = false;
            this.custGroupBox.Enabled = false;
            CustomerGrid.ClearSelection();
            loadCustomers();

        }

        private void loadCustomers()
        {
            string sqlString = "SELECT customer.customerId, customer.customerName, address.address, address.postalCode, address.phone,  city.city,  country.country FROM customer INNER JOIN address ON customer.addressID = address.addressId INNER JOIN city ON address.cityId = city.cityId INNER JOIN country ON city.countryId = country.countryId";
            MySqlDataAdapter cd = new MySqlDataAdapter(sqlString, DBConnection.conn);
            DataTable dt = new DataTable();
            cd.Fill(dt);
            CustomerGrid.DataSource = dt;
            CustomerGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CustomerGrid.ClearSelection();
        }

       

        private void clearTextBoxes(GroupBox custGroupBox)
        {
            foreach (Control ctrl in custGroupBox.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox textBox = (TextBox)ctrl;
                    textBox.Text = null;
                }
            }
        }

        void new_edit_del_butt_enable()
        {

            this.btnCancel.Enabled = true;

            this.custGroupBox.Enabled = true;
            this.CustomerGrid.Enabled = true;
        }


        private void save_cancel_btn_enable()
        {
            this.btnDeleteCust.Enabled = true;

            this.custGroupBox.Enabled = false;
            this.CustomerGrid.Enabled = true;
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            new_edit_del_butt_enable();
            clearTextBoxes(custGroupBox);
        }


        private void btnEditCust_Click(object sender, EventArgs e)
        {
            new_edit_del_butt_enable();
            if (CustomerGrid.CurrentRow == null || !CustomerGrid.CurrentRow.Selected)
            {
                MessageBox.Show("Nothing is selected.  Please make a selection");
                new_edit_del_butt_enable();

                return;
            }
            Customer c = CustomerGrid.CurrentRow.DataBoundItem as Customer;
            var chosenCustomer = CustomerGrid.CurrentCell.Value;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            save_cancel_btn_enable();
            clearTextBoxes(custGroupBox);
            CustomerGrid.ClearSelection();
        }

        private void btnDeleteCust_Click(object sender, EventArgs e)
        {
            if (CustomerGrid.CurrentRow == null || !CustomerGrid.CurrentRow.Selected)
            {
                MessageBox.Show("Nothing is selected.  Please make a selection");
                new_edit_del_butt_enable();
                return;
            }
            try
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this customer? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string mySqlString = "DELETE FROM appointment WHERE customerId = '" + txtBoxCustId.Text + "'";
                    string connString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
                    MySqlConnection connection = new MySqlConnection(connString);
                    MySqlCommand mySqlCommand = new MySqlCommand(mySqlString);
                    mySqlCommand.Connection = connection;
                    mySqlCommand.ExecuteNonQuery();
                }
                {
                    string sqlString = "DELETE FROM customer WHERE customerId = '" + txtBoxCustId.Text;
                    string conString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
                    MySqlConnection con = new MySqlConnection(conString);
                    MySqlCommand sqlCommand = new MySqlCommand(sqlString);
                    sqlCommand.ExecuteNonQuery();

                    loadCustomers();
                    MessageBox.Show("Deleted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message by me", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

          


            //{
            //    if (CustomerGrid.CurrentRow == null || !CustomerGrid.CurrentRow.Selected)
            //    {
            //        MessageBox.Show("Nothing is selected.  Please make a selection");
            //        new_edit_del_butt_enable();
            //        return;
            //    }
            //    try
            //    {
            //        DialogResult result = MessageBox.Show("Are you sure you want to delete this customer? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //        if (result == DialogResult.Yes)
            //        {
            //            MySqlCommand com = new MySqlCommand("DELETE FROM appointment WHERE customerId = '" + txtBoxCustId.Text + "'");
            //            com.ExecuteNonQuery();

            //        }
            //        {
            //            MySqlCommand com = new MySqlCommand("DELETE FROM customer WHERE customerId = '" + txtBoxCustId.Text );
            //            com.ExecuteNonQuery();
            //            loadCustomers();
            //            MessageBox.Show("Deleted Successfully");
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message, "Message by me", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
        }

        private void btnSaveCustomer_Click_1(object sender, EventArgs e)
        {

            if (txtBoxCustName.Text == "" || txtBoxCustAdd.Text == "" || txtBoxCustCity.Text == "" || txtBoxCustPhone.Text == "" || txtBoxCustCountry.Text == "")
            {
                MessageBox.Show("Please complete all fields");
                save_cancel_btn_enable();
                return;
            }

            //try
            //{    

            //get the connection string
            string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            //make the connection
            MySqlConnection conn = new MySqlConnection(constr);
            DBConnection.startConnection();
                DialogResult result = MessageBox.Show("Are you sure you want to save this customer? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    MySqlCommand com = new MySqlCommand("INSERT INTO country VALUES( NULL, @country, NOW(), 'xx', NOW(), 'xx'", conn);
                    com.Parameters.AddWithValue("@country", txtBoxCustCountry.Text);
                    com.ExecuteNonQuery();
                    int countryId = (int)com.LastInsertedId;

                    MySqlCommand cmd = new MySqlCommand("INSERT INTO city VALUES(NULL, @city, @countryId, NOW(), 'XX', NOW(), 'XX'", conn);
                    cmd.Parameters.AddWithValue("@city", txtBoxCustCity.Text);
                    cmd.ExecuteNonQuery();
                    int cityId = (int)cmd.LastInsertedId;

                    MySqlCommand add = new MySqlCommand("INSERT INTO address VALUES(NULL, @address, @address2, @cityId, 'xx', @phoneNumber, NOW(), 'xx', NOW(), 'xx'", conn);
                    add.Parameters.AddWithValue("@address", txtBoxCustAdd.Text);
                    add.Parameters.AddWithValue("@phoneNumber", txtBoxCustPhone.Text);
                    com.ExecuteNonQuery();
                    int addressId = (int)add.LastInsertedId;
                    loadCustomers();

                    MySqlCommand cust = new MySqlCommand("INSERT INTO customer VALUES(NULL, @customerName, @addressId, 'xx', NOW(), 'xx', NOW(), 'xx'", conn);
                    cust.Parameters.AddWithValue("@customer", txtBoxCustName.Text);
                    com.ExecuteNonQuery();
                    int customerId = (int)cust.LastInsertedId;
                    loadCustomers();
                    MessageBox.Show("New Customer Added Successfully");
                }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Message by me", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }





        //private void UpdateButton1_Click(object sender, EventArgs e)
        //{
        //    {
        //        if (CustomerGrid.CurrentRow == null || !CustomerGrid.CurrentRow.Selected)
        //        {
        //            MessageBox.Show("Nothing is selected.  Please make a selection");
        //            new_edit_del_butt_enable();
        //            return;
        //        }

        //        try
        //        {
        //            MySqlCommand com = new MySqlCommand("UPDATE customer SET customerName = '" + txtBoxCustName.Text + '"WHERE custId = txtBoxCustId.Text  "'", DBConnection.conn);
        //            com.ExecuteNonQuery();
        //            loadCustomers();
        //            MessageBox.Show("Updated Successfully");


        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message, "Message by me", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //}


        private void CustomerGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CustomerGrid.SelectedRows.Count > 0)
            {
                selectedCustomer = CustomerGrid.CurrentCell.RowIndex;
                string custId = CustomerGrid.SelectedRows[0].Cells[0].Value + string.Empty;
                string custName = CustomerGrid.SelectedRows[0].Cells[1].Value + string.Empty;
                string custPhone = CustomerGrid.SelectedRows[0].Cells[2].Value + string.Empty;
                string custAddress = CustomerGrid.SelectedRows[0].Cells[3].Value + string.Empty;
                string custCity = CustomerGrid.SelectedRows[0].Cells[4].Value + string.Empty;
                string custCountry = CustomerGrid.SelectedRows[0].Cells[5].Value + string.Empty;

                txtBoxCustId.Text = custId;
                txtBoxCustName.Text = custName;
                txtBoxCustPhone.Text = custPhone;
                txtBoxCustAdd.Text = custAddress;
                txtBoxCustCity.Text = custCity;
                txtBoxCustCountry.Text = custCountry;

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sqlString = "SELECT * FROM customer where customerName like '" + txtBxSearch.Text + "%'";
            MySqlDataAdapter cd = new MySqlDataAdapter(sqlString, DBConnection.conn);
            DataTable dt = new DataTable();
            cd.Fill(dt);
            CustomerGrid.DataSource = dt;
            CustomerGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}











