
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CustomerGrid = new System.Windows.Forms.DataGridView();
            this.btnAddCust = new System.Windows.Forms.Button();
            this.btnEditCust = new System.Windows.Forms.Button();
            this.btnDeleteCust = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGrid)).BeginInit();
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
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnDeleteCust);
            this.panel1.Controls.Add(this.btnEditCust);
            this.panel1.Controls.Add(this.CustomerGrid);
            this.panel1.Controls.Add(this.btnAddCust);
            this.panel1.Location = new System.Drawing.Point(48, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 354);
            this.panel1.TabIndex = 0;
            // 
            // CustomerGrid
            // 
            this.CustomerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerGrid.Location = new System.Drawing.Point(18, 80);
            this.CustomerGrid.Name = "CustomerGrid";
            this.CustomerGrid.Size = new System.Drawing.Size(785, 243);
            this.CustomerGrid.TabIndex = 2;
            // 
            // btnAddCust
            // 
            this.btnAddCust.BackColor = System.Drawing.Color.Coral;
            this.btnAddCust.FlatAppearance.BorderSize = 0;
            this.btnAddCust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCust.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCust.ForeColor = System.Drawing.Color.White;
            this.btnAddCust.Location = new System.Drawing.Point(18, 13);
            this.btnAddCust.Margin = new System.Windows.Forms.Padding(1);
            this.btnAddCust.Name = "btnAddCust";
            this.btnAddCust.Size = new System.Drawing.Size(126, 45);
            this.btnAddCust.TabIndex = 1;
            this.btnAddCust.Text = "Add Customer";
            this.btnAddCust.UseVisualStyleBackColor = false;
            this.btnAddCust.Click += new System.EventHandler(this.AddCustomerBtn_Click_1);
            // 
            // btnEditCust
            // 
            this.btnEditCust.BackColor = System.Drawing.Color.Coral;
            this.btnEditCust.FlatAppearance.BorderSize = 0;
            this.btnEditCust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCust.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCust.ForeColor = System.Drawing.Color.White;
            this.btnEditCust.Location = new System.Drawing.Point(157, 13);
            this.btnEditCust.Margin = new System.Windows.Forms.Padding(1);
            this.btnEditCust.Name = "btnEditCust";
            this.btnEditCust.Size = new System.Drawing.Size(126, 45);
            this.btnEditCust.TabIndex = 3;
            this.btnEditCust.Text = "Edit Customer";
            this.btnEditCust.UseVisualStyleBackColor = false;
            this.btnEditCust.Click += new System.EventHandler(this.btnEditCust_Click);
            // 
            // btnDeleteCust
            // 
            this.btnDeleteCust.BackColor = System.Drawing.Color.Coral;
            this.btnDeleteCust.FlatAppearance.BorderSize = 0;
            this.btnDeleteCust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCust.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCust.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCust.Location = new System.Drawing.Point(297, 13);
            this.btnDeleteCust.Margin = new System.Windows.Forms.Padding(1);
            this.btnDeleteCust.Name = "btnDeleteCust";
            this.btnDeleteCust.Size = new System.Drawing.Size(137, 45);
            this.btnDeleteCust.TabIndex = 4;
            this.btnDeleteCust.Text = "Delete Customer";
            this.btnDeleteCust.UseVisualStyleBackColor = false;
            // 
            // FormAllCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormAllCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.FormAllCustomers_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddCust;
        private System.Windows.Forms.DataGridView CustomerGrid;
        private System.Windows.Forms.Button btnDeleteCust;
        private System.Windows.Forms.Button btnEditCust;
    }
}