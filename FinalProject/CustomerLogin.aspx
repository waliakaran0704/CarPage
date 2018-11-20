<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerLogin.aspx.cs" Inherits="FinalProject.CustomerLogin" %>

<%@ Register src="UserControls/NotLoggedInUserControl.ascx" tagname="NotLoggedInUserControl" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Customer Login</title>
    <link href="styles/styles.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc1:NotLoggedInUserControl ID="NotLoggedInUserControl1" runat="server" />
            <h1>LOGIN</h1>
            <p>
                Username:
                <asp:TextBox ID="txtCustomerUsernameLogin" runat="server"></asp:TextBox>
            </p>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtCustomerUsernameLogin" CssClass="validationText" ErrorMessage="Please provide a login name"></asp:RequiredFieldValidator>
            <p>
                Password: <asp:TextBox ID="txtCustomerPasswordLogin" runat="server" TextMode="Password"></asp:TextBox>
            </p>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtCustomerPasswordLogin" CssClass="validationText" ErrorMessage="Password field can not be left blank"></asp:RequiredFieldValidator>
            <p>
                <asp:Button ID="btnLogin" runat="server" Text="Log In" OnClick="btnLogin_Click" CssClass="button" />
            </p>
            <p>
                New User? <asp:HyperLink ID="linkToRegisterPage" runat="server" NavigateUrl="~/RegisterCustomer.aspx">Register Here</asp:HyperLink>
            </p>
            <p>
                <asp:Label ID="lblMessage" runat="server"></asp:Label>
            </p>
        </div>
    </form>
</body>
</html>
