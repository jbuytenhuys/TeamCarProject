<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierHomepage.aspx.cs" Inherits="SupplierHomepage" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Supplier HomePage</title>
    <link rel="stylesheet" type="text/css" href="StyleSheet.css" />
</head>
<body style="height: 509px">

    <form runat="server" style="height: 868px">

        <asp:Button ID="btnSupplierLogout" CssClass="SupplierButton" runat="server" style="z-index: 1; left: 969px; top: 19px; position: absolute; height: 50px; width: 180px" Text="Logout" OnClick="btnSupplierLogout_Click" ForeColor="#999999" />
       <asp:Label ID="lblListOfSuppliers" runat="server" Text="List Of Suppliers" style="z-index: 1; left: 341px; top: 35px; position: absolute; width: 267px" ></asp:Label>
        <asp:TextBox CssClass="TextBoxes" ID="txtTitle" runat="server" OnClick="this.value=''" style="z-index: 1; left: 885px; top: 158px; position: absolute; width: 267px" >Title</asp:TextBox>
        <asp:TextBox CssClass="TextBoxes" ID="txtName" runat="server" OnClick="this.value=''" Style="z-index: 1; left: 885px; top: 186px; position: absolute; width: 267px; right: 245px;">Name</asp:TextBox>
        <asp:TextBox CssClass="TextBoxes" ID="txtPositionInCompany" runat="server" OnClick="this.value=''" Style="z-index: 1; left: 885px; top: 214px; position: absolute; width: 267px">PositionInCompany</asp:TextBox>
        <asp:TextBox CssClass="TextBoxes" ID="txtAddress" OnClick="this.value=''" runat="server" style="z-index: 1; left: 885px; top: 242px; position: absolute; width: 267px" >Address</asp:TextBox>
        <asp:TextBox CssClass="TextBoxes" ID="txtCity" runat="server" OnClick="this.value=''" style="z-index: 1; left: 885px; top: 270px; position: absolute; width: 267px" >City</asp:TextBox>
        <asp:TextBox CssClass="TextBoxes" ID="txtCounty" runat="server" OnClick="this.value=''" style="z-index: 1; left: 885px; top: 298px; position: absolute; width: 267px">County</asp:TextBox>
        <asp:TextBox CssClass="TextBoxes" ID="txtPostcode" runat="server" OnClick="this.value=''" style="z-index: 1; left: 885px; top: 326px; position: absolute; width: 267px" >Postcode</asp:TextBox>
        <asp:TextBox CssClass="TextBoxes" ID="txtMobile" runat="server" OnClick="this.value=''" style="z-index: 1; left: 885px; top: 354px; position: absolute; width: 267px">Moblie</asp:TextBox>
        <asp:TextBox CssClass="TextBoxes" ID="txtWorkExt" runat="server" OnClick="this.value=''" style="z-index: 1; left: 885px; top: 382px; position: absolute; width: 267px">WorkExt</asp:TextBox>
        <asp:TextBox CssClass="TextBoxes" ID="txtWorkNumber" runat="server" OnClick="this.value=''" style="z-index: 1; left: 885px; top: 410px; position: absolute; width: 267px" >WorkNumber</asp:TextBox>
        <asp:TextBox CssClass="TextBoxes" ID="txtDateAdded" runat="server" OnClick="this.value=''" style="z-index: 1; left: 885px; top: 433px; position: absolute; width: 267px; margin-top: 5px;" >DateAdded</asp:TextBox>
        <asp:TextBox CssClass="TextBoxes" ID="txtSupplierName" runat="server" OnClick="this.value=''" style="z-index: 1; left: 885px; top: 466px; position: absolute; width: 267px" >SupplierName</asp:TextBox>
        <asp:TextBox CssClass="TextBoxes" ID="txtSupplierEmail" runat="server" OnClick="this.value=''" style="z-index: 1; left: 885px; top: 477px; position: absolute; width: 267px; margin-top: 17px;" >SupplierEmail</asp:TextBox>
        <br />
        <br />


       
        <asp:Label ID="lblErrorMessageDisplay" runat="server" style="z-index: 1; left: 349px; top: 662px; position: absolute; width: 332px;" Text=""></asp:Label>

        <asp:Button ID="btnReset" CssClass="SupplierButton" runat="server" style="  left: 638px; top: 25px; position: absolute; width: 176px;" Text="Reset" OnClick="reset_Click" ForeColor="Black" />

        
        
        <asp:Button ID="btnAdd" CssClass="SupplierButton" runat="server" style="  left: 881px; top: 534px; position: absolute; width: 125px;" Text="ADD" OnClick="btnAdd_Click" ForeColor="Black" />
        <asp:Label ID="lblErrorMessageAdd" runat="server" style="z-index: 1; left: 1016px; top: 529px; position: absolute; width: 316px;" Text=""></asp:Label>

        <asp:Label ID="lblErrorMessageDelete" runat="server" style="z-index: 1; left: 1014px; top: 654px; position: absolute; width: 316px;" Text=""></asp:Label>

        <asp:Label ID="lblErrorMessageUpdate" runat="server" style="z-index: 1; left: 1013px; top: 597px; position: absolute; width: 316px;" Text=""></asp:Label>

        
        <br />

        
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
       
        <asp:ListBox CssClass="ListBoxes"  ID="lstBoxListSupplier" runat="server" style="z-index: 1; left: 337px; top: 61px; position: absolute; height: 511px; width: 414px; margin-top: 16px; right: 403px;" OnSelectedIndexChanged="lstBoxListSupplier_SelectedIndexChanged"></asp:ListBox>
        

       
        <asp:Button ID="btnDisplayRecord" CssClass="SupplierButton" runat="server" style="  left: 337px; top: 607px; position: absolute; width: 176px; height: 41px; right: 833px;" Text="Display Record" OnClick="btnDisplayRecord_Click" ForeColor="Black" />

        <asp:Button ID="btnDelete" CssClass="SupplierButton" runat="server" style="  left: 878px; top: 643px; position: absolute; width: 125px; right: 174px;" Text="Delete" OnClick="btnDelete_Click1" ForeColor="Black" />

         <asp:Button ID="btnUpdate" CssClass="SupplierButton" runat="server" style="  left: 879px; top: 593px; position: absolute; width: 125px;" Text="Update" OnClick="btnUpdate_Click" ForeColor="Black" />


    </form>
</body>
</html>











