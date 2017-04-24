using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyClassLibrary;

public partial class Secure_ReceptionistDelete : System.Web.UI.Page
{
    Int32 CarID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be deleted from the session object.
        CarID = Convert.ToInt32(Session["CarID"]);
    }

    void DeleteCar()
    {
        //function to delete the selected record.

        //create a new instance
        clsCarsCollection Cars = new clsCarsCollection();
        //find the record to delete
        Cars.ThisCar.Find(CarID);
        //Delete the record
        Cars.Delete();

    }
    
    void ArchiveAndDeleteCar()
    {
        //function to Archive and delete the selected record.

        //create a new instance
        clsCarsCollection Cars = new clsCarsCollection();
        //find the record to delete
        Cars.ThisCar.Find(CarID);
        //Delete the record
        Cars.ArchiveAndDelete();
    }

    protected void btnDeleteYes_Click(object sender, EventArgs e)
    {
        //delete the car
        ArchiveAndDeleteCar();
        //redirect back to receptionist homepage
        Response.Redirect("ReceptionistHomepage.aspx");
    }

    protected void btnDeleteNo_Click(object sender, EventArgs e)
    {
        //redirect back to receptionist homepage
        Response.Redirect("ReceptionistHomepage.aspx");
    }
}