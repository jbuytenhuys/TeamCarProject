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
    public partial class ReceptionistHomepage : Form
    {
        public ReceptionistHomepage()
        {
            InitializeComponent();
        }

        //This is the code for the Logout Button on the Receptionist homepage.
        private void btnLogout_Click(object sender, EventArgs e)
        {
            //This creates a new instance of the class Homepage.
            Homepage redirectBack = new Homepage();
            //This shows the form 'Homepage'.
            redirectBack.Show();
            //This hides the form 'Receptionist Homepage'.
            this.Hide();
        }

    }
}