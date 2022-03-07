
namespace ScheduleApptApp
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DeleteApptBtn = new System.Windows.Forms.Button();
            this.ModifyApptBtn = new System.Windows.Forms.Button();
            this.dataGridAppts = new System.Windows.Forms.DataGridView();
            this.AddApptBtn = new System.Windows.Forms.Button();
            this.dataGridCustomers = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddCustomerBtn = new System.Windows.Forms.Button();
            this.ModifyCustomerBtn = new System.Windows.Forms.Button();
            this.DeleteCustomerBtn = new System.Windows.Forms.Button();
            this.CustomerLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LogOffBtn = new System.Windows.Forms.Button();
            this.ApptCustRprt = new System.Windows.Forms.Button();
            this.ConsultSchRpt = new System.Windows.Forms.Button();
            this.ApptTypeRprt = new System.Windows.Forms.Button();
            this.ViewAppt = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAppts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomers)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DeleteApptBtn
            // 
            this.DeleteApptBtn.Location = new System.Drawing.Point(1458, 523);
            this.DeleteApptBtn.Name = "DeleteApptBtn";
            this.DeleteApptBtn.Size = new System.Drawing.Size(261, 119);
            this.DeleteApptBtn.TabIndex = 0;
            this.DeleteApptBtn.Text = "Delete";
            this.DeleteApptBtn.UseVisualStyleBackColor = true;
            // 
            // ModifyApptBtn
            // 
            this.ModifyApptBtn.Location = new System.Drawing.Point(1100, 523);
            this.ModifyApptBtn.Name = "ModifyApptBtn";
            this.ModifyApptBtn.Size = new System.Drawing.Size(261, 119);
            this.ModifyApptBtn.TabIndex = 1;
            this.ModifyApptBtn.Text = "Modify";
            this.ModifyApptBtn.UseVisualStyleBackColor = true;
            // 
            // dataGridAppts
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridAppts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridAppts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridAppts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridAppts.Location = new System.Drawing.Point(203, 82);
            this.dataGridAppts.Name = "dataGridAppts";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridAppts.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridAppts.RowHeadersWidth = 102;
            this.dataGridAppts.RowTemplate.Height = 40;
            this.dataGridAppts.Size = new System.Drawing.Size(2029, 418);
            this.dataGridAppts.TabIndex = 2;
            // 
            // AddApptBtn
            // 
            this.AddApptBtn.Location = new System.Drawing.Point(761, 523);
            this.AddApptBtn.Name = "AddApptBtn";
            this.AddApptBtn.Size = new System.Drawing.Size(261, 119);
            this.AddApptBtn.TabIndex = 3;
            this.AddApptBtn.Text = "Add";
            this.AddApptBtn.UseVisualStyleBackColor = true;
            // 
            // dataGridCustomers
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridCustomers.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridCustomers.Location = new System.Drawing.Point(53, 814);
            this.dataGridCustomers.Name = "dataGridCustomers";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCustomers.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridCustomers.RowHeadersWidth = 102;
            this.dataGridCustomers.RowTemplate.Height = 40;
            this.dataGridCustomers.Size = new System.Drawing.Size(1108, 348);
            this.dataGridCustomers.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Customer ID";
            this.Column1.MinimumWidth = 12;
            this.Column1.Name = "Column1";
            this.Column1.Width = 250;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Customer Name";
            this.Column2.MinimumWidth = 12;
            this.Column2.Name = "Column2";
            this.Column2.Width = 250;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Address ID";
            this.Column3.MinimumWidth = 12;
            this.Column3.Name = "Column3";
            this.Column3.Width = 250;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Active";
            this.Column4.MinimumWidth = 12;
            this.Column4.Name = "Column4";
            this.Column4.Width = 250;
            // 
            // AddCustomerBtn
            // 
            this.AddCustomerBtn.Location = new System.Drawing.Point(77, 1191);
            this.AddCustomerBtn.Name = "AddCustomerBtn";
            this.AddCustomerBtn.Size = new System.Drawing.Size(261, 80);
            this.AddCustomerBtn.TabIndex = 5;
            this.AddCustomerBtn.Text = "Add";
            this.AddCustomerBtn.UseVisualStyleBackColor = true;
            // 
            // ModifyCustomerBtn
            // 
            this.ModifyCustomerBtn.Location = new System.Drawing.Point(468, 1184);
            this.ModifyCustomerBtn.Name = "ModifyCustomerBtn";
            this.ModifyCustomerBtn.Size = new System.Drawing.Size(261, 87);
            this.ModifyCustomerBtn.TabIndex = 6;
            this.ModifyCustomerBtn.Text = "Modify";
            this.ModifyCustomerBtn.UseVisualStyleBackColor = true;
            // 
            // DeleteCustomerBtn
            // 
            this.DeleteCustomerBtn.Location = new System.Drawing.Point(861, 1181);
            this.DeleteCustomerBtn.Name = "DeleteCustomerBtn";
            this.DeleteCustomerBtn.Size = new System.Drawing.Size(261, 90);
            this.DeleteCustomerBtn.TabIndex = 7;
            this.DeleteCustomerBtn.Text = "Delete";
            this.DeleteCustomerBtn.UseVisualStyleBackColor = true;
            // 
            // CustomerLabel
            // 
            this.CustomerLabel.AutoSize = true;
            this.CustomerLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.1F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerLabel.Location = new System.Drawing.Point(497, 741);
            this.CustomerLabel.Name = "CustomerLabel";
            this.CustomerLabel.Size = new System.Drawing.Size(279, 55);
            this.CustomerLabel.TabIndex = 13;
            this.CustomerLabel.Text = "Customers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.1F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2071, 587);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 55);
            this.label1.TabIndex = 14;
            this.label1.Text = "Controls";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.1F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1050, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(468, 55);
            this.label2.TabIndex = 15;
            this.label2.Text = "Schedule Software";
            // 
            // LogOffBtn
            // 
            this.LogOffBtn.Location = new System.Drawing.Point(82, 516);
            this.LogOffBtn.Name = "LogOffBtn";
            this.LogOffBtn.Size = new System.Drawing.Size(348, 91);
            this.LogOffBtn.TabIndex = 12;
            this.LogOffBtn.Text = "Log Off";
            this.LogOffBtn.UseVisualStyleBackColor = true;
            // 
            // ApptCustRprt
            // 
            this.ApptCustRprt.Location = new System.Drawing.Point(82, 396);
            this.ApptCustRprt.Name = "ApptCustRprt";
            this.ApptCustRprt.Size = new System.Drawing.Size(348, 91);
            this.ApptCustRprt.TabIndex = 11;
            this.ApptCustRprt.Text = "Appointment Customers Report";
            this.ApptCustRprt.UseVisualStyleBackColor = true;
            // 
            // ConsultSchRpt
            // 
            this.ConsultSchRpt.Location = new System.Drawing.Point(82, 275);
            this.ConsultSchRpt.Name = "ConsultSchRpt";
            this.ConsultSchRpt.Size = new System.Drawing.Size(348, 91);
            this.ConsultSchRpt.TabIndex = 10;
            this.ConsultSchRpt.Text = "Consultant Schedule Report";
            this.ConsultSchRpt.UseVisualStyleBackColor = true;
            // 
            // ApptTypeRprt
            // 
            this.ApptTypeRprt.Location = new System.Drawing.Point(82, 150);
            this.ApptTypeRprt.Name = "ApptTypeRprt";
            this.ApptTypeRprt.Size = new System.Drawing.Size(348, 91);
            this.ApptTypeRprt.TabIndex = 9;
            this.ApptTypeRprt.Text = "Appointment Type Report";
            this.ApptTypeRprt.UseVisualStyleBackColor = true;
            // 
            // ViewAppt
            // 
            this.ViewAppt.Location = new System.Drawing.Point(82, 27);
            this.ViewAppt.Name = "ViewAppt";
            this.ViewAppt.Size = new System.Drawing.Size(348, 91);
            this.ViewAppt.TabIndex = 8;
            this.ViewAppt.Text = "View Appointments";
            this.ViewAppt.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.ViewAppt);
            this.panel1.Controls.Add(this.ApptTypeRprt);
            this.panel1.Controls.Add(this.ConsultSchRpt);
            this.panel1.Controls.Add(this.ApptCustRprt);
            this.panel1.Controls.Add(this.LogOffBtn);
            this.panel1.Location = new System.Drawing.Point(1932, 666);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(519, 623);
            this.panel1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2474, 1314);
            this.Controls.Add(this.dataGridAppts);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CustomerLabel);
            this.Controls.Add(this.DeleteCustomerBtn);
            this.Controls.Add(this.ModifyCustomerBtn);
            this.Controls.Add(this.AddCustomerBtn);
            this.Controls.Add(this.dataGridCustomers);
            this.Controls.Add(this.AddApptBtn);
            this.Controls.Add(this.ModifyApptBtn);
            this.Controls.Add(this.DeleteApptBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAppts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeleteApptBtn;
        private System.Windows.Forms.Button ModifyApptBtn;
        private System.Windows.Forms.DataGridView dataGridAppts;
        private System.Windows.Forms.Button AddApptBtn;
        private System.Windows.Forms.DataGridView dataGridCustomers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button AddCustomerBtn;
        private System.Windows.Forms.Button ModifyCustomerBtn;
        private System.Windows.Forms.Button DeleteCustomerBtn;
        private System.Windows.Forms.Label CustomerLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LogOffBtn;
        private System.Windows.Forms.Button ApptCustRprt;
        private System.Windows.Forms.Button ConsultSchRpt;
        private System.Windows.Forms.Button ApptTypeRprt;
        private System.Windows.Forms.Button ViewAppt;
        private System.Windows.Forms.Panel panel1;
    }
}

