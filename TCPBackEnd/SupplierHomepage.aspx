<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierHomepage.aspx.cs" Inherits="SupplierHomepage" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Supplier HomePage</title>
    <link rel="stylesheet" type="text/css" href="StyleSheet.css" />
</head>
<body style="height: 509px">

    <form runat="server">

    <p>
        
        <br />
    </p>
        <asp:Button ID="btnSupplierLogout" CssClass="SupplierButton" runat="server" style="z-index: 1; left: 730px; top: 18px; position: absolute; height: 50px; width: 180px" Text="Logout" OnClick="btnSupplierLogout_Click" />
        <asp:TextBox ID="txtAddress" CssClass="TextBoxes" runat="server" OnClick="this.value=''" style="z-index: 1; left: 805px; top: 195px; position: absolute" OnTextChanged="txtAddress_TextChanged">Address</asp:TextBox>
        <asp:ListBox CssClass="ListBoxes"  ID="lstBoxListSupplier" runat="server" style="z-index: 1; left: 259px; top: 175px; position: absolute; height: 355px; width: 414px; margin-top: 16px"></asp:ListBox>
        <asp:Button ID="btnDisplay" runat="server" Text="Display" />
        <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="Delete" />
        <asp:Button ID="Button3" runat="server" Text="Update" />
    </form>
</body>
</html>
