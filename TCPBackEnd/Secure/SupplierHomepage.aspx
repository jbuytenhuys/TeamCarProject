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
        <asp:Button ID="btnSupplierLogout" CssClass="SupplierButton" runat="server" style="z-index: 1; left: 730px; top: 18px; position: absolute; height: 50px; width: 180px" Text="Logout" OnClick="btnSupplierLogout_Click" />
       
        <asp:TextBox CssClass="TextBoxes" ID="txtTitle" runat="server" OnClick="this.value=''" style="z-index: 1; left: 858px; top: 220px; position: absolute; width: 264px" >Title</asp:TextBox>
        <asp:TextBox CssClass="TextBoxes" ID="txtName" runat="server" OnClick="this.value=''" style="z-index: 1; left: 857px; top: 250px; position: absolute; width: 264px" >Name</asp:TextBox>
        <asp:TextBox CssClass="TextBoxes" ID="txtPostionInCompany" OnClick="this.value=''" runat="server" style="z-index: 1; left: 858px; top: 280px; position: absolute; width: 264px" >PostionInCompany</asp:TextBox>
        <asp:TextBox CssClass="TextBoxes" ID="txtAddress" runat="server" OnClick="this.value=''" style="z-index: 1; left: 858px; top: 310px; position: absolute; width: 271px" >Address</asp:TextBox>
        <asp:TextBox CssClass="TextBoxes" ID="txtCity" runat="server" OnClick="this.value=''" style="z-index: 1; left: 858px; top: 340px; position: absolute; width: 264px" >City</asp:TextBox>
        <asp:TextBox CssClass="TextBoxes" ID="txtCounty" runat="server" OnClick="this.value=''" style="z-index: 1; left: 858px; top: 370px; position: absolute; width: 264px">County</asp:TextBox>
        <asp:TextBox CssClass="TextBoxes" ID="txtPostcode" runat="server" OnClick="this.value=''" style="z-index: 1; left: 858px; top: 400px; position: absolute; width: 264px" >Postcode</asp:TextBox>
        <asp:TextBox CssClass="TextBoxes" ID="txtMobile" runat="server" OnClick="this.value=''" style="z-index: 1; left: 858px; top: 430px; position: absolute; width: 264px">Moblie</asp:TextBox>
        <asp:TextBox CssClass="TextBoxes" ID="txtWorkExt" runat="server" OnClick="this.value=''" style="z-index: 1; left: 858px; top: 460px; position: absolute; width: 264px">WorkExt</asp:TextBox>
        <asp:TextBox CssClass="TextBoxes" ID="txtWorkNumber" runat="server" OnClick="this.value=''" style="z-index: 1; left: 858px; top: 490px; position: absolute; width: 264px" >WorkNumber</asp:TextBox>
        <asp:TextBox CssClass="TextBoxes" ID="txtDateAdded" runat="server" OnClick="this.value=''" style="z-index: 1; left: 858px; top: 530px; position: absolute; width: 264px" >DateAdded</asp:TextBox>
        <asp:TextBox CssClass="TextBoxes" ID="txtSupplierName" runat="server" OnClick="this.value=''" style="z-index: 1; left: 858px; top: 560px; position: absolute; width: 264px" >SupplierName</asp:TextBox>
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>

        <asp:Button ID="btnDisplayRecord" runat="server" OnClick="btnDisplayRecord_Click" Text="Display Record" />

        <br />
        <asp:TextBox ID="txtFilterPostcode" runat="server" OnTextChanged="txtFilterPostcode_TextChanged">FilterPostcode</asp:TextBox>
        <asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" Text="Search" />

        <br />
         <asp:TextBox ID="txtFilterWorkNumber" runat="server" OnTextChanged="txtFilterWorkNumber_TextChanged">txtFilterWorkNumber</asp:TextBox>
       
        <asp:Button ID="btnSearchWorkNumber" runat="server" OnClick="btnSearchWorkNumber_Click" Text="Search" />
          <br />
          <br />


        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>

       
        <br />
        <br />
        <br />
        <asp:TextBox ID="txtFilterSupplierName" runat="server"></asp:TextBox>

       
          <asp:Button ID="btnSearchSupplierName" runat="server" Text="Button" OnClick="btnSearchSupplierName_Click" />

       
        <br />
       
        <br />
        <br />
       
        <asp:ListBox CssClass="ListBoxes"  ID="lstBoxListSupplier" runat="server" style="z-index: 1; left: 334px; top: 234px; position: absolute; height: 355px; width: 414px; margin-top: 16px" OnSelectedIndexChanged="lstBoxListSupplier_SelectedIndexChanged"></asp:ListBox>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnreset" runat="server" OnClick="reset_Click" Text="reset" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p style="margin-left: 840px">
        <asp:Button ID="BtnUpdate" runat="server" OnClick="BtnUpdate_Click" Text="Update" />
        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click1" Height="39px" />
       
        <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
            &nbsp;</p>

    </form>
</body>
</html>











