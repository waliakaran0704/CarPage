<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReserveCar.aspx.cs" Inherits="FinalProject.SecurePages.ReserveCar" %>

<%@ Register src="../UserControls/HeaderUserControl.ascx" tagname="HeaderUserControl" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../styles/styles.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc1:HeaderUserControl ID="HeaderUserControl1" runat="server" />
            <h1>Reserve Car</h1>
            <p>
                Car License Plate:
                <asp:TextBox ID="txtReservedCarLicense" runat="server" Enabled="False"></asp:TextBox>
            </p>
            <p>
                From:<asp:Calendar ID="calenderFromDate" runat="server" style="margin-top: 0px"></asp:Calendar>
            </p>
            <p>
                To:<asp:Calendar ID="calenderToDate" runat="server"></asp:Calendar>
            </p>
            <p>
                &nbsp;</p>
            <p>
                <asp:Button ID="btnReserveCar" runat="server" OnClick="btnReserveCar_Click" Text="Reserve" CssClass="button" />
            </p>
            <p>
                &nbsp;</p>
            <p>
                <asp:Label ID="lblMessage" runat="server"></asp:Label>
            </p>
        </div>
    </form>
</body>
</html>
