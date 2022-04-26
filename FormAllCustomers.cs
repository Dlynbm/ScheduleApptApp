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


        public FormAllCustomers()
        {
            InitializeComponent();

            MySqlConnection con = new MySqlConnection("server=127.0.0.1; username = sqlUser; password = Passw0rd!; database = client_schedule");
            con.Open();
            String sqlString = "SELECT * from customer"; 
                //" customer.customerId, customer.customerName, customer.active, customer.addressId, address.address, address.address2, address.postalCode, address.phone, address.cityId, city.city, city.countryId, country.country FROM customer INNER JOIN address ON customer.addressID = address.addressId INNER JOIN city ON address.cityId = city.cityId INNER JOIN country ON city.countryId = country.countryId";
            MySqlDataAdapter cd = new MySqlDataAdapter(sqlString, Data.getConnection());
            DataSet custDataSet = new DataSet();
            Data.getConnection().Open();
            cd.Fill(custDataSet);
            dataGridView1.DataSource = custDataSet.Tables[0];
            Data.getConnection().Close();

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = true;
            dataGridView1.ClearSelection();
        }



        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            new_edit_del_butt_enable();
            clearTextBoxes(custGroupBox);
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
            this.btnEditCust.Enabled = false;
            this.btnDeleteCust.Enabled = false;
            this.btnAddCustomer.Enabled = false;

            this.btnSaveCustomer.Enabled = true;
            this.btnCancel.Enabled = true;

            this.custGroupBox.Enabled = true;
            this.dataGridView1.Enabled = true;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            save_cancel_btn_enable();
            clearTextBoxes(custGroupBox);
            dataGridView1.ClearSelection();
        }

        void save_cancel_btn_enable()
        {
            this.btnSaveCustomer.Enabled = false;
            this.btnCancel.Enabled = false;

            this.btnAddCustomer.Enabled = true;
            this.btnEditCust.Enabled = true;
            this.btnDeleteCust.Enabled = true;

            this.custGroupBox.Enabled = false;
            this.dataGridView1.Enabled = true;
        }

        private void FormAllCustomers_Load(object sender, EventArgs e)
        {
            this.btnSaveCustomer.Enabled = false;
            this.btnCancel.Enabled = false;
            this.custGroupBox.Enabled = false;
            this.dataGridView1.Enabled = true;
        }

        private void btnEditCust_Click(object sender, EventArgs e)
        {
            new_edit_del_butt_enable();
            if (dataGridView1.CurrentRow == null || !dataGridView1.CurrentRow.Selected)
            {
                MessageBox.Show("Nothing selected, please make a selection");
            }
            else
            {
                return;
            }

        }

        //private void btnDeleteCust_Click(object sender, EventArgs e)
        //{
        //    new_edit_del_butt_enable();
        //    if (CustomerGrid.CurrentRow == null || !CustomerGrid.CurrentRow.Selected)
        //    {
        //        MessageBox.Show("Noting is selected.  Please make a selection");
        //        return;
        //    }

        //    //Customer c = CustomerGrid.CurrentRow.DataBoundItem as Customer;
        //    //var chosenCustomer = CustomerGrid.CurrentCell.Value;

        //    //DialogResult result = MessageBox.Show("Are you sure you want to delete " + chosenCustomer, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

        //    //if(result == DialogResult.Yes)
        //    //{

        //    //}

        //}

        private void btnSaveCustomer_Click(object sender, EventArgs e)
        {

        }

        //private void CustomerGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (CustomerGrid.SelectedRows.Count > 0)
        //    {
        //        selectedCustomer = CustomerGrid.CurrentCell.RowIndex;
        //        string custId = CustomerGrid.SelectedRows[0].Cells[0].Value + string.Empty;
        //        string custName = CustomerGrid.SelectedRows[0].Cells[1].Value + string.Empty;
        //        string custPhone = CustomerGrid.SelectedRows[0].Cells[2].Value + string.Empty;
        //        string custAddress = CustomerGrid.SelectedRows[0].Cells[3].Value + string.Empty;
        //        string custCity = CustomerGrid.SelectedRows[0].Cells[4].Value + string.Empty;
        //        string custCountry = CustomerGrid.SelectedRows[0].Cells[5].Value + string.Empty;

        //        //txtBxCustId.Text = custId;
        //        //txtBxCustName.Text = custName;
        //        //txtBoxCustPhone.Text = custPhone;
        //        //txtBxCustAdd.Text = custAddress;
        //        //txtBxCustCity.Text = custCity;
        //        //txtBxCustCountry.Text = custCountry;

        //    }
        //}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //private void CustomerGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        //{
        //    CustomerGrid.ClearSelection();
        //}

        private bool allowSave()
        {
            int number;
            //if (string.IsNullOrWhiteSpace(txtBxCustName.Text)) return false;

            //if (string.IsNullOrWhiteSpace(txtBoxCustPhone.Text)) return false;
            //if (!Int32.TryParse(txtBoxCustPhone.Text, out number)) return false;

            //if (string.IsNullOrWhiteSpace(txtBxCustAdd.Text)) return false;
            //if (string.IsNullOrWhiteSpace(txtBxCustCity.Text)) return false;
            //if (string.IsNullOrWhiteSpace(txtBxCustCountry.Text)) return false;

            return true;


        }
    }
}
