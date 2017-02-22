namespace PBBackOffice
{
    partial class ReceptionistLogin
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
            this.btnReceptionLogin = new System.Windows.Forms.Button();
            this.txtReceptionistUsername = new System.Windows.Forms.TextBox();
            this.txtReceptionistPassword = new System.Windows.Forms.TextBox();
            this.lblReceptionistUsername = new System.Windows.Forms.Label();
            this.lblReceptionistPassword = new System.Windows.Forms.Label();
            this.btnBackToHomepageReceptionist = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReceptionLogin
            // 
            this.btnReceptionLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnReceptionLogin.Location = new System.Drawing.Point(140, 150);
            this.btnReceptionLogin.Name = "btnReceptionLogin";
            this.btnReceptionLogin.Size = new System.Drawing.Size(117, 52);
            this.btnReceptionLogin.TabIndex = 0;
            this.btnReceptionLogin.Text = "Login";
            this.btnReceptionLogin.UseVisualStyleBackColor = true;
            this.btnReceptionLogin.Click += new System.EventHandler(this.btnReceptionistLogin_Click);
            // 
            // txtReceptionistUsername
            // 
            this.txtReceptionistUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtReceptionistUsername.Location = new System.Drawing.Point(140, 66);
            this.txtReceptionistUsername.Name = "txtReceptionistUsername";
            this.txtReceptionistUsername.Size = new System.Drawing.Size(154, 30);
            this.txtReceptionistUsername.TabIndex = 1;
            // 
            // txtReceptionistPassword
            // 
            this.txtReceptionistPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtReceptionistPassword.Location = new System.Drawing.Point(140, 102);
            this.txtReceptionistPassword.Name = "txtReceptionistPassword";
            this.txtReceptionistPassword.PasswordChar = '*';
            this.txtReceptionistPassword.Size = new System.Drawing.Size(154, 30);
            this.txtReceptionistPassword.TabIndex = 2;
            // 
            // lblReceptionistUsername
            // 
            this.lblReceptionistUsername.AutoSize = true;
            this.lblReceptionistUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblReceptionistUsername.Location = new System.Drawing.Point(63, 78);
            this.lblReceptionistUsername.Name = "lblReceptionistUsername";
            this.lblReceptionistUsername.Size = new System.Drawing.Size(58, 13);
            this.lblReceptionistUsername.TabIndex = 3;
            this.lblReceptionistUsername.Text = "Username:";
            // 
            // lblReceptionistPassword
            // 
            this.lblReceptionistPassword.AutoSize = true;
            this.lblReceptionistPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblReceptionistPassword.Location = new System.Drawing.Point(65, 114);
            this.lblReceptionistPassword.Name = "lblReceptionistPassword";
            this.lblReceptionistPassword.Size = new System.Drawing.Size(56, 13);
            this.lblReceptionistPassword.TabIndex = 4;
            this.lblReceptionistPassword.Text = "Password:";
            // 
            // btnBackToHomepageReceptionist
            // 
            this.btnBackToHomepageReceptionist.Location = new System.Drawing.Point(30, 21);
            this.btnBackToHomepageReceptionist.Name = "btnBackToHomepageReceptionist";
            this.btnBackToHomepageReceptionist.Size = new System.Drawing.Size(80, 24);
            this.btnBackToHomepageReceptionist.TabIndex = 5;
            this.btnBackToHomepageReceptionist.Text = "Back";
            this.btnBackToHomepageReceptionist.UseVisualStyleBackColor = true;
            this.btnBackToHomepageReceptionist.Click += new System.EventHandler(this.btnBackToHomepageReceptionist_Click);
            // 
            // ReceptionistLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 257);
            this.Controls.Add(this.btnBackToHomepageReceptionist);
            this.Controls.Add(this.lblReceptionistPassword);
            this.Controls.Add(this.lblReceptionistUsername);
            this.Controls.Add(this.txtReceptionistPassword);
            this.Controls.Add(this.txtReceptionistUsername);
            this.Controls.Add(this.btnReceptionLogin);
            this.Name = "ReceptionistLogin";
            this.Text = "ReceptionistLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReceptionLogin;
        private System.Windows.Forms.TextBox txtReceptionistUsername;
        private System.Windows.Forms.TextBox txtReceptionistPassword;
        private System.Windows.Forms.Label lblReceptionistUsername;
        private System.Windows.Forms.Label lblReceptionistPassword;
        private System.Windows.Forms.Button btnBackToHomepageReceptionist;
    }
}