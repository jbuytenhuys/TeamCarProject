using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MechanicHomepage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayRepairs();
        }
    }

    void DisplayRepairs()
    {
        MyClassLibrary.clsCarRepairsCollection Repairs = new MyClassLibrary.clsCarRepairsCollection();
        lstMechanicRepairs.DataSource = Repairs.CarRepairList;
        lstMechanicRepairs.DataValueField = "CarRepairID";
        lstMechanicRepairs.DataTextField = "PartRequired";
        lstMechanicRepairs.DataBind();
    }

    void Add()
    {
        //create an instance
        MyClassLibrary.clsCarRepairsCollection CarRepair = new MyClassLibrary.clsCarRepairsCollection();
        //validate the data on webform
        Boolean OK = CarRepair.ThisCarRepair.Valid(Convert.ToInt32(txtDaysInForRepair.Text), txtMechanicDeadlineDate.Text, Convert.ToDecimal(txtMechanicPartPrice.Text), txtMechanicPartRequired.Text);
        //if data is okay then add to object
        if (OK == true)
        {
            //Fetch data entered by user
            CarRepair.ThisCarRepair.DaysInForRepair = Convert.ToInt32(txtDaysInForRepair.Text);
            CarRepair.ThisCarRepair.DeadlineDate = Convert.ToDateTime(txtMechanicDeadlineDate.Text);
            CarRepair.ThisCarRepair.PartPrice = Convert.ToDecimal(txtMechanicPartPrice.Text);
            CarRepair.ThisCarRepair.PartRequired = txtMechanicPartRequired.Text;
            CarRepair.ThisCarRepair.RepairStatus = chkMechanicRepairStatus.Checked;
            //add record
            CarRepair.Add();
            lblMechanicError.Text = "Repair successfully added";
        }
        else
        {
            //report error
            lblMechanicError.Text = "There were problems with the data you have entered, please try again";
        }
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
            Response.Redirect("MechanicDelete.aspx");
        }
        else
        {
            lblMechanicError.Text = "please select a record to delete from the list";
        }
    }

    
}