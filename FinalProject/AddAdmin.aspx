<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddAdmin.aspx.cs" Inherits="FinalProject.AddAdmin" %>

<%@ Register src="UserControls/NotLoggedInUserControl.ascx" tagname="NotLoggedInUserControl" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">


.controlMenu {
    width: 75%;
}


ul {
    list-style-type: none;
    margin: 10px;
    padding: 10px;
    overflow: hidden;
    background-color: #333;
}

li {
    float: left;
    padding: 5px 20px 5px 20px;
}

li a {
    display: block;
    color: white;
    text-align: center;
    padding: 10px 25px;
    text-decoration: none;
    
}

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="background-color: #FFCC66; font-size: large;">
            <uc1:NotLoggedInUserControl ID="NotLoggedInUserControl1" runat="server" />
            <h1 style="background-color: #FF9933; font-family: Arial, Helvetica, sans-serif; color: #336699;">LOGIN</h1>
            <br />
            <br />
            <br />
            Username:&nbsp;&nbsp;
            <asp:TextBox ID="txtusr" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtusr" ErrorMessage="Please enter your username" ForeColor="#FF3300"></asp:RequiredFieldValidator>
            <br />
            <br />
            <br />
            Password:&nbsp;&nbsp;
            <asp:TextBox ID="txtpass"  runat="server" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtpass" ErrorMessage="Please enter your password" ForeColor="#FF3300"></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Button ID="btnadmin" runat="server" OnClick="btnadmin_Click" Text="Login" />
        </div>
        <p>
            <asp:Label ID="lbl" runat="server" ForeColor="#FF3300"></asp:Label>
        </p>
    </form>
</body>
</html>
