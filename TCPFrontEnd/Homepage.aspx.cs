using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Homepage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void btnHatchbacks_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Hatchbacks.aspx");
    }

    protected void btnSports_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Sports.aspx");
    }

    protected void btnCoupe_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Coupe.aspx");
    }

    protected void btn4x4_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("4x4.aspx");
    }

    protected void btnAboutUs_Click(object sender, EventArgs e)
    {
        Response.Redirect("AboutUs.aspx");
    }
}