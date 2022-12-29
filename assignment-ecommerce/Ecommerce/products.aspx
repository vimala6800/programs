<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="products.aspx.cs" Inherits="Ecommerce.products" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>products</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 96px;
        }
        .auto-style3 {
            width: 719px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h1>product</h1>
        <div>

            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label1" runat="server" Text="pcode"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="code" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label2" runat="server" Text="pname"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="name" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label3" runat="server" Text="pdescription"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="desc" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label4" runat="server" Text="pmanufacturer"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="man" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label5" runat="server" Text="price"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="pric" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:Button ID="ProductButton" runat="server" OnClick="ProductButton_Click" Text="Submit" />
                    </td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
