<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="add_project.aspx.cs" Inherits="WebApplication8.add_project" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label3" runat="server" BackColor="White" BorderColor="White" Font-Bold="True" Font-Names="Algerian" ForeColor="#66CCFF" Text="ADDING PROJECT"></asp:Label>
        <br />
        <br />
        &nbsp;<asp:Label ID="name" runat="server" BackColor="White" Text="name" Font-Bold="True" Font-Names="Andalus" ForeColor="#CC33FF"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        &nbsp;<asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Andalus" ForeColor="#CC33FF" Text="url"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" style="height: 22px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
&nbsp;<br />
&nbsp;<asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Names="Andalus" ForeColor="#CC66FF" Text="E mail"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        &nbsp;
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="add project" BackColor="White" Font-Bold="True" Font-Names="Andalus" ForeColor="#0066FF" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="back" BackColor="White" BorderColor="White" Font-Bold="True" Font-Names="Andalus" ForeColor="#33CCFF" />
        <br />
        <br />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" Height="139px" Width="213px">
            <Columns>
                <asp:BoundField />
            </Columns>
        </asp:GridView>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
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
