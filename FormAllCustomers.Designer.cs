
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label createDateLabel;
            System.Windows.Forms.Label customerIdLabel1;
            System.Windows.Forms.Label customerNameLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label countryLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAllCustomers));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtBxSearch = new System.Windows.Forms.TextBox();
            this.custGroupBox = new System.Windows.Forms.GroupBox();
            this.txtBoxCustCountry = new System.Windows.Forms.TextBox();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtBoxCustCity = new System.Windows.Forms.TextBox();
            this.txtBoxCustAdd = new System.Windows.Forms.TextBox();
            this.txtBoxCustPhone = new System.Windows.Forms.TextBox();
            this.txtBoxCustName = new System.Windows.Forms.TextBox();
            this.txtBoxCustId = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            createDateLabel = new System.Windows.Forms.Label();
            customerIdLabel1 = new System.Windows.Forms.Label();
            customerNameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.custGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // createDateLabel
            // 
            createDateLabel.AutoSize = true;
            createDateLabel.Location = new System.Drawing.Point(679, 177);
            createDateLabel.Name = "createDateLabel";
            createDateLabel.Size = new System.Drawing.Size(69, 15);
            createDateLabel.TabIndex = 38;
            createDateLabel.Text = "create Date:";
            // 
            // customerIdLabel1
            // 
            customerIdLabel1.AutoSize = true;
            customerIdLabel1.Location = new System.Drawing.Point(48, 40);
            customerIdLabel1.Name = "customerIdLabel1";
            customerIdLabel1.Size = new System.Drawing.Size(73, 15);
            customerIdLabel1.TabIndex = 78;
            customerIdLabel1.Text = "customer Id:";
            // 
            // customerNameLabel
            // 
            customerNameLabel.AutoSize = true;
            customerNameLabel.Location = new System.Drawing.Point(26, 67);
            customerNameLabel.Name = "customerNameLabel";
            customerNameLabel.Size = new System.Drawing.Size(95, 15);
            customerNameLabel.TabIndex = 79;
            customerNameLabel.Text = "customer Name:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(299, 37);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(50, 15);
            addressLabel.TabIndex = 80;
            addressLabel.Text = "address:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(77, 97);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(44, 15);
            phoneLabel.TabIndex = 81;
            phoneLabel.Text = "phone:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(320, 72);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(29, 15);
            cityLabel.TabIndex = 82;
            cityLabel.Text = "city:";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new System.Drawing.Point(298, 102);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(51, 15);
            countryLabel.TabIndex = 83;
            countryLabel.Text = "country:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.flowLayoutPanel1.Controls.Add(this.Label);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1109, 62);
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
            this.Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtBxSearch);
            this.panel1.Controls.Add(this.custGroupBox);
            this.panel1.Location = new System.Drawing.Point(52, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1003, 575);
            this.panel1.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(569, 180);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtBxSearch
            // 
            this.txtBxSearch.Location = new System.Drawing.Point(665, 181);
            this.txtBxSearch.Name = "txtBxSearch";
            this.txtBxSearch.Size = new System.Drawing.Size(135, 23);
            this.txtBxSearch.TabIndex = 21;
            // 
            // custGroupBox
            // 
            this.custGroupBox.Controls.Add(this.dataGridView1);
            this.custGroupBox.Controls.Add(this.txtBoxCustCountry);
            this.custGroupBox.Controls.Add(this.txtBoxCustCity);
            this.custGroupBox.Controls.Add(this.txtBoxCustAdd);
            this.custGroupBox.Controls.Add(this.txtBoxCustPhone);
            this.custGroupBox.Controls.Add(this.txtBoxCustName);
            this.custGroupBox.Controls.Add(this.txtBoxCustId);
            this.custGroupBox.Controls.Add(countryLabel);
            this.custGroupBox.Controls.Add(cityLabel);
            this.custGroupBox.Controls.Add(phoneLabel);
            this.custGroupBox.Controls.Add(addressLabel);
            this.custGroupBox.Controls.Add(customerNameLabel);
            this.custGroupBox.Controls.Add(customerIdLabel1);
            this.custGroupBox.Controls.Add(createDateLabel);
            this.custGroupBox.Location = new System.Drawing.Point(3, 3);
            this.custGroupBox.Name = "custGroupBox";
            this.custGroupBox.Size = new System.Drawing.Size(1000, 572);
            this.custGroupBox.TabIndex = 0;
            this.custGroupBox.TabStop = false;
            this.custGroupBox.Text = "Customer Info";
            // 
            // txtBoxCustCountry
            // 
            this.txtBoxCustCountry.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "country", true));
            this.txtBoxCustCountry.Location = new System.Drawing.Point(355, 102);
            this.txtBoxCustCountry.Name = "txtBoxCustCountry";
            this.txtBoxCustCountry.Size = new System.Drawing.Size(100, 23);
            this.txtBoxCustCountry.TabIndex = 91;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            // 
            // txtBoxCustCity
            // 
            this.txtBoxCustCity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "city", true));
            this.txtBoxCustCity.Location = new System.Drawing.Point(355, 59);
            this.txtBoxCustCity.Name = "txtBoxCustCity";
            this.txtBoxCustCity.Size = new System.Drawing.Size(100, 23);
            this.txtBoxCustCity.TabIndex = 90;
            // 
            // txtBoxCustAdd
            // 
            this.txtBoxCustAdd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "address", true));
            this.txtBoxCustAdd.Location = new System.Drawing.Point(355, 30);
            this.txtBoxCustAdd.Name = "txtBoxCustAdd";
            this.txtBoxCustAdd.Size = new System.Drawing.Size(100, 23);
            this.txtBoxCustAdd.TabIndex = 89;
            // 
            // txtBoxCustPhone
            // 
            this.txtBoxCustPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "phone", true));
            this.txtBoxCustPhone.Location = new System.Drawing.Point(127, 94);
            this.txtBoxCustPhone.Name = "txtBoxCustPhone";
            this.txtBoxCustPhone.Size = new System.Drawing.Size(100, 23);
            this.txtBoxCustPhone.TabIndex = 88;
            // 
            // txtBoxCustName
            // 
            this.txtBoxCustName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "customerName", true));
            this.txtBoxCustName.Location = new System.Drawing.Point(127, 61);
            this.txtBoxCustName.Name = "txtBoxCustName";
            this.txtBoxCustName.Size = new System.Drawing.Size(100, 23);
            this.txtBoxCustName.TabIndex = 87;
            // 
            // txtBoxCustId
            // 
            this.txtBoxCustId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "customerId", true));
            this.txtBoxCustId.Location = new System.Drawing.Point(127, 29);
            this.txtBoxCustId.Name = "txtBoxCustId";
            this.txtBoxCustId.ReadOnly = true;
            this.txtBoxCustId.Size = new System.Drawing.Size(100, 23);
            this.txtBoxCustId.TabIndex = 86;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "address";
            this.dataGridViewTextBoxColumn1.HeaderText = "Address";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
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
            //this.btnDeleteCust.Click += new System.EventHandler(this.btnDeleteCust_Click);
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
            this.toolStrip1.Size = new System.Drawing.Size(1109, 60);
            this.toolStrip1.TabIndex = 20;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(192, 252);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(522, 150);
            this.dataGridView1.TabIndex = 92;
            // 
            // FormAllCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 737);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormAllCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormAllCustomers_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.custGroupBox.ResumeLayout(false);
            this.custGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postalCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr1DataGridViewTextBoxColumn;
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
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtBxSearch;


        private System.Windows.Forms.GroupBox custGroupBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;
        private System.Windows.Forms.TextBox txtBoxCustId;
        private System.Windows.Forms.TextBox txtBoxCustCountry;
        private System.Windows.Forms.TextBox txtBoxCustCity;
        private System.Windows.Forms.TextBox txtBoxCustAdd;
        private System.Windows.Forms.TextBox txtBoxCustPhone;
        private System.Windows.Forms.TextBox txtBoxCustName;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}