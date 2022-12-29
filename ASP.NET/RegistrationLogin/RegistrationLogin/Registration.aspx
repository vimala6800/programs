<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="RegistrationLogin.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">   
    <title>Registration</title>
 
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style5 {
            width: 547px;
            height: 31px;
        }
        .auto-style6 {
            width: 103px;
        }
        .auto-style7 {
            width: 103px;
            height: 31px;
        }
        .auto-style8 {
            width: 103px;
            height: 87px;
        }
        .auto-style9 {
            width: 547px;
            height: 87px;
        }
        .auto-style10 {
            width: 547px;
        }
        .auto-style11 {
            width: 103px;
            height: 39px;
        }
        .auto-style12 {
            width: 547px;
            height: 39px;
        }
    </style>
    
  
</head>
<body>
    <form id="form1" runat="server">

        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style11">
                        &nbsp;</td>
                    <td class="auto-style12">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style11">
                        <asp:Label ID="Labl1" runat="server" Text="Name"></asp:Label>
                    </td>
                    <td class="auto-style12">
                        <asp:TextBox ID="name" runat="server" ForeColor="Black" OnTextChanged="name_TextChanged"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="name" Display="Dynamic" ErrorMessage="Name is required" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8">
                        <asp:Label ID="Label2" runat="server" Text="Mobile"></asp:Label>
                    </td>
                    <td id="Mobile" class="auto-style9">
                        <asp:TextBox ID="mobile" runat="server" ForeColor="Black" TextMode="Phone"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="mobile" Display="Dynamic" ErrorMessage="Number is required" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6">
                        <asp:Label ID="Label3" runat="server" Text="Email"></asp:Label>
                    </td>
                    <td class="auto-style10">
                        <asp:TextBox ID="email" runat="server" ForeColor="Black" Height="24px" TextMode="Email"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="email" Display="Dynamic" ErrorMessage="Email is required" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        <asp:Label ID="Label4" runat="server" Text="Password" ToolTip="alphanumaric"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="password" runat="server" ForeColor="Black" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="password" Display="Dynamic" ErrorMessage="password is required" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6">
                        <asp:Label ID="Label6" runat="server" Text="DOB"></asp:Label>
                    </td>
                    <td class="auto-style10">
                        <asp:Calendar ID="dob" runat="server">
                        </asp:Calendar>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        <asp:Label ID="Label7" runat="server" Text="Sex"></asp:Label>
                    </td>
                    <td class="auto-style5" id="female">
                        <asp:RadioButtonList ID="gender" runat="server" RepeatDirection="Horizontal">
                            <asp:ListItem>Female</asp:ListItem>
                            <asp:ListItem>Male</asp:ListItem>
                            <asp:ListItem>Others</asp:ListItem>
                        </asp:RadioButtonList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="gender" Display="Dynamic" ErrorMessage="Gender is required" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        <asp:Label ID="Label9" runat="server" Text="Education"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:CheckBox ID="CheckBox1" runat="server" Text="PG" />
                        <asp:CheckBox ID="ug" runat="server" Text="UG" />
                        <asp:CheckBox ID="CheckBox3" runat="server" Text="others" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6">
                        <asp:Label ID="Label10" runat="server" Text="Location"></asp:Label>
                    </td>
                    <td class="auto-style10">
                        <asp:DropDownList ID="loc" runat="server">
                            <asp:ListItem>Banglore</asp:ListItem>
                            <asp:ListItem>Chennai</asp:ListItem>
                            <asp:ListItem>Delhi</asp:ListItem>
                            <asp:ListItem>Vizag</asp:ListItem>
                            <asp:ListItem>Mumbai</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style10">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="submit" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
    
</html>
