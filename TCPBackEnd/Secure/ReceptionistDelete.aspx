<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReceptionistDelete.aspx.cs" Inherits="Secure_ReceptionistDelete" %>

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
        <p>
            &nbsp;</p>
        <asp:Button ID="btnDeleteNo" runat="server" CssClass="ReceptionistButton" OnClick="btnDeleteNo_Click" style="z-index: 1; left: 444px; top: 314px; position: absolute; width: 103px; height: 49px" Text="No" />
        <asp:Label ID="lblDeleteAuth" runat="server" style="z-index: 1; left: 286px; top: 231px; position: absolute; width: 362px; height: 29px" Text="Are you sure you want to archive this car?"></asp:Label>
        <p>
            <asp:Button ID="btnDeleteYes" runat="server" CssClass="ReceptionistButton" OnClick="btnDeleteYes_Click" style="z-index: 1; left: 283px; top: 313px; position: absolute; height: 48px; width: 127px" Text="Yes" />
        </p>
    </form>
</body>
</html>
