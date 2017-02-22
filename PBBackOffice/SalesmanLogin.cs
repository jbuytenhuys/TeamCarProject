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
    public partial class SalesmanLogin : Form
    {
        //This is the code for the Login Button on the salesman homepage homepage.
        public SalesmanLogin()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //this code redirects the salesman homepage to the main homepage. 
            SalesmanHomepage redirect = new SalesmanHomepage();
            redirect.Show();
            //this code hides the login page
            this.Hide();
        }
        //this code 
        private void btnBackToHomepageSalesman_Click(object sender, EventArgs e)
        {
            Homepage BackToHomepageSalesman = new Homepage();
            BackToHomepageSalesman.Show();
            //this code hides the salesman homepage
            this.Hide();
        }

        private void SalesmanLogin_Load(object sender, EventArgs e)
        {

        }
    }
}

