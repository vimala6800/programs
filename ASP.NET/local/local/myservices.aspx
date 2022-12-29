<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="myservices.aspx.cs" Inherits="local.myservices" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 31px;
        }
        .auto-style3 {
            width: 308px;
        }
        .footer {
            position:fixed;
            left:0;
            bottom:0;
            width:100%;
            text-align:center;
            background-color: powderblue;
        }
        
        .auto-style5 {
            width: 272%;
            height: 206px;
        }
        .auto-style6 {
            width: 318px;
        }
        
    </style>
    <div style="background-color: powderblue; padding: 15px">
            <img src="images/logo2.jpg" alt="image" width="100" height="100"
                style="float: left" />
            <h1 style="font-size: 35px">Jayitri services</h1>
        </div>
</head>
<body style="background-color:honeydew">
    <form id="form1" runat="server">
       
        <h1>My Services</h1>
        <div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">
                    <table class="auto-style5">
                        <tr>
                            <td class="auto-style6">
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
                            <td>rating:<asp:DropDownList ID="DropDownList1" runat="server" Width="161px">
                                <asp:ListItem>1</asp:ListItem>
                                <asp:ListItem>2</asp:ListItem>
                                <asp:ListItem>3</asp:ListItem>
                                <asp:ListItem>4</asp:ListItem>
                                <asp:ListItem>5</asp:ListItem>
                                </asp:DropDownList>
                                <br />
                                <asp:Label ID="Label1" runat="server"></asp:Label>
                                <br />
                                review:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style6">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="submit" />
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
                </td>
                
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            </table>
            </div>
    </form>
</body>
</html>
