using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyClassLibrary;

public partial class ReceptionistHomepage : System.Web.UI.Page
{
    //Variable to store the primary key of the record and forigen key.
    Int32 CarID;
    Int32 SupplierID;

    protected void Page_Load(object sender, EventArgs e)
    {

        //get the number of the Car to be processed.
        CarID = Convert.ToInt32(Session["CarID"]);

        //if this is the first time the page is displayed.
        if (IsPostBack == false)
        {
            //populate list box.
            DisplayAllCars();   
       
        }
        //Displays who the current user is.
        lblReceptionistInfo.Text = "The current User is " + User.Identity.Name;
    }
     
    void DisplayAllCars()
    {
        //create an instance of the Cars collection.
        clsCarsCollection Cars = new clsCarsCollection();
        //Set the data source to the list of cars in the collection.
        lstBoxReceptionistListCars.DataSource = Cars.CarList;
        //Set the name of the primary
        lstBoxReceptionistListCars.DataValueField = "CarID";
        //set the data field to display.
        lstBoxReceptionistListCars.DataTextField = "CarRegistrationPlate";
        //Bind the data to the list.
        lstBoxReceptionistListCars.DataBind();
    }

    void Add()
    {
        //function to add a car.
        //create an instance
        clsCarsCollection Cars = new clsCarsCollection();
        //validate the data on the web form
        Boolean OK = Cars.ThisCar.Valid(txtReceptionistCarManufacturer.Text, txtReceptionistCarModel.Text, txtReceptionistCarRegistrationPlate.Text, txtReceptionistCarColour.Text, txtReceptionistCarNumberOfDoors.Text, txtReceptionistCarNumberOfSeats.Text, txtReceptionistSupplierID.Text);
        //if the data is OK then add it to the object.
        if (OK == true)
        {
            //get the data entered by the user.
            Cars.ThisCar.CarManufacturer = txtReceptionistCarManufacturer.Text;
            Cars.ThisCar.CarModel = txtReceptionistCarModel.Text;
            Cars.ThisCar.CarRegistrationPlate = txtReceptionistCarRegistrationPlate.Text;
            Cars.ThisCar.CarColour = txtReceptionistCarColour.Text;
            Cars.ThisCar.CarNumberOfDoors = Convert.ToInt32(txtReceptionistCarNumberOfDoors.Text);
            Cars.ThisCar.CarNumberOfSeats = Convert.ToInt32(txtReceptionistCarNumberOfSeats.Text);
            Cars.ThisCar.CarNeedsRepair = Convert.ToBoolean(ChkBoxReceptionistNeedsRepair.Checked);
            Cars.ThisCar.CarSold = Convert.ToBoolean(ChkBoxReceptionistSold.Checked);
            Cars.ThisCar.SupplierID = Convert.ToInt32(txtReceptionistSupplierID.Text);
            //test to see if the registration exists.
            if (Convert.ToInt32(Cars.CarRegistrationExists()) == 0)
            {
                lblError.Text = "Car Reg already exists";
            }
            else
            {
                //add the record.
                Cars.Add();
                //set lbl to empty
                lblError.Text = "";
                //reload/refresh the page.
                Response.Redirect("ReceptionistHomepage.aspx");
            }
            

        }
        else
        {
            //report the error
            lblError.Text = "There were problems with the data entered";
        }
    }

        
        void CarRegExists()
        //funtion to test if the car registration exists.
        {
        //create instance of class.
        clsCarsCollection Cars = new clsCarsCollection();
        //get the car registration plate entered by the user.
        Cars.ThisCar.CarRegistrationPlate = txtReceptionistCarRegistrationPlate.Text;
        //check the registration.
        Cars.CarRegistrationExists();
        }

    

    void Update()
        //function for updating records.
    {
        //create an instance.
        clsCarsCollection Cars = new clsCarsCollection();
        //validate the data on the web form.
        Boolean OK = Cars.ThisCar.Valid(txtReceptionistCarManufacturer.Text, txtReceptionistCarModel.Text, txtReceptionistCarRegistrationPlate.Text, txtReceptionistCarColour.Text, txtReceptionistCarNumberOfDoors.Text, txtReceptionistCarNumberOfSeats.Text, txtReceptionistSupplierID.Text);
        //if the data is OK then add it to the object.
        if (OK == true)
        {
            //find the record to update.
            Cars.ThisCar.Find(CarID);
            //get the data entered by the user.
            Cars.ThisCar.CarManufacturer = txtReceptionistCarManufacturer.Text;
            Cars.ThisCar.CarModel = txtReceptionistCarModel.Text;
            Cars.ThisCar.CarRegistrationPlate = txtReceptionistCarRegistrationPlate.Text;
            Cars.ThisCar.CarColour = txtReceptionistCarColour.Text;
            Cars.ThisCar.CarNumberOfDoors = Convert.ToInt32(txtReceptionistCarNumberOfDoors.Text);
            Cars.ThisCar.CarNumberOfSeats = Convert.ToInt32(txtReceptionistCarNumberOfSeats.Text);
            Cars.ThisCar.CarNeedsRepair = ChkBoxReceptionistNeedsRepair.Checked;
            Cars.ThisCar.CarSold = ChkBoxReceptionistSold.Checked;
            Cars.ThisCar.SupplierID = Convert.ToInt32(txtReceptionistSupplierID.Text);
            //update the record
                Cars.Update();
                lblError.Text = "";
                Response.Redirect("ReceptionistHomepage.aspx");
            
            
            
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data you have entered.";
        }
    }

    void DisplayCar()
    {
        //get the number of the Car to be processed.
        CarID = Convert.ToInt32(Session["CarID"]);
        //create an instance.
        clsCarsCollection Cars = new clsCarsCollection();
        //find the record to be displayed.
        Cars.ThisCar.Find(CarID);
        //copy properties into textboxes on web form.
        txtReceptionistCarID.Text = Convert.ToString(Cars.ThisCar.CarID);
        txtReceptionistCarManufacturer.Text = Cars.ThisCar.CarManufacturer;
        txtReceptionistCarModel.Text = Cars.ThisCar.CarModel;
        txtReceptionistCarRegistrationPlate.Text = Cars.ThisCar.CarRegistrationPlate;
        txtReceptionistCarColour.Text = Cars.ThisCar.CarColour;
        txtReceptionistCarNumberOfDoors.Text = Convert.ToString(Cars.ThisCar.CarNumberOfDoors);
        txtReceptionistCarNumberOfSeats.Text = Convert.ToString(Cars.ThisCar.CarNumberOfSeats);
        ChkBoxReceptionistNeedsRepair.Checked = Cars.ThisCar.CarNeedsRepair;
        ChkBoxReceptionistSold.Checked = Cars.ThisCar.CarSold;
        txtReceptionistSupplierID.Text = Convert.ToString(Cars.ThisCar.SupplierID);
    }

    void FilterByCarManufacturer()
    {
        //create an instance of the class.
        clsCarsCollection Cars = new clsCarsCollection();
        //get the manufacturer the user wants to filter by.
        Cars.FilterByCarManufacturer(txtReceptionistFilterByCarManufacturer.Text);
        //Set the data source to the list of cars in the collection.       
        lstBoxReceptionistListCars.DataSource = Cars.CarList;
        //Set the name of the primary
        lstBoxReceptionistListCars.DataValueField = "CarID";
        //set the data field to display.        
        lstBoxReceptionistListCars.DataTextField = "CarRegistrationPlate";
        //Bind the data to the list.    
        lstBoxReceptionistListCars.DataBind();
    }

    void FilterBySupplierEmail()
    {
        //create an instance of the class.
        clsSupplierCollection Suppliers = new clsSupplierCollection();
        //get the supplier email the user wants to filter by.
        Suppliers.FilterBySupplierEmail(txtReceptionistSearchSupplier.Text);
        //Set the data source to the list of cars in the collection.
        lstBoxReceptionistListCars.DataSource = Suppliers.SupplierList;
        //Set the name of the primary
        lstBoxReceptionistListCars.DataValueField = "SupplierID";
        //set the data field to display. 
        lstBoxReceptionistListCars.DataTextField = "SupplierEmail";
        //Bind the data to the list.
        lstBoxReceptionistListCars.DataBind();
    }

    void DisplayRecord()
    {
        //get the number of the Car to be processed.
        SupplierID = Convert.ToInt32(Session["SupplierID"]);
        //create an instance.
        clsSupplierCollection Supplier = new clsSupplierCollection();
        //find the record to be displayed.
        Supplier.ThisSupplier.Find(SupplierID);
        //copy properties into textboxes on web form.
        txtReceptionistSupplierID.Text = Supplier.ThisSupplier.SupplierID.ToString();
    }


    protected void btnReceptionistArchive_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted.
        Int32 CarID;
        //if a record has been selected from the list
        if (lstBoxReceptionistListCars.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete.
            CarID = Convert.ToInt32(lstBoxReceptionistListCars.SelectedValue);
            //store the data in the section object.
            Session["CarID"] = CarID;
            //redirect to the delete page.
            Response.Redirect("ReceptionistDelete.aspx");
        }
        else
        //if no record was found
        {
            //display an error.
            lblError.Text = "Please select a record to be deleted from the list";
        }
    }
    

    protected void btnReceptionistLogout_Click(object sender, EventArgs e)
    {
        //redirect to the login page.
        Response.Redirect("../Login.aspx");
    }
       
    protected void btnReceptionistAddCar_Click(object sender, EventArgs e)
    {
        //Add the car to the database.
       Add();
    }

    protected void btnReceptionistListAllCars_Click(object sender, EventArgs e)
    {
        //update the list box.
        DisplayAllCars();
    }

    protected void btnReceptionistViewSelectedData_Click(object sender, EventArgs e)
    {
        //Variable to store the primary key value of the record to be edited.
        Int32 CarID;
        //if a record has been selected from the list.
        if (lstBoxReceptionistListCars.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit.
            CarID = Convert.ToInt32(lstBoxReceptionistListCars.SelectedValue);
            //store the data in the session object.
            Session["CarID"] = CarID;
            //set the error label to a blank string.
            lblError.Text = "";
            //display the record.
            DisplayCar();
        }
        else
        //If no record has been selected.
        {
            //Display an error
            lblError.Text = "Please select a record to be edited.";
        }
    }

    protected void btnReceptionistUpdate_Click(object sender, EventArgs e)
    {
        if (CarID == -1)
        {
            //add the new record
            Add();
        }
        else
        {
            //update the record
            Update();
            
        }
    }

    protected void btnReceptionistReset_Click(object sender, EventArgs e)
    {
        //reset the text boxes on the web form to original values.
        Response.Redirect("ReceptionistHomepage.aspx");
    }

    protected void btnReceptionistFilterCars_Click(object sender, EventArgs e)
    {
        //filter by car manufacturer.
        FilterByCarManufacturer();
    }

    protected void btnReceptionistSearchSupplier_Click(object sender, EventArgs e)
    {
        //filter by supplier email.
        FilterBySupplierEmail();
    }



    protected void btnReceptionistFetchSupplierID_Click(object sender, EventArgs e)
    {
        //Variable to store the primary key value of the record to be edited.
        Int32 SupplierID;
        //if a record has been selected from the list.
        if (lstBoxReceptionistListCars.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit.
            SupplierID = Convert.ToInt32(lstBoxReceptionistListCars.SelectedValue);
            //store the data in the session object.
            Session["SupplierID"] = SupplierID;
            //set the error label to a blank string.
            lblError.Text = "";
            //display the record.
            DisplayRecord();
        }
        else
        //If no record has been selected.
        {
            //Display an error
            lblError.Text = "Please select a record to be edited.";
        }
    }

    
}
