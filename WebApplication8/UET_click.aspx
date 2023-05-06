<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UET_click.aspx.cs" Inherits="WebApplication8.UET_click" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color:rgb(209,208,225); background-repeat:repeat-x;">     
    <form id="form1" runat="server" background="resim/Desert.jpg"> 
    <div style="height: 361px">
    
        &nbsp;&nbsp;&nbsp;<br />
        Choose the UET action list below or back the page:<br />
        <br />
        <br />
&nbsp;Action:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" CausesValidation="True" Height="26px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="88px">
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" BackColor="White" OnClick="Button1_Click" Text="back" />
    
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
