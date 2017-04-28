<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MainHomepage.aspx.cs" Inherits="MainHomepage" %>

<!DOCTYPE html>

<html>
<head>
    <title>links to pages</title>
    <link rel="stylesheet" type="text/css" href="StyleSheet.css" />
</head>
<body>
    
    <form id="form1" runat="server">
        <asp:Button ID="btnMechanicHomepage" runat="server" OnClick="btnMechanicHomepage_Click" style="z-index: 1; left: 358px; top: 168px; position: absolute; height: 61px; width: 126px" Text="Mechanic" />
        <asp:Button ID="btnSupplierHomepage" runat="server" OnClick="btnSupplierHomepage_Click" style="z-index: 1; left: 360px; top: 266px; position: absolute; height: 60px; width: 122px; right: 747px" Text="Supplier" />
        <asp:Button ID="btnSalesmanHomepage" runat="server" OnClick="btnSalesmanHomepage_Click" style="z-index: 1; left: 508px; top: 267px; position: absolute; height: 58px; width: 119px; margin-bottom: 0px" Text="Salesman" />
        <asp:Button ID="btnReceptionistHomepage" runat="server" OnClick="btnReceptionistHomepage_Click" style="z-index: 1; left: 505px; top: 167px; position: absolute; height: 62px; width: 123px" Text="Receptionist" />
    </form>
    
</body>
</html>
