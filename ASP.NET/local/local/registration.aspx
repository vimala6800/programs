<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registration.aspx.cs" Inherits="local.registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            height: 31px;
        }
        .auto-style3 {
            width: 113px;
        }
        .auto-style4 {
            height: 31px;
            width: 113px;
        }
        .auto-style5 {
            width: 113px;
            height: 33px;
        }
        .auto-style6 {
            height: 33px;
        }
        .abc{
            background-color:lightsalmon;
        }
        .footer {
            display: flex;
            justify-content: space-between;
            align-items: center;
            padding: 15px;
            background-color: powderblue;
        }
        .auto-style7 {
            height: 67px;
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
        <h1 style="background-color:mediumaquamarine" class="auto-style7">Registration</h1>
        <div class="abc">
            <table>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label1" runat="server" Text="name:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="nam" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="nam" Display="Dynamic" ErrorMessage="name is required" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label2" runat="server" Text="email:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="em" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="em" Display="Dynamic" ErrorMessage="email is required" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label3" runat="server" Text="mobile"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="mob" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="mob" Display="Dynamic" ErrorMessage="mobile number is required" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        <asp:Label ID="Label4" runat="server" Text="city:"></asp:Label>
                    </td>
                    <td class="auto-style6">
                        <asp:TextBox ID="cit" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="cit" Display="Dynamic" ErrorMessage="city name is required" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label5" runat="server" Text="location:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="loc" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="loc" Display="Dynamic" ErrorMessage="location is required" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label6" runat="server" Text="address:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="add" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="add" Display="Dynamic" ErrorMessage="address is required" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="Label7" runat="server" Text="zipcode:"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="zc" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="zc" Display="Dynamic" ErrorMessage="zipcode is required" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="Label8" runat="server" Text="password:"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="pass" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="pass" Display="Dynamic" ErrorMessage="password is required" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="Label10" runat="server" Text="confirmpassword:"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="cpas" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="cpas" Display="Dynamic" ErrorMessage="confrimpassword is required" ForeColor="Red">*</asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="cpas" ControlToValidate="pass" Display="Dynamic" ErrorMessage="password should be matched" ForeColor="Red"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="Label9" runat="server" Text="roleid:"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="role" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="role" Display="Dynamic" ErrorMessage="roleid is required" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="labell" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2" colspan="2">
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="submit" Width="174px" style="height: 35px" />
                    </td>
                    <td class="auto-style2"><a href="login.aspx">Already Registred! Click Here</a></td>
                </tr>
            </table>
        </div>
        <div class="footer">
            <p>©2022 Jayitri services local business.com, All Rights Reserved.</p>
            <p1 class="contact_row">Contact:7411003159</p1>
            <p1 class="contact_row">Email:vimala@gmail.com</p1>
            </div>
    
    </form>
</body>
</html>
