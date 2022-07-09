
namespace ScheduleApptApp
{
    partial class FormAllAppointments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAllAppointments));
            this.Label = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAddAppt = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEditAppt = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDeleteAppt = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSaveAppt = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.AppointmentGrid = new System.Windows.Forms.DataGridView();
            this.txtBxSearch = new System.Windows.Forms.TextBox();
            this.apptGroupBox = new System.Windows.Forms.GroupBox();
            this.userCombo = new System.Windows.Forms.ComboBox();
            this.User = new System.Windows.Forms.Label();
            this.comboId = new System.Windows.Forms.ComboBox();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBxApptId = new System.Windows.Forms.TextBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentGrid)).BeginInit();
            this.apptGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Segoe UI", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label.Location = new System.Drawing.Point(1, 0);
            this.Label.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(130, 25);
            this.Label.TabIndex = 0;
            this.Label.Text = "Appointments";
            this.Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.flowLayoutPanel1.TabIndex = 20;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddAppt,
            this.toolStripSeparator5,
            this.btnEditAppt,
            this.toolStripSeparator3,
            this.btnDeleteAppt,
            this.toolStripSeparator4,
            this.btnSaveAppt,
            this.toolStripSeparator1,
            this.btnCancel,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 62);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(933, 60);
            this.toolStrip1.TabIndex = 21;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAddAppt
            // 
            this.btnAddAppt.Image = ((System.Drawing.Image)(resources.GetObject("btnAddAppt.Image")));
            this.btnAddAppt.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAddAppt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddAppt.Name = "btnAddAppt";
            this.btnAddAppt.Size = new System.Drawing.Size(84, 57);
            this.btnAddAppt.Text = "Add New";
            this.btnAddAppt.Click += new System.EventHandler(this.btnAddAppt_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 60);
            // 
            // btnEditAppt
            // 
            this.btnEditAppt.Image = ((System.Drawing.Image)(resources.GetObject("btnEditAppt.Image")));
            this.btnEditAppt.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEditAppt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditAppt.Name = "btnEditAppt";
            this.btnEditAppt.Size = new System.Drawing.Size(55, 57);
            this.btnEditAppt.Text = "Edit";
            this.btnEditAppt.Click += new System.EventHandler(this.btnEditAppt_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 60);
            // 
            // btnDeleteAppt
            // 
            this.btnDeleteAppt.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteAppt.Image")));
            this.btnDeleteAppt.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDeleteAppt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteAppt.Name = "btnDeleteAppt";
            this.btnDeleteAppt.Size = new System.Drawing.Size(68, 57);
            this.btnDeleteAppt.Text = "Delete";
            this.btnDeleteAppt.Click += new System.EventHandler(this.btnDeleteAppt_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 60);
            // 
            // btnSaveAppt
            // 
            this.btnSaveAppt.Enabled = false;
            this.btnSaveAppt.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveAppt.Image")));
            this.btnSaveAppt.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSaveAppt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveAppt.Name = "btnSaveAppt";
            this.btnSaveAppt.Size = new System.Drawing.Size(59, 57);
            this.btnSaveAppt.Text = "Save";
            this.btnSaveAppt.Click += new System.EventHandler(this.btnSaveAppt_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 60);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
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
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.AppointmentGrid);
            this.panel1.Controls.Add(this.txtBxSearch);
            this.panel1.Controls.Add(this.apptGroupBox);
            this.panel1.Location = new System.Drawing.Point(39, 134);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 460);
            this.panel1.TabIndex = 22;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(569, 242);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // AppointmentGrid
            // 
            this.AppointmentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppointmentGrid.Location = new System.Drawing.Point(28, 269);
            this.AppointmentGrid.Name = "AppointmentGrid";
            this.AppointmentGrid.Size = new System.Drawing.Size(772, 174);
            this.AppointmentGrid.TabIndex = 3;
            this.AppointmentGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AppointmentGrid_CellClick);
            // 
            // txtBxSearch
            // 
            this.txtBxSearch.Location = new System.Drawing.Point(665, 243);
            this.txtBxSearch.Name = "txtBxSearch";
            this.txtBxSearch.Size = new System.Drawing.Size(135, 20);
            this.txtBxSearch.TabIndex = 21;
            // 
            // apptGroupBox
            // 
            this.apptGroupBox.Controls.Add(this.userCombo);
            this.apptGroupBox.Controls.Add(this.User);
            this.apptGroupBox.Controls.Add(this.comboId);
            this.apptGroupBox.Controls.Add(this.comboType);
            this.apptGroupBox.Controls.Add(this.label6);
            this.apptGroupBox.Controls.Add(this.dateTimePicker2);
            this.apptGroupBox.Controls.Add(this.label4);
            this.apptGroupBox.Controls.Add(this.dateTimePicker1);
            this.apptGroupBox.Controls.Add(this.label5);
            this.apptGroupBox.Controls.Add(this.label2);
            this.apptGroupBox.Controls.Add(this.label1);
            this.apptGroupBox.Controls.Add(this.txtBxApptId);
            this.apptGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apptGroupBox.Location = new System.Drawing.Point(3, 3);
            this.apptGroupBox.Name = "apptGroupBox";
            this.apptGroupBox.Size = new System.Drawing.Size(821, 233);
            this.apptGroupBox.TabIndex = 3;
            this.apptGroupBox.TabStop = false;
            this.apptGroupBox.Text = "Appointment Info";
            // 
            // userCombo
            // 
            this.userCombo.FormattingEnabled = true;
            this.userCombo.Location = new System.Drawing.Point(136, 142);
            this.userCombo.Name = "userCombo";
            this.userCombo.Size = new System.Drawing.Size(57, 23);
            this.userCombo.TabIndex = 26;
            this.userCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Location = new System.Drawing.Point(22, 142);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(33, 15);
            this.User.TabIndex = 25;
            this.User.Text = "User:";
            // 
            // comboId
            // 
            this.comboId.FormattingEnabled = true;
            this.comboId.Location = new System.Drawing.Point(133, 91);
            this.comboId.Name = "comboId";
            this.comboId.Size = new System.Drawing.Size(60, 23);
            this.comboId.TabIndex = 24;
            // 
            // comboType
            // 
            this.comboType.FormattingEnabled = true;
            this.comboType.Location = new System.Drawing.Point(136, 188);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(121, 23);
            this.comboType.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(460, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "End Time:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(529, 82);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(193, 23);
            this.dateTimePicker2.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(460, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Start Time:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(529, 45);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(193, 23);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Appointment Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Customer ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Apppointment ID:";
            // 
            // txtBxApptId
            // 
            this.txtBxApptId.Location = new System.Drawing.Point(133, 42);
            this.txtBxApptId.Name = "txtBxApptId";
            this.txtBxApptId.ReadOnly = true;
            this.txtBxApptId.Size = new System.Drawing.Size(135, 23);
            this.txtBxApptId.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Coral;
            this.btnHome.Location = new System.Drawing.Point(846, 66);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 34);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Go Back";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // FormAllAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 622);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "FormAllAppointments";
            this.Load += new System.EventHandler(this.FormAllAppointments_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentGrid)).EndInit();
            this.apptGroupBox.ResumeLayout(false);
            this.apptGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAddAppt;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnEditAppt;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnDeleteAppt;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnSaveAppt;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView AppointmentGrid;
        private System.Windows.Forms.TextBox txtBxSearch;
        private System.Windows.Forms.GroupBox apptGroupBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBxApptId;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboType;
        private System.Windows.Forms.ComboBox comboId;
        private System.Windows.Forms.ComboBox userCombo;
        private System.Windows.Forms.Label User;
    }
}