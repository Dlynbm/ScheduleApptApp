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
            //get connection string
            string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            //make connection
            MySqlConnection con = null;
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
                        con = new MySqlConnection(constr);
                        MySqlCommand com = new MySqlCommand("DELETE FROM appointment WHERE customerId = '" + txtBoxCustId.Text + "'", con);
                        con.Open();
                        com.ExecuteNonQuery();
                        con.Close();

                    }
                    {
                        con = new MySqlConnection(constr);
                        MySqlCommand com = new MySqlCommand("DELETE FROM customer WHERE customerId = '" + txtBoxCustId.Text + "'", con);
                        con.Open();
                        com.ExecuteNonQuery();
                        con.Close();
                        loadCustomers();
                        MessageBox.Show("Deleted Successfully");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void btnSaveCustomer_Click_1(object sender, EventArgs e)
        {

            string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            MySqlConnection con = null;

            if (txtBoxCustName.Text == "" || txtBoxCustAdd.Text == "" || txtBoxCustCity.Text == "" || txtBoxCustPhone.Text == "" || txtBoxCustCountry.Text == "")
            {
                MessageBox.Show("Please complete all fields");
                save_cancel_btn_enable();
                return;
            }
            try
            {
                DialogResult results = MessageBox.Show("Are you sure you want to add this customer? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (results == DialogResult.Yes)
                {
                    con = new MySqlConnection(constr);
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO country VALUES (NULL, @COUNTRY, NOW(), 'xx', NOW(), 'xx',", con);
                    cmd.Parameters.AddWithValue("@COUNTRY", txtBoxCustCountry.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    int countryId = (int)cmd.LastInsertedId;
                    con.Close();
                }
                {
                    con = new MySqlConnection(constr);
                    MySqlCommand command = new MySqlCommand("INSERT INTO city VALUES(NULL, @CITY, @COUNTRYIDId, NOW(), 'XX', NOW(), 'XX'", con);
                    command.Parameters.AddWithValue("@CITY", txtBoxCustCity.Text);
                    con.Open();
                    command.ExecuteNonQuery();
                    int cityId = (int)command.LastInsertedId;
                    con.Close();
                }
                {
                    con = new MySqlConnection(constr);
                    MySqlCommand add = new MySqlCommand("INSERT INTO address VALUES(NULL, @address, @address2, @cityId, 'xx', @phoneNumber, NOW(), 'xx', NOW(), 'xx'", con);
                    add.Parameters.AddWithValue("@address", txtBoxCustAdd.Text);
                    add.Parameters.AddWithValue("@phoneNumber", txtBoxCustPhone.Text);
                    con.Open();
                    add.ExecuteNonQuery();
                    int addressId = (int)add.LastInsertedId;
                    con.Close();
                }
                con = new MySqlConnection(constr);
                MySqlCommand com = new MySqlCommand("INSERT INTO customer VALUES(NULL, @customerName, @addressId, 'xx', NOW(), 'xx', NOW(), 'xx'", con);
                com.Parameters.AddWithValue("@customerName", txtBoxCustName.Text);
                con.Open();
                com.ExecuteNonQuery();
                int customerId = (int)com.LastInsertedId;
                con.Close();
                loadCustomers();
                MessageBox.Show("Added Successfully");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



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

        private void UpdateButton1_Click(object sender, EventArgs e)
        {
            //get connection string
            string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            //make connection
            MySqlConnection con = null;
            {
                if (CustomerGrid.CurrentRow == null || !CustomerGrid.CurrentRow.Selected)
                {
                    MessageBox.Show("Nothing is selected.  Please make a selection");
                    new_edit_del_butt_enable();
                    return;
                }
                try
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to update this customer? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        con = new MySqlConnection(constr);
                        MySqlCommand com = new MySqlCommand("UPDATE country SET country = @country WHERE countryId = @countryId", con);
                        com.Parameters.AddWithValue("@country", txtBoxCustCountry.Text);                                    
                        con.Open();
                        com.ExecuteNonQuery();
                        con.Close();

                    }
                    {
                        con = new MySqlConnection(constr);
                        MySqlCommand com = new MySqlCommand("UPDATE city SET city = @city WHERE cityId = @cityId", con);
                        com.Parameters.AddWithValue("@city", txtBoxCustCity.Text);
                        con.Open();
                        com.ExecuteNonQuery();
                        con.Close();                     
                        
                    }

                    {
                        con = new MySqlConnection(constr);
                        MySqlCommand com = new MySqlCommand("UPDATE address SET address = @address WHERE cityId = @cityId", con);
                        com.Parameters.AddWithValue("@address", txtBoxCustAdd.Text);
                        com.Parameters.AddWithValue("@phone", txtBoxCustPhone.Text);
                        con.Open();
                        com.ExecuteNonQuery();
                        con.Close();                        
                    }
                    {
                        con = new MySqlConnection(constr);
                        MySqlCommand com = new MySqlCommand("UPDATE customer SET customer = @customer WHERE customerId = @customerId", con);
                        com.Parameters.AddWithValue("@customer", txtBoxCustName.Text);
                        con.Open();
                        com.ExecuteNonQuery();
                        con.Close();
                        loadCustomers();
                        MessageBox.Show("Updated Successfully");
                    }

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
    }
    }















