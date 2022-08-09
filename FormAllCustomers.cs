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
            btnAddCustomer.Enabled = true;
            btnEditCust.Enabled = true;
            btnDeleteCust.Enabled = true;
            btnSaveCustomer.Enabled = false;
            btnCancel.Enabled = false;
            UpdateButton1.Visible = false;
            CustomerGrid.ClearSelection();
            loadCustomers();
        }

        private void loadCustomers()
        {
            string sqlString = "SELECT customer.customerId, customer.customerName, address.address, address.phone,  city.city,  country.country FROM customer INNER JOIN address ON customer.addressID = address.addressId INNER JOIN city ON address.cityId = city.cityId INNER JOIN country ON city.countryId = country.countryId";
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
            btnSaveCustomer.Visible = true;
            btnSaveCustomer.Enabled = true;
            int count;
            //get connection string
            string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            MySqlConnection con = null;
            con = new MySqlConnection(constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT Max(customerId) from customer", con);
            count = Convert.ToInt16(cmd.ExecuteScalar()) + 1;
            txtBoxCustId.Text = "0" + count;
            con.Close();

            new_edit_del_butt_enable();

            //clearTextBoxes(custGroupBox);
            this.btnEditCust.Enabled = false;
            this.btnDeleteCust.Enabled = false;
            this.UpdateButton1.Visible = false;
        }


        private void btnEditCust_Click(object sender, EventArgs e)
        {
            //new_edit_del_butt_enable();
            btnSaveCustomer.Visible = false;
            this.btnAddCustomer.Enabled = false;
            this.btnEditCust.Enabled = false;
            this.btnDeleteCust.Enabled = false;
            this.btnSaveCustomer.Enabled = false;
            this.btnCancel.Enabled = false;
            this.UpdateButton1.Visible = true;
            if (CustomerGrid.CurrentRow == null || !CustomerGrid.CurrentRow.Selected)
            {
                MessageBox.Show("Nothing is selected.  Please make a selection");
                new_edit_del_butt_enable();

                return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            save_cancel_btn_enable();
            clearTextBoxes(custGroupBox);
            CustomerGrid.ClearSelection();
            this.btnSaveCustomer.Enabled = true;
            this.btnEditCust.Enabled = true;
            this.btnDeleteCust.Enabled = true;
            this.btnAddCustomer.Enabled = true;

        }

        //Requirment B:  Deletes chosen customer from database
        private void btnDeleteCust_Click(object sender, EventArgs e)
        {
            btnAddCustomer.Enabled = false;
            btnEditCust.Enabled = false;
            btnCancel.Enabled = true;
            UpdateButton1.Visible = false;
            btnDeleteCust.Enabled = true;
            //btnSaveCustomer.Enabled = true;
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
                        clearTextBoxes(custGroupBox);
                        btnAddCustomer.Enabled = true;
                        btnEditCust.Enabled = true;
                        btnDeleteCust.Enabled = true;

                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private int InsertCountry(string constr, string countryName)
        {
            var countryId = 0;
            var con = new MySqlConnection(constr);
            MySqlCommand cmd = new MySqlCommand("INSERT INTO country (country, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES (@COUNTRY, NOW(), 'xx', NOW(), 'xx')", con);
            cmd.Parameters.AddWithValue("@COUNTRY", countryName);
            con.Open();
            cmd.ExecuteNonQuery();
            countryId = (int)cmd.LastInsertedId;
            con.Close();
            return countryId;
        }

        private bool TryGetCountryId(string constr, string countryName, out int countryId)
        {
            countryId = 0;
            var con = new MySqlConnection(constr);
            MySqlCommand cmd = new MySqlCommand("SELECT countryId FROM country WHERE country = @COUNTRY", con);
            cmd.Parameters.AddWithValue("@COUNTRY", countryName);
            con.Open();
            var reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    countryId = (int)reader[0];
                }
            }
            con.Close();
            if (countryId == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private int InsertCity(string constr, string cityName, int countryId)
        {
            var cityId = 0;
            var con = new MySqlConnection(constr);
            MySqlCommand cmd = new MySqlCommand("INSERT INTO city (city, countryId, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES(@CITY, @COUNTRYID, NOW(), 'XX', NOW(), 'XX')", con);
            cmd.Parameters.AddWithValue("@CITY", cityName);
            cmd.Parameters.AddWithValue("@COUNTRYID", countryId);
            con.Open();
            cmd.ExecuteNonQuery();
            cityId = (int)cmd.LastInsertedId;
            con.Close();
            return cityId;
        }

        private bool TryGetCityId(string constr, string cityName, int countryId, out int cityId)
        {
            cityId = 0;
            var con = new MySqlConnection(constr);
            MySqlCommand cmd = new MySqlCommand("SELECT cityId FROM city WHERE city = @CITY AND countryId = @COUNTRYID", con);
            cmd.Parameters.AddWithValue("@CITY", cityName);
            cmd.Parameters.AddWithValue("@COUNTRYID", countryId);
            con.Open();
            var reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    cityId = (int)reader[0];
                }
            }
            con.Close();
            if (cityId == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private int InsertAddress(string constr, string address, string address2, int cityId, string phone)
        {
            var addressId = 0;
            var con = new MySqlConnection(constr);
            con = new MySqlConnection(constr);
            MySqlCommand cmd = new MySqlCommand("INSERT INTO address (address, address2, cityId, postalCode, phone, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES(@address, @address2, @cityId, 'xx', @phone, NOW(), 'xx', NOW(), 'xx')", con);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@address2", address2);
            cmd.Parameters.AddWithValue("@cityId", cityId);
            cmd.Parameters.AddWithValue("@phone", phone);
            con.Open();
            cmd.ExecuteNonQuery();
            addressId = (int)cmd.LastInsertedId;
            con.Close();
            return addressId;
        }

        private bool TryGetAddressId(string constr, string address, string address2, int cityId, string phone, out int addressId)
        {
            addressId = 0;
            var con = new MySqlConnection(constr);
            MySqlCommand cmd = new MySqlCommand("SELECT addressId FROM address WHERE address = @address AND address2 = @address2 AND cityId = @cityId AND phone = @phone", con);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@address2", address2);
            cmd.Parameters.AddWithValue("@cityId", cityId);
            cmd.Parameters.AddWithValue("@phone", phone);
            con.Open();
            var reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    addressId = (int)reader[0];
                }
            }
            con.Close();
            if (addressId == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //Requirement B:  Add a new customer record to database
        private void btnSaveCustomer_Click_1(object sender, EventArgs e)
        {

            string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            MySqlConnection con = null;
            //Requirement F:  checks for invalid or nonexistent customer data
            if (txtBoxCustName.Text == "" || txtBoxCustAdd.Text == "" || txtBoxCustCity.Text == "" || txtBoxCustPhone.Text == "" || txtBoxCustCountry.Text == "")
            {
                MessageBox.Show("Please complete all fields");
                save_cancel_btn_enable();
                return;
            }
            try
            {
                DialogResult results = MessageBox.Show("Are you sure you want to add this customer? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                var countryId = 0;
                var cityId = 0;
                var addressId = 0;
                var customerId = 0;
                if (results == DialogResult.Yes)
                {
                    if (!TryGetCountryId(constr, txtBoxCustCountry.Text, out countryId))
                    {
                        countryId = InsertCountry(constr, txtBoxCustCountry.Text);
                    }
                    if (!TryGetCityId(constr, txtBoxCustCity.Text, countryId, out cityId))
                    {
                        cityId = InsertCity(constr, txtBoxCustCity.Text, countryId);
                    }
                    if (!TryGetAddressId(constr, txtBoxCustAdd.Text, string.Empty, cityId, txtBoxCustPhone.Text, out addressId))
                    {
                        addressId = InsertAddress(constr, txtBoxCustAdd.Text, string.Empty, cityId, txtBoxCustPhone.Text);
                    }
                    con = new MySqlConnection(constr);
                    MySqlCommand com = new MySqlCommand("INSERT INTO customer (customerName, addressId, active, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES(@customerName, @addressId, 1, NOW(), 'xx', NOW(), 'xx')", con);
                    com.Parameters.AddWithValue("@customerName", txtBoxCustName.Text);
                    com.Parameters.AddWithValue("@addressId", addressId);
                    con.Open();
                    com.ExecuteNonQuery();
                    customerId = (int)com.LastInsertedId;
                    con.Close();
                    loadCustomers();
                    MessageBox.Show("Added Successfully");
                    clearTextBoxes(custGroupBox);
                }
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
                string custAddress = CustomerGrid.SelectedRows[0].Cells[2].Value + string.Empty;
                //string custPostalCode = CustomerGrid.SelectedRows[0].Cells[3].Value + string.Empty;
                string custPhone = CustomerGrid.SelectedRows[0].Cells[3].Value + string.Empty;
                string custCity = CustomerGrid.SelectedRows[0].Cells[4].Value + string.Empty;
                string custCountry = CustomerGrid.SelectedRows[0].Cells[5].Value + string.Empty;

                txtBoxCustId.Text = custId;
                txtBoxCustName.Text = custName;
                txtBoxCustAdd.Text = custAddress;
                txtBoxCustPhone.Text = custPhone;
                txtBoxCustCity.Text = custCity;
                txtBoxCustCountry.Text = custCountry;
            }
        }


        //allows customer search by customerName or customerId
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sqlString = "SELECT * FROM customer WHERE CONCAT (`customerId`,`customerName`) like '%" + txtBxSearch.Text + "%'";
            MySqlDataAdapter cd = new MySqlDataAdapter(sqlString, DBConnection.conn);
            DataTable dt = new DataTable();
            cd.Fill(dt);
            CustomerGrid.DataSource = dt;
            CustomerGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        //Requirement B:  updates customer records in database
        private void UpdateButton1_Click(object sender, EventArgs e)
        {            
            string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
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
                        var countryId = 0;
                        var cityId = 0;
                        var addressId = 0;

                        if (!TryGetCountryId(constr, txtBoxCustCountry.Text, out countryId))
                        {
                            countryId = InsertCountry(constr, txtBoxCustCountry.Text);
                        }
                        if (!TryGetCityId(constr, txtBoxCustCity.Text, countryId, out cityId))
                        {
                            cityId = InsertCity(constr, txtBoxCustCity.Text, countryId);
                        }
                        if (!TryGetAddressId(constr, txtBoxCustAdd.Text, string.Empty, cityId, txtBoxCustPhone.Text, out addressId))
                        {
                            addressId = InsertAddress(constr, txtBoxCustAdd.Text, string.Empty, cityId, txtBoxCustPhone.Text);
                        }
                        con = new MySqlConnection(constr);
                        MySqlCommand com = new MySqlCommand("UPDATE customer SET customerName = @customerName, addressId = @addressId WHERE customerId = @customerId", con);
                        com.Parameters.AddWithValue("@customerName", txtBoxCustName.Text);
                        com.Parameters.AddWithValue("@addressId", addressId);
                        com.Parameters.AddWithValue("@customerId", int.Parse(txtBoxCustId.Text));
                        con.Open();
                        com.ExecuteNonQuery();
                        con.Close();
                        loadCustomers();
                        MessageBox.Show("Updated Successfully");
                        clearTextBoxes(custGroupBox);
                        btnAddCustomer.Enabled = true;
                        btnEditCust.Enabled = true;
                        btnDeleteCust.Enabled = true;
                        btnCancel.Enabled = false;

                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            MainPage main = new MainPage();
            main.Show();
            this.Close();
        }       
    }
}
































