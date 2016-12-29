<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TenantRegistration.aspx.cs" Inherits="LabManager.TenantRegistration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }
        .auto-style2 {
            height: 32px;
        }
        .auto-style6 {
            width: 261px;
        }
        .auto-style7 {
            height: 26px;
            width: 64px;
        }
        .auto-style8 {
            height: 32px;
            width: 64px;
        }
        .auto-style9 {
            width: 64px;
        }
        .auto-style10 {
            width: 183px;
        }
        .auto-style11 {
            height: 26px;
            width: 183px;
        }
        .auto-style12 {
            height: 32px;
            width: 183px;
        }
        .auto-style13 {
            height: 28px;
        }
        .auto-style14 {
            width: 184px;
        }
        .auto-style15 {
            height: 26px;
            width: 184px;
        }
        .auto-style16 {
            height: 32px;
            width: 184px;
        }
        .auto-style17 {
            width: 261px;
            height: 32px;
        }
    </style>
</head>
<body>
   <form id="form1" runat="server">
    <br />
       :<table style="color: #000000; background-color: #FFCC66; width: 757px; margin-left: 160px; margin-top: 15px;">
    
            <tr>
                <td class="auto-style13" style="font-family: Arial; font-size: 20px; font-weight: bold; font-style: normal; text-transform: capitalize; color: #000080" colspan="4">Create User:</td>
            </tr>
    
            <tr>
                <td class="auto-style13" style="font-family: Arial; font-size: 20px; font-weight: bold; font-style: normal; text-transform: capitalize; color: #000080" colspan="4">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="click to log out" />
                </td>
            </tr>
    
            <tr>
                <td class="auto-style9" style="font-family: Arial; font-size: 20px; font-weight: bold; font-style: normal; text-transform: capitalize; color: #000080">&nbsp;</td>
                <td class="auto-style14" style="font-family: Arial; font-size: 20px; font-weight: bold; font-style: normal; text-transform: capitalize; color: #000080">UserName</td>
                <td class="auto-style6">
                    <asp:TextBox ID="TextBoxUN" runat="server" Height="22px" Width="180px"></asp:TextBox>
                </td>
                <td class="auto-style10" style="font-variant: normal; text-transform: capitalize">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBoxUN" ErrorMessage="please enter username" ForeColor="Red" ValidationGroup="test"></asp:RequiredFieldValidator>
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
                <td class="auto-style9" style="font-family: Arial; font-size: 20px; font-weight: bold; font-style: normal; text-transform: capitalize; color: #000080">&nbsp;</td>              
                <td class="auto-style14" style="font-family: Arial; font-size: 20px; font-weight: bold; font-style: normal; text-transform: capitalize; color: #000080">Email <br /></td>              
                <td class="auto-style6">
                    <asp:TextBox ID="txtEmail" runat="server" Width="180px"></asp:TextBox>            
                </td>
                <td class="auto-style10" style="font-variant: normal; text-transform: capitalize">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Email is required" ForeColor="Red" ControlToValidate="txtEmail" ValidationGroup="test"></asp:RequiredFieldValidator>                    
                 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <br />
                    <asp:RegularExpressionValidator ID="validateEmail" runat="server" ErrorMessage="Please Enter Valid Email" ControlToValidate="txtEmail" ForeColor="Red" ValidationGroup="test"
  ValidationExpression="^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$" /><br />
                </td>

            </tr>
            <tr>
                <td class="auto-style9" style="font-family: Arial; font-size: 20px; font-weight: bold; font-style: normal; text-transform: capitalize; color: #000080">&nbsp;</td>
                <td class="auto-style14" style="font-family: Arial; font-size: 20px; font-weight: bold; font-style: normal; text-transform: capitalize; color: #000080">Password</td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtpwd" runat="server" Width="180px" TextMode="Password"></asp:TextBox>
                </td>
                <td class="auto-style10" style="font-variant: normal; text-transform: capitalize">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Password is required" ForeColor="Red" ControlToValidate="txtpwd" ValidationGroup="test"></asp:RequiredFieldValidator>
                    <br />
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtpwd" ErrorMessage="Password must be at least 8 characters, no more than 15 characters, and must include at least one upper case letter, one lower case letter, and one numeric digit" Font-Bold="True" ForeColor="#FF3300" ValidationExpression="^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,15}$"></asp:RegularExpressionValidator>
                    <br />
                </td>
            </tr>
            <tr>
                <td class="auto-style9" style="font-family: Arial; font-size: 20px; font-weight: bold; font-style: normal; text-transform: capitalize; color: #000080">&nbsp;</td>
                <td class="auto-style14" style="font-family: Arial; font-size: 20px; font-weight: bold; font-style: normal; text-transform: capitalize; color: #000080">Confirm Password</td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtconfirmPWD" runat="server" Width="180px" TextMode="Password"></asp:TextBox>

                </td>
                <td class="auto-style10" style="font-variant: normal; text-transform: capitalize">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="confirm password is required" ForeColor="Red" ControlToValidate="txtconfirmPWD" ValidationGroup="test"></asp:RequiredFieldValidator>
                    <br />
                    <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToCompare="txtpwd" ControlToValidate="txtconfirmPWD" ErrorMessage="Both passwords must be same" ForeColor="Red" ValidationGroup="test"></asp:CompareValidator>
                    <br />
                    
                </td>
            </tr><tr>
        <td class="auto-style7" style="font-family: Arial; font-size: 20px; font-weight: bold; font-style: normal; text-transform: capitalize; color: #000080">&nbsp;</td>
        <td class="auto-style15" style="font-family: Arial; font-size: 20px; font-weight: bold; font-style: normal; text-transform: capitalize; color: #000080">Mobile</td>
                <td class="auto-style1">
                    <asp:TextBox ID="TxtMbl" runat="server" Width="180px" TextMode="Phone"></asp:TextBox>

                </td>
                <td class="auto-style11" style="font-variant: normal; text-transform: capitalize">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Mobile is required" ForeColor="Red" ControlToValidate="TxtMbl" ValidationGroup="test"></asp:RequiredFieldValidator>
                    <br /></td>
                </tr>
            <tr>
                <td class="auto-style8" style="font-family: Arial; font-size: 20px; font-weight: bold; font-style: normal; text-transform: capitalize; color: #000080" >&nbsp;</td>
                <td class="auto-style16" style="font-family: Arial; font-size: 20px; font-weight: bold; font-style: normal; text-transform: capitalize; color: #000080" >Gender</td>
                <td class="auto-style6">
                    <asp:DropDownList ID="ddlGender" runat="server" Width="180px">
                        <asp:ListItem>Select Gender</asp:ListItem>
                        <asp:ListItem>Female</asp:ListItem>
                        <asp:ListItem>Male</asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style10" style="font-variant: normal; text-transform: capitalize">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Select Gender" ForeColor="Red" InitialValue="0" ControlToValidate="ddlGender" ValidationGroup="test"></asp:RequiredFieldValidator>
                </td>
            </tr>
         <tr>
                <td class="auto-style9" style="font-family: Arial; font-size: 20px; font-weight: bold; font-style: normal; text-transform: capitalize; color: #000080">&nbsp;</td>
                <td class="auto-style14" style="font-family: Arial; font-size: 20px; font-weight: bold; font-style: normal; text-transform: capitalize; color: #000080">Address</td>
                <td class="auto-style6">
                    <asp:TextBox ID="TextBoxAddr" runat="server" Height="22px" Width="170px"></asp:TextBox>
                </td>
                <td class="auto-style10" style="font-variant: normal; text-transform: capitalize">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBoxAddr" ErrorMessage="please enter Address" ForeColor="Red" ValidationGroup="test"></asp:RequiredFieldValidator>
                    <br />
                </td>
            </tr>
         <tr>
                <td class="auto-style9" style="font-family: Arial; font-size: 20px; font-weight: bold; font-style: normal; text-transform: capitalize; color: #000080">&nbsp;</td>
                <td class="auto-style14" style="font-family: Arial; font-size: 20px; font-weight: bold; font-style: normal; text-transform: capitalize; color: #000080">Street</td>
                <td class="auto-style6">
                    <asp:TextBox ID="TxtStrt" runat="server" Height="22px" Width="170px"></asp:TextBox>
                </td>
                <td class="auto-style10" style="font-variant: normal; text-transform: capitalize">
                    <br />
                </td>
            </tr> <tr>
                <td class="auto-style9" style="font-family: Arial; font-size: 20px; font-weight: bold; font-style: normal; text-transform: capitalize; color: #000080">&nbsp;</td>
                <td class="auto-style14" style="font-family: Arial; font-size: 20px; font-weight: bold; font-style: normal; text-transform: capitalize; color: #000080">City</td>
                <td class="auto-style6">
                    <asp:TextBox ID="TxtCity" runat="server" Height="22px" Width="170px"></asp:TextBox>
                </td>
                <td class="auto-style10" style="font-variant: normal; text-transform: capitalize">
                    <br />
                </td>
            </tr> <tr>
                <td class="auto-style8" style="font-family: Arial; font-size: 20px; font-weight: bold; font-style: normal; text-transform: capitalize; color: #000080"></td>
                <td class="auto-style16" style="font-family: Arial; font-size: 20px; font-weight: bold; font-style: normal; text-transform: capitalize; color: #000080">state</td>
                <td class="auto-style17">
                    <asp:TextBox ID="TxtState" runat="server" Height="22px" Width="170px"></asp:TextBox>
                </td>
                <td class="auto-style12" style="font-variant: normal; text-transform: capitalize">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="TxtState" ErrorMessage="please enter Address" ForeColor="Red" ValidationGroup="test"></asp:RequiredFieldValidator>
                    <br />
                </td>
            </tr> <tr>
                <td class="auto-style8" style="font-family: Arial; font-size: 20px; font-weight: bold; font-style: normal; text-transform: capitalize; color: #000080">&nbsp;</td>
                <td class="auto-style16" style="font-family: Arial; font-size: 20px; font-weight: bold; font-style: normal; text-transform: capitalize; color: #000080">zip Code</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TeXtZipCode" runat="server" Height="22px" Width="170px"></asp:TextBox>
                </td>
                <td class="auto-style12" style="font-variant: normal; text-transform: capitalize">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="TeXtZipCode" ErrorMessage="please enter Address" ForeColor="Red" ValidationGroup="test"></asp:RequiredFieldValidator>
                    <br />
                </td>
            </tr>
            <tr>
                <td class="auto-style9" style="font-family: Arial; font-size: 20px; font-weight: bold; font-style: normal; text-transform: capitalize; color: #000080">&nbsp;</td>
                <td class="auto-style14" style="font-family: Arial; font-size: 20px; font-weight: bold; font-style: normal; text-transform: capitalize; color: #000080">&nbsp;</td>
                <td class="auto-style6">
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" ValidationGroup="test" OnClick="btnSubmit_Click" />
                </td>
                <td class="auto-style10" style="font-variant: normal; text-transform: capitalize">&nbsp;</td>
            </tr>
        </table>
       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Size="Larger" ForeColor="Blue"></asp:Label>
      <br />
       <br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Hyperlink ID="HyLogin" runat="server" NavigateUrl="~/Login.aspx" Text="Go to login page"></asp:Hyperlink>
    </form>     
</body>
</html>

