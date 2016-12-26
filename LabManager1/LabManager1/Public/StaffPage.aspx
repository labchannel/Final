<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StaffPage.aspx.cs" Inherits="LabManager1.StaffPage" culture="auto" meta:resourcekey="PageResource1" uiculture="auto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
   <style type="text/css">
        .auto-style1 {
           color: #000000; background-color: #FFCC66; width: 781px; 
margin-left: 160px; margin-top: 85px;
           height: 314px;
       }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
    
       <br />
        <asp:Label ID="lbStaff" runat="server" Text="Welocome to Staff Page:" Font-Bold="True" Font-Size="Larger" ForeColor="Blue" meta:resourcekey="lbStaffResource1"></asp:Label>  
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;
        <asp:Button ID="bLogout" runat="server" Font-Bold="True" ForeColor="#FF0066" meta:resourcekey="bLogoutResource1" Text="Click to log out!!" OnClick="bLogout_Click" />
        <br />
        <br />
        <asp:Label ID="lbHello" runat="server" Text="Hello" Font-Bold="True" Font-Size="X-Large" meta:resourcekey="lbHelloResource1"></asp:Label>&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lbusername" runat="server" Font-Bold="True" Font-Size="X-Large" meta:resourcekey="lbusernameResource1"></asp:Label>

        <br />
        <br />
        <asp:Label ID="lbyourrole" runat="server" Font-Bold="True" ForeColor="#FF0066" meta:resourcekey="lbyourroleResource1" Text="Your Role is "></asp:Label>
        <asp:Label ID="lbrole" runat="server" meta:resourcekey="lbroleResource1" Font-Bold="True" Font-Size="Large" Font-Underline="True"></asp:Label>

    </div>
    </form>
</body>
</html>
