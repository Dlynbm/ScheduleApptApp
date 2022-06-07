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

        //    private void btnConsult_Click(object sender, EventArgs e)
        //    {
        //        string user = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
        //        try
        //            {
        //                using (MySqlConnection con = DBConnection.conn)
        //                {
        //                    if (con.State == ConnectionState.Closed)
        //                        con.Open();
        //                    using (DataTable dt = new DataTable("Dates"))
        //                    {
        //                        using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM user WHERE userId IN (SELECT userId FROM appointment) ", con))
        //                        {
        //                            //adding values
        //                            //cmd.Parameters.AddWithValue("@d1", p_StartDate.Value);
        //                            //cmd.Parameters.AddWithValue("@d2", p_EndDate.Value);
        //                            //fill data to datatable
        //                            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        //                            da.Fill(dt);
        //                            //adding datasource
        //                            reportsGrid.DataSource = dt;
        //                            lblTotal.Text = $"Total records: {reportsGrid.RowCount - 1}";

        //                        }
        //                    }
        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show(ex.Message, "Message by me", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //    }
    }
}

