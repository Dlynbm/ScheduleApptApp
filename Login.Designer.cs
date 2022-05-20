
namespace ScheduleApptApp
{
    partial class Login
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
            System.Windows.Forms.Label userIdLabel;
            System.Windows.Forms.Label userNameLabel;
            System.Windows.Forms.Label passwordLabel;
            this.txtBoxUserPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.userIdLabel1 = new System.Windows.Forms.Label();
            this.userNameLabel1 = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.txtBoxUName = new System.Windows.Forms.TextBox();
            userIdLabel = new System.Windows.Forms.Label();
            userNameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // userIdLabel
            // 
            userIdLabel.AutoSize = true;
            userIdLabel.Location = new System.Drawing.Point(322, 39);
            userIdLabel.Name = "userIdLabel";
            userIdLabel.Size = new System.Drawing.Size(42, 13);
            userIdLabel.TabIndex = 6;
            userIdLabel.Text = "user Id:";
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new System.Drawing.Point(322, 62);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new System.Drawing.Size(61, 13);
            userNameLabel.TabIndex = 8;
            userNameLabel.Text = "user Name:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(322, 88);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(55, 13);
            passwordLabel.TabIndex = 10;
            passwordLabel.Text = "password:";
            // 
            // txtBoxUserPass
            // 
            this.txtBoxUserPass.Location = new System.Drawing.Point(163, 88);
            this.txtBoxUserPass.Name = "txtBoxUserPass";
            this.txtBoxUserPass.Size = new System.Drawing.Size(121, 20);
            this.txtBoxUserPass.TabIndex = 1;
            this.txtBoxUserPass.TextChanged += new System.EventHandler(this.txtBoxUserPass_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(181, 147);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "user";
         
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(181, 176);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // userTableAdapter
            // 
        
            // 
            // userIdLabel1
            // 
            this.userIdLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "userId", true));
            this.userIdLabel1.Location = new System.Drawing.Point(370, 39);
            this.userIdLabel1.Name = "userIdLabel1";
            this.userIdLabel1.Size = new System.Drawing.Size(100, 23);
            this.userIdLabel1.TabIndex = 7;
            this.userIdLabel1.Text = "label3";
            // 
            // userNameLabel1
            // 
            this.userNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "userName", true));
            this.userNameLabel1.Location = new System.Drawing.Point(389, 62);
            this.userNameLabel1.Name = "userNameLabel1";
            this.userNameLabel1.Size = new System.Drawing.Size(100, 23);
            this.userNameLabel1.TabIndex = 9;
            this.userNameLabel1.Text = "label3";
            // 
            // passLabel
            // 
            this.passLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "password", true));
            this.passLabel.Location = new System.Drawing.Point(383, 88);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(100, 23);
            this.passLabel.TabIndex = 11;
            this.passLabel.Text = "label3";
            // 
            // txtBoxUName
            // 
            this.txtBoxUName.Location = new System.Drawing.Point(163, 62);
            this.txtBoxUName.Name = "txtBoxUName";
            this.txtBoxUName.Size = new System.Drawing.Size(121, 20);
            this.txtBoxUName.TabIndex = 12;
            this.txtBoxUName.TextChanged += new System.EventHandler(this.txtBoxUName_TextChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 361);
            this.Controls.Add(this.txtBoxUName);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(userNameLabel);
            this.Controls.Add(this.userNameLabel1);
            this.Controls.Add(userIdLabel);
            this.Controls.Add(this.userIdLabel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxUserPass);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBoxUserPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.Label userIdLabel1;
        private System.Windows.Forms.Label userNameLabel1;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.TextBox txtBoxUName;
    }
}