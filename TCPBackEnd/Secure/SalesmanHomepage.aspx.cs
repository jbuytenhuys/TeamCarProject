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
    Int32 CarID;
    //this function handles the load event for the page
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayCustomers();
        }
        //get the number of the customer to be processed
        CustomerID = Convert.ToInt32(Session["CustomerID"]);

        txtSalesmanDateAddedOK.Text = DateTime.Today.ToShortDateString();


    }

    void DisplayCustomers()
    {
        //create an instance of the customer collection
        MyClassLibrary.clsCustomerCollection Customer = new MyClassLibrary.clsCustomerCollection();
        lstSalesmanBox.DataSource = Customer.CustomerList;////set the data dource to the list of customer in the collection
        ////set the name of the primary key
        lstSalesmanBox.DataValueField = "CustomerID";
        ////set the data field to display
        lstSalesmanBox.DataTextField = "CustomerFirstName";
        lstSalesmanBox.DataBind();
    }

    void DisplayRecordData()
    {

        //fuction to display selected customer data
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
        ////create an instance of the Customer addresses
        MyClassLibrary.clsCustomerCollection CustomerBook = new MyClassLibrary.clsCustomerCollection();
        CustomerBook.ThisCustomer.Find(CustomerID);////find the record to update 
        //display the data for the record
        txtSalesmanCustomerID.Text = Convert.ToString(CustomerBook.ThisCustomer.CustomerID);
        txtSalesmanCustomerAddress.Text = CustomerBook.ThisCustomer.CustomerAddress;
        txtSalesmanCustomerEmail.Text = CustomerBook.ThisCustomer.CustomerEmail;
        txtSalesmanFirstName.Text = CustomerBook.ThisCustomer.CustomerFirstName;
        txtSalesmanLastName.Text = CustomerBook.ThisCustomer.CustomerLastName;
        txtSalesmanCustomerPostCode.Text = CustomerBook.ThisCustomer.CustomerPostCodeOK;
        txtSalesmanDateAddedOK.Text = CustomerBook.ThisCustomer.DateAddedOK.ToString();
        chkSalesmanActiveOK.Checked = CustomerBook.ThisCustomer.ActiveOK;
        txtCustomerNumber.Text = CustomerBook.ThisCustomer.CustomerNumber;
    }

    void DisplayCarID()
    {
        //get the number of the Car to be processed.
        CarID = Convert.ToInt32(Session["CarID"]);
        //create an instance.
        MyClassLibrary.clsCarsCollection ReceptionistCarID = new MyClassLibrary.clsCarsCollection();
        //find the record to be displayed.
        ReceptionistCarID.ThisCar.Find(CarID);
        //copy properties into textboxes on web form.
        txtReceptionistCarID.Text = ReceptionistCarID.ThisCar.CarID.ToString();
    }

    void Add()
    {
        //create an instance
        MyClassLibrary.clsCustomerCollection CustomerBook = new MyClassLibrary.clsCustomerCollection();
        //validate the data on webform
        Boolean OK = CustomerBook.ThisCustomer.Valid(txtSalesmanCustomerAddress.Text, txtSalesmanCustomerEmail.Text, txtCustomerNumber.Text, txtSalesmanFirstName.Text, txtSalesmanLastName.Text, txtSalesmanCustomerPostCode.Text, txtSalesmanDateAddedOK.Text);
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
            CustomerBook.ThisCustomer.CustomerNumber = txtCustomerNumber.Text;

            //add record
            CustomerBook.Add();
            Response.Redirect("SalesmanHomepage.aspx");
            lblSalesmanError.Text = "Customer successfully added";

        }
        else
        {
            //report error
            lblSalesmanError.Text = "There were problems with the data you have entered, please try again";
        }
    }

    void Update()
    {
        //create an instance
        MyClassLibrary.clsCustomerCollection CustomerBook = new MyClassLibrary.clsCustomerCollection();
        //validate the data on webform
        Boolean OK = CustomerBook.ThisCustomer.Valid(txtSalesmanCustomerAddress.Text, txtSalesmanCustomerEmail.Text, txtCustomerNumber.Text,  txtSalesmanFirstName.Text, txtSalesmanLastName.Text, txtSalesmanCustomerPostCode.Text, txtSalesmanDateAddedOK.Text);
        //if data is okay then add to object
        if (OK == true)
        {
            //find the record to update
            CustomerBook.ThisCustomer.Find(CustomerID);
            CustomerBook.ThisCustomer.CustomerAddress = txtSalesmanCustomerAddress.Text;
            CustomerBook.ThisCustomer.CustomerEmail = txtSalesmanCustomerEmail.Text;
            CustomerBook.ThisCustomer.CustomerFirstName = txtSalesmanFirstName.Text;
            CustomerBook.ThisCustomer.CustomerLastName = txtSalesmanLastName.Text;
            CustomerBook.ThisCustomer.CustomerPostCodeOK = txtSalesmanCustomerPostCode.Text;
            CustomerBook.ThisCustomer.DateAddedOK = Convert.ToDateTime(txtSalesmanDateAddedOK.Text);
            CustomerBook.ThisCustomer.ActiveOK = chkSalesmanActiveOK.Checked;
            CustomerBook.ThisCustomer.CustomerNumber = txtCustomerNumber.Text;
            //update the record
            CustomerBook.Update();
            Response.Redirect("SalesmanHomepage.aspx");
            lblSalesmanError.Text = "Customer successfully added";
        }
        else
        {
            //report error
            lblSalesmanError.Text = "There were problems with updating the data you have entered, please try again";
        }
    }


    void FilterCustomerFirstName()
    {
        //create an instance of the customer collection
        MyClassLibrary.clsCustomerCollection Customer = new MyClassLibrary.clsCustomerCollection();
        //set the data dource to the list of customer in the collection
        Customer.ThisCustomer.CustomerFirstName = txtSalesmanFilterBy.Text;
        Customer.FilterByCustomerFirstName(Customer.ThisCustomer.CustomerFirstName);
        lstSalesmanBox.DataSource = Customer.CustomerList;
        //set the name of the primary key
        lstSalesmanBox.DataValueField = "CustomerID";
        //set the data field to display
        lstSalesmanBox.DataTextField = "CustomerFirstName";
        lstSalesmanBox.DataBind();
    }

    void FilterCustomerAddress()
    {
        //create an instance of the customer collection
        MyClassLibrary.clsCustomerCollection Customer = new MyClassLibrary.clsCustomerCollection();
        //set the data dource to the list of customer in the collection
        Customer.ThisCustomer.CustomerAddress = txtSalesmanAddress.Text;
        Customer.FilterByCustomerAddress(Customer.ThisCustomer.CustomerAddress);
        lstSalesmanBox.DataSource = Customer.CustomerList;
        //set the name of the primary key
        lstSalesmanBox.DataValueField = "CustomerID";
        //set the data field to display
        lstSalesmanBox.DataTextField = "CustomerAddress";
        lstSalesmanBox.DataBind();
    }

    void FilterCarRegistrationPlate()
    {
        //create an instance of the customer collection
        MyClassLibrary.clsCarsCollection Cars = new MyClassLibrary.clsCarsCollection();
        //set the data dource to the list of customer in the collection
        Cars.ThisCar.CarRegistrationPlate = txtFilterCarReg.Text;
        Cars.FilterByRegPlate(Cars.ThisCar.CarRegistrationPlate);
        lstSalesmanBox.DataSource = Cars.CarList;
        //set the name of the primary key
        lstSalesmanBox.DataValueField = "CarID";
        //set the data field to display
        lstSalesmanBox.DataTextField = "CarRegistrationPlate";
        lstSalesmanBox.DataBind();
    }

    protected void btnSalesmanAddCustomer_Click(object sender, EventArgs e)
    {
        Add();
    }

    protected void btnSalesmanHomePage_Click(object sender, EventArgs e)
    {
        //alll done so redirect back to main page
        Response.Redirect("../Login.aspx");
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
        if (lstSalesmanBox.SelectedIndex != -1)
        {
            Update();
        }
        else
        {
            //report error
            lblSalesmanError.Text = "Please select data you want to update";
        }
        
    }
       



    //function to view data
protected void btnSalesmanViewData_Click(object sender, EventArgs e)
    {
        if (lstSalesmanBox.SelectedIndex != -1)
        {
            CustomerID = Convert.ToInt32(lstSalesmanBox.SelectedValue);
            //store the data in the session objective
            Session["CustomerID"] = CustomerID;
            DisplayRecordData();
            lblSalesmanError.Text = "";

        }
        else
        {
            //report error
            lblSalesmanError.Text = "Please select data you want to view";
        }
    }
   
   

    protected void lstSalesmanBox_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void txtSalesmanFilterBy_TextChanged(object sender, EventArgs e)
    {

    }
    

    protected void btnSalesmanSearch_Click(object sender, EventArgs e)
    {
        FilterCustomerFirstName();
        

    }

    protected void btnSalesmanReset_Click(object sender, EventArgs e)
    {
        Response.Redirect("SalesmanHomepage.aspx");
    }

    protected void btnSalesmanHomePage_Click1(object sender, EventArgs e)
    {
        Response.Redirect("../Login.aspx");
    }

    protected void txtSalesmanAddress_TextChanged(object sender, EventArgs e)
    {
        
    }

    protected void btnFilterByAddress_Click(object sender, EventArgs e)
    {
        FilterCustomerAddress();
    }

    protected void txtCustomerNumber_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtSalesmanFirstName_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnFetchReceptionistCarID_Click(object sender, EventArgs e)
    {
        
        //if a record has been selected from the list.
        if (lstSalesmanBox.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit.
            CarID = Convert.ToInt32(lstSalesmanBox.SelectedValue);
            //store the data in the session object.
            Session["CarID"] = CarID;
            lblSalesmanError.Text = "";
            DisplayCarID();
        }
        else
        //If no record has been selected.
        {
            //Display an error
            lblSalesmanError.Text = "Please select a record to be edited.";
        }
    }



    protected void btnFilterCarReg_Click(object sender, EventArgs e)
    {
        //filter by
        FilterCarRegistrationPlate();
    }
}








