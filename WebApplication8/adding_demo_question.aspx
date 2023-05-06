<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adding_demo_question.aspx.cs" Inherits="WebApplication8.adding_demo_question" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 281px">
    
        Question:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        Answer:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    
    </div>
    </form>
</body>
</html>
