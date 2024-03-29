﻿
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogOff = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.AppointmentGrid = new System.Windows.Forms.DataGridView();
            this.ViewCustomersBtn = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnAddAppt = new System.Windows.Forms.Button();
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.monthBtn = new System.Windows.Forms.RadioButton();
            this.weekBtn = new System.Windows.Forms.RadioButton();
            this.allBtn = new System.Windows.Forms.RadioButton();
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
            this.panel2.Controls.Add(this.label3);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "APPOINTMENTS";
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
            // monthBtn
            // 
            this.monthBtn.AutoSize = true;
            this.monthBtn.Location = new System.Drawing.Point(10, 91);
            this.monthBtn.Name = "monthBtn";
            this.monthBtn.Size = new System.Drawing.Size(152, 17);
            this.monthBtn.TabIndex = 24;
            this.monthBtn.TabStop = true;
            this.monthBtn.Text = "This Month\'s Appointments";
            this.monthBtn.UseVisualStyleBackColor = true;
            this.monthBtn.CheckedChanged += new System.EventHandler(this.monthBtn_CheckedChanged);
            // 
            // weekBtn
            // 
            this.weekBtn.AutoSize = true;
            this.weekBtn.Location = new System.Drawing.Point(10, 116);
            this.weekBtn.Name = "weekBtn";
            this.weekBtn.Size = new System.Drawing.Size(151, 17);
            this.weekBtn.TabIndex = 25;
            this.weekBtn.TabStop = true;
            this.weekBtn.Text = "This Week\'s Appointments";
            this.weekBtn.UseVisualStyleBackColor = true;
            this.weekBtn.CheckedChanged += new System.EventHandler(this.weekBtn_CheckedChanged);
            // 
            // allBtn
            // 
            this.allBtn.AutoSize = true;
            this.allBtn.Location = new System.Drawing.Point(10, 141);
            this.allBtn.Name = "allBtn";
            this.allBtn.Size = new System.Drawing.Size(103, 17);
            this.allBtn.TabIndex = 26;
            this.allBtn.TabStop = true;
            this.allBtn.Text = "All Appointments";
            this.allBtn.UseVisualStyleBackColor = true;
            this.allBtn.CheckedChanged += new System.EventHandler(this.allBtn_CheckedChanged);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 551);
            this.Controls.Add(this.allBtn);
            this.Controls.Add(this.weekBtn);
            this.Controls.Add(this.monthBtn);
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
        private System.Windows.Forms.BindingSource appointmentBindingSource;
     
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnLogOff;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton monthBtn;
        private System.Windows.Forms.RadioButton weekBtn;
        private System.Windows.Forms.RadioButton allBtn;
        private System.Windows.Forms.Label label3;
    }
}

