namespace PBBackOffice
{
    partial class SalesmanHomepage
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
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnCopyCustomer = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnArchive = new System.Windows.Forms.Button();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblAddress1 = new System.Windows.Forms.Label();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.lblPostCode = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.txtPostCode = new System.Windows.Forms.TextBox();
            this.lstBox = new System.Windows.Forms.ListBox();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.txtHouseNo = new System.Windows.Forms.TextBox();
            this.lblHouseNo = new System.Windows.Forms.Label();
            this.txtDateAdded = new System.Windows.Forms.TextBox();
            this.lblCustomerDateAdded = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(799, 447);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(160, 23);
            this.btnAddCustomer.TabIndex = 0;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnNewCustomer_Click);
            // 
            // btnCopyCustomer
            // 
            this.btnCopyCustomer.Location = new System.Drawing.Point(380, 320);
            this.btnCopyCustomer.Name = "btnCopyCustomer";
            this.btnCopyCustomer.Size = new System.Drawing.Size(154, 23);
            this.btnCopyCustomer.TabIndex = 1;
            this.btnCopyCustomer.Text = "Copy Customer";
            this.btnCopyCustomer.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(965, 447);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnArchive
            // 
            this.btnArchive.Location = new System.Drawing.Point(412, 349);
            this.btnArchive.Name = "btnArchive";
            this.btnArchive.Size = new System.Drawing.Size(75, 28);
            this.btnArchive.TabIndex = 3;
            this.btnArchive.Text = "Archive";
            this.btnArchive.UseVisualStyleBackColor = true;
            this.btnArchive.Click += new System.EventHandler(this.btnArchive_Click);
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(704, 81);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(65, 13);
            this.lblCustomerID.TabIndex = 4;
            this.lblCustomerID.Text = "Customer ID";
            this.lblCustomerID.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(812, 74);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(271, 20);
            this.txtCustomerID.TabIndex = 5;
            this.txtCustomerID.Text = "6598455";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(704, 122);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 6;
            this.lblFirstName.Text = "First Name";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(692, 209);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(68, 13);
            this.lblDOB.TabIndex = 7;
            this.lblDOB.Text = "Date Of Birth";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(702, 162);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 8;
            this.lblLastName.Text = "Last Name";
            // 
            // lblAddress1
            // 
            this.lblAddress1.AutoSize = true;
            this.lblAddress1.Location = new System.Drawing.Point(681, 281);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(80, 13);
            this.lblAddress1.TabIndex = 9;
            this.lblAddress1.Text = "Address Line 1 ";
            this.lblAddress1.Click += new System.EventHandler(this.lblAddress1_Click);
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.Location = new System.Drawing.Point(672, 325);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(123, 13);
            this.lblAddress2.TabIndex = 10;
            this.lblAddress2.Text = "Address Line 2 (optional)";
            this.lblAddress2.Click += new System.EventHandler(this.lblAddress2_Click);
            // 
            // lblPostCode
            // 
            this.lblPostCode.AutoSize = true;
            this.lblPostCode.Location = new System.Drawing.Point(702, 364);
            this.lblPostCode.Name = "lblPostCode";
            this.lblPostCode.Size = new System.Drawing.Size(53, 13);
            this.lblPostCode.TabIndex = 11;
            this.lblPostCode.Text = "PostCode";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(812, 115);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(271, 20);
            this.txtFirstName.TabIndex = 13;
            this.txtFirstName.Text = "Zad";
            // 
            // TxtLastName
            // 
            this.TxtLastName.Location = new System.Drawing.Point(812, 159);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(271, 20);
            this.TxtLastName.TabIndex = 14;
            this.TxtLastName.Text = "Ali";
            // 
            // txtDOB
            // 
            this.txtDOB.Location = new System.Drawing.Point(812, 206);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(271, 20);
            this.txtDOB.TabIndex = 15;
            this.txtDOB.Text = "20/03/1996";
            // 
            // txtAddress1
            // 
            this.txtAddress1.Location = new System.Drawing.Point(812, 278);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(271, 20);
            this.txtAddress1.TabIndex = 16;
            this.txtAddress1.Text = "20 Austen Avenue";
            // 
            // txtAddress2
            // 
            this.txtAddress2.Location = new System.Drawing.Point(812, 320);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(271, 20);
            this.txtAddress2.TabIndex = 17;
            // 
            // txtPostCode
            // 
            this.txtPostCode.Location = new System.Drawing.Point(812, 357);
            this.txtPostCode.Name = "txtPostCode";
            this.txtPostCode.Size = new System.Drawing.Size(271, 20);
            this.txtPostCode.TabIndex = 18;
            this.txtPostCode.Text = "NG7 6PE";
            // 
            // lstBox
            // 
            this.lstBox.FormattingEnabled = true;
            this.lstBox.Location = new System.Drawing.Point(253, 89);
            this.lstBox.Name = "lstBox";
            this.lstBox.Size = new System.Drawing.Size(397, 225);
            this.lstBox.TabIndex = 20;
            // 
            // cmbFilter
            // 
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Items.AddRange(new object[] {
            "Customer ID",
            "First Name",
            "Last Name",
            "Date of Birth",
            ""});
            this.cmbFilter.Location = new System.Drawing.Point(102, 105);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(121, 21);
            this.cmbFilter.TabIndex = 21;
            this.cmbFilter.Text = "Filter By";
            this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.cmbFilter_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(125, 204);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(111, 169);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(100, 20);
            this.txtFilter.TabIndex = 23;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(452, 467);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 24;
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(125, 21);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 23);
            this.btnHome.TabIndex = 25;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // txtHouseNo
            // 
            this.txtHouseNo.Location = new System.Drawing.Point(812, 242);
            this.txtHouseNo.Name = "txtHouseNo";
            this.txtHouseNo.Size = new System.Drawing.Size(271, 20);
            this.txtHouseNo.TabIndex = 26;
            this.txtHouseNo.Text = "20";
            // 
            // lblHouseNo
            // 
            this.lblHouseNo.AutoSize = true;
            this.lblHouseNo.Location = new System.Drawing.Point(691, 245);
            this.lblHouseNo.Name = "lblHouseNo";
            this.lblHouseNo.Size = new System.Drawing.Size(78, 13);
            this.lblHouseNo.TabIndex = 27;
            this.lblHouseNo.Text = "House Number";
            this.lblHouseNo.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtDateAdded
            // 
            this.txtDateAdded.Location = new System.Drawing.Point(799, 403);
            this.txtDateAdded.Name = "txtDateAdded";
            this.txtDateAdded.Size = new System.Drawing.Size(271, 20);
            this.txtDateAdded.TabIndex = 29;
            this.txtDateAdded.Text = "20/03/2016";
            // 
            // lblCustomerDateAdded
            // 
            this.lblCustomerDateAdded.AutoSize = true;
            this.lblCustomerDateAdded.Location = new System.Drawing.Point(672, 410);
            this.lblCustomerDateAdded.Name = "lblCustomerDateAdded";
            this.lblCustomerDateAdded.Size = new System.Drawing.Size(111, 13);
            this.lblCustomerDateAdded.TabIndex = 28;
            this.lblCustomerDateAdded.Text = "Customer Date Added";
            // 
            // SalesmanHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 658);
            this.Controls.Add(this.txtDateAdded);
            this.Controls.Add(this.lblCustomerDateAdded);
            this.Controls.Add(this.lblHouseNo);
            this.Controls.Add(this.txtHouseNo);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.lstBox);
            this.Controls.Add(this.txtPostCode);
            this.Controls.Add(this.txtAddress2);
            this.Controls.Add(this.txtAddress1);
            this.Controls.Add(this.txtDOB);
            this.Controls.Add(this.TxtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblPostCode);
            this.Controls.Add(this.lblAddress2);
            this.Controls.Add(this.lblAddress1);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.btnArchive);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCopyCustomer);
            this.Controls.Add(this.btnAddCustomer);
            this.Name = "SalesmanHomepage";
            this.Text = "SalesmanHomepage";
            this.Load += new System.EventHandler(this.SalesmanHomepage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnCopyCustomer;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnArchive;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblAddress1;
        private System.Windows.Forms.Label lblAddress2;
        private System.Windows.Forms.Label lblPostCode;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox TxtLastName;
        private System.Windows.Forms.TextBox txtDOB;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.TextBox txtPostCode;
        private System.Windows.Forms.ListBox lstBox;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.TextBox txtHouseNo;
        private System.Windows.Forms.Label lblHouseNo;
        private System.Windows.Forms.TextBox txtDateAdded;
        private System.Windows.Forms.Label lblCustomerDateAdded;
    }
}