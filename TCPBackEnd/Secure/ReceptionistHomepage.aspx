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

        <asp:DropDownList CssClass="DropDownMenu" ID="DDlstReceptionistManufacturerFilter" runat="server" style="z-index: 1; left: 79px; top: 182px; position: absolute; width: 124px">
        </asp:DropDownList>

        <asp:DropDownList CssClass="DropDownMenu" ID="DDlstReceptionistModelFilter" runat="server" style="z-index: 1; left: 79px; top: 214px; position: absolute; width: 124px; height: 22px">
        </asp:DropDownList>


        <asp:DropDownList CssClass="DropDownMenu" ID="DDlstReceptionistYearFilter" runat="server" style="z-index: 1; left: 80px; top: 246px; position: absolute; height: 22px; width: 124px">
        </asp:DropDownList>

        <asp:Button CssClass="ReceptionistButton" ID="btnReceptionistFilterCars" runat="server" style="z-index: 1; left: 85px; top: 294px; position: absolute; height: 53px; width: 109px" Text="Filter Cars" />

        <asp:ListBox CssClass="ListBoxes"  ID="lstBoxReceptionistListCars" runat="server" style="z-index: 1; left: 348px; top: 97px; position: absolute; height: 355px; width: 414px; margin-top: 16px"></asp:ListBox>

        <asp:Button CssClass="ReceptionistButton" ID="btnReceptionistListAllCars" runat="server" style="z-index: 1; left: 388px; top: 502px; position: absolute; height: 63px; width: 132px" Text="List All Cars" OnClick="btnReceptionistListAllCars_Click" />

        <asp:Button CssClass="ReceptionistButton" ID="btnReceptionistAddCar" runat="server" style="z-index: 1; left: 810px; top: 555px; position: absolute; height: 51px; width: 102px; margin-bottom: 0px;" Text="Add Car" OnClick="btnReceptionistAddCar_Click" />

        <asp:Button CssClass="ReceptionistButton" ID="btnReceptionistArchive" runat="server" style="z-index: 1; left: 1038px; top: 554px; position: absolute; height: 51px; width: 86px;" Text="Archive" OnClick="btnReceptionistArchive_Click" />

        <asp:Button CssClass="ReceptionistButton" ID="btnReceptionistUpdate" runat="server" style="z-index: 1; left: 930px; top: 554px; position: absolute; height: 51px; width: 86px; right: 471px;" Text="Update" />

        <asp:TextBox CssClass="TextBoxes" ID="txtReceptionistCarModel" runat="server" OnClick="this.value=''" style="z-index: 1; left: 849px; top: 187px; position: absolute; width: 288px" >Car Model</asp:TextBox>

        <asp:TextBox CssClass="TextBoxes" ID="txtReceptionistCarRegistrationPlate" runat="server" style="z-index: 1; left: 852px; top: 268px; position: absolute; width: 290px">Car Registration Plate</asp:TextBox>

        <asp:TextBox CssClass="TextBoxes" ID="txtReceptionistCarNumberOfDoors" runat="server" style="z-index: 1; left: 852px; top: 311px; position: absolute; width: 291px">Number Of Doors</asp:TextBox>

        <asp:TextBox CssClass="TextBoxes" ID="txtReceptionistCarNumberOfSeats" runat="server" style="z-index: 1; left: 852px; top: 355px; position: absolute; width: 290px">Number Of Seats</asp:TextBox>

        <asp:CheckBox ID="ChkBoxReceptionistNeedsRepair" CssClass="CheckBoxText" runat="server" style="z-index: 1; left: 881px; top: 395px; position: absolute" Text="Check for yes, leave unchecked for no" />

        <asp:CheckBox ID="ChkBoxReceptionistSold" CssClass="CheckBoxText" runat="server" style="z-index: 1; left: 886px; top: 472px; position: absolute" Text="Check for yes, leave unchecked for no" />
        
        <asp:Label ID="lblReceptionistNeedsRepair" runat="server" Font-Size="Large" style="z-index: 1; left: 772px; top: 404px; position: absolute" Text="Needs Repair?"></asp:Label>

        <asp:Label ID="lblReceptionistSold" runat="server" Font-Size="Large" style="z-index: 1; left: 774px; top: 470px; position: absolute; margin-bottom: 0px" Text="Sold?"></asp:Label>

        <asp:TextBox CssClass="TextBoxes" ID="txtReceptionistCarID" runat="server" style="z-index: 1; left: 854px; top: 113px; position: absolute; width: 284px" ReadOnly="True"></asp:TextBox>

        <asp:TextBox ID="txtReceptionistCarManufacturer" runat="server" CssClass="TextBoxes" style="z-index: 1; left: 854px; top: 149px; position: absolute; width: 290px">Car Manufacturer</asp:TextBox>

        <asp:Button ID="btnReceptionistEdit" runat="server" CssClass="ReceptionistButton" OnClick="btnReceptionistEdit_Click" style="z-index: 1; left: 568px; top: 502px; position: absolute; height: 58px; width: 100px; right: 586px" Text="Edit" />


        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 423px; top: 593px; position: absolute"></asp:Label>


        <asp:TextBox ID="txtReceptionistCarColour" runat="server" CssClass="TextBoxes" style="z-index: 1; left: 850px; top: 230px; position: absolute; width: 284px">Car Colour</asp:TextBox>


    </form>
</body>
</html>
