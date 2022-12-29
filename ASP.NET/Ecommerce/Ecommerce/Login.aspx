<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Ecommerce.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>login</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 300px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h1>login</h1>
        <div>

            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label1" runat="server" Text="email"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="Ema" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label2" runat="server" Text="password"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="Pass" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="loginButton1" runat="server" OnClick="loginButton1_Click" Text="login" />
                    </td>
                    <td>
                         
                        <a href="newuser.aspx">Not Registered yet ? Click Here</a>
                    
                    </td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
