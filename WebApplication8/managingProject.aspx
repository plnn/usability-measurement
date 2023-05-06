<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="managingProject.aspx.cs" Inherits="WebApplication8.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        EDITING PROJECT<br />
        <br />
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        </asp:DropDownList>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <br />
        name<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;
        <br />
        <br />
        url&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="edit" />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" BackColor="White" OnClick="Button2_Click" Text="back" />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
