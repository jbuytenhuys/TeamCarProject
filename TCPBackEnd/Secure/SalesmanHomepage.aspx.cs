using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SalesmanHomepage : System.Web.UI.Page
{
    //variable to store the primary key with page level scop
    Int32 CustomerID;
    //this function handles the load event for the page
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayCustomers();
            //if this is not a new record
            if (CustomerID != -1)
            {
                //display the current data for the record
                DisplayCustomers();
            }
        }
        txtSalesmanDateAddedOK.Text = DateTime.Today.ToShortDateString();

        //get the number of the customer to be processed
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
        if (IsPostBack == false)
        {
            //populate the list of customers
            DisplayCustomers();
        }
    }

    void DisplayCustomers()
    {
        //create an instance of the customer collection
        MyClassLibrary.clsCustomerCollection Customer = new MyClassLibrary.clsCustomerCollection();
        //set the data dource to the list of customer in the collection
        lstSalesmanBox.DataSource = Customer.CustomerList;
        //set the name of the primary key
        lstSalesmanBox.DataValueField = "CustomerID";
        //set the data field to display
        lstSalesmanBox.DataTextField = "CustomerFirstName";
        lstSalesmanBox.DataBind();
    }

    protected void btnSalesmanAddCustomer_Click(object sender, EventArgs e)
    {
        Add();
    }

    void Add()
    {
        //create an instance
        MyClassLibrary.clsCustomerCollection CustomerBook = new MyClassLibrary.clsCustomerCollection();
        //validate the data on webform
        Boolean OK = CustomerBook.ThisCustomer.Valid(txtSalesmanCustomerAddress.Text, txtSalesmanCustomerEmail.Text, txtSalesmanFirstName.Text, txtSalesmanLastName.Text, txtSalesmanCustomerPostCode.Text, txtSalesmanDateAddedOK.Text);
        //if data is okay then add to object
        if (OK == true)
        {
            //Fetch data entered by user
            CustomerBook.ThisCustomer.CustomerAddress = txtSalesmanCustomerAddress.Text;
            CustomerBook.ThisCustomer.CustomerEmail = txtSalesmanCustomerEmail.Text;
            CustomerBook.ThisCustomer.CustomerFirstName = txtSalesmanFirstName.Text;
            CustomerBook.ThisCustomer.CustomerLastName = txtSalesmanLastName.Text;
            CustomerBook.ThisCustomer.CustomerPostCodeOK = txtSalesmanCustomerPostCode.Text;
            CustomerBook.ThisCustomer.DateAddedOK = Convert.ToDateTime(txtSalesmanDateAddedOK.Text);
            CustomerBook.ThisCustomer.ActiveOK = chkSalesmanActiveOK.Checked;

            //add record
            CustomerBook.Add();
            lblSalesmanError.Text = "Customer successfully added";
            Response.Redirect("SalesmanHomepage.aspx");
        }
        else
        {
            //report error
            lblSalesmanError.Text = "There were problems with the data you have entered, please try again";
        }
    }


    protected void btnSalesmanHomePage_Click(object sender, EventArgs e)
    {
        //alll done so redirect back to main page
        Response.Redirect("Default.aspx");
    }

    protected void btnSalesmanArchiveCustomer_Click(object sender, EventArgs e)
    {
        //event handler for the archive button
        //var to store the primary key value of the record to be deleted
        Int32 CustomerID;
        //if a record has been selected from the list 
        if (lstSalesmanBox.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            CustomerID = Convert.ToInt32(lstSalesmanBox.SelectedValue);
            //store the data in the session objective
            Session["CustomerID"] = CustomerID;
            //redirect to the confirmation page
            Response.Redirect("SalesmanArchive.aspx");
        }
        else
        {
            //display an error 
            lblSalesmanError.Text = "please select a record to archive from the list";
        }
    }

    protected void chkSalesmanActiveOK_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void txtSalesmanDateAddedOK_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnSalesmanUpdateCustomer_Click(object sender, EventArgs e)
    {
        Update();
    }


    protected void btnSalesmanViewData_Click(object sender, EventArgs e)
    {
        if (lstSalesmanBox.SelectedIndex != -1)
        {
            CustomerID = Convert.ToInt32(lstSalesmanBox.SelectedValue);
            //store the data in the session objective
            Session["CustomerID"] = CustomerID;
            DisplayRecordData();
        }
        else
        {
            //report error
            lblSalesmanError.Text = "There were problems with updating the data you have entered, please try again";
        }
    }
    void Update()
    {
        //create an instance
        MyClassLibrary.clsCustomerCollection CustomerBook = new MyClassLibrary.clsCustomerCollection();
        //validate the data on webform
        Boolean OK = CustomerBook.ThisCustomer.Valid(txtSalesmanCustomerAddress.Text, txtSalesmanCustomerEmail.Text, txtSalesmanFirstName.Text, txtSalesmanLastName.Text, txtSalesmanCustomerPostCode.Text, txtSalesmanDateAddedOK.Text);
        //if data is okay then add to object
        if (OK == true)
        {
            //find the record to update
            CustomerBook.ThisCustomer.CustomerAddress = txtSalesmanCustomerAddress.Text;
            CustomerBook.ThisCustomer.CustomerEmail = txtSalesmanCustomerEmail.Text;
            CustomerBook.ThisCustomer.CustomerFirstName = txtSalesmanFirstName.Text;
            CustomerBook.ThisCustomer.CustomerLastName = txtSalesmanLastName.Text;
            CustomerBook.ThisCustomer.CustomerPostCodeOK = txtSalesmanCustomerPostCode.Text;
            CustomerBook.ThisCustomer.DateAddedOK = Convert.ToDateTime(txtSalesmanDateAddedOK.Text);
            CustomerBook.ThisCustomer.ActiveOK = chkSalesmanActiveOK.Checked;
            //update the record
            CustomerBook.Update();
        }
        else
        {
            //report error
            lblSalesmanError.Text = "There were problems with updating the data you have entered, please try again";
        }
    }

    void DisplayRecordData()
    {
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
        //create an instance of the Customer addresses
        MyClassLibrary.clsCustomerCollection CustomerBook = new MyClassLibrary.clsCustomerCollection();
        //find the record to update 
        CustomerBook.ThisCustomer.Find(CustomerID);
        //display the data for the record
        txtSalesmanCustomerAddress.Text = CustomerBook.ThisCustomer.CustomerAddress;
        txtSalesmanCustomerEmail.Text = CustomerBook.ThisCustomer.CustomerEmail;
        txtSalesmanFirstName.Text = CustomerBook.ThisCustomer.CustomerFirstName;
        txtSalesmanLastName.Text = CustomerBook.ThisCustomer.CustomerLastName;
        txtSalesmanCustomerPostCode.Text = CustomerBook.ThisCustomer.CustomerPostCodeOK;
        txtSalesmanDateAddedOK.Text = CustomerBook.ThisCustomer.CustomerPostCodeOK;
        txtSalesmanDateAddedOK.Text = CustomerBook.ThisCustomer.DateAddedOK.ToString();
        chkSalesmanActiveOK.Checked = CustomerBook.ThisCustomer.ActiveOK;
    }
}







