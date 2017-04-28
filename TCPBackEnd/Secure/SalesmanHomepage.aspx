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
        <asp:Button ID="btnSalesmanHomePage" runat="server" style="z-index: 1; left: 24px; top: 73px; position: absolute; width: 100px; height: 49px;" Text="Home" OnClick="btnSalesmanHomePage_Click1" Font-Bold="True" ForeColor="Blue" />
        <asp:TextBox ID="txtSalesmanFilterBy" runat="server" style="z-index: 1; left: 219px; top: 208px; position: absolute; width: 174px; bottom: 434px;" OnTextChanged="txtSalesmanFilterBy_TextChanged"></asp:TextBox>
        <asp:Button ID="btnSalesmanSearch" runat="server"  style="z-index: 1; left: 55px; top: 204px; position: absolute" Text="Filter First Name" OnClick="btnSalesmanSearch_Click" />
        <asp:ListBox ID="lstSalesmanBox" runat="server" style="z-index: 1; left: 415px; top: 77px; position: absolute; height: 242px; width: 362px" OnSelectedIndexChanged="lstSalesmanBox_SelectedIndexChanged"></asp:ListBox>
        <asp:Button ID="btnSalesmanArchiveCustomer" runat="server" style="z-index: 1; left: 484px; top: 333px; position: absolute" Text="Archive customer" OnClick="btnSalesmanArchiveCustomer_Click" Font-Bold="True" ForeColor="Blue" />
        <asp:TextBox ID="txtSalesmanCustomerID" runat="server" style="z-index: 1; left: 913px; top: 111px; position: absolute" ReadOnly="True" >Customer ID</asp:TextBox>
        <asp:TextBox ID="txtSalesmanFirstName" runat="server" OnClick="this.value=''" style="z-index: 1; left: 913px; top: 141px; position: absolute; margin-bottom: 2px" OnTextChanged="txtSalesmanFirstName_TextChanged">First Name</asp:TextBox>
        <asp:TextBox ID="txtSalesmanLastName" runat="server" OnClick="this.value=''" style="z-index: 1; left: 911px; top: 172px; position: absolute; margin-top: 0px">Last Name</asp:TextBox>
        <asp:TextBox ID="txtSalesmanCustomerPostCode" runat="server" OnClick="this.value=''" style="z-index: 1; left: 909px; top: 315px; position: absolute">Post Code</asp:TextBox>
        <asp:TextBox ID="txtSalesmanCustomerAddress" runat="server" OnClick="this.value=''" style="z-index: 1; left: 909px; top: 233px; position: absolute">Customer Address</asp:TextBox>
        <asp:TextBox ID="txtSalesmanCustomerEmail" runat="server" OnClick="this.value=''" style="z-index: 1; top: 203px; position: absolute; bottom: 439px; left: 909px">Customer Email</asp:TextBox>
        <asp:TextBox ID="txtSalesmanDateAddedOK" runat="server" style="z-index: 1; left: 911px; top: 352px; position: absolute" OnTextChanged="txtSalesmanDateAddedOK_TextChanged" ReadOnly="True">Date Added</asp:TextBox>
        <asp:CheckBox ID="chkSalesmanActiveOK" runat="server"  style="z-index: 1; left: 917px; top: 377px; position: absolute" Text="Active?" OnCheckedChanged="chkSalesmanActiveOK_CheckedChanged" />
        <asp:Button ID="btnSalesmanAddCustomer" runat="server" style="z-index: 1; left: 469px; top: 383px; position: absolute" Text="Add Customer" OnClick="btnSalesmanAddCustomer_Click" Font-Bold="True" ForeColor="Blue" />
        <p>
        <asp:Label ID="lblSalesmanError" runat="server" style="z-index: 1; left: 363px; top: 453px; position: absolute"></asp:Label>
            <asp:TextBox ID="txtReceptionistCarID" runat="server"  style="z-index: 1; left: 911px; top: 82px; position: absolute" ReadOnly="True">Receptionist CarID</asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblFilterByFirstName" runat="server" Font-Bold="True" Font-Size="Medium" ForeColor="Blue" style="z-index: 1; left: 59px; top: 181px; position: absolute" Text="Filter By First Name"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnSalesmanReset" runat="server" OnClick="btnSalesmanReset_Click" style="z-index: 1; left: 657px; top: 325px; position: absolute; height: 35px; width: 101px" Text="Reset Data" Font-Bold="True" ForeColor="Blue" />
            <asp:TextBox ID="txtSalesmanAddress" runat="server" OnTextChanged="txtSalesmanAddress_TextChanged" style="z-index: 1; left: 216px; top: 262px; position: absolute; width: 169px;"></asp:TextBox>
            <asp:Label ID="lblFilterByCustomerAddress" runat="server" Font-Bold="True" Font-Size="Medium" ForeColor="Blue" style="z-index: 1; left: 19px; top: 247px; position: absolute" Text="Filter By Customer Address"></asp:Label>
            <asp:TextBox ID="txtCustomerNumber" runat="server" OnClick="this.value=''" style="z-index: 1; left: 905px; top: 276px; position: absolute" OnTextChanged="txtCustomerNumber_TextChanged">Customer Number</asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnSalesmanViewDate" runat="server" style="z-index: 1; left: 360px; top: 332px; position: absolute; height: 34px; width: 110px; right: 635px;" Text="View Data" OnClick="btnSalesmanViewData_Click" Font-Bold="True" ForeColor="Blue" />
            </p>
        <p>
            <asp:Button ID="btnFilterByAddress" runat="server" OnClick="btnFilterByAddress_Click" style="z-index: 1; left: 47px; top: 267px; position: absolute" Text="Filter By Address" />
        <asp:Button ID="btnSalesmanUpdateCustomer" runat="server" style="z-index: 1; left: 636px; top: 380px; position: absolute" Text="Update Customer" OnClick="btnSalesmanUpdateCustomer_Click" Font-Bold="True" ForeColor="Blue" />
        </p>
        <asp:Button ID="btnFetchReceptionistCarID" runat="server" OnClick="btnFetchReceptionistCarID_Click" style="z-index: 1; left: 359px; top: 383px; position: absolute" Text="Fetch CarID" />
        <asp:TextBox ID="txtFilterCarReg" runat="server" style="z-index: 1; left: 218px; top: 480px; position: absolute; margin-top: 0px"></asp:TextBox>
        <asp:Button ID="btnFilterCarReg" runat="server" OnClick="btnFilterCarReg_Click" style="z-index: 1; left: 149px; top: 479px; position: absolute" Text="Filter" />
    </form>
</body>
</html>
