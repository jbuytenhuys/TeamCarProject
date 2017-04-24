using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyClassLibrary;

public partial class ReceptionistHomepage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed.
        if (IsPostBack == false)
        {
            //update the list box.
            DisplayCars();
       
        }
    }
     
    void DisplayCars()
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
        //create an instance
        clsCarsCollection Cars = new clsCarsCollection();
        //validate the data on the web form
        Boolean OK = Cars.ThisCar.Valid(txtReceptionistCarManufacturer.Text, txtReceptionistCarModel.Text, txtReceptionistCarRegistrationPlate.Text, txtReceptionistCarColour.Text, Convert.ToInt32(txtReceptionistCarNumberOfDoors.Text), Convert.ToInt32(txtReceptionistCarNumberOfSeats.Text));
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
            //add the record
            Cars.Add();
        }
        else
        {
            //report the error
            lblError.Text = "There were problems with the data entered";
        }
    }

    


    protected void btnReceptionistLogout_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }



    protected void txtReceptionistCarModel_TextChanged(object sender, EventArgs e)
    {
       
    }

    protected void btnReceptionistAddCar_Click(object sender, EventArgs e)
    {
       Add();
        
    }


    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
}
