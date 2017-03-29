<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MechanicHomepage.aspx.cs" Inherits="MechanicHomepage" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Mechanic Homepage</title>
    <link rel="stylesheet" type="text/css" href="StyleSheet.css" />
</head>
<body style="height: 509px">

    <form runat="server">
    
        <asp:Button ID="btnMechanicLogout" CssClass="MechanicButton" runat="server" style="z-index: 1; left: 17px; top: 42px; position: absolute; height: 50px; width: 180px" Text="Logout" />

        <asp:DropDownList ID="ddlMechanicFilterBy" CssClass="DropDownMenu" runat="server" style="z-index: 1; left: 112px; top: 108px; position: absolute; height: 50px; width: 167px"></asp:DropDownList>

        <asp:TextBox ID="txtMechanicFilter" CssClass="TextBoxes"  runat="server" style="z-index: 1; left: 111px; top: 180px; position: absolute; width: 156px">Keyword Filter</asp:TextBox>

        <asp:Button ID="btnMechanicFilter" CssClass="MechanicButton" runat="server" style="z-index: 1; left: 113px; top: 220px; position: absolute; height: 50px; width: 180px" Text="Filter" />

        <asp:ListBox ID="lstMechanicRepairs" CssClass="ListBoxes" runat="server" style="z-index: 1; left: 460px; top: 104px; position: absolute; height: 269px; width: 428px"></asp:ListBox>

        <asp:Button ID="btnMechanicListAll" CssClass="MechanicButton" runat="server" style="z-index: 1; left: 463px; top: 408px; position: absolute; height: 50px; width: 180px" Text="List All Repairs" />

        <asp:TextBox ID="txtMechanicRepairID" CssClass="TextBoxes" runat="server" style="z-index: 1; left: 1021px; top: 108px; position: absolute; height: 17px; width: 263px" ReadOnly="True">RepairID</asp:TextBox>

        <asp:TextBox ID="txtMechanicDeadlineDate" CssClass="TextBoxes" runat="server" style="z-index: 1; left: 1021px; top: 169px; position: absolute">Deadline Date</asp:TextBox>

        <asp:TextBox ID="txtMechanicPartRequired" CssClass="TextBoxes" runat="server" style="z-index: 1; left: 1015px; top: 219px; position: absolute">Part Required</asp:TextBox>

        <asp:TextBox ID="txtMechanicPartPrice" CssClass="TextBoxes" runat="server" style="z-index: 1; left: 1016px; top: 272px; position: absolute">Part Price</asp:TextBox>

        <asp:CheckBox ID="chkMechanicRepairStatus" CssClass="CheckBox" runat="server" style="z-index: 1; left: 1024px; top: 323px; position: absolute" Text="Repair Status" />

        <asp:Button ID="btnMechanicAddRepair" CssClass="MechanicButton" runat="server" style="z-index: 1; left: 1021px; top: 425px; position: absolute; height: 50px; width: 180px" Text="Add Repair" />

        <asp:Button ID="btnMechanicUpdateRepair" CssClass="MechanicButton" runat="server" style="z-index: 1; left: 1220px; top: 425px; position: absolute; height: 50px; width: 180px" Text="UpdateRepair" />

        <asp:Button ID="btnMechanicDeleteRepair" CssClass="MechanicButton" runat="server" style="z-index: 1; left: 1021px; top: 487px; position: absolute; height: 50px; width: 180px; margin-bottom: 3px" Text="Delete Repair" />

    </form>
</body>
</html>
