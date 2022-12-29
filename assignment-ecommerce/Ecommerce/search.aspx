<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="search.aspx.cs" Inherits="Ecommerce.seach" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>search</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 246px;
        }
        .auto-style3 {
            width: 343px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h1> welcome</h1>
        <div>
            <table class="auto-style1">
                <tr>
                    <td>
                        <table class="auto-style1">
                            <tr>
                                <td class="auto-style2">
                                   <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="search" />
                                </td>
                                <td class="auto-style3">
                                    <asp:TextBox ID="searchtextbox" runat="server"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:DropDownList ID="DropDownList1" runat="server">
                                        <asp:ListItem>pname</asp:ListItem>
                                        <asp:ListItem>pmanufacturer</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </div>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
