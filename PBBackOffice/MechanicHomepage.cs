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
    public partial class MechanicHomepage : Form
    {
        public MechanicHomepage()
        {
            InitializeComponent();
        }
        //This is the code for the Logout Button on the Mechanic homepage.
        private void btnMechanicBack_Click(object sender, EventArgs e)
        {
            //This creates a new instance of the class Homepage.
            Homepage GoBack = new Homepage();
            //This shows the form 'Homepage'.
            GoBack.Show();
            //This hides the form 'Mechanic Homepage'.
            this.Hide();
        }

        private void btnFilterRepair_Click(object sender, EventArgs e)
        {

        }
    }
}
