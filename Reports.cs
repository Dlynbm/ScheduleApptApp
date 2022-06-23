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
            lblTitle.Text = "DATE RANGE SEARCH";
            string mySqlString = "SELECT appointmentId, customerId, userId, type,  start, end  FROM appointment WHERE start BETWEEN @d1 AND @d2";
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
            numLbl.Text = $"There are a total of {reportsGrid.RowCount -1} appointments for the chosen date range:";
        }       

        private void btnConsult_Click_1(object sender, EventArgs e)
        {
            lblTitle.Text = "Consultant Schedule";
            string mySqlString = "SELECT appointmentId, customerId, type, start, end from appointment where userId = @d1";
            string connString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            MySqlConnection connection = new MySqlConnection(connString);
            DataTable myDataTable = new DataTable();
            MySqlCommand mySqlCommand = new MySqlCommand(mySqlString);
            mySqlCommand.Connection = connection;

            mySqlCommand.Parameters.AddWithValue("@d1", listBoxConsult.SelectedIndex + 1);

            //fill data to datatable
            MySqlDataAdapter da = new MySqlDataAdapter(mySqlCommand);
            da.Fill(myDataTable);
            //adding datasource
            reportsGrid.DataSource = myDataTable;
            numLbl.Text = $"There are a total of {reportsGrid.RowCount - 1} appointments for this consultant";
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            MainPage main = new MainPage();
            main.Show();
            this.Close();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            string connString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            MySqlConnection connection = new MySqlConnection(connString);
            string sqlString = "SELECT userName FROM user";
            MySqlCommand mySqlCommand = new MySqlCommand(sqlString);
            mySqlCommand.Connection = connection;

            MySqlDataAdapter cd = new MySqlDataAdapter(sqlString, DBConnection.conn);
            DataTable table = new DataTable();
            cd.Fill(table);
            listBoxConsult.DataSource = table;
            listBoxConsult.DisplayMember = "userName";
           
        }


       


        

        private void btnAptType_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "APPOINTMENT TYPE BY MONTH SEARCH";
            string mySqlString = "SELECT type, COUNT(*) FROM appointment WHERE MONTHNAME(start) = @d1 GROUP BY type";
            //select type, count(*) from appointment group by type;

            string connString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            MySqlConnection connection = new MySqlConnection(connString);
            DataTable myDataTable = new DataTable();
            MySqlCommand mySqlCommand = new MySqlCommand(mySqlString);
            mySqlCommand.Connection = connection;

            mySqlCommand.Parameters.AddWithValue("@d1", listBoxMonth.SelectedItem);
            //mySqlCommand.Parameters.AddWithValue("@d2", listBoxType.SelectedItem);

            //fill data to datatable
            MySqlDataAdapter da = new MySqlDataAdapter(mySqlCommand);
            da.Fill(myDataTable);
            //adding datasource
            reportsGrid.DataSource = myDataTable;
            numLbl.Text = $"There are a total of {reportsGrid.RowCount - 1} appointments for the chosen month:";
        }

        
    }
}


