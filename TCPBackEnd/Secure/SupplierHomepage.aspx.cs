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
        lstBoxListSupplier.DataTextField = "SupplierID";
        lstBoxListSupplier.DataBind();




    }


    protected void btnSupplierLogout_Click(object sender, EventArgs e)
    {
        Response.Redirect("../Login.aspx");
    }

    //function for adding new records 
    void Add()
    {
        //create an instance of the address book
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
            Suppliers.ThisSupplier.PostCode = txtPostcode.Text;
            Suppliers.ThisSupplier.PositionInCompany = txtPositionInCompany.Text;
            Suppliers.ThisSupplier.SupplierName = txtSupplierName.Text;
            Suppliers.ThisSupplier.Title = txtTitle.Text;
            Suppliers.ThisSupplier.WorkExt = txtWorkExt.Text;
            Suppliers.ThisSupplier.WorkNumber = txtWorkNumber.Text;
            Suppliers.ThisSupplier.SupplierEmail = txtSupplierEmail.Text;

            //add the record
            Suppliers.Add();
        }
        else
        {
            //Report error
            lblErrorMessageAdd.Text = "There were problems with the data entered";
        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Add();

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
            lblErrorMessageDelete.Text = "Please seect a record to delete from the list";
        }

    }
    protected void BtnUpdate_Click(object sender, EventArgs e)
    {

        if (lstBoxListSupplier.SelectedIndex != -1)
        {
            SupplierID = Convert.ToInt32(lstBoxListSupplier.SelectedValue);
            Session["SupplierID"] = SupplierID;
            AddSupplier();
        }
        else
        {
            lblErrorMessageAdd.Text = "Please select a record";
        }

    }

    protected void btnDisplayRecord_Click(object sender, EventArgs e)
    {
        if (lstBoxListSupplier.SelectedIndex != -1)
        {
            SupplierID = Convert.ToInt32(lstBoxListSupplier.SelectedValue);
            Session["SupplierID"] = SupplierID;
            AddSupplier();
        }
        else
        {
            lblErrorMessageDisplay.Text = "Please select a record";
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
            SupplierBook.ThisSupplier.PostCode = txtPostcode.Text;
            SupplierBook.ThisSupplier.PositionInCompany = txtPositionInCompany.Text;
            SupplierBook.ThisSupplier.SupplierName = txtSupplierName.Text;
            SupplierBook.ThisSupplier.Title = txtTitle.Text;
            SupplierBook.ThisSupplier.WorkExt = txtWorkExt.Text;
            SupplierBook.ThisSupplier.WorkNumber = txtWorkNumber.Text;
            SupplierBook.ThisSupplier.SupplierEmail = txtSupplierEmail.Text;

            SupplierBook.Update();
        }
        else
        {
            lblErrorMessageAdd.Text = "There were problems with the data entered";
        }
    }
    void AddSupplier()
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
        txtPositionInCompany.Text = SupplierBook.ThisSupplier.PositionInCompany;
        txtSupplierName.Text = SupplierBook.ThisSupplier.SupplierName;
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
        {
            if (lstBoxListSupplier.SelectedIndex != -1)
            {
                SupplierID = Convert.ToInt32(lstBoxListSupplier.SelectedValue);
                Session["SupplierID"] = SupplierID;
                AddSupplier();
                Filter();
            }
            else
            {
                lblErrorMessageDisplay.Text = "Please select a record";
            }
        }
        
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
}















