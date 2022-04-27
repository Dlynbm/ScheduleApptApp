
namespace ScheduleApptApp
{
    partial class MainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label startLabel;
            System.Windows.Forms.Label label2;
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.AppointmentGrid = new System.Windows.Forms.DataGridView();
            this.ViewCustomersBtn = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnAddAppt = new System.Windows.Forms.Button();
            this.btnDateSearch = new System.Windows.Forms.Button();
            this.p_EndDate = new System.Windows.Forms.DateTimePicker();
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.client_scheduleDataSet = new ScheduleApptApp.client_scheduleDataSet();
            this.p_StartDate = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.appointmentTableAdapter = new ScheduleApptApp.client_scheduleDataSetTableAdapters.appointmentTableAdapter();
            this.tableAdapterManager = new ScheduleApptApp.client_scheduleDataSetTableAdapters.TableAdapterManager();
            this.btnWeekSrch = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            startLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_scheduleDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // startLabel
            // 
            startLabel.AutoSize = true;
            startLabel.Location = new System.Drawing.Point(285, 102);
            startLabel.Name = "startLabel";
            startLabel.Size = new System.Drawing.Size(59, 13);
            startLabel.TabIndex = 4;
            startLabel.Text = "From Date:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(469, 103);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(23, 13);
            label2.TabIndex = 6;
            label2.Text = "To:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Controls.Add(this.AppointmentGrid);
            this.panel2.Controls.Add(this.ViewCustomersBtn);
            this.panel2.Controls.Add(this.btnReports);
            this.panel2.Controls.Add(this.btnAddAppt);
            this.panel2.Location = new System.Drawing.Point(10, 171);
            this.panel2.Margin = new System.Windows.Forms.Padding(1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(737, 357);
            this.panel2.TabIndex = 18;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(36, 255);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 13);
            this.lblTotal.TabIndex = 9;
            // 
            // AppointmentGrid
            // 
            this.AppointmentGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AppointmentGrid.BackgroundColor = System.Drawing.Color.White;
            this.AppointmentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppointmentGrid.Location = new System.Drawing.Point(42, 163);
            this.AppointmentGrid.MultiSelect = false;
            this.AppointmentGrid.Name = "AppointmentGrid";
            this.AppointmentGrid.Size = new System.Drawing.Size(650, 123);
            this.AppointmentGrid.TabIndex = 0;
            // 
            // ViewCustomersBtn
            // 
            this.ViewCustomersBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ViewCustomersBtn.BackColor = System.Drawing.Color.CadetBlue;
            this.ViewCustomersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewCustomersBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewCustomersBtn.ForeColor = System.Drawing.Color.White;
            this.ViewCustomersBtn.Location = new System.Drawing.Point(370, 296);
            this.ViewCustomersBtn.Margin = new System.Windows.Forms.Padding(1);
            this.ViewCustomersBtn.Name = "ViewCustomersBtn";
            this.ViewCustomersBtn.Size = new System.Drawing.Size(150, 45);
            this.ViewCustomersBtn.TabIndex = 2;
            this.ViewCustomersBtn.Text = "View Customers";
            this.ViewCustomersBtn.UseVisualStyleBackColor = false;
            this.ViewCustomersBtn.Click += new System.EventHandler(this.ViewCustomersBtn_Click);
            // 
            // btnReports
            // 
            this.btnReports.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReports.BackColor = System.Drawing.Color.CadetBlue;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Location = new System.Drawing.Point(537, 296);
            this.btnReports.Margin = new System.Windows.Forms.Padding(1);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(150, 45);
            this.btnReports.TabIndex = 1;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = false;
            // 
            // btnAddAppt
            // 
            this.btnAddAppt.BackColor = System.Drawing.Color.Coral;
            this.btnAddAppt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAppt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAppt.ForeColor = System.Drawing.Color.White;
            this.btnAddAppt.Location = new System.Drawing.Point(39, 16);
            this.btnAddAppt.Margin = new System.Windows.Forms.Padding(1);
            this.btnAddAppt.Name = "btnAddAppt";
            this.btnAddAppt.Size = new System.Drawing.Size(240, 45);
            this.btnAddAppt.TabIndex = 0;
            this.btnAddAppt.Text = "Add/Edit/Delete Appointment";
            this.btnAddAppt.UseVisualStyleBackColor = false;
            this.btnAddAppt.Click += new System.EventHandler(this.btnAddAppt_Click);
            // 
            // btnDateSearch
            // 
            this.btnDateSearch.BackColor = System.Drawing.Color.Coral;
            this.btnDateSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDateSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDateSearch.ForeColor = System.Drawing.Color.White;
            this.btnDateSearch.Location = new System.Drawing.Point(624, 91);
            this.btnDateSearch.Margin = new System.Windows.Forms.Padding(1);
            this.btnDateSearch.Name = "btnDateSearch";
            this.btnDateSearch.Size = new System.Drawing.Size(112, 26);
            this.btnDateSearch.TabIndex = 8;
            this.btnDateSearch.Text = "Search By Month";
            this.btnDateSearch.UseVisualStyleBackColor = false;
            this.btnDateSearch.Click += new System.EventHandler(this.btnDateSearch_Click);
            // 
            // p_EndDate
            // 
            this.p_EndDate.CustomFormat = "YYYY-MM-DD HH:MM:SS";
            this.p_EndDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.appointmentBindingSource, "start", true));
            this.p_EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.p_EndDate.Location = new System.Drawing.Point(498, 97);
            this.p_EndDate.Name = "p_EndDate";
            this.p_EndDate.Size = new System.Drawing.Size(113, 20);
            this.p_EndDate.TabIndex = 7;
            this.p_EndDate.Value = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            // 
            // appointmentBindingSource
            // 
            this.appointmentBindingSource.DataMember = "appointment";
            this.appointmentBindingSource.DataSource = this.client_scheduleDataSet;
            // 
            // client_scheduleDataSet
            // 
            this.client_scheduleDataSet.DataSetName = "client_scheduleDataSet";
            this.client_scheduleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // p_StartDate
            // 
            this.p_StartDate.CustomFormat = "YYYY-MM-DD HH:MM:SS";
            this.p_StartDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.appointmentBindingSource, "start", true));
            this.p_StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.p_StartDate.Location = new System.Drawing.Point(350, 96);
            this.p_StartDate.Name = "p_StartDate";
            this.p_StartDate.Size = new System.Drawing.Size(113, 20);
            this.p_StartDate.TabIndex = 5;
            this.p_StartDate.Value = new System.DateTime(2018, 12, 31, 0, 0, 0, 0);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(756, 83);
            this.panel1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "View All Customers and Appointments";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // appointmentTableAdapter
            // 
            this.appointmentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.addressTableAdapter = null;
            this.tableAdapterManager.appointmentTableAdapter = this.appointmentTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cityTableAdapter = null;
            this.tableAdapterManager.countryTableAdapter = null;
            this.tableAdapterManager.customerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ScheduleApptApp.client_scheduleDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userTableAdapter = null;
            // 
            // btnWeekSrch
            // 
            this.btnWeekSrch.BackColor = System.Drawing.Color.Coral;
            this.btnWeekSrch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWeekSrch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWeekSrch.ForeColor = System.Drawing.Color.White;
            this.btnWeekSrch.Location = new System.Drawing.Point(624, 133);
            this.btnWeekSrch.Margin = new System.Windows.Forms.Padding(1);
            this.btnWeekSrch.Name = "btnWeekSrch";
            this.btnWeekSrch.Size = new System.Drawing.Size(112, 26);
            this.btnWeekSrch.TabIndex = 21;
            this.btnWeekSrch.Text = "This Week";
            this.btnWeekSrch.UseVisualStyleBackColor = false;
            this.btnWeekSrch.Click += new System.EventHandler(this.btnWeekSrch_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(380, 160);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 22;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 551);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.btnWeekSrch);
            this.Controls.Add(this.btnDateSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(label2);
            this.Controls.Add(this.p_EndDate);
            this.Controls.Add(this.panel2);
            this.Controls.Add(startLabel);
            this.Controls.Add(this.p_StartDate);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All Appointments";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_scheduleDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button ViewCustomersBtn;
        
        private System.Windows.Forms.DataGridView AppointmentGrid;
        private System.Windows.Forms.Button btnAddAppt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private client_scheduleDataSet client_scheduleDataSet;
        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private client_scheduleDataSetTableAdapters.appointmentTableAdapter appointmentTableAdapter;
        private client_scheduleDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnDateSearch;
        private System.Windows.Forms.DateTimePicker p_EndDate;
        private System.Windows.Forms.DateTimePicker p_StartDate;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnWeekSrch;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}

