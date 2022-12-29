<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="RegistrationLogin.Dashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Dashboard</title>
    <style type="text/css">
        .auto-style1 {
            width: 55%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Home Page<table class="auto-style1">
            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Logout" />
                </td>
            </tr>
            </table>
        </h1>
        <div>
        </div>
    </form>
</body>
</html>
