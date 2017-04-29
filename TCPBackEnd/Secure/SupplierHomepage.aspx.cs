using MyClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class SupplierHomepage : System.Web.UI.Page

{
    Int32 SupplierID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is being displayed
        if (IsPostBack == false)
        {
            //Update the list box
            DisplaySuppliers();
        }
        {
            //auto add the date to current day
            txtDateAdded.Text = DateTime.Today.ToShortDateString();

        }
        SupplierID = Convert.ToInt32(Session["SupplierID"]);

    }
    void DisplaySuppliers()
    {
        //Create and instance of the supplier collection
        MyClassLibrary.clsSupplierCollection Suppliers = new MyClassLibrary.clsSupplierCollection();
        //set the data source to the list of suppliers in the collection
        lstBoxListSupplier.DataSource = Suppliers.SupplierList;
        //set the name of the primary key
        lstBoxListSupplier.DataValueField = "SupplierID";
        //set the data.filed to display
        lstBoxListSupplier.DataTextField = "SupplierName";
        //bind the data to list 
        lstBoxListSupplier.DataBind();
    }
    protected void btnSupplierLogout_Click(object sender, EventArgs e)
    {
        //redirect to the mainhompage
        Response.Redirect("MainHomepage.aspx");
    }

    void DisplaySupplier()
    {
        //set variable equal to the session number
        SupplierID = Convert.ToInt32(Session["SupplierID"]);
        //Create instance in Supplier collection class
        clsSupplierCollection SupplierBook = new clsSupplierCollection();
        //run SupplierID through the find function
        SupplierBook.ThisSupplier.Find(SupplierID);
        //assign the data from records in the database to the text boxes
        txtAddress.Text = SupplierBook.ThisSupplier.Address;
        txtCity.Text = SupplierBook.ThisSupplier.City;
        txtCounty.Text = SupplierBook.ThisSupplier.County;
        txtDateAdded.Text = SupplierBook.ThisSupplier.DateAdded.ToShortDateString();
        txtMobile.Text = SupplierBook.ThisSupplier.Mobile;
        txtName.Text = SupplierBook.ThisSupplier.Name;
        txtPostcode.Text = SupplierBook.ThisSupplier.Postcode;
        txtPositionInCompany.Text = SupplierBook.ThisSupplier.PositionInCompany;
        txtSupplierName.Text = SupplierBook.ThisSupplier.SupplierName;
        txtTitle.Text = SupplierBook.ThisSupplier.Title;
        txtWorkExt.Text = SupplierBook.ThisSupplier.WorkExt;
        txtWorkNumber.Text = SupplierBook.ThisSupplier.WorkNumber;
        txtSupplierEmail.Text = SupplierBook.ThisSupplier.SupplierEmail;
    }


    void Add() //function for adding new records 
    {
        //Create instance in Supplier collection class
        clsSupplierCollection Suppliers = new clsSupplierCollection();
        //validate the data on the web form
        Boolean OK = Suppliers.ThisSupplier.Valid(txtAddress.Text, txtCity.Text, txtCounty.Text, txtDateAdded.Text, txtMobile.Text, txtName.Text, txtPostcode.Text, txtPositionInCompany.Text, txtSupplierName.Text, txtTitle.Text, txtWorkExt.Text, txtWorkNumber.Text, txtSupplierEmail.Text);
        //if the data is ok then add it to the object 
        if (OK == true)
        {
            Suppliers.ThisSupplier.Address = txtAddress.Text;
            Suppliers.ThisSupplier.City = txtCity.Text;
            Suppliers.ThisSupplier.County = txtCounty.Text;
            Suppliers.ThisSupplier.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
            Suppliers.ThisSupplier.Mobile = txtMobile.Text;
            Suppliers.ThisSupplier.Name = txtName.Text;
            Suppliers.ThisSupplier.Postcode = txtPostcode.Text;
            Suppliers.ThisSupplier.PositionInCompany = txtPositionInCompany.Text;
            Suppliers.ThisSupplier.SupplierName = txtSupplierName.Text;
            Suppliers.ThisSupplier.Title = txtTitle.Text;
            Suppliers.ThisSupplier.WorkExt = txtWorkExt.Text;
            Suppliers.ThisSupplier.WorkNumber = txtWorkNumber.Text;
            Suppliers.ThisSupplier.SupplierEmail = txtSupplierEmail.Text;

            //add the record
            Suppliers.Add();
            Response.Redirect("SupplierHomepage.aspx");

        }
        else
        {
            //Report error
            lblErrorMessageAdd.Text = "there were problems with the data entered";
        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        {
            if (lstBoxListSupplier.SelectedIndex != -1)
            {
                SupplierID = Convert.ToInt32(lstBoxListSupplier.SelectedValue);
                Session["SupplierID"] = SupplierID;
                Add();
            }

            else
            {
                lblErrorMessageAdd.Text = "There is something wrong with the data entered please review";
            }
        }
    }

    protected void btnDelete_Click1(object sender, EventArgs e)
    {
        if (lstBoxListSupplier.SelectedIndex != -1)
        {
            SupplierID = Convert.ToInt32(lstBoxListSupplier.SelectedValue);
            Session["SupplierID"] = SupplierID;
            Delete();
            Response.Redirect("SupplierDelete.aspx");
        }

        else
        {
            lblErrorMessageDelete.Text = "Please seect a record to delete from the list";
        }

    }

    void Update()
    {
        clsSupplierCollection SupplierBook = new clsSupplierCollection();
        Boolean OK = SupplierBook.ThisSupplier.Valid(txtAddress.Text, txtCity.Text, txtCounty.Text, txtDateAdded.Text, txtMobile.Text, txtName.Text, txtPostcode.Text, txtPositionInCompany.Text, txtSupplierName.Text, txtTitle.Text, txtWorkExt.Text, txtWorkNumber.Text, txtSupplierEmail.Text);
        if (OK == true)
        {
            SupplierBook.ThisSupplier.Find(SupplierID);
            SupplierBook.ThisSupplier.Address = txtAddress.Text;
            SupplierBook.ThisSupplier.City = txtCity.Text;
            SupplierBook.ThisSupplier.County = txtCounty.Text;
            SupplierBook.ThisSupplier.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
            SupplierBook.ThisSupplier.Mobile = txtMobile.Text;
            SupplierBook.ThisSupplier.Name = txtName.Text;
            SupplierBook.ThisSupplier.Postcode = txtPostcode.Text;
            SupplierBook.ThisSupplier.PositionInCompany = txtPositionInCompany.Text;
            SupplierBook.ThisSupplier.SupplierName = txtSupplierName.Text;
            SupplierBook.ThisSupplier.Title = txtTitle.Text;
            SupplierBook.ThisSupplier.WorkExt = txtWorkExt.Text;
            SupplierBook.ThisSupplier.WorkNumber = txtWorkNumber.Text;
            SupplierBook.ThisSupplier.SupplierEmail = txtSupplierEmail.Text;
            SupplierBook.Update();
            Response.Redirect("SupplierHomepage.aspx");

        }
        else
        {
            lblErrorMessageAdd.Text = "There were problems with the data enerter";
        }
    }
    protected void btnDisplayRecord_Click(object sender, EventArgs e)
    {
        if (lstBoxListSupplier.SelectedIndex != -1)
        {
            SupplierID = Convert.ToInt32(lstBoxListSupplier.SelectedValue);
            Session["SupplierID"] = SupplierID;
            DisplaySupplier();
        }
        else
        {
            lblErrorMessageDisplay.Text = "Please select a record";
        }
    }
    void Delete()
    {
        SupplierID = Convert.ToInt32(Session["SupplierID"]);
        clsSupplierCollection SupplierBook = new clsSupplierCollection();
        SupplierBook.ThisSupplier.Find(SupplierID);
        txtAddress.Text = SupplierBook.ThisSupplier.Address;
        txtCity.Text = SupplierBook.ThisSupplier.City;
        txtCounty.Text = SupplierBook.ThisSupplier.County;
        txtDateAdded.Text = SupplierBook.ThisSupplier.DateAdded.ToString();
        txtMobile.Text = SupplierBook.ThisSupplier.Mobile;
        txtName.Text = SupplierBook.ThisSupplier.Name;
        txtPostcode.Text = SupplierBook.ThisSupplier.Postcode;
        txtPositionInCompany.Text = SupplierBook.ThisSupplier.PositionInCompany;
        txtSupplierName.Text = SupplierBook.ThisSupplier.SupplierName;
        txtTitle.Text = SupplierBook.ThisSupplier.Title;
        txtWorkExt.Text = SupplierBook.ThisSupplier.WorkExt;
        txtWorkNumber.Text = SupplierBook.ThisSupplier.WorkNumber;

        SupplierBook.Delete();
    }

    void Filter()
    {
        clsSupplierCollection Supplier = new clsSupplierCollection();
        Supplier.ThisSupplier.Postcode = txtFilterPostcode.Text;
        Supplier.FilterByPostCode(Supplier.ThisSupplier.Postcode);
        lstBoxListSupplier.DataSource = Supplier.SupplierList;
        lstBoxListSupplier.DataValueField = "SupplierID";
        lstBoxListSupplier.DataTextField = "Postcode";
        lstBoxListSupplier.DataBind();
    }

    void Filter2()
    {
        clsSupplierCollection Supplier = new clsSupplierCollection();
        Supplier.ThisSupplier.WorkNumber = txtFilterWorkNumber.Text;
        Supplier.FilterByWorkNumber(Supplier.ThisSupplier.WorkNumber);
        lstBoxListSupplier.DataSource = Supplier.SupplierList;
        lstBoxListSupplier.DataValueField = "SupplierID";
        lstBoxListSupplier.DataTextField = "WorkNumber";
        lstBoxListSupplier.DataBind();
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        Filter();

    }


    protected void txtFilterPostcode_TextChanged(object sender, EventArgs e)
    {

    }
    protected void txtFilterWorkNumber_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnSearchWorkNumber_Click(object sender, EventArgs e)
    {
        Filter2();
    }



    protected void reset_Click(object sender, EventArgs e)
    {
        Response.Redirect("SupplierHomepage.aspx");
    }




    void Filter3()
    {
        clsSupplierCollection Supplier = new clsSupplierCollection();
        Supplier.ThisSupplier.SupplierName = txtFilterSupplierName.Text;
        Supplier.FilterBySupplierName(Supplier.ThisSupplier.SupplierName);
        lstBoxListSupplier.DataSource = Supplier.SupplierList;
        lstBoxListSupplier.DataValueField = "SupplierID";
        lstBoxListSupplier.DataTextField = "SupplierName";
        lstBoxListSupplier.DataBind();
    }


    protected void btnSearchSupplierName_Click(object sender, EventArgs e)
    {
        Filter3();
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





    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        if (lstBoxListSupplier.SelectedIndex != 1)
        {
            SupplierID = Convert.ToInt32(lstBoxListSupplier.SelectedValue);
            Session["SupplierID"] = SupplierID;
            Update();
        }

        else
        {
            lblErrorMessageAdd.Text = "There is something wrong with the data entered please review";
        }
    }
}
  















