using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
        MyClassLibrary.clsCarsCollection Cars = new MyClassLibrary.clsCarsCollection();
        //Set the data source to the list of cars in the collection.
        lstBoxReceptionistListCars.DataSource = Cars.CarList;
        //Set the name of the primary
        lstBoxReceptionistListCars.DataValueField = "CarID";
        //set the data field to display.
        lstBoxReceptionistListCars.DataTextField = "CarRegistrationPlate";
        //Bind the data to the list.
        lstBoxReceptionistListCars.DataBind();
    }

    protected void btnReceptionistLogout_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }



    protected void txtReceptionistCarModel_TextChanged(object sender, EventArgs e)
    {
       
    }
}
