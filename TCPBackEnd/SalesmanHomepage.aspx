<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SalesmanHomepage.aspx.cs" Inherits="SalesmanHomepage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="StyleSheet.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Button ID="btnSalesmanHomePage" runat="server" style="z-index: 1; left: 24px; top: 73px; position: absolute; width: 52px" Text="Home" />
        <asp:DropDownList ID="ddlSalesmanFilterBy" runat="server" style="z-index: 1; left: 21px; top: 146px; position: absolute; height: -5px">
        </asp:DropDownList>
        <asp:TextBox ID="txtSalesmanFilterBy" runat="server" style="z-index: 1; left: 23px; top: 206px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnSalesmanSearch" runat="server" style="z-index: 1; left: 24px; top: 288px; position: absolute" Text="Search" />
        <asp:ListBox ID="lstSalesmanBox" runat="server" style="z-index: 1; left: 415px; top: 77px; position: absolute; height: 242px; width: 362px"></asp:ListBox>
        <asp:Button ID="btnSalesmanArchiveCustomer" runat="server" style="z-index: 1; left: 574px; top: 344px; position: absolute" Text="Archive customer" />
        <asp:TextBox ID="txtSalesmanCustomerID" runat="server" style="z-index: 1; left: 909px; top: 114px; position: absolute">Customer ID</asp:TextBox>
        <asp:TextBox ID="txtSalesmanFirstName" runat="server" style="z-index: 1; left: 910px; top: 231px; position: absolute; margin-bottom: 2px">First Name</asp:TextBox>
        <asp:TextBox ID="txtSalesmanLastName" runat="server" style="z-index: 1; left: 912px; top: 265px; position: absolute; margin-top: 0px">Last Name</asp:TextBox>
        <asp:TextBox ID="txtSalesmanCustomerPostCode" runat="server" style="z-index: 1; left: 911px; top: 301px; position: absolute">Post Code</asp:TextBox>
        <asp:TextBox ID="txtSalesmanCustomerAddress" runat="server" style="z-index: 1; left: 910px; top: 153px; position: absolute">Customer Address</asp:TextBox>
        <asp:TextBox ID="txtSalesmanCustomerEmail" runat="server" style="z-index: 1; top: 197px; position: absolute; bottom: 445px; left: 911px">Customer Email</asp:TextBox>
        <asp:TextBox ID="txtSalesmanDateAddedOK" runat="server" style="z-index: 1; left: 909px; top: 338px; position: absolute">Date Added</asp:TextBox>
        <asp:CheckBox ID="chkSalesmanActiveOK" runat="server" style="z-index: 1; left: 917px; top: 369px; position: absolute" Text="Active?" />
        <asp:Button ID="btnSalesmanAddCustomer" runat="server" style="z-index: 1; left: 851px; top: 439px; position: absolute" Text="Add Customer" OnClick="btnSalesmanAddCustomer_Click" />
        <asp:Button ID="btnSalesmanUpdateCustomer" runat="server" style="z-index: 1; left: 992px; top: 441px; position: absolute" Text="Update Customer" />
        <asp:Label ID="lblSalesmanError" runat="server" style="z-index: 1; left: 447px; top: 424px; position: absolute"></asp:Label>
    </form>
</body>
</html>
