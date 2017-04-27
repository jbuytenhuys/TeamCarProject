<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Homepage.aspx.cs" Inherits="Homepage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Homepage</title>
    <link rel="stylesheet" type="text/css" href="StyleSheet.css" />
</head>
<body style="height: 611px">
    <form id="form1" runat="server">
    <div style="height: 606px">
    
        <asp:ImageButton ID="btnCoupe" runat="server" ImageUrl="~/Images/e-class-coupe-v2-180x110_jpg_asset_ulqEJLw9J6xspmDRXccLXjCX8zqdohmUg6X2z0d6ih4.jpg" style="z-index: 1; left: 700px; top: 321px; position: absolute; height: 168px; width: 227px" OnClick="btnCoupe_Click" />
        <asp:ImageButton ID="btnHatchbacks" runat="server" ImageUrl="~/Images/A-160-Sport_jpg_asset_UPqedCzsqR5sG6aEseWjUtmCFNJLMDuH7RjAVKZGABo.jpg" style="z-index: 1; left: 212px; top: 322px; position: absolute; height: 166px; width: 232px" OnClick="btnHatchbacks_Click" />
        <asp:ImageButton ID="btnSports" runat="server" ImageUrl="~/Images/media.jpg" style="z-index: 1; left: 458px; top: 321px; position: absolute; height: 167px; width: 224px" OnClick="btnSports_Click" />
        <asp:ImageButton ID="btn4x4" runat="server" ImageUrl="~/Images/mediaES2E2G83.jpg" style="z-index: 1; left: 950px; top: 320px; position: absolute; height: 168px; width: 218px" OnClick="btn4x4_Click" />
        <asp:Button ID="btnAboutUs" runat="server" style="z-index: 1; left: 201px; top: 559px; position: absolute; right: 1227px" Text="About Us" OnClick="btnAboutUs_Click" />
        <asp:Label ID="lblHatchbacks" runat="server" style="z-index: 1; left: 284px; top: 271px; position: absolute; margin-bottom: 0px" Text="Hatchbacks"></asp:Label>
        <asp:Label ID="lblSports" runat="server" style="z-index: 1; left: 549px; top: 271px; position: absolute" Text="Sports"></asp:Label>
        <asp:Label ID="lblCoupe" runat="server" style="z-index: 1; left: 792px; top: 270px; position: absolute" Text="Coupe"></asp:Label>
        <asp:Label ID="lbl4x4" runat="server" style="z-index: 1; left: 1038px; top: 270px; position: absolute; height: 23px; width: 28px" Text="4x4"></asp:Label>
        <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/logo.png" style="z-index: 1; left: 619px; top: 56px; position: absolute; height: 204px; width: 201px" />
    
    </div>
    </form>
</body>
</html>
