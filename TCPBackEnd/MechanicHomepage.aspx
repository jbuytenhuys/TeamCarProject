<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MechanicHomepage.aspx.cs" Inherits="MechanicHomepage" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Mechanic Homepage</title>
    <link rel="stylesheet" type="text/css" href="StyleSheet.css" />
</head>
<body style="height: 509px">

    <form runat="server">
    
        <asp:Button ID="btnMechanicLogout" runat="server" style="z-index: 1; left: 17px; top: 42px; position: absolute" Text="Logout" />

        <asp:DropDownList ID="ddlMechanicFilterBy" runat="server" style="z-index: 1; left: 112px; top: 108px; position: absolute; height: 32px; width: 167px"></asp:DropDownList>

        <asp:TextBox ID="txtMechanicFilter" runat="server" style="z-index: 1; left: 111px; top: 141px; position: absolute; width: 156px">Keyword Filter</asp:TextBox>

        <asp:Button ID="btnMechanicFilter" runat="server" style="z-index: 1; left: 113px; top: 190px; position: absolute; height: 35px; width: 109px" Text="Filter" />

        <asp:ListBox ID="lstMechanicRepairs" runat="server" style="z-index: 1; left: 460px; top: 104px; position: absolute; height: 269px; width: 428px"></asp:ListBox>

        <asp:Button ID="btnMechanicListAll" runat="server" style="z-index: 1; left: 463px; top: 408px; position: absolute; height: 39px; width: 177px" Text="List All Repairs" />

        <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 1021px; top: 108px; position: absolute; height: 17px; width: 263px"></asp:TextBox>

        <asp:TextBox ID="TextBox3" runat="server" style="z-index: 1; left: 1021px; top: 108px; position: absolute; height: 17px; width: 263px"></asp:TextBox>

        <asp:TextBox ID="txtMechanicRepairID" runat="server" style="z-index: 1; left: 1021px; top: 108px; position: absolute; height: 17px; width: 263px" ReadOnly="True">RepairID</asp:TextBox>

        <asp:TextBox ID="TextBox7" runat="server" style="z-index: 1; left: 1020px; top: 154px; position: absolute"></asp:TextBox>

        <asp:TextBox ID="TextBox8" runat="server" style="z-index: 1; left: 1023px; top: 257px; position: absolute"></asp:TextBox>

        <asp:TextBox ID="TextBox9" runat="server" style="z-index: 1; left: 1022px; top: 295px; position: absolute"></asp:TextBox>

        <asp:TextBox ID="TextBox10" runat="server" style="z-index: 1; left: 1024px; top: 338px; position: absolute"></asp:TextBox>

        <asp:CheckBox ID="CheckBox1" runat="server" style="z-index: 1; left: 1027px; top: 382px; position: absolute" />

        <asp:Button ID="Button4" runat="server" style="z-index: 1; left: 1021px; top: 424px; position: absolute" Text="Button" />

        <asp:Button ID="Button5" runat="server" style="z-index: 1; left: 1173px; top: 425px; position: absolute" Text="Button" />

    </form>
</body>
</html>
