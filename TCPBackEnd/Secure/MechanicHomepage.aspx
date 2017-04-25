﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MechanicHomepage.aspx.cs" Inherits="MechanicHomepage" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Mechanic Homepage</title>
    <link rel="stylesheet" type="text/css" href="StyleSheet.css" />
</head>
<body style="height: 509px">

    <form runat="server">
    
    <p>
        <br />
    </p>

        <p>

        <asp:Button ID="btnMechanicReset" CssClass="MechanicButton" runat="server" style="z-index: 1; left: 1020px; top: 72px; position: absolute; height: 33px; width: 82px;" Text="Reset" OnClick="btnMechanicReset_Click" />

            <asp:Label ID="lblMechanicUserInfo" runat="server" style="z-index: 1; left: 19px; top: 1px; position: absolute" Text="-"></asp:Label>

        </p>
    
        <asp:Button ID="btnMechanicLogout" CssClass="MechanicButton" runat="server" style="z-index: 1; left: 17px; top: 42px; position: absolute; height: 50px; width: 180px" Text="Logout" OnClick="btnMechanicLogout_Click" />

        <asp:DropDownList ID="ddlMechanicFilterBy" CssClass="DropDownMenu" runat="server" style="z-index: 1; left: 112px; top: 108px; position: absolute; height: 50px; width: 167px" OnSelectedIndexChanged="ddlMechanicFilterBy_SelectedIndexChanged"></asp:DropDownList>

        <asp:TextBox ID="txtMechanicFilter" CssClass="TextBoxes"  runat="server" OnClick="this.value=''" style="z-index: 1; left: 111px; top: 180px; position: absolute; width: 156px" OnTextChanged="txtMechanicFilter_Click">Keyword Filter</asp:TextBox>

        <asp:Button ID="btnMechanicFilter" CssClass="MechanicButton" runat="server" style="z-index: 1; left: 111px; top: 225px; position: absolute; height: 50px; width: 180px" Text="Filter" OnClick="btnMechanicFilter_Click" />

        <asp:ListBox ID="lstMechanicRepairs" CssClass="ListBoxes" runat="server" style="z-index: 1; left: 460px; top: 104px; position: absolute; height: 269px; width: 428px" OnSelectedIndexChanged="lstMechanicRepairs_SelectedIndexChanged"></asp:ListBox>

        <asp:Button ID="btnMechanicListAll" CssClass="MechanicButton" runat="server" style="z-index: 1; left: 463px; top: 408px; position: absolute; height: 50px; width: 180px" Text="List All Repairs" OnClick="btnMechanicListAll_Click" />

        <asp:TextBox ID="txtMechanicRepairID" CssClass="TextBoxes" runat="server" style="z-index: 1; left: 1021px; top: 110px; position: absolute; height: 17px; width: 263px" ReadOnly="True" OnTextChanged="txtMechanicRepairID_TextChanged">RepairID</asp:TextBox>

        <asp:TextBox ID="txtMechanicDeadlineDate" CssClass="TextBoxes" runat="server" OnClick="this.value=''" style="z-index: 1; left: 1021px; top: 150px; position: absolute" OnTextChanged="txtMechanicDeadlineDate_TextChanged"></asp:TextBox>

        <asp:TextBox ID="txtMechanicPartRequired" CssClass="TextBoxes" runat="server" OnClick="this.value=''" style="z-index: 1; left: 1021px; top: 190px; position: absolute" OnTextChanged="txtMechanicPartRequired_TextChanged">Part Required</asp:TextBox>

        <asp:TextBox ID="txtMechanicPartPrice" CssClass="TextBoxes" runat="server" OnClick="this.value=''" style="z-index: 1; left: 1021px; top: 230px; position: absolute" OnTextChanged="txtMechanicPartPrice_TextChanged">Part Price</asp:TextBox>

        <asp:CheckBox ID="chkMechanicRepairStatus" CssClass="CheckBox" runat="server" style="z-index: 1; left: 1024px; top: 323px; position: absolute" Text="Repair Status" />

        <asp:Button ID="btnMechanicAddRepair" CssClass="MechanicButton" runat="server" style="z-index: 1; left: 1021px; top: 425px; position: absolute; height: 50px; width: 180px" Text="Add Repair" OnClick="btnMechanicAddRepair_Click" />

        <asp:Button ID="btnMechanicUpdateRepair" CssClass="MechanicButton" runat="server" style="z-index: 1; left: 1220px; top: 425px; position: absolute; height: 50px; width: 180px" Text="Update Repair" OnClick="btnMechanicUpdateRepair_Click" />

        <asp:Button ID="btnMechanicDeleteRepair" CssClass="MechanicButton" runat="server" style="z-index: 1; left: 1021px; top: 487px; position: absolute; height: 50px; width: 180px; margin-bottom: 3px" Text="Delete Repair" OnClick="btnMechanicDeleteRepair_Click" />

        <asp:TextBox ID="txtMechanicDaysInForRepair" CssClass="TextBoxes" runat="server" OnClick="this.value=''" style="z-index: 1; left: 1021px; top: 270px; position: absolute"  OnTextChanged="txtMechanicPartPrice_TextChanged">Days In For Repair</asp:TextBox>

        <asp:Label ID="lblMechanicError" runat="server" style="z-index: 1; left: 1023px; top: 370px; position: absolute" Text="-"></asp:Label>

        <asp:Button ID="btnMechanicViewData" CssClass="MechanicButton" runat="server" style="z-index: 1; left: 650px; top: 407px; position: absolute; height: 51px; width: 197px" Text="View Data" OnClick="btnMechanicViewData_Click" />

    </form>
</body>
</html>