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
    public partial class ReceptionistLogin : Form
    {
        public ReceptionistLogin()
        {
            InitializeComponent();
        }

        //This is the code for the login button on the Receptionist Login Page.
        private void btnReceptionistLogin_Click(object sender, EventArgs e)
        {
            //This creates a new instance of the class Receptionist Homepage.
            ReceptionistHomepage redirect = new ReceptionistHomepage();
            //This shows the ReceptionistHomepage.
            redirect.Show();
            //Hides this form (Receptionist Login).
            this.Hide();
        }
        //This is the code for the back button located on the recepionist Login Page.
        private void btnBackToHomepageReceptionist_Click(object sender, EventArgs e)
        {
            //This creates a new instance of the class Homepage.
            Homepage BackToHomepageReceptionist = new Homepage();
            //this shows the form Homepage.
            BackToHomepageReceptionist.Show();
            //Hides this form (Receptionist Homepage).
            this.Hide();
        }
    }
}
