<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="checklist.aspx.cs" Inherits="WebApplication8.checklist" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 272px">
    
        CHECKLIST<br />
        <br />
        Choose the project&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Search" />
    
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
&nbsp;
        <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/home.aspx" Visible="False">click here</asp:LinkButton>
        <br />
    
        <br />
        <asp:Label ID="Label2" runat="server" Text="Label" Visible="False"></asp:Label>
&nbsp;
        <asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl="~/add_test_user.aspx" Visible="False">click here</asp:LinkButton>
    
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="back" />
    
    </div>
    </form>
</body>
</html>
