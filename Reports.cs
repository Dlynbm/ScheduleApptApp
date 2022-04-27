using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        MySqlConnection con = new MySqlConnection("server = 127.0.0.1; username = sqlUser; password = Passw0rd!; database = client_schedule");

        public Reports()
        {
            InitializeComponent();
           
            reportsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            reportsGrid.RowHeadersVisible = false;
            reportsGrid.ReadOnly = true;
            reportsGrid.AllowUserToAddRows = true;
            //reportsGrid.ClearSelection();
        }

        private void btnDateSearch_Click(object sender, EventArgs e)
        {
            try
                {
                    using (MySqlConnection con = Data.getConnection())
                    {
                        if (con.State == ConnectionState.Closed)
                            con.Open();
                        using (DataTable dt = new DataTable("Dates"))
                        {
                            using (MySqlCommand cmd = new MySqlCommand("SELECT appointmentId, customerId, userId, title, description, location, contact, type, url, start, end, createDate, createdBy, lastUpdate, lastUpdateBy  FROM appointment WHERE start BETWEEN @d1 AND @d2", con))
                            {
                                //adding values
                                cmd.Parameters.AddWithValue("@d1", p_StartDate.Value);
                                cmd.Parameters.AddWithValue("@d2", p_EndDate.Value);
                                //fill data to datatable
                                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                                da.Fill(dt);
                                //adding datasource
                                reportsGrid.DataSource = dt;
                                lblTotal.Text = $"Total records: {reportsGrid.RowCount - 1}";

                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message by me", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }

