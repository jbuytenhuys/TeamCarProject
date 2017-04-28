using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyClassLibrary;

public partial class MechanicHomepage : System.Web.UI.Page
{
    Int32 CarRepairID;
    Int32 CarID;
    Int32 StaffID;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayRepairs();
        }
        CarRepairID = Convert.ToInt32(Session["CarRepairID"]);
        txtMechanicDeadlineDate.Text = DateTime.Today.AddDays(60).ToShortDateString();

        lblMechanicUserInfo.Text = "the current user is " + User.Identity.Name;
        
    }

    //Function to display records from the database
    void DisplayRepairs()
    {
        //Create instance in repair collection class
        clsCarRepairsCollection Repairs = new clsCarRepairsCollection();
        //set the datasource for the list box to the car repair list
        lstMechanicRepairs.DataSource = Repairs.CarRepairList;
        //Give each line the value of primary CarRepairID
        lstMechanicRepairs.DataValueField = "CarRepairID";
        //Show the part required field in the list
        lstMechanicRepairs.DataTextField = "PartRequired";
        //Bind the data to the list
        lstMechanicRepairs.DataBind();
    }

    void DisplayRecordData()
    {
        //set variable equal to the session number
        CarRepairID = Convert.ToInt32(Session["CarRepairID"]);
        //Create instance in repair collection class
        clsCarRepairsCollection CarRepair = new clsCarRepairsCollection();
        //run carRepairId through the find function
        CarRepair.ThisCarRepair.Find(CarRepairID);
        //assign the data from records in the database to the text boxes
        txtMechanicRepairID.Text = CarRepair.ThisCarRepair.CarRepairID.ToString();
        txtMechanicDeadlineDate.Text = CarRepair.ThisCarRepair.DeadlineDate.ToShortDateString();
        txtMechanicPartRequired.Text = CarRepair.ThisCarRepair.PartRequired;
        txtMechanicPartPrice.Text = CarRepair.ThisCarRepair.PartPrice.ToString();
        txtMechanicDaysInForRepair.Text = CarRepair.ThisCarRepair.DaysInForRepair.ToString();
        txtMechanicCarID.Text = CarRepair.ThisCarRepair.CarID.ToString();
        txtMechanicStaffID.Text = CarRepair.ThisCarRepair.StaffID.ToString();
    }

    void FetchCarID()
    {
        //set variable equal to the session number
        CarID = Convert.ToInt32(Session["CarID"]);
        //Create instance in car class
        clsCarsCollection Car = new clsCarsCollection();
        //run carId through the find function
        Car.ThisCar.Find(CarID);
        //assign the data from record in the database to the text box
        txtMechanicCarID.Text = Car.ThisCar.CarID.ToString();  
    }

    void FetchStaffID()
    {
        //set variable equal to the session number
        StaffID = Convert.ToInt32(Session["StaffID"]);
        //Create instance in car class
        clsStaffCollection Staff = new clsStaffCollection();
        //run carId through the find function
        Staff.ThisStaff.Find(StaffID);
        //assign the data from record in the database to the text box
        txtMechanicStaffID.Text = Staff.ThisStaff.StaffID.ToString();
    }

    void Add()
    {
        //create an instance
        clsCarRepairsCollection CarRepair = new clsCarRepairsCollection();
        //validate the data on webform
        Boolean OK = CarRepair.ThisCarRepair.Valid(txtMechanicDaysInForRepair.Text, txtMechanicDeadlineDate.Text, txtMechanicPartPrice.Text, txtMechanicPartRequired.Text, txtMechanicCarID.Text, txtMechanicStaffID.Text);
        //if data is okay then add to object
        if (OK == true)
        {
            //Fetch data entered by user
            CarRepair.ThisCarRepair.DaysInForRepair = Convert.ToInt32(txtMechanicDaysInForRepair.Text);
            CarRepair.ThisCarRepair.DeadlineDate = Convert.ToDateTime(txtMechanicDeadlineDate.Text);
            CarRepair.ThisCarRepair.PartPrice = Convert.ToDecimal(txtMechanicPartPrice.Text);
            CarRepair.ThisCarRepair.PartRequired = txtMechanicPartRequired.Text;
            CarRepair.ThisCarRepair.CarID = Convert.ToInt32(txtMechanicCarID.Text);
            CarRepair.ThisCarRepair.StaffID = Convert.ToInt32(txtMechanicStaffID.Text);
            //add record
            CarRepair.Add();
            Response.Redirect("MechanicHomepage.aspx");
            lblMechanicError.Text = "Repair successfully added";
        }
        else
        {
            //report error
            lblMechanicError.Text = "There were problems with the data you have entered, please try again";
        }
    }
    void Update()
    {
        //create an instance
        clsCarRepairsCollection CarRepair = new clsCarRepairsCollection();
        //validate the data on webform
        Boolean OK = CarRepair.ThisCarRepair.Valid(txtMechanicDaysInForRepair.Text, txtMechanicDeadlineDate.Text, txtMechanicPartPrice.Text, txtMechanicPartRequired.Text, txtMechanicCarID.Text, txtMechanicStaffID.Text);
        //if data is okay then add to object
        if (OK == true)
        {
            //Find record to update
            CarRepair.ThisCarRepair.Find(CarRepairID);
            //Fetch data entered by user
            CarRepair.ThisCarRepair.DaysInForRepair = Convert.ToInt32(txtMechanicDaysInForRepair.Text);
            CarRepair.ThisCarRepair.DeadlineDate = Convert.ToDateTime(txtMechanicDeadlineDate.Text);
            CarRepair.ThisCarRepair.PartPrice = Convert.ToDecimal(txtMechanicPartPrice.Text);
            CarRepair.ThisCarRepair.PartRequired = txtMechanicPartRequired.Text;
            CarRepair.ThisCarRepair.CarID = Convert.ToInt32(txtMechanicCarID.Text);
            CarRepair.ThisCarRepair.StaffID = Convert.ToInt32(txtMechanicStaffID.Text);
            //update record
            CarRepair.Update();
            Response.Redirect("MechanicHomepage.aspx");
            lblMechanicError.Text = "Repair successfully added";
        }
        else
        {
            //report error
            lblMechanicError.Text = "There were problems with the data you have entered, please try again";
        }
    }

    void FilterRepairs()
    {
        //create an instance
        clsCarRepairsCollection CarRepair = new clsCarRepairsCollection();
        //Pass the text box value through the filter method
        CarRepair.ThisCarRepair.PartRequired = txtMechanicFilter.Text;
        CarRepair.FilterByPartRequired(CarRepair.ThisCarRepair.PartRequired);
        //set the datasource for the list boc to the car repair list
        lstMechanicRepairs.DataSource = CarRepair.CarRepairList;
        //Give each line the value of primary CarRepairID
        lstMechanicRepairs.DataValueField = "CarRepairID";
        //Show the part required field in the list
        lstMechanicRepairs.DataTextField = "PartRequired";
        //Bind the data to the list
        lstMechanicRepairs.DataBind();  
    }

    void FilterByRegPlate()
    {
        //create an instance
        clsCarsCollection Cars = new clsCarsCollection();
        //Pass the text box value through the filter method
        Cars.ThisCar.CarRegistrationPlate = txtMechanicRegPlateFilter.Text;
        Cars.FilterByRegPlate(Cars.ThisCar.CarRegistrationPlate);
        //set the datasource for the list boc to the car repair list
        lstMechanicRepairs.DataSource = Cars.CarList;
        //Show the part required field in the list
        lstMechanicRepairs.DataValueField = "CarID";
        //Show the part required field in the list
        lstMechanicRepairs.DataTextField = "CarRegistrationPlate";
        //Bind the data to the list
        lstMechanicRepairs.DataBind();
    }

    void FilterByStaffirstName()
    {
        //create an instance
        clsStaffCollection Staff = new clsStaffCollection();
        //Pass the text box value through the filter method
        Staff.FilterByStaffFirstName(txtMechanicStaffFilter.Text);
        lstMechanicRepairs.DataSource = Staff.StaffList;
        //Show the part required field in the list
        lstMechanicRepairs.DataValueField = "StaffID";
        //Show the part required field in the list
        lstMechanicRepairs.DataTextField = "StaffFirstName";
        //Bind the data to the list
        lstMechanicRepairs.DataBind();
    }


    protected void btnMechanicLogout_Click(object sender, EventArgs e)
    {
        Response.Redirect("../Login.aspx");
    }


    protected void ddlMechanicFilterBy_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void txtMechanicFilter_Click(object sender, EventArgs e)
    {

    }

    protected void btnMechanicFilter_Click(object sender, EventArgs e)
    {
        FilterRepairs();
    }

    protected void lstMechanicRepairs_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnMechanicListAll_Click(object sender, EventArgs e)
    {
        DisplayRepairs();
    }

    protected void txtMechanicRepairID_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtMechanicDeadlineDate_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtMechanicPartRequired_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtMechanicPartPrice_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnMechanicAddRepair_Click(object sender, EventArgs e)
    {
        //Call the Add function
        Add();
    }

    protected void btnMechanicUpdateRepair_Click(object sender, EventArgs e)
    {
        //Call the Update function
        Update();
    }

    protected void btnMechanicDeleteRepair_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 CarRepairID;
        //if a record has been selected form the list
        if (lstMechanicRepairs.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            CarRepairID = Convert.ToInt32(lstMechanicRepairs.SelectedValue);
            //store the data in the session object
            Session["CarRepairID"] = CarRepairID;
            //redirect to delete confirmation page
            Response.Redirect("MechanicArchive.aspx");
        }
        else
        {
            lblMechanicError.Text = "please select a record to delete from the list";
        }
    }



    protected void btnMechanicViewData_Click(object sender, EventArgs e)
    {

        if (lstMechanicRepairs.SelectedIndex != -1)
        {
            CarRepairID = Convert.ToInt32(lstMechanicRepairs.SelectedValue);
            Session["CarRepairID"] = CarRepairID;
            DisplayRecordData();

        }
        else
        {
            lblMechanicError.Text = ("Please select a record to view from the list");
        }
    }

    protected void btnMechanicReset_Click(object sender, EventArgs e)
    {
        Response.Redirect("MechanicHomepage.aspx");
    }

    protected void txtMechanicManufacturerFilter_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtMechanicCarID_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnMechanicFetchCarID_Click(object sender, EventArgs e)
    {
        if (lstMechanicRepairs.SelectedIndex != -1)
        {
            CarID = Convert.ToInt32(lstMechanicRepairs.SelectedValue);
            Session["CarID"] = CarID;
            FetchCarID();

        }
        else
        {
            lblMechanicError.Text = ("Please select a record to view from the list");
        }
    }

    protected void btnMechanicRegPlateFilter_Click(object sender, EventArgs e)
    {
        FilterByRegPlate();
    }

    protected void btnMechanicStaffFilter_Click(object sender, EventArgs e)
    {
        FilterByStaffirstName();
    }

    protected void btnMechanicFetchStaffID_Click(object sender, EventArgs e)
    {
        if (lstMechanicRepairs.SelectedIndex != -1)
        {
            StaffID = Convert.ToInt32(lstMechanicRepairs.SelectedValue);
            Session["StaffID"] = StaffID;
            FetchStaffID();
        }
        else
        {
            lblMechanicError.Text = ("Please select a record to view from the list");
        }
    }
}