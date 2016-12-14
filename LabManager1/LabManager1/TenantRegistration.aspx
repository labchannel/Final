<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TenantRegistration.aspx.cs" Inherits="LabManager.TenantRegistration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
   <form id="form1" runat="server">
    
    <table class="auto-style1">
            <tr>
                <td class="auto-style3">UserName</td>
                <td class="auto-style6">
                    <asp:TextBox ID="TextBoxUN" runat="server" Height="22px" Width="170px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBoxUN" ErrorMessage="please enter username" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
<%--        <tr>
                <td class="auto-style3">MobileNumber</td>
                <td class="auto-style6">
                    <asp:TextBox ID="TextBoxMN" runat="server" Height="22px" Width="170px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="TextBoxMN" ErrorMessage="please enter Mobile number" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="validateMobile" runat="server" ErrorMessage="Please enter 10 digit valid mobile number" ControlToValidate="TextBoxMN" ForeColor="Red" ValidationGroup="test"
                        ValidationExpression="[0-9]{10}"></asp:RegularExpressionValidator><br />
                </td>
            </tr>--%>
            <tr>
                <td class="auto-style3">Email <br /></td>              
                <td class="auto-style6">
                    <asp:TextBox ID="txtEmail" runat="server" Width="180px"></asp:TextBox>            
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Email is required" ForeColor="Red" ControlToValidate="txtEmail"></asp:RequiredFieldValidator>                    
                     <asp:RegularExpressionValidator ID="validateEmail" runat="server" ErrorMessage="Please Enter Valid Email" ControlToValidate="txtEmail" ForeColor="Red" ValidationGroup="test"
  ValidationExpression="^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$" /><br />
                </td>

            </tr>
            <tr>
                <td class="auto-style3">Password</td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtpwd" runat="server" Width="180px" TextMode="Password"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Password is required" ForeColor="Red" ControlToValidate="txtpwd"></asp:RequiredFieldValidator>
                    <br />
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtpwd"
ValidationExpression="^(?=.*[A-Za-z])(?=.*\d)(?=.*[$@$!%*#?&])[A-Za-z\d$@$!%*#?&]{8,10}$"
ErrorMessage="password must contain minimum 8 characters,1 upper case ,1 lower case,1 numeric,1 special character" ForeColor="Red" ValidationGroup="test" />
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Confirm Password</td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtconfirmPWD" runat="server" Width="180px" TextMode="Password"></asp:TextBox>

                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="confirm password is required" ForeColor="Red" ControlToValidate="txtconfirmPWD"></asp:RequiredFieldValidator>
                    <br />
                    <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToCompare="txtpwd" ControlToValidate="txtconfirmPWD" ErrorMessage="Both passwords must be same" ForeColor="Red"></asp:CompareValidator>
                    <br />
                    
                </td>
            </tr>
            <tr>
                <td class="auto-style2" style="text-align: right">Gender</td>
                <td class="auto-style6">
                    <asp:DropDownList ID="ddlGender" runat="server" Width="180px">
                        <asp:ListItem>Select Gender</asp:ListItem>
                        <asp:ListItem>Female</asp:ListItem>
                        <asp:ListItem>Male</asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Select Gender" ForeColor="Red" InitialValue="0" ControlToValidate="ddlGender"></asp:RequiredFieldValidator>
                </td>
            </tr>
         <tr>
                <td class="auto-style3">Address</td>
                <td class="auto-style6">
                    <asp:TextBox ID="TextBoxAddr" runat="server" Height="22px" Width="170px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBoxAddr" ErrorMessage="please enter Address" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style6">
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>     
</body>
</html>

