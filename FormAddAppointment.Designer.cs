
namespace ScheduleApptApp
{
    partial class FormAddAppointment
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.AddApptLabel = new System.Windows.Forms.Label();
            this.SaveApptBtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.addTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.addTimeStart = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.txtApptId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCustId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel3.Controls.Add(this.AddApptLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(509, 74);
            this.panel3.TabIndex = 0;
            // 
            // AddApptLabel
            // 
            this.AddApptLabel.AutoSize = true;
            this.AddApptLabel.Font = new System.Drawing.Font("Segoe UI", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddApptLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddApptLabel.Location = new System.Drawing.Point(10, 19);
            this.AddApptLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.AddApptLabel.Name = "AddApptLabel";
            this.AddApptLabel.Size = new System.Drawing.Size(161, 25);
            this.AddApptLabel.TabIndex = 0;
            this.AddApptLabel.Text = "Add Appointment";
            // 
            // SaveApptBtn
            // 
            this.SaveApptBtn.BackColor = System.Drawing.Color.Coral;
            this.SaveApptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveApptBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveApptBtn.ForeColor = System.Drawing.Color.White;
            this.SaveApptBtn.Location = new System.Drawing.Point(396, 524);
            this.SaveApptBtn.Margin = new System.Windows.Forms.Padding(1);
            this.SaveApptBtn.Name = "SaveApptBtn";
            this.SaveApptBtn.Size = new System.Drawing.Size(103, 45);
            this.SaveApptBtn.TabIndex = 0;
            this.SaveApptBtn.Text = "Save";
            this.SaveApptBtn.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.addTimeEnd);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.addTimeStart);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.txtApptId);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.txtType);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.txtCustId);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.txtUserId);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(29, 104);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(452, 389);
            this.panel4.TabIndex = 0;
            // 
            // addTimeEnd
            // 
            this.addTimeEnd.Location = new System.Drawing.Point(244, 299);
            this.addTimeEnd.Name = "addTimeEnd";
            this.addTimeEnd.Size = new System.Drawing.Size(200, 20);
            this.addTimeEnd.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "End Time:";
            // 
            // addTimeStart
            // 
            this.addTimeStart.Location = new System.Drawing.Point(9, 299);
            this.addTimeStart.Name = "addTimeStart";
            this.addTimeStart.Size = new System.Drawing.Size(200, 20);
            this.addTimeStart.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 281);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 15);
            this.label13.TabIndex = 14;
            this.label13.Text = "Start Time:";
            // 
            // txtApptId
            // 
            this.txtApptId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApptId.Location = new System.Drawing.Point(26, 117);
            this.txtApptId.Name = "txtApptId";
            this.txtApptId.Size = new System.Drawing.Size(403, 23);
            this.txtApptId.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(28, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 15);
            this.label11.TabIndex = 10;
            this.label11.Text = "Appointment ID:";
            // 
            // txtType
            // 
            this.txtType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtType.Location = new System.Drawing.Point(26, 245);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(403, 23);
            this.txtType.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(23, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "Type:";
            // 
            // txtCustId
            // 
            this.txtCustId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustId.Location = new System.Drawing.Point(26, 181);
            this.txtCustId.Name = "txtCustId";
            this.txtCustId.Size = new System.Drawing.Size(403, 23);
            this.txtCustId.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 15);
            this.label8.TabIndex = 4;
            this.label8.Text = "Customer ID:";
            // 
            // txtUserId
            // 
            this.txtUserId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserId.Location = new System.Drawing.Point(26, 53);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(403, 23);
            this.txtUserId.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "User Id:";
            // 
            // FormAddAppointment
            // 
            this.ClientSize = new System.Drawing.Size(509, 577);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.SaveApptBtn);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormAddAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Appointment";
            this.Load += new System.EventHandler(this.FormAddAppointment_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button SaveApptBtn;
        private System.Windows.Forms.Label AddApptLabel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCustId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtApptId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker addTimeStart;
        private System.Windows.Forms.DateTimePicker addTimeEnd;
        private System.Windows.Forms.Label label1;
    }
}