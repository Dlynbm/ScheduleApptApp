
namespace ScheduleApptApp
{
    partial class FormAllCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAllCustomers));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Label = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAddCustomer = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEditCust = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDeleteCust = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSaveCustomer = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.custGroupBox = new System.Windows.Forms.GroupBox();
            this.cityComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxCountry = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxCustPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxCustName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxCustAddress = new System.Windows.Forms.TextBox();
            this.txtBoxCustId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.custGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.flowLayoutPanel1.Controls.Add(this.Label);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(933, 62);
            this.flowLayoutPanel1.TabIndex = 19;
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Segoe UI", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label.Location = new System.Drawing.Point(1, 0);
            this.Label.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(101, 25);
            this.Label.TabIndex = 0;
            this.Label.Text = "Customers";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddCustomer,
            this.toolStripSeparator5,
            this.btnEditCust,
            this.toolStripSeparator3,
            this.btnDeleteCust,
            this.toolStripSeparator4,
            this.btnSaveCustomer,
            this.toolStripSeparator1,
            this.btnCancel,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 62);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(933, 60);
            this.toolStrip1.TabIndex = 20;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCustomer.Image")));
            this.btnAddCustomer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAddCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(84, 57);
            this.btnAddCustomer.Text = "Add New";
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 60);
            // 
            // btnEditCust
            // 
            this.btnEditCust.Image = ((System.Drawing.Image)(resources.GetObject("btnEditCust.Image")));
            this.btnEditCust.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEditCust.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditCust.Name = "btnEditCust";
            this.btnEditCust.Size = new System.Drawing.Size(55, 57);
            this.btnEditCust.Text = "Edit";
            this.btnEditCust.Click += new System.EventHandler(this.btnEditCust_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 60);
            // 
            // btnDeleteCust
            // 
            this.btnDeleteCust.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteCust.Image")));
            this.btnDeleteCust.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDeleteCust.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteCust.Name = "btnDeleteCust";
            this.btnDeleteCust.Size = new System.Drawing.Size(68, 57);
            this.btnDeleteCust.Text = "Delete";
            this.btnDeleteCust.Click += new System.EventHandler(this.btnDeleteCust_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 60);
            // 
            // btnSaveCustomer
            // 
            this.btnSaveCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveCustomer.Image")));
            this.btnSaveCustomer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSaveCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveCustomer.Name = "btnSaveCustomer";
            this.btnSaveCustomer.Size = new System.Drawing.Size(59, 57);
            this.btnSaveCustomer.Text = "Save";
            this.btnSaveCustomer.Click += new System.EventHandler(this.btnSaveCustomer_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 60);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(71, 57);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 60);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.custGroupBox);
            this.panel1.Location = new System.Drawing.Point(52, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 357);
            this.panel1.TabIndex = 0;
            // 
            // custGroupBox
            // 
            this.custGroupBox.Controls.Add(this.cityComboBox);
            this.custGroupBox.Controls.Add(this.label5);
            this.custGroupBox.Controls.Add(this.txtBoxCountry);
            this.custGroupBox.Controls.Add(this.label4);
            this.custGroupBox.Controls.Add(this.txtBoxCustPhone);
            this.custGroupBox.Controls.Add(this.label3);
            this.custGroupBox.Controls.Add(this.label6);
            this.custGroupBox.Controls.Add(this.txtBoxCustName);
            this.custGroupBox.Controls.Add(this.label2);
            this.custGroupBox.Controls.Add(this.txtBoxCustAddress);
            this.custGroupBox.Controls.Add(this.txtBoxCustId);
            this.custGroupBox.Controls.Add(this.label1);
            this.custGroupBox.Location = new System.Drawing.Point(18, 3);
            this.custGroupBox.Name = "custGroupBox";
            this.custGroupBox.Size = new System.Drawing.Size(785, 162);
            this.custGroupBox.TabIndex = 3;
            this.custGroupBox.TabStop = false;
            this.custGroupBox.Text = "Customer Info";
            // 
            // cityComboBox
            // 
            this.cityComboBox.FormattingEnabled = true;
            this.cityComboBox.Items.AddRange(new object[] {
            "New York",
            "Los Angeles",
            "Houston",
            "Salt Lake City",
            "Lancaster",
            "London",
            "Glasgow",
            "Toronto",
            "Vancouver",
            "Ottawa",
            "Oslo",
            "Bergen",
            "Trondheim"});
            this.cityComboBox.Location = new System.Drawing.Point(447, 69);
            this.cityComboBox.Name = "cityComboBox";
            this.cityComboBox.Size = new System.Drawing.Size(254, 23);
            this.cityComboBox.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(355, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 15);
            this.label5.TabIndex = 26;
            this.label5.Text = "Postal Code:";
            // 
            // txtBoxCountry
            // 
            this.txtBoxCountry.Location = new System.Drawing.Point(447, 104);
            this.txtBoxCountry.Name = "txtBoxCountry";
            this.txtBoxCountry.Size = new System.Drawing.Size(254, 23);
            this.txtBoxCountry.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(397, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "City:";
            // 
            // txtBoxCustPhone
            // 
            this.txtBoxCustPhone.Location = new System.Drawing.Point(447, 33);
            this.txtBoxCustPhone.Name = "txtBoxCustPhone";
            this.txtBoxCustPhone.Size = new System.Drawing.Size(254, 23);
            this.txtBoxCustPhone.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(397, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Phone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Name:";
            // 
            // txtBoxCustName
            // 
            this.txtBoxCustName.Location = new System.Drawing.Point(105, 69);
            this.txtBoxCustName.Name = "txtBoxCustName";
            this.txtBoxCustName.Size = new System.Drawing.Size(241, 23);
            this.txtBoxCustName.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Address:";
            // 
            // txtBoxCustAddress
            // 
            this.txtBoxCustAddress.Location = new System.Drawing.Point(105, 101);
            this.txtBoxCustAddress.Name = "txtBoxCustAddress";
            this.txtBoxCustAddress.Size = new System.Drawing.Size(241, 23);
            this.txtBoxCustAddress.TabIndex = 17;
            // 
            // txtBoxCustId
            // 
            this.txtBoxCustId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCustId.Location = new System.Drawing.Point(105, 33);
            this.txtBoxCustId.Name = "txtBoxCustId";
            this.txtBoxCustId.Size = new System.Drawing.Size(241, 23);
            this.txtBoxCustId.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Customer ID:";
            // 
            // FormAllCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormAllCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.FormAllCustomers_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.custGroupBox.ResumeLayout(false);
            this.custGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAddCustomer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnEditCust;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnDeleteCust;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnSaveCustomer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox custGroupBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxCustName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxCustAddress;
        private System.Windows.Forms.TextBox txtBoxCustId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxCountry;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxCustPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cityComboBox;
    }
}