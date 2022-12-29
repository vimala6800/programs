<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login1.aspx.cs" Inherits="local.login1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .footer {
            position:fixed;
            left:0;
            bottom:0;
            width:100%;
            text-align:center;
            background-color: powderblue;
        }
        .auto-style1 {
            width: 463px;
        }
        .auto-style2 {
            width: 315px;
        }
        .auto-style3 {
            width: 693px;
        }
    </style>
    <div style="background-color: powderblue; padding: 15px">
            <img src="images/logo2.jpg" alt="image" width="100" height="100"
                style="float: left" />
            <h1 style="font-size: 35px">Jayitri services</h1>
        </div>
</head>
<body style="background-color:mediumaquamarine">
    <form id="form1" runat="server">
        <h1 >Login</h1>
        <div class="abc">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label1" runat="server" Text="email:"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" Display="Dynamic" ErrorMessage="enter valid email" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label2" runat="server" Text="password:"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" Display="Dynamic" ErrorMessage="enter valid password" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label" runat="server"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:CheckBox ID="CheckBox1" runat="server" Text="Remember me" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    &nbsp;</td>
                <td class="auto-style3">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="Button1" runat="server" Text="login" OnClick="Button1_Click" />
                </td>
                <td class="auto-style3">
                        <a href="registration.aspx">Not Registered yet ? Click Here</a>
                    </td>
                
            </tr>
        </table>

        <div>

        </div>
        <div class="footer">
            <p>©2022 Jayitri services local business.com, All Rights Reserved.</p>
            <p1 class="contact_row">Contact:7411003159</p1>
            <p1 class="contact_row">Email:vimala@gmail.com</p1>
            </div>
    
    </form>
</body>
</html>
