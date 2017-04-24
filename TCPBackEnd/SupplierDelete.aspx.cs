using MyClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SupplierDelete : System.Web.UI.Page
{
    Int32 SupplierID;
    protected void Page_Load(object sender, EventArgs e)
    {
        SupplierID = Convert.ToInt32(Session["SupplierID"]);

    }
    void DeleteSupplier()
    {
        clsSupplierCollection SupplierBook = new clsSupplierCollection();
        SupplierBook.ThisSupplier.Find(SupplierID);
        SupplierBook.Delete();
        
    }
        

    protected void BtnYes_Click(object sender, EventArgs e)
    {
        DeleteSupplier();
        Response.Redirect("SupplierHomepage.aspx");
    }
 


}