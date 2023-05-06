<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="USET_userpage.aspx.cs" Inherits="WebApplication8.USET_userpage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 428px">
    <form id="form1" runat="server">
    <div>
    
        UET Login page<br />
        <br />
        Enter your email:<asp:TextBox ID="TextBox1" runat="server" style="margin-bottom: 1px"></asp:TextBox>
        <br />
        Enter project:<asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
