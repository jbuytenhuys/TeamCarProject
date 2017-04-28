<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AboutUs.aspx.cs" Inherits="AboutUs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>About Us</title>
    <link rel="stylesheet" type="text/css" href="../TCPBackEnd/Secure/StyleSheet.css"/>
    <style type="text/css">
        #TextArea1 {
            z-index: 1;
            left: 98px;
            top: 291px;
            position: absolute;
            height: 158px;
            width: 222px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <br />
        <asp:Image ID="Image2" runat="server" ImageUrl="~/Images/logo.png" style="z-index: 1; left: 642px; top: 21px; position: absolute; height: 173px; width: 180px" />
        <br />
        <br />
        Opening Times:<br />
        Mon - Fri: 9:00am - 6:00pm<br />
        Sat - Sun: 10:00am - 4:00pm<br />
        <br />
        Contact Number - 12345678910<br />
        Contact Email - <a href="mailto:Contact@PrestigeWorldWide.com">Contact@PrestigeWorldWide.com</a><br />
        <br />
        <br />
        Location - SW19 6TH<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Beaumont Rd, London</div>
        <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/Location.PNG" style="z-index: 1; left: 458px; top: 443px; position: absolute; height: 335px; width: 601px" />
    </form>
</body>
</html>
