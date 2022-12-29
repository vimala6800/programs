<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="Ecommerce.Dashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Dashboard</title>
    <style type="text/css">

        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 209px;
        }
        .auto-style3 {
            width: 256px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Dashboard</h1>
        <div>

            <table class="auto-style1">
                
                    
                    
                    <td>&nbsp;</td>
                </tr>
                </table>

            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Products" />
                    </td>
                    <td class="auto-style3">
                        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Search" />
                    </td>
                    <td>
                        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Logout" />
                    </td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
