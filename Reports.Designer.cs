
namespace ScheduleApptApp
{
    partial class Reports
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label startLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports));
            this.reportsGrid = new System.Windows.Forms.DataGridView();
            this.btnDateSearch = new System.Windows.Forms.Button();
            this.p_EndDate = new System.Windows.Forms.DateTimePicker();
            this.p_StartDate = new System.Windows.Forms.DateTimePicker();
            this.btnConsult = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.listBoxConsult = new System.Windows.Forms.ListBox();
            this.listBoxMonth = new System.Windows.Forms.ListBox();
            this.rprtLbl = new System.Windows.Forms.Label();
            this.btnAptType = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.numLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            label2 = new System.Windows.Forms.Label();
            startLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.reportsGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(710, 139);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(22, 15);
            label2.TabIndex = 11;
            label2.Text = "To:";
            // 
            // startLabel
            // 
            startLabel.AutoSize = true;
            startLabel.Location = new System.Drawing.Point(679, 107);
            startLabel.Name = "startLabel";
            startLabel.Size = new System.Drawing.Size(65, 15);
            startLabel.TabIndex = 9;
            startLabel.Text = "From Date:";
            // 
            // reportsGrid
            // 
            this.reportsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.reportsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportsGrid.Location = new System.Drawing.Point(160, 313);
            this.reportsGrid.Name = "reportsGrid";
            this.reportsGrid.Size = new System.Drawing.Size(607, 181);
            this.reportsGrid.TabIndex = 0;
            // 
            // btnDateSearch
            // 
            this.btnDateSearch.BackColor = System.Drawing.Color.Coral;
            this.btnDateSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDateSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDateSearch.ForeColor = System.Drawing.Color.White;
            this.btnDateSearch.Location = new System.Drawing.Point(672, 200);
            this.btnDateSearch.Margin = new System.Windows.Forms.Padding(1);
            this.btnDateSearch.Name = "btnDateSearch";
            this.btnDateSearch.Size = new System.Drawing.Size(220, 30);
            this.btnDateSearch.TabIndex = 13;
            this.btnDateSearch.Text = "Search Appointment By Dates";
            this.btnDateSearch.UseVisualStyleBackColor = false;
            this.btnDateSearch.Click += new System.EventHandler(this.btnDateSearch_Click_1);
            // 
            // p_EndDate
            // 
            this.p_EndDate.CustomFormat = "YYYY-MM-DD HH:MM:SS";
            this.p_EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.p_EndDate.Location = new System.Drawing.Point(744, 132);
            this.p_EndDate.Name = "p_EndDate";
            this.p_EndDate.Size = new System.Drawing.Size(131, 23);
            this.p_EndDate.TabIndex = 12;
            this.p_EndDate.Value = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            // 
            // p_StartDate
            // 
            this.p_StartDate.CustomFormat = "YYYY-MM-DD HH:MM:SS";
            this.p_StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.p_StartDate.Location = new System.Drawing.Point(744, 102);
            this.p_StartDate.Name = "p_StartDate";
            this.p_StartDate.Size = new System.Drawing.Size(131, 23);
            this.p_StartDate.TabIndex = 10;
            this.p_StartDate.Value = new System.DateTime(2018, 12, 31, 0, 0, 0, 0);
            // 
            // btnConsult
            // 
            this.btnConsult.BackColor = System.Drawing.Color.Coral;
            this.btnConsult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsult.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsult.ForeColor = System.Drawing.Color.White;
            this.btnConsult.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsult.Location = new System.Drawing.Point(362, 200);
            this.btnConsult.Margin = new System.Windows.Forms.Padding(1);
            this.btnConsult.Name = "btnConsult";
            this.btnConsult.Size = new System.Drawing.Size(220, 30);
            this.btnConsult.TabIndex = 14;
            this.btnConsult.Text = "View Each Consultant Schedule";
            this.btnConsult.UseVisualStyleBackColor = false;
            this.btnConsult.Click += new System.EventHandler(this.btnConsult_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(3, -1);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(931, 74);
            this.panel1.TabIndex = 20;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Coral;
            this.btnHome.Location = new System.Drawing.Point(828, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(87, 39);
            this.btnHome.TabIndex = 22;
            this.btnHome.Text = "Go Back";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(385, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reports";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(154, 451);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 15);
            this.lblTotal.TabIndex = 21;
            // 
            // listBoxConsult
            // 
            this.listBoxConsult.FormattingEnabled = true;
            this.listBoxConsult.ItemHeight = 15;
            this.listBoxConsult.Location = new System.Drawing.Point(425, 101);
            this.listBoxConsult.Name = "listBoxConsult";
            this.listBoxConsult.Size = new System.Drawing.Size(95, 94);
            this.listBoxConsult.TabIndex = 26;
            // 
            // listBoxMonth
            // 
            this.listBoxMonth.FormattingEnabled = true;
            this.listBoxMonth.ItemHeight = 15;
            this.listBoxMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.listBoxMonth.Location = new System.Drawing.Point(97, 102);
            this.listBoxMonth.Name = "listBoxMonth";
            this.listBoxMonth.Size = new System.Drawing.Size(95, 94);
            this.listBoxMonth.TabIndex = 27;
            // 
            // rprtLbl
            // 
            this.rprtLbl.AutoSize = true;
            this.rprtLbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rprtLbl.Location = new System.Drawing.Point(407, 313);
            this.rprtLbl.Name = "rprtLbl";
            this.rprtLbl.Size = new System.Drawing.Size(0, 25);
            this.rprtLbl.TabIndex = 28;
            // 
            // btnAptType
            // 
            this.btnAptType.BackColor = System.Drawing.Color.Coral;
            this.btnAptType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAptType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAptType.ForeColor = System.Drawing.Color.White;
            this.btnAptType.Location = new System.Drawing.Point(34, 200);
            this.btnAptType.Margin = new System.Windows.Forms.Padding(1);
            this.btnAptType.Name = "btnAptType";
            this.btnAptType.Size = new System.Drawing.Size(220, 30);
            this.btnAptType.TabIndex = 15;
            this.btnAptType.Text = "View Apt Types By Month";
            this.btnAptType.UseVisualStyleBackColor = false;
            this.btnAptType.Click += new System.EventHandler(this.btnAptType_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(438, 246);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 25);
            this.lblTitle.TabIndex = 29;
            // 
            // numLbl
            // 
            this.numLbl.AutoSize = true;
            this.numLbl.Location = new System.Drawing.Point(409, 284);
            this.numLbl.Name = "numLbl";
            this.numLbl.Size = new System.Drawing.Size(0, 15);
            this.numLbl.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(46, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 35;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numLbl);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.rprtLbl);
            this.Controls.Add(this.listBoxMonth);
            this.Controls.Add(this.listBoxConsult);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAptType);
            this.Controls.Add(this.btnConsult);
            this.Controls.Add(this.btnDateSearch);
            this.Controls.Add(label2);
            this.Controls.Add(this.p_EndDate);
            this.Controls.Add(startLabel);
            this.Controls.Add(this.p_StartDate);
            this.Controls.Add(this.reportsGrid);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Reports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportsGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView reportsGrid;
        private System.Windows.Forms.Button btnDateSearch;
        private System.Windows.Forms.DateTimePicker p_EndDate;
        private System.Windows.Forms.DateTimePicker p_StartDate;
        private System.Windows.Forms.Button btnConsult;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ListBox listBoxConsult;
        private System.Windows.Forms.ListBox listBoxMonth;
        private System.Windows.Forms.Label rprtLbl;
        private System.Windows.Forms.Button btnAptType;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label numLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ImageList imageList1;
    }
}