<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReceptionistHomepage.aspx.cs" Inherits="ReceptionistHomepage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="StyleSheet.css" />
</head>
<body>
    <form id="form1" runat="server">


        <asp:Button CssClass="ReceptionistButton" ID="btnReceptionistLogout" runat="server" style="z-index: 1; left: 29px; top: 67px; position: absolute; height: 63px; width: 115px" Text="Logout" />

        <asp:DropDownList CssClass="DropDownMenu" ID="DDlstReceptionistManufacturerFilter" runat="server" style="z-index: 1; left: 79px; top: 182px; position: absolute; width: 124px">
        </asp:DropDownList>

        <asp:DropDownList CssClass="DropDownMenu" ID="DDlstReceptionistModelFilter" runat="server" style="z-index: 1; left: 79px; top: 214px; position: absolute; width: 124px; height: 22px">
        </asp:DropDownList>


        <asp:DropDownList CssClass="DropDownMenu" ID="DDlstReceptionistYearFilter" runat="server" style="z-index: 1; left: 80px; top: 246px; position: absolute; height: 22px; width: 124px">
        </asp:DropDownList>

        <asp:Button CssClass="ReceptionistButton" ID="btnReceptionistFilterCars" runat="server" style="z-index: 1; left: 85px; top: 294px; position: absolute; height: 53px; width: 109px" Text="Filter Cars" />

        <asp:ListBox CssClass="ReceptionistButton" ID="lstBoxReceptionistListCars" runat="server" style="z-index: 1; left: 348px; top: 97px; position: absolute; height: 355px; width: 414px; margin-top: 16px"></asp:ListBox>

        <asp:Button CssClass="ReceptionistButton" ID="btnReceptionistListAllCars" runat="server" style="z-index: 1; left: 500px; top: 498px; position: absolute; height: 63px; width: 132px" Text="List All Cars" />


        <asp:Button ID="btnReceptionistAddCar" runat="server" style="z-index: 1; left: 819px; top: 554px; position: absolute; height: 51px; width: 86px; margin-bottom: 0px;" Text="Add Car" />
        <asp:Button ID="btnReceptionistArchive" runat="server" style="z-index: 1; left: 1026px; top: 564px; position: absolute" Text="Archive" />
        <asp:Button ID="btnReceptionistUpdate" runat="server" style="z-index: 1; left: 933px; top: 575px; position: absolute" Text="Update" />
        <asp:DropDownList ID="DDlstReceptionistManufacturer" runat="server" style="z-index: 1; left: 853px; top: 149px; position: absolute; width: 277px">
        </asp:DropDownList>
        <asp:TextBox ID="txtReceptionistCarModel" runat="server" style="z-index: 1; left: 853px; top: 183px; position: absolute; width: 269px">Car Model</asp:TextBox>
        <asp:TextBox ID="txtReceptionistCarColour" runat="server" style="z-index: 1; left: 858px; top: 220px; position: absolute; width: 264px">Car Colour</asp:TextBox>
        <asp:TextBox ID="txtReceptionistCarRegistrationPlate" runat="server" style="z-index: 1; left: 852px; top: 268px; position: absolute; width: 276px">Car Registration Plate</asp:TextBox>
        <asp:TextBox ID="txtReceptionistCarNumberOfDoors" runat="server" style="z-index: 1; left: 852px; top: 311px; position: absolute; width: 279px">Number Of Doors</asp:TextBox>
        <asp:TextBox ID="txtReceptionistCarNumberOfSeats" runat="server" style="z-index: 1; left: 855px; top: 355px; position: absolute; width: 279px">Number Of Seats</asp:TextBox>
        <asp:CheckBox ID="ChkBoxReceptionistNeedsRepair" CssClass="CheckBoxText" runat="server" style="z-index: 1; left: 881px; top: 395px; position: absolute" Text="Check for yes, leave unchecked for no" />
        <asp:CheckBox ID="ChkBoxReceptionistSold" CssClass="CheckBoxText" runat="server" style="z-index: 1; left: 886px; top: 472px; position: absolute" Text="Check for yes, leave unchecked for no" />


        <asp:Label ID="lblReceptionistNeedsRepair" runat="server" Font-Size="Large" style="z-index: 1; left: 772px; top: 404px; position: absolute" Text="Needs Repair?"></asp:Label>
        <asp:Label ID="lblReceptionistSold" runat="server" Font-Size="Large" style="z-index: 1; left: 774px; top: 470px; position: absolute; margin-bottom: 0px" Text="Sold?"></asp:Label>


    </form>
</body>
</html>
