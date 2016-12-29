<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="tenantpage.aspx.cs" Inherits="LabManager1.tenantpage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        function Create(code) {
            window.open('Employee.aspx?code=' + code, 'Create', ' width=640, height=480, left=0, top=0');
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Restaurant Name:<asp:TextBox ID="txtResname" runat="server"></asp:TextBox>
        <br />
        Restaurant Address:<asp:TextBox ID="txtResaddr" runat="server"></asp:TextBox>
        <br />
        Manager Name:<asp:TextBox ID="txtMN" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Click To Logout" />
        <br />
        Manager Address:<asp:TextBox ID="txtMA" runat="server"></asp:TextBox>
        <br />
        Manager MobileEmail:<asp:TextBox ID="txtMEmail" runat="server"></asp:TextBox>
    
        <br />
        DateOfBirth:<asp:TextBox ID="txtDOB" runat="server"></asp:TextBox>
        <asp:Button ID="btnDate" runat="server" OnClick="btnDate_Click" Text="Date" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="Black" DayNameFormat="Shortest" Font-Names="Times New Roman" Font-Size="10pt" ForeColor="Black" Height="100px" NextPrevFormat="FullMonth" OnSelectionChanged="Calendar1_SelectionChanged" TitleFormat="Month" Visible="False" Width="296px">
            <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" ForeColor="#333333" Height="10pt" />
            <DayStyle Width="14%" />
            <NextPrevStyle Font-Size="8pt" ForeColor="White" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <SelectedDayStyle BackColor="#CC3333" ForeColor="White" />
            <SelectorStyle BackColor="#CCCCCC" Font-Bold="True" Font-Names="Verdana" Font-Size="8pt" ForeColor="#333333" Width="1%" />
            <TitleStyle BackColor="Black" Font-Bold="True" Font-Size="13pt" ForeColor="White" Height="14pt" />
            <TodayDayStyle BackColor="#CCCC99" />
        </asp:Calendar>
    
        <br />
        <asp:Button ID="btnSubmit" runat="server" OnClick="Button1_Click" Text="Submit" />
    
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Employee" />
       
<asp:gridview ID="Gridview1" runat="server" ShowFooter="True" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" DataSourceID="SqlDataSource1" >
    <Columns>
         <asp:BoundField DataField="EName" HeaderText="EName" SortExpression="EName" />
        <asp:BoundField DataField="EAddress" HeaderText="EAddress" SortExpression="EAddress" />       
        <asp:BoundField DataField="EEmail" HeaderText="EEmail" SortExpression="EEmail" />
       <asp:TemplateField HeaderText="">
             <ItemTemplate>
            <a href="#" onclick='Create("<%# Eval(" EName") %>");'>Create</a>                           
       </ItemTemplate>
        </asp:TemplateField>
    </Columns>  
</asp:gridview>
       
    
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:aspnetdbConnectionString %>" SelectCommand="SELECT EName, EAddress, EEmail FROM aspnet_Employee"></asp:SqlDataSource>
       
    
    </div>
    </form>
</body>
</html>