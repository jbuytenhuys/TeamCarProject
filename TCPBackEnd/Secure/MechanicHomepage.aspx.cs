﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyClassLibrary;

public partial class MechanicHomepage : System.Web.UI.Page
{
    Int32 CarRepairID;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayRepairs();
        }
        CarRepairID = Convert.ToInt32(Session["CarRepairID"]);
        txtMechanicDeadlineDate.Text = DateTime.Today.AddDays(60).ToShortDateString();

        lblMechanicUserInfo.Text = "the current user is " + User.Identity.Name;

        if (User.IsInRole("Admins") == true)
        {
            lblMechanicUserInfo.Text = lblMechanicUserInfo.Text + " the user is an admin";
        }
        else
        {
            lblMechanicUserInfo.Text = lblMechanicUserInfo.Text + " the user is not an admin";
        }
        
    }

    void DisplayRepairs()
    {
        clsCarRepairsCollection Repairs = new clsCarRepairsCollection();
        lstMechanicRepairs.DataSource = Repairs.CarRepairList;
        lstMechanicRepairs.DataValueField = "CarRepairID";
        lstMechanicRepairs.DataTextField = "PartRequired";
        lstMechanicRepairs.DataBind();
    }

    void DisplayRecordData()
    {
        CarRepairID = Convert.ToInt32(Session["CarRepairID"]);
        clsCarRepairsCollection CarRepair = new clsCarRepairsCollection();
        CarRepair.ThisCarRepair.Find(CarRepairID);
        txtMechanicRepairID.Text = CarRepair.ThisCarRepair.CarRepairID.ToString();
        txtMechanicDeadlineDate.Text = CarRepair.ThisCarRepair.DeadlineDate.ToShortDateString();
        txtMechanicPartRequired.Text = CarRepair.ThisCarRepair.PartRequired;
        txtMechanicPartPrice.Text = CarRepair.ThisCarRepair.PartPrice.ToString();
        txtMechanicDaysInForRepair.Text = CarRepair.ThisCarRepair.DaysInForRepair.ToString();
        chkMechanicRepairStatus.Checked = CarRepair.ThisCarRepair.RepairStatus;
    }

    void Add()
    {
        //create an instance
        clsCarRepairsCollection CarRepair = new clsCarRepairsCollection();
        //validate the data on webform
        Boolean OK = CarRepair.ThisCarRepair.Valid(Convert.ToInt32(txtMechanicDaysInForRepair.Text), txtMechanicDeadlineDate.Text, Convert.ToDecimal(txtMechanicPartPrice.Text), txtMechanicPartRequired.Text);
        //if data is okay then add to object
        if (OK == true)
        {
            //Fetch data entered by user
            CarRepair.ThisCarRepair.DaysInForRepair = Convert.ToInt32(txtMechanicDaysInForRepair.Text);
            CarRepair.ThisCarRepair.DeadlineDate = Convert.ToDateTime(txtMechanicDeadlineDate.Text);
            CarRepair.ThisCarRepair.PartPrice = Convert.ToDecimal(txtMechanicPartPrice.Text);
            CarRepair.ThisCarRepair.PartRequired = txtMechanicPartRequired.Text;
            CarRepair.ThisCarRepair.RepairStatus = chkMechanicRepairStatus.Checked;
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
        Boolean OK = CarRepair.ThisCarRepair.Valid(Convert.ToInt32(txtMechanicDaysInForRepair.Text), txtMechanicDeadlineDate.Text, Convert.ToDecimal(txtMechanicPartPrice.Text), txtMechanicPartRequired.Text);
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
            CarRepair.ThisCarRepair.RepairStatus = chkMechanicRepairStatus.Checked;
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

    void Filter()
    {
        //create an instance
        clsCarRepairsCollection CarRepair = new clsCarRepairsCollection();
        CarRepair.ThisCarRepair.PartRequired = txtMechanicFilter.Text;
        CarRepair.FilterByPartRequired(CarRepair.ThisCarRepair.PartRequired);
        lstMechanicRepairs.DataSource = CarRepair.CarRepairList;
        lstMechanicRepairs.DataValueField = "CarRepairID";
        lstMechanicRepairs.DataTextField = "PartRequired";
        lstMechanicRepairs.DataBind();
    }



    protected void btnMechanicLogout_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }


    protected void ddlMechanicFilterBy_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void txtMechanicFilter_Click(object sender, EventArgs e)
    {

    }

    protected void btnMechanicFilter_Click(object sender, EventArgs e)
    {
        Filter();
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
        Add();
    }

    protected void btnMechanicUpdateRepair_Click(object sender, EventArgs e)
    {
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
}