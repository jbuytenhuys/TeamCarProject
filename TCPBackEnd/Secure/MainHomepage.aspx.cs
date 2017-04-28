using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MainHomepage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnMechanicHomepage_Click(object sender, EventArgs e)
    {
        Response.Redirect("MechanicHomepage.aspx");
    }

    protected void btnReceptionistHomepage_Click(object sender, EventArgs e)
    {
        Response.Redirect("ReceptionistHomepage.aspx");
    }

    protected void btnSupplierHomepage_Click(object sender, EventArgs e)
    {
        Response.Redirect("SupplierHomepage.aspx");
    }

    protected void btnSalesmanHomepage_Click(object sender, EventArgs e)
    {
        Response.Redirect("SalesmanHomepage.aspx");
    }
}