<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Hatchbacks.aspx.cs" Inherits="Hatchbacks" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hatchbacks</title>
    <link rel="stylesheet" type="text/css" href="../TCPBackEnd/Secure/StyleSheet.css"/>
</head>
<body style="height: 639px">
    <form id="form1" runat="server">
        <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/HB1.jpg" style="z-index: 1; left: 58px; top: 132px; position: absolute; height: 188px; width: 245px" />
        <asp:Image ID="Image2" runat="server" ImageUrl="~/Images/HB2.jpg" style="z-index: 1; left: 48px; top: 382px; position: absolute; height: 215px; width: 267px" />
        <asp:Image ID="Image3" runat="server" ImageUrl="~/Images/2.0L GOLF GTD.PNG" style="z-index: 1; left: 336px; top: 123px; position: absolute; height: 206px; width: 318px" />
        <asp:Image ID="Image4" runat="server" ImageUrl="~/Images/Volkswagen Beetle 1.4L.PNG" style="z-index: 1; left: 344px; top: 382px; position: absolute; height: 235px; width: 308px" />
        <asp:Button ID="btnHatchbackHomepage" runat="server" OnClick="btnHatchbackHomepage_Click" style="z-index: 1; left: 25px; top: 72px; position: absolute" Text="Homepage" />
    </form>
</body>
</html>
