
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.AppointmentGrid = new System.Windows.Forms.DataGridView();
            this.ViewCustomersBtn = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnAddAppt = new System.Windows.Forms.Button();
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnWeekSrch = new System.Windows.Forms.Button();
            this.btnSearchMonth = new System.Windows.Forms.Button();
            this.btnLogOff = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnLogOff);
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Controls.Add(this.AppointmentGrid);
            this.panel2.Controls.Add(this.ViewCustomersBtn);
            this.panel2.Controls.Add(this.btnReports);
            this.panel2.Controls.Add(this.btnAddAppt);
            this.panel2.Location = new System.Drawing.Point(10, 170);
            this.panel2.Margin = new System.Windows.Forms.Padding(1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(649, 357);
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
            this.AppointmentGrid.Location = new System.Drawing.Point(4, 94);
            this.AppointmentGrid.MultiSelect = false;
            this.AppointmentGrid.Name = "AppointmentGrid";
            this.AppointmentGrid.Size = new System.Drawing.Size(643, 123);
            this.AppointmentGrid.TabIndex = 0;
            this.AppointmentGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AppointmentGrid_CellContentClick);
            // 
            // ViewCustomersBtn
            // 
            this.ViewCustomersBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ViewCustomersBtn.BackColor = System.Drawing.Color.CadetBlue;
            this.ViewCustomersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewCustomersBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewCustomersBtn.ForeColor = System.Drawing.Color.White;
            this.ViewCustomersBtn.Location = new System.Drawing.Point(218, 294);
            this.ViewCustomersBtn.Margin = new System.Windows.Forms.Padding(1);
            this.ViewCustomersBtn.Name = "ViewCustomersBtn";
            this.ViewCustomersBtn.Size = new System.Drawing.Size(250, 45);
            this.ViewCustomersBtn.TabIndex = 2;
            this.ViewCustomersBtn.Text = "Add/Edit/Delete Customers";
            this.ViewCustomersBtn.UseVisualStyleBackColor = false;
            this.ViewCustomersBtn.Click += new System.EventHandler(this.ViewCustomersBtn_Click);
            // 
            // btnReports
            // 
            this.btnReports.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReports.BackColor = System.Drawing.Color.CadetBlue;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Location = new System.Drawing.Point(481, 294);
            this.btnReports.Margin = new System.Windows.Forms.Padding(1);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(131, 45);
            this.btnReports.TabIndex = 1;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnAddAppt
            // 
            this.btnAddAppt.BackColor = System.Drawing.Color.Coral;
            this.btnAddAppt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAppt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAppt.ForeColor = System.Drawing.Color.White;
            this.btnAddAppt.Location = new System.Drawing.Point(15, 12);
            this.btnAddAppt.Margin = new System.Windows.Forms.Padding(1);
            this.btnAddAppt.Name = "btnAddAppt";
            this.btnAddAppt.Size = new System.Drawing.Size(240, 45);
            this.btnAddAppt.TabIndex = 0;
            this.btnAddAppt.Text = "Add/Edit/Delete Appointment";
            this.btnAddAppt.UseVisualStyleBackColor = false;
            this.btnAddAppt.Click += new System.EventHandler(this.btnAddAppt_Click);
            // 
            // appointmentBindingSource
            // 
            this.appointmentBindingSource.DataMember = "appointment";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(670, 83);
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
            // 
            // btnWeekSrch
            // 
            this.btnWeekSrch.BackColor = System.Drawing.Color.Coral;
            this.btnWeekSrch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWeekSrch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWeekSrch.ForeColor = System.Drawing.Color.White;
            this.btnWeekSrch.Location = new System.Drawing.Point(545, 133);
            this.btnWeekSrch.Margin = new System.Windows.Forms.Padding(1);
            this.btnWeekSrch.Name = "btnWeekSrch";
            this.btnWeekSrch.Size = new System.Drawing.Size(112, 26);
            this.btnWeekSrch.TabIndex = 21;
            this.btnWeekSrch.Text = "This Week";
            this.btnWeekSrch.UseVisualStyleBackColor = false;
            this.btnWeekSrch.Click += new System.EventHandler(this.btnWeekSrch_Click);
            // 
            // btnSearchMonth
            // 
            this.btnSearchMonth.BackColor = System.Drawing.Color.Coral;
            this.btnSearchMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchMonth.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchMonth.ForeColor = System.Drawing.Color.White;
            this.btnSearchMonth.Location = new System.Drawing.Point(545, 86);
            this.btnSearchMonth.Margin = new System.Windows.Forms.Padding(1);
            this.btnSearchMonth.Name = "btnSearchMonth";
            this.btnSearchMonth.Size = new System.Drawing.Size(112, 26);
            this.btnSearchMonth.TabIndex = 22;
            this.btnSearchMonth.Text = "This Month";
            this.btnSearchMonth.UseVisualStyleBackColor = false;
            this.btnSearchMonth.Click += new System.EventHandler(this.btnSearchMonth_Click);
            // 
            // btnLogOff
            // 
            this.btnLogOff.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLogOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOff.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOff.ForeColor = System.Drawing.Color.White;
            this.btnLogOff.Location = new System.Drawing.Point(15, 309);
            this.btnLogOff.Name = "btnLogOff";
            this.btnLogOff.Size = new System.Drawing.Size(75, 30);
            this.btnLogOff.TabIndex = 10;
            this.btnLogOff.Text = "Log Off";
            this.btnLogOff.UseVisualStyleBackColor = false;
            this.btnLogOff.Click += new System.EventHandler(this.btnLogOff_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(288, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "label2";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 551);
            this.Controls.Add(this.btnSearchMonth);
            this.Controls.Add(this.btnWeekSrch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All Appointments";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button ViewCustomersBtn;
        
        private System.Windows.Forms.DataGridView AppointmentGrid;
        private System.Windows.Forms.Button btnAddAppt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource appointmentBindingSource;
     
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnWeekSrch;
        private System.Windows.Forms.Button btnSearchMonth;
        private System.Windows.Forms.Button btnLogOff;
        private System.Windows.Forms.Label label2;
    }
}

