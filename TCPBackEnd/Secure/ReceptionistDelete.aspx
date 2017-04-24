<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReceptionistDelete.aspx.cs" Inherits="Secure_ReceptionistDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnDeleteNo" runat="server" CssClass="ReceptionistButton" OnClick="btnDeleteNo_Click" style="z-index: 1; left: 454px; top: 254px; position: absolute; width: 103px; height: 49px" Text="No" />
        <asp:Label ID="lblDeleteAuth" runat="server" style="z-index: 1; left: 266px; top: 204px; position: absolute; width: 362px; height: 29px" Text="Are you sure you want to archive this car?"></asp:Label>
        <p>
            <asp:Button ID="btnDeleteYes" runat="server" CssClass="ReceptionistButton" OnClick="btnDeleteYes_Click" style="z-index: 1; left: 279px; top: 254px; position: absolute; height: 48px; width: 127px" Text="Yes" />
        </p>
    </form>
</body>
</html>
