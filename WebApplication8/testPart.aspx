<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="testPart.aspx.cs" Inherits="WebApplication8.testPart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        WELCOME TO TEST<br />
        Kurallar...<br />
        <br />
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Click here to start test</asp:LinkButton>
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
