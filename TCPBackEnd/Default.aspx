<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title>Login</title>
    <link rel="stylesheet" type="text/css" href="StyleSheet.css" />
</head>

<body>
        <h4 id ="HomePageTitles">Please login</h4>
    <br />
        <h1 id="FormHeading"> Please enter your Username and Password:</h1>

        <form id="UserForms" action="MechanicHomepage.aspx" method="post" runat="server">
            Please enter your Username: <input type="text" class="FormTextBoxes" /><br />
            Please enter your Password: <input type="text" class="FormTextBoxes" /><br />
            <br />
            <div>
                <input type="submit" class="ButtonForms" value="Login" />
            </div>
        </form>
    
    
</body>
</html>
