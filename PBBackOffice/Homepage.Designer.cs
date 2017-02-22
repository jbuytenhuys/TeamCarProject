namespace PBBackOffice
{
    partial class Homepage
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
            this.btnReceptionist = new System.Windows.Forms.Button();
            this.btnSalesman = new System.Windows.Forms.Button();
            this.btnMechanic = new System.Windows.Forms.Button();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReceptionist
            // 
            this.btnReceptionist.Location = new System.Drawing.Point(366, 150);
            this.btnReceptionist.Name = "btnReceptionist";
            this.btnReceptionist.Size = new System.Drawing.Size(138, 58);
            this.btnReceptionist.TabIndex = 1;
            this.btnReceptionist.Text = "Receptionist";
            this.btnReceptionist.UseVisualStyleBackColor = true;
            this.btnReceptionist.Click += new System.EventHandler(this.btnReceptionist_Click);
            // 
            // btnSalesman
            // 
            this.btnSalesman.Location = new System.Drawing.Point(75, 150);
            this.btnSalesman.Name = "btnSalesman";
            this.btnSalesman.Size = new System.Drawing.Size(138, 58);
            this.btnSalesman.TabIndex = 3;
            this.btnSalesman.Text = "Salesman";
            this.btnSalesman.UseVisualStyleBackColor = true;
            this.btnSalesman.Click += new System.EventHandler(this.btnSalesman_Click);
            // 
            // btnMechanic
            // 
            this.btnMechanic.Location = new System.Drawing.Point(366, 38);
            this.btnMechanic.Name = "btnMechanic";
            this.btnMechanic.Size = new System.Drawing.Size(138, 57);
            this.btnMechanic.TabIndex = 4;
            this.btnMechanic.Text = "Mechanic";
            this.btnMechanic.UseVisualStyleBackColor = true;
            this.btnMechanic.Click += new System.EventHandler(this.btnMechanic_Click);
            // 
            // btnSupplier
            // 
            this.btnSupplier.Location = new System.Drawing.Point(75, 38);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(138, 57);
            this.btnSupplier.TabIndex = 5;
            this.btnSupplier.Text = "Supplier Consultant";
            this.btnSupplier.UseVisualStyleBackColor = true;
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 262);
            this.Controls.Add(this.btnSupplier);
            this.Controls.Add(this.btnMechanic);
            this.Controls.Add(this.btnSalesman);
            this.Controls.Add(this.btnReceptionist);
            this.Name = "Homepage";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnReceptionist;
        private System.Windows.Forms.Button btnSalesman;
        private System.Windows.Forms.Button btnMechanic;
        private System.Windows.Forms.Button btnSupplier;
    }
}

