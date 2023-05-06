<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication8.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 334px;
            height: 296px;
           
        }
    </style>
</head>

<body style="height: 270px; width: 995px">
    <form id="form1" runat="server">
    <div style="height: 600px">
     
      
	    
        <img alt="" class="auto-style1" src="resim/Adsız.png" /><asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="download" />
        <br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        account:<br />
        password:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <br />
    
        log in<br />
        account:<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
        <br />
        password:<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
    
    </div>
    </form>
</body>
</html>
