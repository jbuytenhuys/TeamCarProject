<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReceptionistHomepage.aspx.cs" Inherits="ReceptionistHomepage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="StyleSheet.css" />
</head>
<body>
    <form id="form1" runat="server">


        <asp:Button CssClass="ReceptionistButton" ID="btnReceptionistLogout" runat="server" style="z-index: 1; left: 29px; top: 67px; position: absolute; height: 63px; width: 115px" Text="Logout" OnClick="btnReceptionistLogout_Click" />

        <asp:Button CssClass="ReceptionistButton" ID="btnReceptionistFilterCars" runat="server" style="z-index: 1; left: 74px; top: 434px; position: absolute; height: 53px; width: 122px" Text="Filter Cars" OnClick="btnReceptionistFilterCars_Click" />

        <asp:ListBox CssClass="ListBoxes"  ID="lstBoxReceptionistListCars" runat="server" style="z-index: 1; left: 261px; top: 109px; position: absolute; height: 355px; width: 414px; margin-top: 16px"></asp:ListBox>

        <asp:Button CssClass="ReceptionistButton" ID="btnReceptionistListAllCars" runat="server" style="z-index: 1; left: 337px; top: 496px; position: absolute; height: 63px; width: 148px" Text="List All Cars" OnClick="btnReceptionistListAllCars_Click" />

        <asp:Button CssClass="ReceptionistButton" ID="btnReceptionistAddCar" runat="server" style="z-index: 1; left: 855px; top: 555px; position: absolute; height: 51px; width: 102px;" Text="Add Car" OnClick="btnReceptionistAddCar_Click" />

        <asp:Button CssClass="ReceptionistButton" ID="btnReceptionistArchive" runat="server" style="z-index: 1; left: 1078px; top: 554px; position: absolute; height: 51px; width: 102px;" Text="Archive" OnClick="btnReceptionistArchive_Click" />

        <asp:Button CssClass="ReceptionistButton" ID="btnReceptionistUpdate" runat="server" style="z-index: 1; left: 968px; top: 554px; position: absolute; height: 51px; width: 102px;" Text="Update" OnClick="btnReceptionistUpdate_Click" />

        <asp:Button ID="btnReceptionistViewSelectedData" runat="server" CssClass="ReceptionistButton" OnClick="btnReceptionistViewSelectedData_Click" style="z-index: 1; left: 506px; top: 495px; position: absolute; height: 66px; width: 118px; " Text="View Data" />

        <asp:TextBox CssClass="TextBoxes" ID="txtReceptionistCarModel" runat="server" OnClick="this.value=''" style="z-index: 1; left: 840px; top: 289px; position: absolute; width: 288px" >Car Model</asp:TextBox>

        <asp:TextBox CssClass="TextBoxes" ID="txtReceptionistCarRegistrationPlate" runat="server" OnClick="this.value=''" style="z-index: 1; left: 837px; top: 253px; position: absolute; width: 290px; margin-bottom: 1px;">Car Registration Plate</asp:TextBox>

        <asp:TextBox CssClass="TextBoxes" ID="txtReceptionistCarNumberOfDoors" runat="server" OnClick="this.value=''" style="z-index: 1; left: 840px; top: 357px; position: absolute; width: 291px">Number Of Doors</asp:TextBox>

        <asp:TextBox CssClass="TextBoxes" ID="txtReceptionistCarNumberOfSeats" runat="server" OnClick="this.value=''" style="z-index: 1; left: 839px; top: 393px; position: absolute; width: 290px">Number Of Seats</asp:TextBox>

        <asp:CheckBox ID="ChkBoxReceptionistNeedsRepair" CssClass="CheckBoxText" runat="server" style="z-index: 1; left: 835px; top: 437px; position: absolute" Text="Check for yes, leave unchecked for no" Font-Size="Large" />

        <asp:CheckBox ID="ChkBoxReceptionistSold" CssClass="CheckBoxText" runat="server" style="z-index: 1; left: 837px; top: 472px; position: absolute; width: 392px;" Text="Check for yes, leave unchecked for no" Font-Size="Large" />
        
        <asp:Label ID="lblReceptionistNeedsRepair" runat="server" Font-Size="Large" style="z-index: 1; left: 727px; top: 437px; position: absolute" Text="Needs Repair?"></asp:Label>

        <asp:Label ID="lblReceptionistSold" runat="server" Font-Size="Large" style="z-index: 1; left: 763px; top: 475px; position: absolute; margin-bottom: 0px" Text="Sold?"></asp:Label>

        <asp:TextBox CssClass="TextBoxes" ID="txtReceptionistCarID" runat="server" style="z-index: 1; left: 835px; top: 145px; position: absolute; width: 284px" ReadOnly="True"></asp:TextBox>

        <asp:TextBox ID="txtReceptionistCarManufacturer" runat="server" OnClick="this.value=''" CssClass="TextBoxes" style="z-index: 1; left: 836px; top: 221px; position: absolute; width: 290px">Car Manufacturer</asp:TextBox>

        


        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 423px; top: 593px; position: absolute"></asp:Label>


        <asp:TextBox ID="txtReceptionistCarColour" runat="server" OnClick="this.value=''" CssClass="TextBoxes" style="z-index: 1; left: 839px; top: 322px; position: absolute; width: 284px">Car Colour</asp:TextBox>


        <asp:Button ID="btnReceptionistReset" runat="server" CssClass="ReceptionistButton" OnClick="btnReceptionistReset_Click" style="z-index: 1; left: 880px; top: 67px; position: absolute;" Text="Reset Form" />


        <asp:TextBox ID="txtReceptionistFilterByCarManufacturer" runat="server" CssClass="TextBoxes" style="z-index: 1; left: 50px; top: 397px; position: absolute; width: 178px">Car Manufacturer</asp:TextBox>

        <asp:Button ID="btnReceptionistSearchSupplier" runat="server" CssClass="ReceptionistButton" style="z-index: 1; left: 34px; top: 314px; position: absolute; height: 56px; width: 199px" Text="Search Supplier" OnClick="btnReceptionistSearchSupplier_Click" />

        <asp:TextBox ID="txtReceptionistSearchSupplier" runat="server" OnClick="this.value=''" CssClass="TextBoxes" style="z-index: 1; left: 29px; top: 259px; position: absolute; width: 190px">Supplier Email</asp:TextBox>

        <asp:TextBox ID="txtReceptionistSupplierID" runat="server" CssClass="TextBoxes" ReadOnly="True" style="z-index: 1; left: 837px; top: 184px; position: absolute; width: 283px"></asp:TextBox>

        <asp:Button ID="btnReceptionistFetchSupplierID" runat="server" CssClass="ReceptionistButton" Font-Size="Medium" style="z-index: 1; left: 692px; top: 180px; position: absolute; height: 33px; width: 140px" Text="Fetch Supplier ID" OnClick="btnReceptionistFetchSupplierID_Click" />


        <asp:Label ID="lblReceptionistInfo" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute" Text="-"></asp:Label>


    </form>
</body>
</html>
