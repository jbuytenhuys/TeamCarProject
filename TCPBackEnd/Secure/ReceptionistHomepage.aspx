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

        <asp:DropDownList CssClass="DropDownMenu" ID="DDlstReceptionistManufacturerFilter" runat="server" style="z-index: 1; left: 61px; top: 214px; position: absolute; width: 173px; height: 22px;">
        </asp:DropDownList>

        <asp:DropDownList CssClass="DropDownMenu" ID="DDlstReceptionistModelFilter" runat="server" style="z-index: 1; left: 60px; top: 246px; position: absolute; width: 175px; height: 19px">
        </asp:DropDownList>


        <asp:DropDownList CssClass="DropDownMenu" ID="DDlstReceptionistYearFilter" runat="server" style="z-index: 1; left: 63px; top: 182px; position: absolute; height: 22px; width: 180px">
        </asp:DropDownList>

        <asp:Button CssClass="ReceptionistButton" ID="btnReceptionistFilterCars" runat="server" style="z-index: 1; left: 83px; top: 316px; position: absolute; height: 53px; width: 122px" Text="Filter Cars" OnClick="btnReceptionistFilterCars_Click" />

        <asp:ListBox CssClass="ListBoxes"  ID="lstBoxReceptionistListCars" runat="server" style="z-index: 1; left: 348px; top: 97px; position: absolute; height: 355px; width: 414px; margin-top: 16px"></asp:ListBox>

        <asp:Button CssClass="ReceptionistButton" ID="btnReceptionistListAllCars" runat="server" style="z-index: 1; left: 388px; top: 502px; position: absolute; height: 63px; width: 148px" Text="List All Cars" OnClick="btnReceptionistListAllCars_Click" />

        <asp:Button CssClass="ReceptionistButton" ID="btnReceptionistAddCar" runat="server" style="z-index: 1; left: 858px; top: 554px; position: absolute; height: 51px; width: 102px;" Text="Add Car" OnClick="btnReceptionistAddCar_Click" />

        <asp:Button CssClass="ReceptionistButton" ID="btnReceptionistArchive" runat="server" style="z-index: 1; left: 1078px; top: 554px; position: absolute; height: 51px; width: 102px;" Text="Archive" OnClick="btnReceptionistArchive_Click" />

        <asp:Button CssClass="ReceptionistButton" ID="btnReceptionistUpdate" runat="server" style="z-index: 1; left: 968px; top: 554px; position: absolute; height: 51px; width: 102px;" Text="Update" OnClick="btnReceptionistUpdate_Click" />

        <asp:Button ID="btnReceptionistEdit" runat="server" CssClass="ReceptionistButton" OnClick="btnReceptionistEdit_Click" style="z-index: 1; left: 555px; top: 499px; position: absolute; height: 66px; width: 105px; " Text="Edit" />

        <asp:TextBox CssClass="TextBoxes" ID="txtReceptionistCarModel" runat="server" OnClick="this.value=''" style="z-index: 1; left: 849px; top: 187px; position: absolute; width: 288px" >Car Model</asp:TextBox>

        <asp:TextBox CssClass="TextBoxes" ID="txtReceptionistCarRegistrationPlate" runat="server" style="z-index: 1; left: 852px; top: 268px; position: absolute; width: 290px">Car Registration Plate</asp:TextBox>

        <asp:TextBox CssClass="TextBoxes" ID="txtReceptionistCarNumberOfDoors" runat="server" style="z-index: 1; left: 852px; top: 311px; position: absolute; width: 291px">Number Of Doors</asp:TextBox>

        <asp:TextBox CssClass="TextBoxes" ID="txtReceptionistCarNumberOfSeats" runat="server" style="z-index: 1; left: 852px; top: 355px; position: absolute; width: 290px">Number Of Seats</asp:TextBox>

        <asp:CheckBox ID="ChkBoxReceptionistNeedsRepair" CssClass="CheckBoxText" runat="server" style="z-index: 1; left: 881px; top: 395px; position: absolute" Text="Check for yes, leave unchecked for no" Font-Size="X-Large" />

        <asp:CheckBox ID="ChkBoxReceptionistSold" CssClass="CheckBoxText" runat="server" style="z-index: 1; left: 886px; top: 472px; position: absolute" Text="Check for yes, leave unchecked for no" Font-Size="X-Large" />
        
        <asp:Label ID="lblReceptionistNeedsRepair" runat="server" Font-Size="Large" style="z-index: 1; left: 772px; top: 404px; position: absolute" Text="Needs Repair?"></asp:Label>

        <asp:Label ID="lblReceptionistSold" runat="server" Font-Size="Large" style="z-index: 1; left: 774px; top: 470px; position: absolute; margin-bottom: 0px" Text="Sold?"></asp:Label>

        <asp:TextBox CssClass="TextBoxes" ID="txtReceptionistCarID" runat="server" style="z-index: 1; left: 854px; top: 113px; position: absolute; width: 284px" ReadOnly="True"></asp:TextBox>

        <asp:TextBox ID="txtReceptionistCarManufacturer" runat="server" CssClass="TextBoxes" style="z-index: 1; left: 854px; top: 149px; position: absolute; width: 290px">Car Manufacturer</asp:TextBox>

        


        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 423px; top: 593px; position: absolute"></asp:Label>


        <asp:TextBox ID="txtReceptionistCarColour" runat="server" CssClass="TextBoxes" style="z-index: 1; left: 850px; top: 230px; position: absolute; width: 284px">Car Colour</asp:TextBox>


        <asp:Button ID="btnReceptionistReset" runat="server" CssClass="ReceptionistButton" OnClick="btnReceptionistReset_Click" style="z-index: 1; left: 901px; top: 54px; position: absolute;" Text="Reset Form" />


        <asp:TextBox ID="txtReceptionistFilterByCarManufacturer" runat="server" CssClass="TextBoxes" style="z-index: 1; left: 60px; top: 276px; position: absolute; width: 178px">Car Manufacturer</asp:TextBox>


    </form>
</body>
</html>
