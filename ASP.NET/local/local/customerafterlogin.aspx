<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="customerafterlogin.aspx.cs" Inherits="local.customerlogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 73%;
        }
        .auto-style3 {
            width: 361px;
            height: 39px;
        }
        .auto-style4 {
            width: 362px;
            height: 39px;
        }
        .auto-style5 {
            height: 39px;
        }
        .abc{
            background-color:lightsalmon;
        }
        .footer {
            position:fixed;
            left:0;
            bottom:0;
            width:100%;
            text-align:center;
            background-color: powderblue;
        }
    </style>
    <div style="background-color: powderblue; padding: 15px">
            <img src="images/logo2.jpg" alt="image" width="100" height="100"
                style="float: left" />
            <h1 style="font-size: 35px">Jayitri services</h1>
        </div>
</head>
<body>
    <form id="form1" runat="server">
        <div >
            <table class="auto-style1">
                <tr>
                    <td class="auto-style4">Services:<asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem>plumbing services</asp:ListItem>
                        <asp:ListItem>electical services</asp:ListItem>
                        <asp:ListItem>mobile services</asp:ListItem>
                        <asp:ListItem>computer services</asp:ListItem>
                        <asp:ListItem>mechanical services</asp:ListItem>
                        <asp:ListItem>home appliances</asp:ListItem>
                        <asp:ListItem>doctors</asp:ListItem>
                        <asp:ListItem>Showall</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style3">Search By:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style5">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Search" />
                        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Back" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">
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
                        </td>
                    <td class="auto-style3"></td>
                    <td class="auto-style5">
                        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="book" />
                    </td>
                </tr>
            </table>
        </div>
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
        <div class="footer">
            <p>©2022 Jatri services local business.com, All Rights Reserved.</p>
            <p1 class="contact_row">Contact:7411003159</p1>
            <p1 class="contact_row">Email:vimala@gmail.com</p1>
            </div>
    
    </form>
</body>
</html>
