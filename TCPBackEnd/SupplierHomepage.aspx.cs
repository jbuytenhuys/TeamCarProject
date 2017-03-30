using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SupplierHomepage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplaySuppliers();

        }
    }

    void DisplaySuppliers()
    {
        MyClassLibrary.clsSupplierCollection Suppliers = new MyClassLibrary.clsSupplierCollection();
        lstBoxListSupplier.DataSource = Suppliers.SupplierList;
        lstBoxListSupplier.DataValueField = "SupplierID";
        lstBoxListSupplier.DataTextField = "Postcode";
        lstBoxListSupplier.DataBind();
 


    }

}



 