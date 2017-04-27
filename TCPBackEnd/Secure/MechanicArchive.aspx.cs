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
        CarRepairID = Convert.ToInt32(Session["CarRepairID"]); 
    }
    void ArchiveRepair()
    {
        clsCarRepairsCollection CarRepair = new clsCarRepairsCollection();
        CarRepair.ThisCarRepair.Find(CarRepairID);
        CarRepair.Archive();
    }

    protected void btnMechanicDeleteYes_Click(object sender, EventArgs e)
    {
        ArchiveRepair();
        Response.Redirect("MechanicHomepage.aspx");
    }

    protected void btnMechanicDeleteNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("MechanicHomepage.aspx");
    }
}