using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBBackOffice
{
    public partial class SalesmanHomepage : Form
    {
        public SalesmanHomepage()
        {
            InitializeComponent();
        }

        private void SalesmanHomepage_Load(object sender, EventArgs e)
        {

        }
        //this code is the label message when customer is added,updated, or archived from the system.
        private void label1_Click(object sender, EventArgs e)
        {

        }
        //this code redirects back to main homepage. 
        private void btnHome_Click(object sender, EventArgs e)
        {
            //redirects back to homepage
            Homepage GoBackToHomepage = new Homepage();
            GoBackToHomepage.Show();
            this.Hide();

        }
        //this code is the customerID which is automatically generated
        private void txtCustomerID_TextChanged(object sender, EventArgs e)
        {

        }
        //this code is the combo box which the user can select which fields they want to search the data by. i.e first name or address. 
        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //this code will add a new customer to the system 
        private void btnNewCustomer_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblAddress2_Click(object sender, EventArgs e)
        {

        }

        private void lblAddress1_Click(object sender, EventArgs e)
        {

        }

        private void btnArchive_Click(object sender, EventArgs e)
        {

        }
    }
}
