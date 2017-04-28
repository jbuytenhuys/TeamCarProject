<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Coupe.aspx.cs" Inherits="Coupe" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Coupe</title>
    <link rel="stylesheet" type="text/css" href="../TCPBackEnd/Secure/StyleSheet.css"/>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/C1.jpg" style="z-index: 1; left: 58px; top: 130px; position: absolute; height: 233px; width: 262px" />
        <asp:Image ID="Image2" runat="server" ImageUrl="~/Images/C2.jpg" style="z-index: 1; left: 58px; top: 399px; position: absolute; height: 230px; width: 258px" />
        <asp:Image ID="Image3" runat="server" ImageUrl="~/Images/Audi TT 2.0L.PNG" style="z-index: 1; left: 331px; top: 136px; position: absolute; height: 227px; width: 402px" />
        <asp:Image ID="Image4" runat="server" ImageUrl="~/Images/Renault Megane 1.5 DCI Dynamique 3dr.PNG" style="z-index: 1; left: 349px; top: 392px; position: absolute; height: 251px; width: 394px" />
        <asp:Button ID="btnCoupeHomepage" runat="server" style="z-index: 1; left: 58px; top: 75px; position: absolute" Text="Homepage" />
    </form>
</body>
</html>
