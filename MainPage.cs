using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ScheduleApptApp
{
    public partial class MainPage : Form
    {

        public MainPage()
        {
            InitializeComponent();

            

            MySqlConnection con = new MySqlConnection("server=127.0.0.1; username = sqlUser; password = Passw0rd!; database = client_schedule");
            con.Open();
            String sqlString = "SELECT appointmentId, customerId, userId, type, start FROM appointment";
            MySqlCommand cmd = new MySqlCommand(sqlString, con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            AppointmentGrid.DataSource = dt;
            AppointmentGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            AppointmentGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AppointmentGrid.RowHeadersVisible = false;
            AppointmentGrid.ReadOnly = true;
            AppointmentGrid.AllowUserToAddRows=true;
            //AppointmentGrid.DataSource = Appointment.AppointmentStockPile;

        }

        //private void AppointmentGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex >= 0)
        //    {
        //        //idxSelectedAppointment = AppointmentGrid.CurrentCell.RowIndex;
        //        //Appointment.Cu
        //    }
             

       

        //private void dbQueries()
        //{
        //    //retrieveAppDB();
        //    //retrieveCustomerDB();
        //}

        //private void retrieveCustomerDB()
        //{
        //    string custQr = $"customer.customerId, customer.customerName, customer.active, customer.addressId, address.address, address.address2, " +
        //        $"address.postalCode, address.phone, address.cityId, address.countryId, country.country FROM customer INNER JOIN address ON customer.addressID = address.addressId " +
        //        $"INNER JOIN city ON address.cityId = city.cityId INNER JOIN country ON city.countryId = country.countryId";

        //    MySqlDataAdapter custDA = new MySqlDataAdapter(custQr, DbConn.getConnection());
        //    DataSet custDS = new DataSet();
        //    DbConn.getConnection().Open();
        //    custDA.Fill(custDS);

        //    //AllCustomersGrid.DataSource = custDS.Tables[0];


        //}

        //private void retrieveAppDB()
        //{
        //    string apptQr = $"appointment.appointmentId, customer.customerName, customer.CustomerId, appointment.title, appointment.description, appointment.location" +
        //        $"appointment.contact, appointment.start, appointment.end, appointment.type,appointment.url FROM appointment INNER JOIN customer ON appointment.customerId = customer.customerId" +
        //        $"INNER JOIN 'user' ON appointment.userId = 'user'.userId WHERE customer.customerId = '{AppointmentGrid.CurrentRow.Cells[0].Value}' ";
        //    MySqlDataAdapter adpt = new MySqlDataAdapter(apptQr, DbConn.getConnection());
        //    DataSet appDS = new DataSet();
        //    DbConn.getConnection().Open();
        //    adpt.Fill(appDS);

        //    AppointmentGrid.DataSource = appDS.Tables[0];
        //    DbConn.getConnection().Close();
        //}

        private void ViewCustomersBtn_Click(object sender, EventArgs e)
            {
            FormAllCustomers allCust = new FormAllCustomers();
            allCust.Show();
            }

        private void AddApptBtn_Click(object sender, EventArgs e)
        {
            FormAddAppointment addAppt = new FormAddAppointment(this);
            addAppt.Show();
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {

        }

        private void MainPage_Load(object sender, EventArgs e)
        {
          
        }
    }


        
    }









