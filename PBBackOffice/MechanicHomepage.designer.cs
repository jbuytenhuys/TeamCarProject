namespace PBBackOffice
{
    partial class MechanicHomepage
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
            this.txtRepairID = new System.Windows.Forms.TextBox();
            this.txtCarModelRepair = new System.Windows.Forms.TextBox();
            this.txtDeadlineDate = new System.Windows.Forms.TextBox();
            this.txtPartRequired = new System.Windows.Forms.TextBox();
            this.txtPartPrice = new System.Windows.Forms.TextBox();
            this.txtCarID = new System.Windows.Forms.TextBox();
            this.chkRepairStatus = new System.Windows.Forms.CheckBox();
            this.cmbCarManufacturuerRepair = new System.Windows.Forms.ComboBox();
            this.btnAddRepair = new System.Windows.Forms.Button();
            this.btnUpdateRepair = new System.Windows.Forms.Button();
            this.lstRepairs = new System.Windows.Forms.ListBox();
            this.cmbFieldNames = new System.Windows.Forms.ComboBox();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.btnMechanicLogout = new System.Windows.Forms.Button();
            this.btnListAllRepairs = new System.Windows.Forms.Button();
            this.btnFilterRepair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRepairID
            // 
            this.txtRepairID.Location = new System.Drawing.Point(795, 100);
            this.txtRepairID.Name = "txtRepairID";
            this.txtRepairID.ReadOnly = true;
            this.txtRepairID.Size = new System.Drawing.Size(284, 20);
            this.txtRepairID.TabIndex = 0;
            this.txtRepairID.Text = "RepairID";
            // 
            // txtCarModelRepair
            // 
            this.txtCarModelRepair.Location = new System.Drawing.Point(796, 153);
            this.txtCarModelRepair.Name = "txtCarModelRepair";
            this.txtCarModelRepair.Size = new System.Drawing.Size(283, 20);
            this.txtCarModelRepair.TabIndex = 2;
            this.txtCarModelRepair.Text = "Car Model";
            // 
            // txtDeadlineDate
            // 
            this.txtDeadlineDate.Location = new System.Drawing.Point(797, 179);
            this.txtDeadlineDate.Name = "txtDeadlineDate";
            this.txtDeadlineDate.Size = new System.Drawing.Size(284, 20);
            this.txtDeadlineDate.TabIndex = 3;
            this.txtDeadlineDate.Text = "Deadline Date";
            // 
            // txtPartRequired
            // 
            this.txtPartRequired.Location = new System.Drawing.Point(796, 205);
            this.txtPartRequired.Name = "txtPartRequired";
            this.txtPartRequired.Size = new System.Drawing.Size(285, 20);
            this.txtPartRequired.TabIndex = 4;
            this.txtPartRequired.Text = "Part Required";
            // 
            // txtPartPrice
            // 
            this.txtPartPrice.Location = new System.Drawing.Point(796, 231);
            this.txtPartPrice.Name = "txtPartPrice";
            this.txtPartPrice.Size = new System.Drawing.Size(285, 20);
            this.txtPartPrice.TabIndex = 5;
            this.txtPartPrice.Text = "Part Price";
            // 
            // txtCarID
            // 
            this.txtCarID.Location = new System.Drawing.Point(796, 257);
            this.txtCarID.Name = "txtCarID";
            this.txtCarID.Size = new System.Drawing.Size(285, 20);
            this.txtCarID.TabIndex = 6;
            this.txtCarID.Text = "CarID";
            // 
            // chkRepairStatus
            // 
            this.chkRepairStatus.AutoSize = true;
            this.chkRepairStatus.Location = new System.Drawing.Point(795, 283);
            this.chkRepairStatus.Name = "chkRepairStatus";
            this.chkRepairStatus.Size = new System.Drawing.Size(90, 17);
            this.chkRepairStatus.TabIndex = 7;
            this.chkRepairStatus.Text = "Repair Status";
            this.chkRepairStatus.UseVisualStyleBackColor = true;
            // 
            // cmbCarManufacturuerRepair
            // 
            this.cmbCarManufacturuerRepair.FormattingEnabled = true;
            this.cmbCarManufacturuerRepair.Items.AddRange(new object[] {
            "Seat",
            "BMW",
            "Mercedes",
            "Audi",
            "Nissan"});
            this.cmbCarManufacturuerRepair.Location = new System.Drawing.Point(795, 126);
            this.cmbCarManufacturuerRepair.Name = "cmbCarManufacturuerRepair";
            this.cmbCarManufacturuerRepair.Size = new System.Drawing.Size(284, 21);
            this.cmbCarManufacturuerRepair.TabIndex = 8;
            this.cmbCarManufacturuerRepair.Text = "Car Manufacturer";
            // 
            // btnAddRepair
            // 
            this.btnAddRepair.Location = new System.Drawing.Point(795, 306);
            this.btnAddRepair.Name = "btnAddRepair";
            this.btnAddRepair.Size = new System.Drawing.Size(140, 37);
            this.btnAddRepair.TabIndex = 9;
            this.btnAddRepair.Text = "Add Repair";
            this.btnAddRepair.UseVisualStyleBackColor = true;
            // 
            // btnUpdateRepair
            // 
            this.btnUpdateRepair.Location = new System.Drawing.Point(939, 307);
            this.btnUpdateRepair.Name = "btnUpdateRepair";
            this.btnUpdateRepair.Size = new System.Drawing.Size(140, 36);
            this.btnUpdateRepair.TabIndex = 10;
            this.btnUpdateRepair.Text = "Update Repair";
            this.btnUpdateRepair.UseVisualStyleBackColor = true;
            // 
            // lstRepairs
            // 
            this.lstRepairs.FormattingEnabled = true;
            this.lstRepairs.Location = new System.Drawing.Point(404, 100);
            this.lstRepairs.Name = "lstRepairs";
            this.lstRepairs.Size = new System.Drawing.Size(303, 303);
            this.lstRepairs.TabIndex = 11;
            // 
            // cmbFieldNames
            // 
            this.cmbFieldNames.FormattingEnabled = true;
            this.cmbFieldNames.Items.AddRange(new object[] {
            "Car Manufacturer",
            "Car Model",
            "Deadline Date",
            "Part Required",
            "Part Price"});
            this.cmbFieldNames.Location = new System.Drawing.Point(100, 99);
            this.cmbFieldNames.Name = "cmbFieldNames";
            this.cmbFieldNames.Size = new System.Drawing.Size(180, 21);
            this.cmbFieldNames.TabIndex = 12;
            this.cmbFieldNames.Text = "Filter by";
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(100, 148);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(180, 20);
            this.txtKeyword.TabIndex = 13;
            this.txtKeyword.Text = "Keyword filter";
            // 
            // btnMechanicLogout
            // 
            this.btnMechanicLogout.Location = new System.Drawing.Point(22, 16);
            this.btnMechanicLogout.Name = "btnMechanicLogout";
            this.btnMechanicLogout.Size = new System.Drawing.Size(135, 45);
            this.btnMechanicLogout.TabIndex = 14;
            this.btnMechanicLogout.Text = "Logout";
            this.btnMechanicLogout.UseVisualStyleBackColor = true;
            this.btnMechanicLogout.Click += new System.EventHandler(this.btnMechanicBack_Click);
            // 
            // btnListAllRepairs
            // 
            this.btnListAllRepairs.Location = new System.Drawing.Point(468, 428);
            this.btnListAllRepairs.Name = "btnListAllRepairs";
            this.btnListAllRepairs.Size = new System.Drawing.Size(182, 39);
            this.btnListAllRepairs.TabIndex = 15;
            this.btnListAllRepairs.Text = "List All Repairs";
            this.btnListAllRepairs.UseVisualStyleBackColor = true;
            // 
            // btnFilterRepair
            // 
            this.btnFilterRepair.Location = new System.Drawing.Point(100, 189);
            this.btnFilterRepair.Name = "btnFilterRepair";
            this.btnFilterRepair.Size = new System.Drawing.Size(137, 36);
            this.btnFilterRepair.TabIndex = 16;
            this.btnFilterRepair.Text = "Filter";
            this.btnFilterRepair.UseVisualStyleBackColor = true;
            this.btnFilterRepair.Click += new System.EventHandler(this.btnFilterRepair_Click);
            // 
            // MechanicHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 627);
            this.Controls.Add(this.btnFilterRepair);
            this.Controls.Add(this.btnListAllRepairs);
            this.Controls.Add(this.btnMechanicLogout);
            this.Controls.Add(this.txtKeyword);
            this.Controls.Add(this.cmbFieldNames);
            this.Controls.Add(this.lstRepairs);
            this.Controls.Add(this.btnUpdateRepair);
            this.Controls.Add(this.btnAddRepair);
            this.Controls.Add(this.cmbCarManufacturuerRepair);
            this.Controls.Add(this.chkRepairStatus);
            this.Controls.Add(this.txtCarID);
            this.Controls.Add(this.txtPartPrice);
            this.Controls.Add(this.txtPartRequired);
            this.Controls.Add(this.txtDeadlineDate);
            this.Controls.Add(this.txtCarModelRepair);
            this.Controls.Add(this.txtRepairID);
            this.Name = "MechanicHomepage";
            this.Text = "MechanicHomepage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRepairID;
        private System.Windows.Forms.TextBox txtCarModelRepair;
        private System.Windows.Forms.TextBox txtDeadlineDate;
        private System.Windows.Forms.TextBox txtPartRequired;
        private System.Windows.Forms.TextBox txtPartPrice;
        private System.Windows.Forms.TextBox txtCarID;
        private System.Windows.Forms.CheckBox chkRepairStatus;
        private System.Windows.Forms.ComboBox cmbCarManufacturuerRepair;
        private System.Windows.Forms.Button btnAddRepair;
        private System.Windows.Forms.Button btnUpdateRepair;
        private System.Windows.Forms.ListBox lstRepairs;
        private System.Windows.Forms.ComboBox cmbFieldNames;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Button btnMechanicLogout;
        private System.Windows.Forms.Button btnListAllRepairs;
        private System.Windows.Forms.Button btnFilterRepair;
    }
}