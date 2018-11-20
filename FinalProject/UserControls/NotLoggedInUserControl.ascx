<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="NotLoggedInUserControl.ascx.cs" Inherits="FinalProject.UserControls.NotLoggedInUserControl" %>
<asp:Menu ID="Menu1" runat="server" Orientation="Horizontal" StaticSubMenuIndent="16px" CssClass="controlMenu">
    <Items>
        <asp:MenuItem NavigateUrl="~/CustomerLogin.aspx" Text="Login" Value="Login"></asp:MenuItem>
        <asp:MenuItem NavigateUrl="~/RegisterCustomer.aspx" Text="Register" Value="Register"></asp:MenuItem>
        <asp:MenuItem NavigateUrl="~/AddAdmin.aspx" Text="Login as Admin" Value="Login as Admin"></asp:MenuItem>
    </Items>
</asp:Menu>

<hr />

