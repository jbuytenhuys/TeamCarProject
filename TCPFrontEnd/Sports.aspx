﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Sports.aspx.cs" Inherits="Sports" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sports</title>
    <link rel="stylesheet" type="text/css" href="../TCPBackEnd/Secure/StyleSheet.css"/>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/lamborghini-aventador.jpg" style="z-index: 1; left: 84px; top: 184px; position: absolute; height: 217px; width: 260px" />
        <asp:Image ID="Image2" runat="server" ImageUrl="~/Images/Lamborghini Aventador .PNG" style="z-index: 1; left: 375px; top: 194px; position: absolute; height: 228px; width: 381px" />
        <asp:Image ID="Image3" runat="server" ImageUrl="~/Images/logo.png" style="z-index: 1; left: 635px; top: 19px; position: absolute; height: 123px; width: 127px" />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 10px; top: 51px; position: absolute" Text="Homepage" />
    </form>
</body>
</html>
