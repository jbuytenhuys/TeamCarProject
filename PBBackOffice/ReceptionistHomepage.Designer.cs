namespace PBBackOffice
{
    partial class ReceptionistHomepage
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnListAll = new System.Windows.Forms.Button();
            this.btnFiltercars = new System.Windows.Forms.Button();
            this.txtCarModel = new System.Windows.Forms.TextBox();
            this.txtNoOfSeats = new System.Windows.Forms.TextBox();
            this.txtColour = new System.Windows.Forms.TextBox();
            this.txtRegPlate = new System.Windows.Forms.TextBox();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.txtNoOfDoors = new System.Windows.Forms.TextBox();
            this.txtFilterCarModel = new System.Windows.Forms.TextBox();
            this.CMBFilterCarManufacturer = new System.Windows.Forms.ComboBox();
            this.txtFilterCarYear = new System.Windows.Forms.TextBox();
            this.lstBoxListCars = new System.Windows.Forms.ListBox();
            this.btnUpdateCar = new System.Windows.Forms.Button();
            this.btnArchive = new System.Windows.Forms.Button();
            this.lblCarNeedsRepair = new System.Windows.Forms.Label();
            this.chkboxCarNeedsRepair = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.CMBCarManufacturer = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(12, 27);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(101, 47);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnListAll
            // 
            this.btnListAll.Location = new System.Drawing.Point(451, 429);
            this.btnListAll.Name = "btnListAll";
            this.btnListAll.Size = new System.Drawing.Size(101, 47);
            this.btnListAll.TabIndex = 1;
            this.btnListAll.Text = "List all Cars";
            this.btnListAll.UseVisualStyleBackColor = true;
            
            // 
            // btnFiltercars
            // 
            this.btnFiltercars.Location = new System.Drawing.Point(73, 241);
            this.btnFiltercars.Name = "btnFiltercars";
            this.btnFiltercars.Size = new System.Drawing.Size(101, 47);
            this.btnFiltercars.TabIndex = 2;
            this.btnFiltercars.Text = "Filter Cars";
            this.btnFiltercars.UseVisualStyleBackColor = true;
            // 
            // txtCarModel
            // 
            this.txtCarModel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCarModel.Location = new System.Drawing.Point(750, 135);
            this.txtCarModel.Name = "txtCarModel";
            this.txtCarModel.Size = new System.Drawing.Size(325, 20);
            this.txtCarModel.TabIndex = 5;
            this.txtCarModel.Text = "Car Model";
            // 
            // txtNoOfSeats
            // 
            this.txtNoOfSeats.Location = new System.Drawing.Point(750, 224);
            this.txtNoOfSeats.Name = "txtNoOfSeats";
            this.txtNoOfSeats.Size = new System.Drawing.Size(325, 20);
            this.txtNoOfSeats.TabIndex = 6;
            this.txtNoOfSeats.Text = "Number of Seats";
            // 
            // txtColour
            // 
            this.txtColour.Location = new System.Drawing.Point(750, 267);
            this.txtColour.Name = "txtColour";
            this.txtColour.Size = new System.Drawing.Size(325, 20);
            this.txtColour.TabIndex = 7;
            this.txtColour.Text = "Colour";
            // 
            // txtRegPlate
            // 
            this.txtRegPlate.Location = new System.Drawing.Point(750, 307);
            this.txtRegPlate.Name = "txtRegPlate";
            this.txtRegPlate.Size = new System.Drawing.Size(325, 20);
            this.txtRegPlate.TabIndex = 8;
            this.txtRegPlate.Text = "Registration";
            // 
            // btnAddCar
            // 
            this.btnAddCar.Location = new System.Drawing.Point(766, 429);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(99, 47);
            this.btnAddCar.TabIndex = 11;
            this.btnAddCar.Text = "Add Car";
            this.btnAddCar.UseVisualStyleBackColor = true;
            // 
            // txtNoOfDoors
            // 
            this.txtNoOfDoors.Location = new System.Drawing.Point(750, 178);
            this.txtNoOfDoors.Name = "txtNoOfDoors";
            this.txtNoOfDoors.Size = new System.Drawing.Size(325, 20);
            this.txtNoOfDoors.TabIndex = 12;
            this.txtNoOfDoors.Text = "Number Of Doors";
            // 
            // txtFilterCarModel
            // 
            this.txtFilterCarModel.Location = new System.Drawing.Point(46, 178);
            this.txtFilterCarModel.Name = "txtFilterCarModel";
            this.txtFilterCarModel.Size = new System.Drawing.Size(183, 20);
            this.txtFilterCarModel.TabIndex = 13;
            this.txtFilterCarModel.Text = "Car Model";
            // 
            // CMBFilterCarManufacturer
            // 
            this.CMBFilterCarManufacturer.FormattingEnabled = true;
            this.CMBFilterCarManufacturer.Items.AddRange(new object[] {
            "test",
            "test2",
            "Test 3"});
            this.CMBFilterCarManufacturer.Location = new System.Drawing.Point(46, 135);
            this.CMBFilterCarManufacturer.Name = "CMBFilterCarManufacturer";
            this.CMBFilterCarManufacturer.Size = new System.Drawing.Size(183, 21);
            this.CMBFilterCarManufacturer.TabIndex = 14;
            this.CMBFilterCarManufacturer.Text = "Car Manufacturer";
            // 
            // txtFilterCarYear
            // 
            this.txtFilterCarYear.Location = new System.Drawing.Point(46, 215);
            this.txtFilterCarYear.Name = "txtFilterCarYear";
            this.txtFilterCarYear.Size = new System.Drawing.Size(183, 20);
            this.txtFilterCarYear.TabIndex = 15;
            this.txtFilterCarYear.Text = "Year";
            // 
            // lstBoxListCars
            // 
            this.lstBoxListCars.FormattingEnabled = true;
            this.lstBoxListCars.Location = new System.Drawing.Point(327, 99);
            this.lstBoxListCars.Name = "lstBoxListCars";
            this.lstBoxListCars.Size = new System.Drawing.Size(353, 303);
            this.lstBoxListCars.TabIndex = 16;
            // 
            // btnUpdateCar
            // 
            this.btnUpdateCar.Location = new System.Drawing.Point(871, 429);
            this.btnUpdateCar.Name = "btnUpdateCar";
            this.btnUpdateCar.Size = new System.Drawing.Size(99, 47);
            this.btnUpdateCar.TabIndex = 17;
            this.btnUpdateCar.Text = "Update";
            this.btnUpdateCar.UseVisualStyleBackColor = true;
            // 
            // btnArchive
            // 
            this.btnArchive.Location = new System.Drawing.Point(976, 429);
            this.btnArchive.Name = "btnArchive";
            this.btnArchive.Size = new System.Drawing.Size(99, 47);
            this.btnArchive.TabIndex = 18;
            this.btnArchive.Text = "Archive";
            this.btnArchive.UseVisualStyleBackColor = true;
            // 
            // lblCarNeedsRepair
            // 
            this.lblCarNeedsRepair.AutoSize = true;
            this.lblCarNeedsRepair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCarNeedsRepair.Location = new System.Drawing.Point(747, 348);
            this.lblCarNeedsRepair.Name = "lblCarNeedsRepair";
            this.lblCarNeedsRepair.Size = new System.Drawing.Size(103, 17);
            this.lblCarNeedsRepair.TabIndex = 25;
            this.lblCarNeedsRepair.Text = "Needs Repair?";
            // 
            // chkboxCarNeedsRepair
            // 
            this.chkboxCarNeedsRepair.AutoSize = true;
            this.chkboxCarNeedsRepair.Location = new System.Drawing.Point(871, 349);
            this.chkboxCarNeedsRepair.Name = "chkboxCarNeedsRepair";
            this.chkboxCarNeedsRepair.Size = new System.Drawing.Size(214, 17);
            this.chkboxCarNeedsRepair.TabIndex = 26;
            this.chkboxCarNeedsRepair.Text = "Check for Yes, leave unchecked for No";
            this.chkboxCarNeedsRepair.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(747, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Sold?";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(871, 383);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(214, 17);
            this.checkBox1.TabIndex = 28;
            this.checkBox1.Text = "Check for Yes, leave unchecked for No";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // CMBCarManufacturer
            // 
            this.CMBCarManufacturer.FormattingEnabled = true;
            this.CMBCarManufacturer.Items.AddRange(new object[] {
            "Volkswagon",
            "Land Rover",
            "Jaguar",
            "Mercedes",
            "Mini",
            "BMW",
            "Ford",
            "Nissan"});
            this.CMBCarManufacturer.Location = new System.Drawing.Point(750, 99);
            this.CMBCarManufacturer.Name = "CMBCarManufacturer";
            this.CMBCarManufacturer.Size = new System.Drawing.Size(325, 21);
            this.CMBCarManufacturer.TabIndex = 29;
            this.CMBCarManufacturer.Text = "Car Manufacturer";
            // 
            // ReceptionistHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 609);
            this.Controls.Add(this.CMBCarManufacturer);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkboxCarNeedsRepair);
            this.Controls.Add(this.lblCarNeedsRepair);
            this.Controls.Add(this.btnArchive);
            this.Controls.Add(this.btnUpdateCar);
            this.Controls.Add(this.lstBoxListCars);
            this.Controls.Add(this.txtFilterCarYear);
            this.Controls.Add(this.CMBFilterCarManufacturer);
            this.Controls.Add(this.txtFilterCarModel);
            this.Controls.Add(this.txtNoOfDoors);
            this.Controls.Add(this.btnAddCar);
            this.Controls.Add(this.txtRegPlate);
            this.Controls.Add(this.txtColour);
            this.Controls.Add(this.txtNoOfSeats);
            this.Controls.Add(this.txtCarModel);
            this.Controls.Add(this.btnFiltercars);
            this.Controls.Add(this.btnListAll);
            this.Controls.Add(this.btnLogout);
            this.Name = "ReceptionistHomepage";
            this.Text = "Receptionist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnListAll;
        private System.Windows.Forms.Button btnFiltercars;
        private System.Windows.Forms.TextBox txtCarModel;
        private System.Windows.Forms.TextBox txtNoOfSeats;
        private System.Windows.Forms.TextBox txtColour;
        private System.Windows.Forms.TextBox txtRegPlate;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.TextBox txtNoOfDoors;
        private System.Windows.Forms.TextBox txtFilterCarModel;
        private System.Windows.Forms.ComboBox CMBFilterCarManufacturer;
        private System.Windows.Forms.TextBox txtFilterCarYear;
        private System.Windows.Forms.ListBox lstBoxListCars;
        private System.Windows.Forms.Button btnUpdateCar;
        private System.Windows.Forms.Button btnArchive;
        private System.Windows.Forms.Label lblCarNeedsRepair;
        private System.Windows.Forms.CheckBox chkboxCarNeedsRepair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox CMBCarManufacturer;
    }
}