<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Controls.aspx.cs" Inherits="FinalProject.Controls" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 442px;
            position: fixed;
        }
        .auto-style3 {
            width: 47%;
            height: 513px;
        }
        .auto-style4 {
            width: 442px;
            position: fixed;
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" style="background-color: #CCFFCC">
        <div>
            <h1 style="background-color: #CCFF66; font-family: Arial, Helvetica, sans-serif; color: #FF9933;">Cars Information</h1>
            <table class="auto-style3">
                <tr>
                    <td class="auto-style4" style="margin: auto;">License Plate:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:TextBox ID="txtLic" runat="server" BorderColor="#CCFFCC" ></asp:TextBox>
                        &nbsp;
                        <asp:Button ID="btn_fetch" runat="server" Text="FIND" OnClick="btn_fetch_Click" />
                        <br />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" style="margin: auto;">Year:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtyear" runat="server" BorderColor="#CCFFCC"></asp:TextBox>
                        <br />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4" style="margin: auto;">Model:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtModel" runat="server" BorderColor="#CCFFCC"></asp:TextBox>
                        <br />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" style="margin: auto;">VIN:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtVIN" runat="server" BorderColor="#CCFFCC"></asp:TextBox>
                        <br />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" style="margin: auto;">
                        Color: &nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; <asp:TextBox ID="txtColor" runat="server" BorderColor="#CCFFCC"></asp:TextBox>
                        <br />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" style="margin: auto;">Odometer:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; <asp:TextBox ID="txtOdometer" runat="server" BorderColor="#CCFFCC" ></asp:TextBox>
                        <br />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" style="margin: auto;">Price:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtPrice" runat="server" BorderColor="#CCFFCC" ></asp:TextBox>
                        <br />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" style="margin: auto;">Car Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                        <asp:TextBox ID="txtmake" runat="server" BorderColor="#CCFFCC"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" style="margin: auto;">Available:
                        <asp:CheckBox ID="chkAvailable" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" style="margin: auto;">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lbl" runat="server"></asp:Label>
                        &nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        </td>
                </tr>
                <tr>
                    <td class="auto-style2" style="margin: auto;">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2" style="margin: auto;">
                        <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
                        <asp:Button ID="Update" runat="server" Text="Update" OnClick="Update_Click" />
                        <asp:Button ID="Delete" runat="server" Text="Delete" OnClick="Delete_Click" />
                    </td>
                </tr>
            </table>
        </div>
        <asp:GridView ID="grdView" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
    </form>
</body>
</html>
