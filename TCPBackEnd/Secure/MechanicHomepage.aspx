<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MechanicHomepage.aspx.cs" Inherits="MechanicHomepage" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Mechanic Homepage</title>
    <link rel="stylesheet" type="text/css" href="StyleSheet.css" />
</head>
<body style="height: 509px">

        <form id="form1" runat="server">

        <asp:Button ID="btnMechanicReset" CssClass="MechanicButton" runat="server" style="z-index: 1; left: 1020px; top: 63px; position: absolute; height: 33px; width: 82px;" Text="Reset" OnClick="btnMechanicReset_Click" />

        <asp:Button ID="btnMechanicLogout" CssClass="MechanicButton" runat="server" style="z-index: 1; left: 17px; top: 63px; position: absolute; height: 50px; width: 180px" Text="Logout" OnClick="btnMechanicLogout_Click" />

        <asp:TextBox ID="txtMechanicFilter" CssClass="TextBoxes"  runat="server" OnClick="this.value=''" style="z-index: 1; left: 111px; top: 180px; position: absolute; width: 156px" OnTextChanged="txtMechanicFilter_Click">Keyword Filter</asp:TextBox>

        <asp:Button ID="btnMechanicFilter" CssClass="MechanicButton" runat="server" style="z-index: 1; left: 111px; top: 225px; position: absolute; height: 50px; width: 180px" Text="Filter" OnClick="btnMechanicFilter_Click" />

        <asp:ListBox ID="lstMechanicRepairs" CssClass="ListBoxes" runat="server" style="z-index: 1; left: 372px; top: 107px; position: absolute; height: 269px; width: 428px" OnSelectedIndexChanged="lstMechanicRepairs_SelectedIndexChanged"></asp:ListBox>

        <asp:Button ID="btnMechanicListAll" CssClass="MechanicButton" runat="server" style="z-index: 1; left: 370px; top: 404px; position: absolute; height: 50px; width: 180px" Text="List All Repairs" OnClick="btnMechanicListAll_Click" />

        <asp:TextBox ID="txtMechanicRepairID" CssClass="TextBoxes" runat="server" style="z-index: 1; left: 1057px; top: 109px; position: absolute; height: 17px; width: 139px" ReadOnly="True" OnTextChanged="txtMechanicRepairID_TextChanged">RepairID</asp:TextBox>

        <asp:TextBox ID="txtMechanicDeadlineDate" CssClass="TextBoxes" runat="server" OnClick="this.value=''" style="z-index: 1; left: 1057px; top: 305px; position: absolute" OnTextChanged="txtMechanicDeadlineDate_TextChanged"></asp:TextBox>

        <asp:TextBox ID="txtMechanicPartRequired" CssClass="TextBoxes" runat="server" OnClick="this.value=''" style="z-index: 1; left: 1057px; top: 339px; position: absolute" OnTextChanged="txtMechanicPartRequired_TextChanged">Part Required</asp:TextBox>

        <asp:TextBox ID="txtMechanicPartPrice" CssClass="TextBoxes" runat="server" OnClick="this.value=''" style="z-index: 1; left: 1057px; top: 368px; position: absolute" OnTextChanged="txtMechanicPartPrice_TextChanged">Part Price</asp:TextBox>

        <asp:CheckBox ID="chkMechanicRepairStatus" CssClass="CheckBox" runat="server" style="z-index: 1; left: 1023px; top: 427px; position: absolute" Text="Repair Status" />

        <asp:Button ID="btnMechanicAddRepair" CssClass="MechanicButton" runat="server" style="z-index: 1; left: 1022px; top: 488px; position: absolute; height: 50px; width: 180px" Text="Add Repair" OnClick="btnMechanicAddRepair_Click" />

        <asp:Button ID="btnMechanicUpdateRepair" CssClass="MechanicButton" runat="server" style="z-index: 1; left: 1207px; top: 488px; position: absolute; height: 50px; width: 180px" Text="Update Repair" OnClick="btnMechanicUpdateRepair_Click" />

        <asp:Button ID="btnMechanicDeleteRepair" CssClass="MechanicButton" runat="server" style="z-index: 1; left: 1023px; top: 545px; position: absolute; height: 50px; width: 180px; margin-bottom: 3px" Text="Archive Repair" OnClick="btnMechanicDeleteRepair_Click" />

        <asp:TextBox ID="txtMechanicDaysInForRepair" CssClass="TextBoxes" runat="server" OnClick="this.value=''" style="z-index: 1; left: 1057px; top: 400px; position: absolute"  OnTextChanged="txtMechanicPartPrice_TextChanged">Days In For Repair</asp:TextBox>

        <asp:Label ID="lblMechanicError" runat="server" style="z-index: 1; left: 1025px; top: 446px; position: absolute; width: 10px;" Text="-"></asp:Label>

        <asp:Button ID="btnMechanicViewData" CssClass="MechanicButton" runat="server" style="z-index: 1; left: 559px; top: 403px; position: absolute; height: 51px; width: 197px" Text="View Data" OnClick="btnMechanicViewData_Click" />

        <asp:TextBox ID="txtMechanicCarID" CssClass="TextBoxes" runat="server" ReadOnly="True" style="z-index: 1; left: 1057px; top: 191px; position: absolute; bottom: 441px;" OnTextChanged="txtMechanicCarID_TextChanged">CarID</asp:TextBox>

        <asp:Button ID="btnMechanicFetchCarID" CssClass="MechanicButton" runat="server" style="z-index: 1; left: 921px; top: 157px; position: absolute; width: 81px; height: 59px; bottom: 440px;" Text="Fetch CarID" OnClick="btnMechanicFetchCarID_Click" Font-Size="Small" />

        <asp:TextBox ID="txtMechanicRegPlateFilter" CssClass="TextBoxes" runat="server" style="z-index: 1; left: 1057px; top: 153px; position: absolute">Reg Plate Filter</asp:TextBox>

        <asp:Button ID="btnMechanicRegPlateFilter" CssClass="MechanicButton" runat="server" style="z-index: 1; left: 829px; top: 157px; position: absolute; height: 60px; width: 76px;" Text="Filter Cars" OnClick="btnMechanicRegPlateFilter_Click" Font-Size="Small"/>

        <asp:TextBox ID="txtMechanicStaffID" CssClass="TextBoxes" runat="server" style="z-index: 1; left: 1057px; top: 263px; position: absolute">StaffID</asp:TextBox>

        <asp:Button ID="btnMechanicStaffFilter" CssClass="MechanicButton" runat="server" style="z-index: 1; left: 829px; top: 231px; position: absolute; height: 61px; width: 75px; right: 453px;" Text="Filter staff" OnClick="btnMechanicStaffFilter_Click" Font-Size="Small" />

        <asp:TextBox ID="txtMechanicStaffFilter" CssClass="TextBoxes" runat="server" style="z-index: 1; left: 1057px; top: 230px; position: absolute">First Name Filter</asp:TextBox>

        <asp:Button ID="btnMechanicFetchStaffID" CssClass="MechanicButton" runat="server" style="z-index: 1; left: 921px; top: 230px; position: absolute; width: 83px; height: 62px;" Text="Fetch StaffID" OnClick="btnMechanicFetchStaffID_Click" Font-Size="Small" />

        <asp:Label ID="lblMechanicUserInfo" runat="server" style="z-index: 1; left: 19px; top: 14px; position: absolute" Text="-"></asp:Label>

        </form>

</body>
</html>
