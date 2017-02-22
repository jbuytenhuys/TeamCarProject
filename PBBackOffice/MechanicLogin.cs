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
    public partial class MechanicLogin : Form
    {
        public MechanicLogin()
        {
            InitializeComponent();
        }
        //This is the code for the login button on the Mechanic Login Page.
        private void btnMechanicLogin_Click(object sender, EventArgs e)
        {
            //This creates a new instance of the class Mechanic Homepage.
            MechanicHomepage Login = new MechanicHomepage();
            //This shows the Mechanic Homepage
            Login.Show();
            //Hides this form Mechanic Login.
            this.Hide();
        }
        //This is the code for the back button located on the Mechanic Login Page.
        private void btnBackToHomepageMechanic_Click(object sender, EventArgs e)
        {
            //This creates a new instance of the class Homepage.
            Homepage BackToHomepageMechanic = new Homepage();
            //this shows the form Homepage.
            BackToHomepageMechanic.Show();
            //Hides this form MechanicHomepage.
            this.Hide();
        }

        private void MechanicLogin_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
