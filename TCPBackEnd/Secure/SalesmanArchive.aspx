﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SalesmanArchive.aspx.cs" Inherits="Secure_SalesmanArchive" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Are you sure you want to archive this customer?<br />
        <br />
        <asp:Button ID="btnYes" runat="server" Text="Yes" OnClick="btnYes_Click" />
        <asp:Button ID="btnNo" runat="server" Text="No" />
    
    </div>
    </form>
</body>
</html>
