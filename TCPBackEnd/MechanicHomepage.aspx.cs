using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MechanicHomepage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayRepairs();
        }
    }

    void DisplayRepairs()
    {
        MyClassLibrary.clsCarRepairsCollection Repairs = new MyClassLibrary.clsCarRepairsCollection();
        lstMechanicRepairs.DataSource = Repairs.CarRepairList;
        lstMechanicRepairs.DataValueField = "RepairID";
        lstMechanicRepairs.DataTextField = "PartRequired";
        lstMechanicRepairs.DataBind();
    }


    protected void btnMechanicLogout_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }


    protected void ddlMechanicFilterBy_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void txtMechanicFilter_Click(object sender, EventArgs e)
    {

    }

    protected void btnMechanicFilter_Click(object sender, EventArgs e)
    {

    }

    protected void lstMechanicRepairs_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnMechanicListAll_Click(object sender, EventArgs e)
    {

    }

    protected void txtMechanicRepairID_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtMechanicDeadlineDate_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtMechanicPartRequired_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtMechanicPartPrice_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnMechanicAddRepair_Click(object sender, EventArgs e)
    {

    }

    protected void btnMechanicUpdateRepair_Click(object sender, EventArgs e)
    {

    }

    protected void btnMechanicDeleteRepair_Click(object sender, EventArgs e)
    {

    }

    
}