using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyClassLibrary;

namespace PBBackOffice
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
            
        }

 
        private void btnSalesman_Click(object sender, EventArgs e)
        {
            //This creates
            SalesmanLogin SalesmanLoginpage = new SalesmanLogin();
            SalesmanLoginpage.Show();
            this.Hide();
        }

        //This is the code for the button to redirect the user the Recptionist Homepage.
        public void btnReceptionist_Click(object sender, EventArgs e)
        {
            //This creates a new instance of the class Receptionist Login.
            ReceptionistLogin Login = new ReceptionistLogin();
            //This shows the form 'Receptionist Login'.
            Login.Show();
            //This hides the form 'Homepage'.
            this.Hide();
        }

        private void btnMechanic_Click(object sender, EventArgs e)
        {
            //This creates a new instance of the class Mechanic Login.
            MechanicLogin MechanicLoginpage = new MechanicLogin();
            //This shows the form 'Mechanic Login'.
            MechanicLoginpage.Show();
            //This hides the form 'Homepage'.
            this.Hide();
        }

        private void btnSupplier_Click(object sender, EventArgs e) // Once clicked this redirects the user to 'supplier homepage'
        {
            FormSupplier redirect = new FormSupplier(); // This redirects to 'supplier homepage'
            redirect.Show();//Form 'Supplier' is shown.
            this.Hide(); // this hides the homepage form
        }
    }
}
