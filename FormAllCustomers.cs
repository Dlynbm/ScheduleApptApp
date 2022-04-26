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
        MySqlConnection con;
        private int selectedCustomer = -1;


        public FormAllCustomers()
        {
            InitializeComponent();

            
            MySqlConnection con = new MySqlConnection("server=127.0.0.1; username = sqlUser; password = Passw0rd!; database = client_schedule");
            con = new MySqlConnection();
            con.Open();
            String sqlString = "SELECT customer.customerId, customer.customerName, address.address, address.postalCode, address.phone,  city.city,  country.country FROM customer INNER JOIN address ON customer.addressID = address.addressId INNER JOIN city ON address.cityId = city.cityId INNER JOIN country ON city.countryId = country.countryId";
            MySqlDataAdapter cd = new MySqlDataAdapter(sqlString, Data.getConnection());
            DataSet custDataSet = new DataSet();
            Data.getConnection().Open();
            cd.Fill(custDataSet);
            CustomerGrid.DataSource = custDataSet.Tables[0];
            Data.getConnection().Close();

            CustomerGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CustomerGrid.RowHeadersVisible = false;
            CustomerGrid.ReadOnly = true;
            CustomerGrid.AllowUserToAddRows = true;
            CustomerGrid.ClearSelection();
        }

        private void FormAllCustomers_Load(object sender, EventArgs e)
        {
            this.btnSaveCustomer.Enabled = false;
            this.btnCancel.Enabled = false;
            this.custGroupBox.Enabled = false;
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
                MessageBox.Show("Nothing selected, please make a selection");
            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            save_cancel_btn_enable();
            clearTextBoxes(custGroupBox);
            CustomerGrid.ClearSelection();
        }

        private void btnSaveCustomer_Click(string name, int cityID, string pNumber, string address, string pCode )
        {

            try
            {
                bool status = true;
                DateTime insertDate = DateTime.Now;
                string formattedDate = insertDate.ToString("yyyy-MM-dd HH:mm:ss.fff");
                string add = $"INSERT INTO customer (customerId, customerName, addressID, active, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES ('{createNewID("customer")}', '{name}', '{addAddress(address, pNumber, pCode, cityID)}', '{status}', '{formattedDate}', 'test', '{formattedDate}', 'test')";
                MySqlCommand cmd = new MySqlCommand(add, con);
                con.Open();
                cmd.Parameters.AddWithValue("customerId", CustomerGrid.SelectedColumns);
                cmd.Parameters.AddWithValue("appointmentId", CustomerGrid.SelectedColumns);
                cmd.Parameters.AddWithValue("cityId", CustomerGrid.SelectedColumns);
                cmd.Parameters.AddWithValue("countryId", CustomerGrid.SelectedColumns);
                cmd.ExecuteScalar();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();

            }

        }

        private object createNewID(string v)
        {
            throw new NotImplementedException();
        }

        //private void btnDeleteCust_Click(object sender, EventArgs e)
        //{
        //    new_edit_del_butt_enable();
        //    if (CustomerGrid.CurrentRow == null || !CustomerGrid.CurrentRow.Selected)
        //    {
        //        MessageBox.Show("Noting is selected.  Please make a selection");
        //        return;
        //    }
        //    else
        //    {
        //        string delCus = $"DELETE FROM customer WHERE customerId = '{Convert.ToInt32(CustomerGrid.CurrentRow.Cells[0].Value.ToString())}'";
        //        MySqlConnection con = Data.getConnection();
        //        MySqlCommand com = new MySqlCommand(delCus, con);
        //        con.Open();
        //        com.ExecuteNonQuery();
        //        con.Close();


    }
}







