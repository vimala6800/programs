﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sevicesearch.aspx.cs" Inherits="serviceproviderform.sevicesearch" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>service search</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 283px;
        }
        .auto-style3 {
            width: 268px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h1>sevice search</h1>
        <div>

            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:ListItem>servicetype</asp:ListItem>
                            <asp:ListItem>location</asp:ListItem>
                            <asp:ListItem>all </asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="searchtextbox" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Go" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Back" />
                    </td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>

        </div>
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <EditRowStyle BackColor="#7C6F57" />
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#E3EAEB" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F8FAFA" />
            <SortedAscendingHeaderStyle BackColor="#246B61" />
            <SortedDescendingCellStyle BackColor="#D4DFE1" />
            <SortedDescendingHeaderStyle BackColor="#15524A" />
        </asp:GridView>
    </form>
</body>
</html>
