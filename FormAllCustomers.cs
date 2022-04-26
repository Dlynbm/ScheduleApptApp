using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        MySqlConnection con = new MySqlConnection("server=127.0.0.1; username = sqlUser; password = Passw0rd!; database = client_schedule");
        MySqlDataAdapter adapt;
        DataTable dt;

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
            con.Open();
            string sqlString = "SELECT customer.customerId, customer.customerName, address.address, address.postalCode, address.phone,  city.city,  country.country FROM customer INNER JOIN address ON customer.addressID = address.addressId INNER JOIN city ON address.cityId = city.cityId INNER JOIN country ON city.countryId = country.countryId";
            MySqlDataAdapter cd = new MySqlDataAdapter(sqlString, con);
            DataTable dt = new DataTable();
            cd.Fill(dt);
            CustomerGrid.DataSource = dt;
            CustomerGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            this.btnSaveCustomer.Enabled = false;
            this.btnCancel.Enabled = false;
            this.custGroupBox.Enabled = false;
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
            DialogResult result = MessageBox.Show("Are you sure you want to update this customer? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                //string updateCus = $"UPDATE customer AS c INNER JOIN address  AS a ON c.addressId = c.addressId SET c.customerName = '{name}', c.lastUpdate = '{sqlFormattedDate}', a.address = '{address}', a.phone = '{pNumber}', a.postalCode = '{pCode}', a.cityId = '{cityID}' WHERE c.customerId = '{cusid}' AND a.addressId = '{addressID}'"; MySqlConnection con = Data.getConnection();
                //MySqlCommand com = new MySqlCommand(updateCus, con);
                //con.Open();
                //com.Parameters.AddWithValue("customerName", txtBoxCustName.Text);
                //com.Parameters.AddWithValue("customerPhone", txtBoxCustPhone.Text);
                //com.Parameters.AddWithValue("customerAddress", txtBoxCustAdd.Text);
                //com.Parameters.AddWithValue("customerCity", txtBoxCustCity.Text);
                //com.Parameters.AddWithValue("customerCountry", txtBoxCustCountry.Text);

                //con.Close();
            }
        }


    

        private void btnCancel_Click(object sender, EventArgs e)
        {
            save_cancel_btn_enable();
            clearTextBoxes(custGroupBox);
            CustomerGrid.ClearSelection();
        }

        //private void btnSaveCustomer_Click(string name, int cityID, string pNumber, string address, string pCode )
        //{

        //    try
        //    {
        //        bool status = true;
        //        DateTime insertDate = DateTime.Now;
        //        string formattedDate = insertDate.ToString("yyyy-MM-dd HH:mm:ss.fff");
        //        string add = $"INSERT INTO customer (customerId, customerName, addressID, active, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES ('{createNewID("customer")}', '{name}', '{addAddress(address, pNumber, pCode, cityID)}', '{status}', '{formattedDate}', 'test', '{formattedDate}', 'test')";
        //        MySqlCommand cmd = new MySqlCommand(add, con);
        //        con.Open();
        //        cmd.Parameters.AddWithValue("customerId", CustomerGrid.SelectedColumns);
        //        cmd.Parameters.AddWithValue("appointmentId", CustomerGrid.SelectedColumns);
        //        cmd.Parameters.AddWithValue("cityId", CustomerGrid.SelectedColumns);
        //        cmd.Parameters.AddWithValue("countryId", CustomerGrid.SelectedColumns);
        //        cmd.ExecuteScalar();
        //    }
        //    catch(Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }
        //    finally
        //    {
        //        con.Close();

        //    }

        //}

        //private object createNewCustID(string table)
        //{
        //    MySqlConnection con = Data.getConnection();
        //    con.Open();
        //    MySqlCommand com = new MySqlCommand($"SELECT {table + "Id"} FROM {table}", con);
        //    MySqlDataReader read = com.ExecuteReader();
        //    List<int> 1 = new List<int>();

        //    while read.Read())
        //    {
        //        1.Add(Convert.ToInt32(read[0]));
        //    }
        //    read.Close();
        //    con.Close();
        //    return newID(1);
        //}

        //static public int newID(List<int> 1)
        //{
        //    int ID = 0;
        //    foreach(int id in 1)
        //    {
        //        if(id > ID)
        //        {
        //            ID = id;
        //        }
        //    }
        //    return ID + 1;
        //}

        

        private void btnDeleteCust_Click_1(object sender, EventArgs e)
        {
            if (CustomerGrid.CurrentRow == null || !CustomerGrid.CurrentRow.Selected)
            {
                MessageBox.Show("Nothing is selected.  Please make a selection");
                new_edit_del_butt_enable();

                return;
            }
            Customer c = CustomerGrid.CurrentRow.DataBoundItem as Customer;
            var chosenCustomer = CustomerGrid.CurrentCell.Value;
            DialogResult result = MessageBox.Show("Are you sure you want to delete this customer? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
             if(result == DialogResult.Yes)
            { 
                string delCus = $"DELETE FROM customer WHERE customerId = '{Convert.ToInt32(CustomerGrid.CurrentRow.Cells[0].Value.ToString())}'";
                MySqlConnection con = Data.getConnection();
                MySqlCommand com = new MySqlCommand(delCus, con);
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
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

        private void txtBxSearch_TextChanged(object sender, EventArgs e)
        {
            con = new MySqlConnection();
            con.Open();
            string sqlString = "SELECT * FROM customer where customerName like '" + txtBxSearch.Text + "%'";
            MySqlDataAdapter cd = new MySqlDataAdapter(sqlString, con);
            DataTable dt = new DataTable();
            cd.Fill(dt);
            CustomerGrid.DataSource = dt;
            con.Close();
        }
    }
}



//MySqlConnection con = new MySqlConnection("server=127.0.0.1; username = sqlUser; password = Passw0rd!; database = client_schedule");
////con = new MySqlConnection();
//con.Open();
//string sqlString = "SELECT customer.customerId, customer.customerName, address.address, address.postalCode, address.phone,  city.city,  country.country FROM customer INNER JOIN address ON customer.addressID = address.addressId INNER JOIN city ON address.cityId = city.cityId INNER JOIN country ON city.countryId = country.countryId";
//MySqlDataAdapter cd = new MySqlDataAdapter(sqlString, con);
//DataTable dt = new DataTable();
//cd.Fill(dt);
//CustomerGrid.DataSource = dt;
//CustomerGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;



