
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            System.Windows.Forms.Label startLabel;
            System.Windows.Forms.Label label2;
            this.panel2 = new System.Windows.Forms.Panel();
            this.AppointmentGrid = new System.Windows.Forms.DataGridView();
            this.ViewCustomersBtn = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnAddAppt = new System.Windows.Forms.Button();
            this.SearchTxtBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.client_scheduleDataSet = new ScheduleApptApp.client_scheduleDataSet();
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentTableAdapter = new ScheduleApptApp.client_scheduleDataSetTableAdapters.appointmentTableAdapter();
            this.tableAdapterManager = new ScheduleApptApp.client_scheduleDataSetTableAdapters.TableAdapterManager();
            this.appointmentBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.appointmentBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.p_StartDate = new System.Windows.Forms.DateTimePicker();
            this.p_EndDate = new System.Windows.Forms.DateTimePicker();
            this.btnDateSearch = new System.Windows.Forms.Button();
            startLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentGrid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.client_scheduleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingNavigator)).BeginInit();
            this.appointmentBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnDateSearch);
            this.panel2.Controls.Add(label2);
            this.panel2.Controls.Add(this.p_EndDate);
            this.panel2.Controls.Add(startLabel);
            this.panel2.Controls.Add(this.p_StartDate);
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
            // AppointmentGrid
            // 
            this.AppointmentGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AppointmentGrid.BackgroundColor = System.Drawing.Color.White;
            this.AppointmentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppointmentGrid.Location = new System.Drawing.Point(39, 114);
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
            // SearchTxtBox
            // 
            this.SearchTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchTxtBox.Location = new System.Drawing.Point(495, 121);
            this.SearchTxtBox.Name = "SearchTxtBox";
            this.SearchTxtBox.Size = new System.Drawing.Size(144, 20);
            this.SearchTxtBox.TabIndex = 1;
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
            this.label1.Location = new System.Drawing.Point(116, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(532, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "View All Your Customers and Appointments";
            // 
            // client_scheduleDataSet
            // 
            this.client_scheduleDataSet.DataSetName = "client_scheduleDataSet";
            this.client_scheduleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appointmentBindingSource
            // 
            this.appointmentBindingSource.DataMember = "appointment";
            this.appointmentBindingSource.DataSource = this.client_scheduleDataSet;
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
            // appointmentBindingNavigator
            // 
            this.appointmentBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.appointmentBindingNavigator.BindingSource = this.appointmentBindingSource;
            this.appointmentBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.appointmentBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.appointmentBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.appointmentBindingNavigatorSaveItem});
            this.appointmentBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.appointmentBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.appointmentBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.appointmentBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.appointmentBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.appointmentBindingNavigator.Name = "appointmentBindingNavigator";
            this.appointmentBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.appointmentBindingNavigator.Size = new System.Drawing.Size(757, 25);
            this.appointmentBindingNavigator.TabIndex = 20;
            this.appointmentBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // appointmentBindingNavigatorSaveItem
            // 
            this.appointmentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.appointmentBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("appointmentBindingNavigatorSaveItem.Image")));
            this.appointmentBindingNavigatorSaveItem.Name = "appointmentBindingNavigatorSaveItem";
            this.appointmentBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.appointmentBindingNavigatorSaveItem.Text = "Save Data";
            this.appointmentBindingNavigatorSaveItem.Click += new System.EventHandler(this.appointmentBindingNavigatorSaveItem_Click);
            // 
            // startLabel
            // 
            startLabel.AutoSize = true;
            startLabel.Location = new System.Drawing.Point(377, 16);
            startLabel.Name = "startLabel";
            startLabel.Size = new System.Drawing.Size(84, 13);
            startLabel.TabIndex = 4;
            startLabel.Text = "Filter Date From:";
            // 
            // p_StartDate
            // 
            this.p_StartDate.CustomFormat = "yyyy/mm/dd HH:mm:ss";
            this.p_StartDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.appointmentBindingSource, "start", true));
            this.p_StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.p_StartDate.Location = new System.Drawing.Point(476, 16);
            this.p_StartDate.Name = "p_StartDate";
            this.p_StartDate.Size = new System.Drawing.Size(113, 20);
            this.p_StartDate.TabIndex = 5;
            this.p_StartDate.Value = new System.DateTime(2018, 12, 31, 0, 0, 0, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(438, 48);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(23, 13);
            label2.TabIndex = 6;
            label2.Text = "To:";
            // 
            // p_EndDate
            // 
            this.p_EndDate.CustomFormat = "yyyy/mm/dd HH:mm:ss";
            this.p_EndDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.appointmentBindingSource, "start", true));
            this.p_EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.p_EndDate.Location = new System.Drawing.Point(476, 48);
            this.p_EndDate.Name = "p_EndDate";
            this.p_EndDate.Size = new System.Drawing.Size(113, 20);
            this.p_EndDate.TabIndex = 7;
            this.p_EndDate.Value = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            // 
            // btnDateSearch
            // 
            this.btnDateSearch.BackColor = System.Drawing.Color.Coral;
            this.btnDateSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDateSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDateSearch.ForeColor = System.Drawing.Color.White;
            this.btnDateSearch.Location = new System.Drawing.Point(593, 27);
            this.btnDateSearch.Margin = new System.Windows.Forms.Padding(1);
            this.btnDateSearch.Name = "btnDateSearch";
            this.btnDateSearch.Size = new System.Drawing.Size(112, 26);
            this.btnDateSearch.TabIndex = 8;
            this.btnDateSearch.Text = "Search By Month";
            this.btnDateSearch.UseVisualStyleBackColor = false;
            this.btnDateSearch.Click += new System.EventHandler(this.btnDateSearch_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 551);
            this.Controls.Add(this.appointmentBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.SearchTxtBox);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All Appointments";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.client_scheduleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingNavigator)).EndInit();
            this.appointmentBindingNavigator.ResumeLayout(false);
            this.appointmentBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button ViewCustomersBtn;
        private System.Windows.Forms.TextBox SearchTxtBox;
        
        private System.Windows.Forms.DataGridView AppointmentGrid;
        private System.Windows.Forms.Button btnAddAppt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private client_scheduleDataSet client_scheduleDataSet;
        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private client_scheduleDataSetTableAdapters.appointmentTableAdapter appointmentTableAdapter;
        private client_scheduleDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator appointmentBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton appointmentBindingNavigatorSaveItem;
        private System.Windows.Forms.Button btnDateSearch;
        private System.Windows.Forms.DateTimePicker p_EndDate;
        private System.Windows.Forms.DateTimePicker p_StartDate;
    }
}

