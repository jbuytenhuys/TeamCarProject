using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyClassLibrary;

public partial class Secure_SalesmanArchive : System.Web.UI.Page
{

    //var to store the primary key value of the record to be deleted
    Int32 CustomerID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the customer to be archived from the session objetive
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //event handler for the load event
        //get the number of the customer to be archived from the session object 
        //delete the record
        ArchiveCustomer();
        //redirect back to main page
        Response.Redirect("SalesmanHomepage.aspx");
    }

    void ArchiveCustomer()
    {
        //function to archive the selected record
        //create a new instance of the customer 
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        //find the record to archive
        CustomerBook.ThisCustomer.Find(CustomerID);
        //delete the record
        CustomerBook.Delete();
    }

        protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back to main page
        Response.Redirect("SalesmanHomepage.aspx");
    }


}