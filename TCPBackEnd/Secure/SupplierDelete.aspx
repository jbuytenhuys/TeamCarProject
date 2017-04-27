<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierDelete.aspx.cs" Inherits="SupplierDelete" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Supplier Delete</title>
    <link rel="stylesheet" type="text/css" href="StyleSheet.css" />
</head>
<body style="height: 509px">

    <form runat="server">

    <p>
        
        <asp:Button ID="BtnYes" runat="server" Text="Yes" OnClick="BtnYes_Click" />
        <asp:Button ID="BtnNo" runat="server" Text="No" OnClick="BtnNo_Click" />
        
        <br />
    </p>


        <asp:Label ID="lblconfirmdelete" runat="server" Text="Are you sure you want to delete?"></asp:Label>


    </form>
</body>
</html>