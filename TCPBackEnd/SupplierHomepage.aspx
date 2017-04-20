<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierHomepage.aspx.cs" Inherits="SupplierHomepage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
          <asp:ListBox CssClass="ListBoxes"  ID="lstBoxListSupplier" runat="server" style="z-index: 1; left: 337px; top: 88px; position: absolute; height: 355px; width: 414px; margin-top: 16px"></asp:ListBox>
         <asp:Button ID="btnDisplay" runat="server" Text="Display" />
        <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="Delete" />
        <asp:Button ID="Button3" runat="server" Text="Update" />
    </form>
</body>
</html>
