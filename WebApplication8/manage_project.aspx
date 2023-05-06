<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="manage_project.aspx.cs" Inherits="WebApplication8.manage_project" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 183px">
    <form id="form1" runat="server">
    <div>
    
        MANAGE PROJECT<br />
        Choose in the list a project you like to change<br />
        <br />
        Project name:&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
&nbsp;
        <br />
        <br />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
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
