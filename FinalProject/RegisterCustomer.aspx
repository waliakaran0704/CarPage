<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterCustomer.aspx.cs" Inherits="FinalProject.RegisterUser" %>

<%@ Register src="UserControls/NotLoggedInUserControl.ascx" tagname="NotLoggedInUserControl" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="styles/styles.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc1:NotLoggedInUserControl ID="NotLoggedInUserControl1" runat="server" />
            <h1>REGISTER</h1>
            <p>
                Name:
                <asp:TextBox ID="txtCustomerName" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="CustomerNameRequiredFieldValidator" runat="server" ControlToValidate="txtCustomerName" Display="Dynamic" ErrorMessage="Customer name must be provided" CssClass="validationText"></asp:RequiredFieldValidator>
            </p>
            <p>
                Username:
                <asp:TextBox ID="txtCustomerUsername" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="UserNameRequiredFieldValidator" runat="server" ControlToValidate="txtCustomerUsername" ErrorMessage="Customer username must be provided" CssClass="validationText"></asp:RequiredFieldValidator>
            </p>
            <p>
                Password:
                <asp:TextBox ID="txtCustomerPassword" runat="server" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="PasswordRequiredFieldValidator" runat="server" ControlToValidate="txtCustomerPassword" ErrorMessage="Customer password must be provided" CssClass="validationText"></asp:RequiredFieldValidator>
            </p>
            <p>
                Confirm Password:
                <asp:TextBox ID="txtConfirmCustomerPassword" runat="server" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="ConfirmPasswordRequiredFieldValidator" runat="server" ControlToValidate="txtConfirmCustomerPassword" Display="Dynamic" ErrorMessage="Confirm password field must be provided" CssClass="validationText"></asp:RequiredFieldValidator>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtCustomerPassword" ControlToValidate="txtConfirmCustomerPassword" ErrorMessage="The passwords do not match" CssClass="validationText"></asp:CompareValidator>
            </p>
            <p>
                Phone:
                <asp:TextBox ID="txtCustomerPhone" runat="server"></asp:TextBox>
            </p>
            <p>
                Address: <asp:TextBox ID="txtCustomerAddress" runat="server"></asp:TextBox>
            </p>
            <p>
                Age:
                <asp:TextBox ID="txtCustomerAge" runat="server"></asp:TextBox>
            </p>
            <asp:Button ID="btnRegister" runat="server" OnClick="btnRegister_Click" Text="Register" CssClass="button" />
            <br />
            <br />
            <asp:Label ID="lblMessage" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
