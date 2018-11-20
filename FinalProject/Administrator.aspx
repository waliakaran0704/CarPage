<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Administrator.aspx.cs" Inherits="FinalProject.Administrator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Username:&nbsp;&nbsp;
            <asp:TextBox ID="txtusr" runat="server"></asp:TextBox>
            <br />
            Password:&nbsp;&nbsp;
            <asp:TextBox ID="txtpass" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnlogin" runat="server" Text="Login" />
        </div>
    </form>
</body>
</html>
