<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="HeaderUserControl.ascx.cs" Inherits="FinalProject.HeaderUserControl" %>
<asp:Button ID="btnLogout" runat="server" OnClick="btnLogout_Click" Text="Logout" style="float:right; width:30%; background-color: #4CAF50;
    color: white; display:inline-block; "/>
<br />
<br />
<asp:Menu ID="Menu1" runat="server" StaticSubMenuIndent="16px" Orientation="Horizontal">
    <Items>
        <asp:MenuItem NavigateUrl="~/SecurePages/ViewCars.aspx" Text="Home" Value="Home"></asp:MenuItem>
        <asp:MenuItem NavigateUrl="~/SecurePages/ViewReservations.aspx" Text="View My Reservations" Value="View My Reservations"></asp:MenuItem>
        <asp:MenuItem NavigateUrl="~/SecurePages/EditProfile.aspx" Text="My Profile" Value="My Profile"></asp:MenuItem>
    </Items>
</asp:Menu>

<br />
<hr />


