<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierHomepage.aspx.cs" Inherits="SupplierHomepage" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Supplier HomePage</title>
    <link rel="stylesheet" type="text/css" href="StyleSheet.css" />
</head>
<body style="height: 509px">

    <form runat="server" style="height: 643px">

    <p>
        
        <br />
    </p>
        <asp:Button ID="btnSupplierLogout" CssClass="SupplierButton" runat="server" style="z-index: 1; left: 730px; top: 18px; position: absolute; height: 50px; width: 180px" Text="Logout" OnClick="btnSupplierLogout_Click" ForeColor="#999999" />
       
        <asp:TextBox CssClass="TextBoxes" ID="txtTitle" runat="server" OnClick="this.value=''" style="z-index: 1; left: 837px; top: 220px; position: absolute; width: 267px" >Title</asp:TextBox>
        <asp:TextBox CssClass="TextBoxes" ID="txtName" runat="server" OnClick="this.value=''" style="z-index: 1; left: 836px; top: 250px; position: absolute; width: 267px" >Name</asp:TextBox>
        <asp:TextBox CssClass="TextBoxes" ID="txtPositionInCompany" OnClick="this.value=''" runat="server" style="z-index: 1; left: 836px; top: 280px; position: absolute; width: 267px" >PostionInCompany</asp:TextBox>
        <asp:TextBox CssClass="TextBoxes" ID="txtAddress" OnClick="this.value=''" runat="server" style="z-index: 1; left: 836px; top: 310px; position: absolute; width: 267px" >Address</asp:TextBox>
        <asp:TextBox CssClass="TextBoxes" ID="txtCity" runat="server" OnClick="this.value=''" style="z-index: 1; left: 837px; top: 340px; position: absolute; width: 267px" >City</asp:TextBox>
        <asp:TextBox CssClass="TextBoxes" ID="txtCounty" runat="server" OnClick="this.value=''" style="z-index: 1; left: 835px; top: 370px; position: absolute; width: 267px">County</asp:TextBox>
        <asp:TextBox CssClass="TextBoxes" ID="txtPostcode" runat="server" OnClick="this.value=''" style="z-index: 1; left: 834px; top: 400px; position: absolute; width: 267px" >Postcode</asp:TextBox>
        <asp:TextBox CssClass="TextBoxes" ID="txtMobile" runat="server" OnClick="this.value=''" style="z-index: 1; left: 834px; top: 430px; position: absolute; width: 267px">Moblie</asp:TextBox>
        <asp:TextBox CssClass="TextBoxes" ID="txtWorkExt" runat="server" OnClick="this.value=''" style="z-index: 1; left: 834px; top: 460px; position: absolute; width: 267px">WorkExt</asp:TextBox>
        <asp:TextBox CssClass="TextBoxes" ID="txtWorkNumber" runat="server" OnClick="this.value=''" style="z-index: 1; left: 834px; top: 490px; position: absolute; width: 267px" >WorkNumber</asp:TextBox>
        <asp:TextBox CssClass="TextBoxes" ID="txtDateAdded" runat="server" OnClick="this.value=''" style="z-index: 1; left: 833px; top: 522px; position: absolute; width: 267px" >DateAdded</asp:TextBox>
        <asp:TextBox CssClass="TextBoxes" ID="txtSupplierName" runat="server" OnClick="this.value=''" style="z-index: 1; left: 834px; top: 555px; position: absolute; width: 267px" >SupplierName</asp:TextBox>
        <asp:TextBox CssClass="TextBoxes" ID="txtSupplierEmail" runat="server" OnClick="this.value=''" style="z-index: 1; left: 833px; top: 585px; position: absolute; width: 267px" >SupplierEmail</asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

        <asp:Button ID="btnDisplayRecord" runat="server" OnClick="btnDisplayRecord_Click" Text="Display Record" />

        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnReset" runat="server" OnClick="reset_Click" Text="Reset" Height="30px" Width="100px" />
        <asp:Button ID="btnAdd" CssClass="SupplierButton" runat="server" style="  left: 115px; top: 672px; position: absolute; width: 82px;" Text="ADD" OnClick="btnAdd_Click" ForeColor="Black" />
        <asp:Label ID="lblErrorMessageAdd" runat="server" style="z-index: 1; left: 79px; top: 615px; position: absolute; width: 316px;" Text=""></asp:Label>

        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblErrorMessageDisplay" runat="server" Text=""  style="z-index: 1; font-size: large;"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        
        <br />
        <asp:Label ID="lblFilterByPostcode" runat="server" Text="Search Supplier PostCode" style="font-size: large"></asp:Label>
        <br />
        <asp:TextBox ID="txtFilterPostcode" runat="server" OnTextChanged="txtFilterPostcode_TextChanged">Enter Postcode</asp:TextBox>
        &nbsp;<asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" Text="Search" />

        <br />
        <asp:Label ID="lblErrorSearchPostCode" runat="server" Text="" style="font-size: large"></asp:Label>
         <br />
        <asp:Label ID="lblFilterByWorkNumber" runat="server" Text="Search Supplier WorkNumber" style="font-size: large"></asp:Label>
        <br />
         <asp:TextBox ID="txtFilterWorkNumber" runat="server" OnTextChanged="txtFilterWorkNumber_TextChanged">Enter WorkNumber</asp:TextBox>
       
        &nbsp;<asp:Button ID="btnSearchWorkNumber" runat="server" OnClick="btnSearchWorkNumber_Click" Text="Search" />
          <br />
        <asp:Label ID="Label2" runat="server" Text="" style="font-size: large"></asp:Label>

        <br />

       
        <asp:Label ID="lblFilterBySupplierNmae" runat="server" Text="Search Supplier Name" style="font-size: large"></asp:Label>

       
        <br />
        <asp:TextBox ID="txtFilterSupplierName" runat="server">Enter SupplierName</asp:TextBox>

       
          &nbsp;<asp:Button ID="btnSearchSupplierName" runat="server" Text="Search" OnClick="btnSearchSupplierName_Click" />

       
        <br />
       

        <asp:Label ID="Label3" runat="server" style="font-size: large"></asp:Label>

       
        <br />
        &nbsp;&nbsp;&nbsp;
       
        <asp:ListBox CssClass="ListBoxes"  ID="lstBoxListSupplier" runat="server" style="z-index: 1; left: 337px; top: 242px; position: absolute; height: 342px; width: 414px; margin-top: 16px; right: 403px;" OnSelectedIndexChanged="lstBoxListSupplier_SelectedIndexChanged"></asp:ListBox>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
        <p style="width: 1116px">
            &nbsp;</p>
        <p style="width: 1116px; margin-left: 400px; height: 36px;">

            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
        <p style="width: 1116px; margin-left: 760px;">
            &nbsp;&nbsp;<asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click1" Height="30px" Width="100px" />
       
            &nbsp;&nbsp;&nbsp;<asp:Label ID="lblErrorMessageDelete" runat="server" Text="" style="font-size: large"></asp:Label>
        </p>
        <p style="width: 1116px">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="BtnUpdate" runat="server" OnClick="BtnUpdate_Click" Text="Update" Height="30px" Width="100px" />
            &nbsp;
        </p>
        <p style="width: 1116px">
            &nbsp;</p>

    </form>
</body>
</html>











