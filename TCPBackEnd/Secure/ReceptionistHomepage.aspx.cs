﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyClassLibrary;

public partial class ReceptionistHomepage : System.Web.UI.Page
{
    //Variable to store the primary key of the record.
    Int32 CarID;

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

    void Update()
        //function for updating records.
    {
        //create an instance.
        clsCarsCollection Cars = new clsCarsCollection();
        //validate the data on the web form.
        Boolean OK = Cars.ThisCar.Valid(txtReceptionistCarManufacturer.Text, txtReceptionistCarModel.Text, txtReceptionistCarRegistrationPlate.Text, txtReceptionistCarColour.Text, Convert.ToInt32(txtReceptionistCarNumberOfDoors.Text), Convert.ToInt32(txtReceptionistCarNumberOfSeats.Text));
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
            //update the record
            Cars.Update();
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
        Response.Redirect("Default.aspx");
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

    protected void btnReceptionistEdit_Click(object sender, EventArgs e)
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
            lblError.Text = "";
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
        txtReceptionistCarID.Text = "";
        txtReceptionistCarManufacturer.Text = "Car Manufacturer";
        txtReceptionistCarModel.Text = "Car Model";
        txtReceptionistCarRegistrationPlate.Text = "Car Registration Plate";
        txtReceptionistCarColour.Text = "Car Colour";
        txtReceptionistCarNumberOfDoors.Text = "Number Of Doors";
        txtReceptionistCarNumberOfSeats.Text = "Number Of Seats";
        ChkBoxReceptionistNeedsRepair.Checked = false;
        ChkBoxReceptionistSold.Checked = false;
    }
}
