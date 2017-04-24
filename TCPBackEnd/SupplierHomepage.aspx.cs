using MyClassLibrary;
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


    protected void btnSupplierLogout_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }

    //function for adding new records 
    void Add()
    {
        //create an instance of the address book
        clsSupplierCollection Suppliers = new clsSupplierCollection();
        //validate the data on the web form
        Boolean OK = Suppliers.ThisSupplier.Valid(txtAddress.Text, txtCity.Text, txtCounty.Text, txtDateAdded.Text, txtMobile.Text, txtName.Text, txtPostcode.Text, txtPostionInCompany.Text, txtSupplierName.Text, txtTitle.Text, txtWorkExt.Text, txtWorkNumber.Text);
        //if the data is ok then add it to the object 
        if (OK == true)
        {
            Suppliers.ThisSupplier.Address = txtAddress.Text;
            Suppliers.ThisSupplier.City = txtCity.Text;
            Suppliers.ThisSupplier.County = txtCounty.Text;
            Suppliers.ThisSupplier.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
            Suppliers.ThisSupplier.Mobile = txtMobile.Text;
            Suppliers.ThisSupplier.Name = txtName.Text;
            Suppliers.ThisSupplier.PostCode = txtPostcode.Text;
            Suppliers.ThisSupplier.PostionInCompany = txtPostionInCompany.Text;
            Suppliers.ThisSupplier.SupplierName = txtSupplierName.Text;
            Suppliers.ThisSupplier.Title = txtTitle.Text;
            Suppliers.ThisSupplier.WorkExt = txtWorkExt.Text;
            Suppliers.ThisSupplier.WorkNumber = txtWorkNumber.Text;
            //add the record
            Suppliers.Add();
        }
        else
        {
            //Report error
            Label1.Text = "there were problems with the data entered";
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Add();
        Response.Redirect("SupplierHomepage.aspx");

    }

    protected void lstBoxListSupplier_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void txtSupplierName_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtName_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtPostionInCompany_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtAddress_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtCity_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtCounty_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtPostcode_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtMoblie_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtWorkExt_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtWorkNumber_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtDateAdded_TextChanged(object sender, EventArgs e)
    {

    }

 


    protected void btnDelete_Click1(object sender, EventArgs e)
    {
        Int32 SupplierID;
        if (lstBoxListSupplier.SelectedIndex != -1)
        {
            SupplierID = Convert.ToInt32(lstBoxListSupplier.SelectedValue);
            Session["SupplierID"] = SupplierID;
            Response.Redirect("SupplierDelete.aspx");
        }

        else
        {
            Label1.Text = "Please seect a record to delete from the list";
        }

    }
}


        






