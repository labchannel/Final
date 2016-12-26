<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employee.aspx.cs" Inherits="LabManager1.Employee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        EmployeeName:<asp:TextBox ID="txtEmpName" runat="server"></asp:TextBox>
        <br />
        EmployeeAddress:<asp:TextBox ID="txtEmpAddr" runat="server"></asp:TextBox>
        <br />
        EmployeeEmail:<asp:TextBox ID="txtEmpEmail" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <br />
    
    </div>
    </form>
</body>
</html>
