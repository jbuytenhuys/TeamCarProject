﻿using MyClassLibrary;
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
        SupplierID = Convert.ToInt32(Session["SupplierID"]);
        if (IsPostBack == false)
        {
            DisplaySuppliers();
        }
        {
            txtDateAdded.Text = DateTime.Today.ToShortDateString();

        }
        SupplierID = Convert.ToInt32(Session["SupplierID"]);

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

    protected void btnAdd_Click(object sender, EventArgs e)
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
    protected void BtnUpdate_Click(object sender, EventArgs e)
    {

        Update();
        Response.Redirect("SupplierHomepage.aspx");


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
            Label2.Text = "please select a record";
        }
    }

    void Update()
    {
        clsSupplierCollection SupplierBook = new clsSupplierCollection();
        Boolean OK = SupplierBook.ThisSupplier.Valid(txtAddress.Text, txtCity.Text, txtCounty.Text, txtDateAdded.Text, txtMobile.Text, txtName.Text, txtPostcode.Text, txtPostionInCompany.Text, txtSupplierName.Text, txtTitle.Text, txtWorkExt.Text, txtWorkNumber.Text);
        if (OK == true)
        {
            SupplierBook.ThisSupplier.Find(SupplierID);
            SupplierBook.ThisSupplier.Address = txtAddress.Text;
            SupplierBook.ThisSupplier.City = txtCity.Text;
            SupplierBook.ThisSupplier.County = txtCounty.Text;
            SupplierBook.ThisSupplier.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
            SupplierBook.ThisSupplier.Mobile = txtMobile.Text;
            SupplierBook.ThisSupplier.Name = txtName.Text;
            SupplierBook.ThisSupplier.PostCode = txtPostcode.Text;
            SupplierBook.ThisSupplier.PostionInCompany = txtPostionInCompany.Text;
            SupplierBook.ThisSupplier.SupplierName = txtSupplierName.Text;
            SupplierBook.ThisSupplier.Title = txtTitle.Text;
            SupplierBook.ThisSupplier.WorkExt = txtWorkExt.Text;
            SupplierBook.ThisSupplier.WorkNumber = txtWorkNumber.Text;
            SupplierBook.Update();
        }
        else
        {
            Label3.Text = "there were problems with the data enerterd";
        }
    }
    void DisplaySupplier()
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
        txtPostcode.Text = SupplierBook.ThisSupplier.PostCode;
        txtPostionInCompany.Text = SupplierBook.ThisSupplier.PostionInCompany;
        txtSupplierName.Text = SupplierBook.ThisSupplier.Name;
        txtTitle.Text = SupplierBook.ThisSupplier.Title;
        txtWorkExt.Text = SupplierBook.ThisSupplier.WorkExt;
        txtWorkNumber.Text = SupplierBook.ThisSupplier.WorkNumber;
    }
    void Filter()
    {
        clsSupplierCollection Supplier = new clsSupplierCollection();
        Supplier.ThisSupplier.PostCode = txtFilterPostcode.Text;
        Supplier.FilterByPostCode(Supplier.ThisSupplier.PostCode);
        lstBoxListSupplier.DataSource = Supplier.SupplierList;
        lstBoxListSupplier.DataValueField = "SupplierID";
        lstBoxListSupplier.DataTextField = "Postcode";
        lstBoxListSupplier.DataBind();
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        Filter();
    }

    protected void txtFilterPostcode_TextChanged(object sender, EventArgs e)
    {

    }
}















