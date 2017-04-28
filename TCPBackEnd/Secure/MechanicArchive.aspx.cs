using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyClassLibrary;

public partial class MechanicDelete : System.Web.UI.Page
{
    Int32 CarRepairID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //assign session value to the carRepairID variable
        CarRepairID = Convert.ToInt32(Session["CarRepairID"]); 
    }
    //fucntion for archiving repair
    void ArchiveRepair()
    {
        //create an instance
        clsCarRepairsCollection CarRepair = new clsCarRepairsCollection();
        //run CarRepairID through the Find method
        CarRepair.ThisCarRepair.Find(CarRepairID);
        //call Archive method
        CarRepair.Archive();
    }

    protected void btnMechanicDeleteYes_Click(object sender, EventArgs e)
    {
        //Call Archive Function
        ArchiveRepair();
        //redirect to the Mechanic homepage
        Response.Redirect("MechanicHomepage.aspx");
    }

    protected void btnMechanicDeleteNo_Click(object sender, EventArgs e)
    {
        //redirect to the Mechanic homepage
        Response.Redirect("MechanicHomepage.aspx");
    }
}