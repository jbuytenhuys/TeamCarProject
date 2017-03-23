<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReceptionistHomepage.aspx.cs" Inherits="ReceptionistHomepage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="StyleSheet.css" />
</head>
<body>
    <form id="form1" runat="server">


        <asp:Button CssClass="ReceptionistButton" ID="btnLogout" runat="server" style="z-index: 1; left: 29px; top: 67px; position: absolute; height: 63px; width: 115px" Text="Logout" />

        <asp:DropDownList CssClass="ReceptionistButton" ID="DDlstManufacturer" runat="server" style="z-index: 1; left: 79px; top: 182px; position: absolute; width: 124px">
        </asp:DropDownList>

        <asp:DropDownList CssClass="ReceptionistButton" ID="DDlstModel" runat="server" style="z-index: 1; left: 79px; top: 214px; position: absolute; width: 124px; height: 22px">
        </asp:DropDownList>


        <asp:DropDownList CssClass="ReceptionistButton" ID="DDlstYear" runat="server" style="z-index: 1; left: 80px; top: 246px; position: absolute; height: 22px; width: 124px">
        </asp:DropDownList>

        <asp:Button CssClass="ReceptionistButton" ID="btnFilterCars" runat="server" style="z-index: 1; left: 85px; top: 294px; position: absolute; height: 53px; width: 109px" Text="Filter Cars" />

        <asp:ListBox CssClass="ReceptionistButton" ID="lstBoxListCars" runat="server" style="z-index: 1; left: 348px; top: 97px; position: absolute; height: 355px; width: 414px; margin-top: 16px"></asp:ListBox>

        <asp:Button CssClass="ReceptionistButton" ID="btnListAllCars" runat="server" style="z-index: 1; left: 500px; top: 498px; position: absolute; height: 63px; width: 132px" Text="List All Cars" />


    </form>
</body>
</html>
