
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label startLabel;
            this.reportsGrid = new System.Windows.Forms.DataGridView();
            this.btnDateSearch = new System.Windows.Forms.Button();
            this.p_EndDate = new System.Windows.Forms.DateTimePicker();
            this.p_StartDate = new System.Windows.Forms.DateTimePicker();
            this.btnConsult = new System.Windows.Forms.Button();
            this.btnAptType = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            startLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.reportsGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(351, 162);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(23, 13);
            label2.TabIndex = 11;
            label2.Text = "To:";
            // 
            // startLabel
            // 
            startLabel.AutoSize = true;
            startLabel.Location = new System.Drawing.Point(167, 161);
            startLabel.Name = "startLabel";
            startLabel.Size = new System.Drawing.Size(59, 13);
            startLabel.TabIndex = 9;
            startLabel.Text = "From Date:";
            // 
            // reportsGrid
            // 
            this.reportsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportsGrid.Location = new System.Drawing.Point(135, 219);
            this.reportsGrid.Name = "reportsGrid";
            this.reportsGrid.Size = new System.Drawing.Size(520, 150);
            this.reportsGrid.TabIndex = 0;
            // 
            // btnDateSearch
            // 
            this.btnDateSearch.BackColor = System.Drawing.Color.Coral;
            this.btnDateSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDateSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDateSearch.ForeColor = System.Drawing.Color.White;
            this.btnDateSearch.Location = new System.Drawing.Point(506, 156);
            this.btnDateSearch.Margin = new System.Windows.Forms.Padding(1);
            this.btnDateSearch.Name = "btnDateSearch";
            this.btnDateSearch.Size = new System.Drawing.Size(111, 26);
            this.btnDateSearch.TabIndex = 13;
            this.btnDateSearch.Text = "Search by Range";
            this.btnDateSearch.UseVisualStyleBackColor = false;
            this.btnDateSearch.Click += new System.EventHandler(this.btnDateSearch_Click);
            // 
            // p_EndDate
            // 
            this.p_EndDate.CustomFormat = "YYYY-MM-DD HH:MM:SS";
            this.p_EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.p_EndDate.Location = new System.Drawing.Point(380, 156);
            this.p_EndDate.Name = "p_EndDate";
            this.p_EndDate.Size = new System.Drawing.Size(113, 20);
            this.p_EndDate.TabIndex = 12;
            this.p_EndDate.Value = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            // 
            // p_StartDate
            // 
            this.p_StartDate.CustomFormat = "YYYY-MM-DD HH:MM:SS";
            this.p_StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.p_StartDate.Location = new System.Drawing.Point(232, 155);
            this.p_StartDate.Name = "p_StartDate";
            this.p_StartDate.Size = new System.Drawing.Size(113, 20);
            this.p_StartDate.TabIndex = 10;
            this.p_StartDate.Value = new System.DateTime(2018, 12, 31, 0, 0, 0, 0);
            // 
            // btnConsult
            // 
            this.btnConsult.BackColor = System.Drawing.Color.Coral;
            this.btnConsult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsult.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsult.ForeColor = System.Drawing.Color.White;
            this.btnConsult.Location = new System.Drawing.Point(506, 117);
            this.btnConsult.Margin = new System.Windows.Forms.Padding(1);
            this.btnConsult.Name = "btnConsult";
            this.btnConsult.Size = new System.Drawing.Size(111, 26);
            this.btnConsult.TabIndex = 14;
            this.btnConsult.Text = "Consult Schedule";
            this.btnConsult.UseVisualStyleBackColor = false;
            // 
            // btnAptType
            // 
            this.btnAptType.BackColor = System.Drawing.Color.Coral;
            this.btnAptType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAptType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAptType.ForeColor = System.Drawing.Color.White;
            this.btnAptType.Location = new System.Drawing.Point(506, 79);
            this.btnAptType.Margin = new System.Windows.Forms.Padding(1);
            this.btnAptType.Name = "btnAptType";
            this.btnAptType.Size = new System.Drawing.Size(111, 26);
            this.btnAptType.TabIndex = 15;
            this.btnAptType.Text = "Apt Types Month";
            this.btnAptType.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(330, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reports";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(3, -1);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(798, 64);
            this.panel1.TabIndex = 20;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(132, 391);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 13);
            this.lblTotal.TabIndex = 21;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "Reports";
            this.Text = "Reports";
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
        private System.Windows.Forms.Button btnAptType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotal;
    }
}