using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SalesmanHomepage : System.Web.UI.Page
{
    //this function handles the load event for the page
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
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
}
