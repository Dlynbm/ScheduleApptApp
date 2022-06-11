using MySql.Data.MySqlClient;
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

namespace ScheduleApptApp
{
    public partial class Reports : Form
    {
           public Reports()
        {
            InitializeComponent();
           
            reportsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            reportsGrid.RowHeadersVisible = false;
            reportsGrid.ReadOnly = true;
            reportsGrid.AllowUserToAddRows = true;
            //reportsGrid.ClearSelection();
        }
            
        

        private void btnDateSearch_Click_1(object sender, EventArgs e)
        {
            string mySqlString = "SELECT appointmentId, customerId, userId, type,  start, end, createDate, createdBy, lastUpdate, lastUpdateBy  FROM appointment WHERE start BETWEEN @d1 AND @d2";
            string connString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            MySqlConnection connection = new MySqlConnection(connString);
            DataTable myDataTable = new DataTable();
            MySqlCommand mySqlCommand = new MySqlCommand(mySqlString);
            mySqlCommand.Connection = connection;

            mySqlCommand.Parameters.AddWithValue("@d1", p_StartDate.Value);
            mySqlCommand.Parameters.AddWithValue("@d2", p_EndDate.Value);

            //fill data to datatable
            MySqlDataAdapter da = new MySqlDataAdapter(mySqlCommand);
            da.Fill(myDataTable);
            //adding datasource
            reportsGrid.DataSource = myDataTable;
            lblTotal.Text = $"There are a total of {reportsGrid.RowCount -1} appointments for the chosen date range:";
        }       

        private void btnConsult_Click_1(object sender, EventArgs e)
        {
            string mySqlString = "SELECT user.userName, appointment.start FROM user INNER JOIN appointment ON user.userId = appointment.userId ORDER BY user.userName, appointment.start";
            string connString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            MySqlConnection connection = new MySqlConnection(connString);
            DataTable myDataTable = new DataTable();
            MySqlCommand mySqlCommand = new MySqlCommand(mySqlString);
            mySqlCommand.Connection = connection;

           
            //fill data to datatable
            MySqlDataAdapter da = new MySqlDataAdapter(mySqlCommand);
            da.Fill(myDataTable);
            //adding datasource
            reportsGrid.DataSource = myDataTable;
            lblTotal.Text = $"There are a total of {reportsGrid.RowCount - 1} appointments for this consultant range:";
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            MainPage main = new MainPage();
            main.Show();
            this.Close();
        }
    }
}

