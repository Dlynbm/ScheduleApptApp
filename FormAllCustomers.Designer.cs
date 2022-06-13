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
            this.createDateLabel = new System.Windows.Forms.Label();
            this.customerIdLabel1 = new System.Windows.Forms.Label();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.countryLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.custGroupBox = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.CustomerGrid = new System.Windows.Forms.DataGridView();
            this.txtBxSearch = new System.Windows.Forms.TextBox();
            this.txtBoxCustCountry = new System.Windows.Forms.TextBox();
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
            this.UpdateButton1 = new System.Windows.Forms.ToolStripButton();
            this.btnHome = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.custGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGrid)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // createDateLabel
            // 
            this.createDateLabel.AutoSize = true;
            this.createDateLabel.Location = new System.Drawing.Point(679, 177);
            this.createDateLabel.Name = "createDateLabel";
            this.createDateLabel.Size = new System.Drawing.Size(69, 15);
            this.createDateLabel.TabIndex = 38;
            this.createDateLabel.Text = "create Date:";
            // 
            // customerIdLabel1
            // 
            this.customerIdLabel1.AutoSize = true;
            this.customerIdLabel1.Location = new System.Drawing.Point(48, 40);
            this.customerIdLabel1.Name = "customerIdLabel1";
            this.customerIdLabel1.Size = new System.Drawing.Size(75, 15);
            this.customerIdLabel1.TabIndex = 78;
            this.customerIdLabel1.Text = "Customer Id:";
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Location = new System.Drawing.Point(26, 67);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(97, 15);
            this.customerNameLabel.TabIndex = 79;
            this.customerNameLabel.Text = "Customer Name:";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(378, 36);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(52, 15);
            this.addressLabel.TabIndex = 80;
            this.addressLabel.Text = "Address:";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(77, 97);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(44, 15);
            this.phoneLabel.TabIndex = 81;
            this.phoneLabel.Text = "Phone:";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(399, 71);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(31, 15);
            this.cityLabel.TabIndex = 82;
            this.cityLabel.Text = "City:";
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Location = new System.Drawing.Point(377, 101);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(53, 15);
            this.countryLabel.TabIndex = 83;
            this.countryLabel.Text = "Country:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.flowLayoutPanel1.Controls.Add(this.Label);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(925, 62);
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
            this.panel1.Controls.Add(this.custGroupBox);
            this.panel1.Location = new System.Drawing.Point(52, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(819, 497);
            this.panel1.TabIndex = 0;
            // 
            // custGroupBox
            // 
            this.custGroupBox.Controls.Add(this.btnSearch);
            this.custGroupBox.Controls.Add(this.CustomerGrid);
            this.custGroupBox.Controls.Add(this.txtBxSearch);
            this.custGroupBox.Controls.Add(this.txtBoxCustCountry);
            this.custGroupBox.Controls.Add(this.txtBoxCustCity);
            this.custGroupBox.Controls.Add(this.txtBoxCustAdd);
            this.custGroupBox.Controls.Add(this.txtBoxCustPhone);
            this.custGroupBox.Controls.Add(this.txtBoxCustName);
            this.custGroupBox.Controls.Add(this.txtBoxCustId);
            this.custGroupBox.Controls.Add(this.countryLabel);
            this.custGroupBox.Controls.Add(this.cityLabel);
            this.custGroupBox.Controls.Add(this.phoneLabel);
            this.custGroupBox.Controls.Add(this.addressLabel);
            this.custGroupBox.Controls.Add(this.customerNameLabel);
            this.custGroupBox.Controls.Add(this.customerIdLabel1);
            this.custGroupBox.Controls.Add(this.createDateLabel);
            this.custGroupBox.Location = new System.Drawing.Point(3, 3);
            this.custGroupBox.Name = "custGroupBox";
            this.custGroupBox.Size = new System.Drawing.Size(837, 572);
            this.custGroupBox.TabIndex = 0;
            this.custGroupBox.TabStop = false;
            this.custGroupBox.Text = "Customer Info";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(529, 176);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // CustomerGrid
            // 
            this.CustomerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerGrid.Location = new System.Drawing.Point(66, 252);
            this.CustomerGrid.Name = "CustomerGrid";
            this.CustomerGrid.Size = new System.Drawing.Size(694, 150);
            this.CustomerGrid.TabIndex = 92;
            this.CustomerGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerGrid_CellClick);
            // 
            // txtBxSearch
            // 
            this.txtBxSearch.Location = new System.Drawing.Point(625, 177);
            this.txtBxSearch.Name = "txtBxSearch";
            this.txtBxSearch.Size = new System.Drawing.Size(135, 23);
            this.txtBxSearch.TabIndex = 21;
            // 
            // txtBoxCustCountry
            // 
            this.txtBoxCustCountry.Location = new System.Drawing.Point(434, 101);
            this.txtBoxCustCountry.Name = "txtBoxCustCountry";
            this.txtBoxCustCountry.Size = new System.Drawing.Size(173, 23);
            this.txtBoxCustCountry.TabIndex = 91;
            // 
            // txtBoxCustCity
            // 
            this.txtBoxCustCity.Location = new System.Drawing.Point(434, 64);
            this.txtBoxCustCity.Name = "txtBoxCustCity";
            this.txtBoxCustCity.Size = new System.Drawing.Size(173, 23);
            this.txtBoxCustCity.TabIndex = 90;
            // 
            // txtBoxCustAdd
            // 
            this.txtBoxCustAdd.Location = new System.Drawing.Point(434, 29);
            this.txtBoxCustAdd.Name = "txtBoxCustAdd";
            this.txtBoxCustAdd.Size = new System.Drawing.Size(173, 23);
            this.txtBoxCustAdd.TabIndex = 89;
            // 
            // txtBoxCustPhone
            // 
            this.txtBoxCustPhone.Location = new System.Drawing.Point(127, 94);
            this.txtBoxCustPhone.Name = "txtBoxCustPhone";
            this.txtBoxCustPhone.Size = new System.Drawing.Size(173, 23);
            this.txtBoxCustPhone.TabIndex = 88;
            // 
            // txtBoxCustName
            // 
            this.txtBoxCustName.Location = new System.Drawing.Point(127, 61);
            this.txtBoxCustName.Name = "txtBoxCustName";
            this.txtBoxCustName.Size = new System.Drawing.Size(173, 23);
            this.txtBoxCustName.TabIndex = 87;
            // 
            // txtBoxCustId
            // 
            this.txtBoxCustId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtBoxCustId.HideSelection = false;
            this.txtBoxCustId.Location = new System.Drawing.Point(127, 29);
            this.txtBoxCustId.Name = "txtBoxCustId";
            this.txtBoxCustId.ReadOnly = true;
            this.txtBoxCustId.Size = new System.Drawing.Size(173, 23);
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
            this.btnAddCustomer.Size = new System.Drawing.Size(84, 56);
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
            this.btnEditCust.Size = new System.Drawing.Size(48, 56);
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
            this.btnSaveCustomer.Size = new System.Drawing.Size(65, 57);
            this.btnSaveCustomer.Text = "Save";
            this.btnSaveCustomer.Click += new System.EventHandler(this.btnSaveCustomer_Click_1);
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
            this.toolStripSeparator2,
            this.UpdateButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 62);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(925, 59);
            this.toolStrip1.TabIndex = 20;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // UpdateButton1
            // 
            this.UpdateButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.UpdateButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UpdateButton1.Name = "UpdateButton1";
            this.UpdateButton1.Size = new System.Drawing.Size(49, 57);
            this.UpdateButton1.Text = "Update";
            this.UpdateButton1.Click += new System.EventHandler(this.UpdateButton1_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Coral;
            this.btnHome.Location = new System.Drawing.Point(838, 66);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 34);
            this.btnHome.TabIndex = 21;
            this.btnHome.Text = "Go Back";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // FormAllCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 623);
            this.Controls.Add(this.btnHome);
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
            this.custGroupBox.ResumeLayout(false);
            this.custGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGrid)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label Label;
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
        private System.Windows.Forms.DataGridView CustomerGrid;
        private System.Windows.Forms.Label createDateLabel;
        private System.Windows.Forms.Label customerIdLabel1;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.ToolStripButton UpdateButton1;
        private System.Windows.Forms.Button btnHome;
    }
}