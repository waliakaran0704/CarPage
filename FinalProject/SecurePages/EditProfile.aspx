<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditProfile.aspx.cs" Inherits="FinalProject.SecurePages.EditProfile" %>

<%@ Register src="../UserControls/HeaderUserControl.ascx" tagname="HeaderUserControl" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc1:HeaderUserControl ID="HeaderUserControl1" runat="server" />
            <h1>Edit Profile</h1>
            <p>
                Username:<asp:TextBox ID="txtUsernameE" runat="server" Enabled="False"></asp:TextBox>
            </p>
            <p>
                Name:<asp:TextBox ID="txtNameE" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtNameE" ErrorMessage="Name can not be empty" CssClass="validationText"></asp:RequiredFieldValidator>
            </p>
            <!--<p>
                Password<asp:TextBox ID="txtPasswordE" runat="server" TextMode="Password"></asp:TextBox>
            </p>
            <p>
                Confirm Password<asp:TextBox ID="txtConfirmPasswordE" runat="server" TextMode="Password"></asp:TextBox>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtPasswordE" ControlToValidate="txtConfirmPasswordE" ErrorMessage="Passwords do not match"></asp:CompareValidator>
            </p>-->
            <p>
                Phone<asp:TextBox ID="txtPhoneE" runat="server"></asp:TextBox>
            </p>
            <p>
                Address<asp:TextBox ID="txtAddressE" runat="server"></asp:TextBox>
            </p>
            <p>
                Age<asp:TextBox ID="txtAgeE" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Update" />
            </p>
            <p>
                <asp:Label ID="lblMessage" runat="server"></asp:Label>
            </p>
        </div>
    </form>
</body>
</html>
