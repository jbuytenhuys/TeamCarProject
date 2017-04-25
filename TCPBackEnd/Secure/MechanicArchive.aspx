<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MechanicArchive.aspx.cs" Inherits="MechanicDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Delete Confirmation</title>
    <link rel="stylesheet" type="text/css" href="StyleSheet.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <p>
            Are you sure you want to archive this Repair?</p>
        <p>
            <asp:Button ID="btnMechanicDeleteYes" CssClass="MechanicButton" runat="server" style="z-index: 1; top: 129px; position: absolute" Text="Yes" OnClick="btnMechanicDeleteYes_Click" />
        </p>
        <asp:Button ID="btnMechanicDeleteNo" CssClass="MechanicButton" runat="server" style="z-index: 1; left: 98px; top: 129px; position: absolute" Text="No" OnClick="btnMechanicDeleteNo_Click" />
    </form>
</body>
</html>
