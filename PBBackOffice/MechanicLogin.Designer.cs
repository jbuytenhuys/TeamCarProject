namespace PBBackOffice
{
    partial class MechanicLogin
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblMechanicUsername = new System.Windows.Forms.Label();
            this.lblMechanicPassword = new System.Windows.Forms.Label();
            this.btnMechanicLogin = new System.Windows.Forms.Button();
            this.btnBackToHomepageMechanic = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(112, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(112, 99);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(220, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // lblMechanicUsername
            // 
            this.lblMechanicUsername.AutoSize = true;
            this.lblMechanicUsername.Location = new System.Drawing.Point(39, 71);
            this.lblMechanicUsername.Name = "lblMechanicUsername";
            this.lblMechanicUsername.Size = new System.Drawing.Size(55, 13);
            this.lblMechanicUsername.TabIndex = 2;
            this.lblMechanicUsername.Text = "Username";
            // 
            // lblMechanicPassword
            // 
            this.lblMechanicPassword.AutoSize = true;
            this.lblMechanicPassword.Location = new System.Drawing.Point(39, 106);
            this.lblMechanicPassword.Name = "lblMechanicPassword";
            this.lblMechanicPassword.Size = new System.Drawing.Size(53, 13);
            this.lblMechanicPassword.TabIndex = 3;
            this.lblMechanicPassword.Text = "Password";
            // 
            // btnMechanicLogin
            // 
            this.btnMechanicLogin.Location = new System.Drawing.Point(145, 176);
            this.btnMechanicLogin.Name = "btnMechanicLogin";
            this.btnMechanicLogin.Size = new System.Drawing.Size(121, 31);
            this.btnMechanicLogin.TabIndex = 4;
            this.btnMechanicLogin.Text = "Login";
            this.btnMechanicLogin.UseVisualStyleBackColor = true;
            this.btnMechanicLogin.Click += new System.EventHandler(this.btnMechanicLogin_Click);
            // 
            // btnBackToHomepageMechanic
            // 
            this.btnBackToHomepageMechanic.Location = new System.Drawing.Point(26, 12);
            this.btnBackToHomepageMechanic.Name = "btnBackToHomepageMechanic";
            this.btnBackToHomepageMechanic.Size = new System.Drawing.Size(86, 24);
            this.btnBackToHomepageMechanic.TabIndex = 5;
            this.btnBackToHomepageMechanic.Text = "Back";
            this.btnBackToHomepageMechanic.UseVisualStyleBackColor = true;
            this.btnBackToHomepageMechanic.Click += new System.EventHandler(this.btnBackToHomepageMechanic_Click);
            // 
            // MechanicLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 404);
            this.Controls.Add(this.btnBackToHomepageMechanic);
            this.Controls.Add(this.btnMechanicLogin);
            this.Controls.Add(this.lblMechanicPassword);
            this.Controls.Add(this.lblMechanicUsername);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "MechanicLogin";
            this.Text = "MechanicLogin";
            this.Load += new System.EventHandler(this.MechanicLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblMechanicUsername;
        private System.Windows.Forms.Label lblMechanicPassword;
        private System.Windows.Forms.Button btnMechanicLogin;
        private System.Windows.Forms.Button btnBackToHomepageMechanic;
    }
}