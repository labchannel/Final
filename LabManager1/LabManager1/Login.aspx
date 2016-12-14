<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LabManager.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
     <form id="form1" runat="server">
    <div>
    
        Email:<asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Email is required" ForeColor="Red" ControlToValidate="txtEmail"></asp:RequiredFieldValidator>                    
                     <asp:RegularExpressionValidator ID="validateEmail" runat="server" ErrorMessage="Please Enter Valid Email" ControlToValidate="txtEmail" ForeColor="Red" ValidationGroup="test"
  ValidationExpression="^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$" /><br />
        Password:<asp:TextBox ID="txtLoginpwd" runat="server"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtLoginpwd"
ValidationExpression="^(?=.*[A-Za-z])(?=.*\d)(?=.*[$@$!%*#?&])[A-Za-z\d$@$!%*#?&]{8,10}$"
ErrorMessage="Invalid Username or Password" ForeColor="Red" ValidationGroup="test" />

        <br />
        <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Newuser" />
    
    </div>
    </form>
</body>
</html>
