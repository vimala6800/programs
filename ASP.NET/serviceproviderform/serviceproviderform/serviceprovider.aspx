<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="serviceprovider.aspx.cs" Inherits="serviceproviderform.serviceprovider" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>seviceprovider</title>
    <style type="text/css">
        .auto-style1 {
            width: 99%;
        }
        .auto-style4 {
            width: 434px;
            height: 33px;
        }
        .auto-style5 {
            width: 1643px;
            height: 33px;
        }
        .auto-style6 {
            width: 434px;
            height: 39px;
        }
        .auto-style7 {
            width: 1643px;
            height: 39px;
        }
        .auto-style8 {
            width: 434px;
        }
        .auto-style9 {
            width: 1643px;
        }
        .auto-style10 {
            margin-left: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h1>sevice providers</h1>
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style8">
                        <asp:Label ID="Label1" runat="server" Text="name"></asp:Label>
                    </td>
                    <td class="auto-style9">
                        <asp:TextBox ID="nam" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="nam" Display="Dynamic" ErrorMessage="name is required" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="Label2" runat="server" Text="email"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="em" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="em" Display="Dynamic" ErrorMessage="email is required" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8">
                        <asp:Label ID="Label3" runat="server" Text="mobile"></asp:Label>
                    </td>
                    <td class="auto-style9">
                        <asp:TextBox ID="mob" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="mob" Display="Dynamic" ErrorMessage="mobile number is required" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6">
                        <asp:Label ID="Label4" runat="server" Text="servicetype"></asp:Label>
                    </td>
                    <td class="auto-style7">
                        <asp:DropDownList ID="source" runat="server">
                            <asp:ListItem>electronics</asp:ListItem>
                            <asp:ListItem>software</asp:ListItem>
                            <asp:ListItem>electrical</asp:ListItem>
                            <asp:ListItem>home appliances</asp:ListItem>
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="source" Display="Dynamic" ErrorMessage="service type is requred" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8">
                        <asp:Label ID="Label5" runat="server" Text="address"></asp:Label>
                    </td>
                    <td class="auto-style9">
                        <asp:TextBox ID="add" runat="server" CssClass="auto-style10"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="add" Display="Dynamic" ErrorMessage="address is required" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8">
                        <asp:Label ID="Label6" runat="server" Text="location"></asp:Label>
                    </td>
                    <td class="auto-style9">
                        <asp:TextBox ID="loc" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="loc" Display="Dynamic" ErrorMessage="locationis required" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8">
                        <asp:Label ID="Label7" runat="server" Text="city"></asp:Label>
                    </td>
                    <td class="auto-style9">
                        <asp:TextBox ID="cit" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="cit" Display="Dynamic" ErrorMessage="city name is required" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8">
                        <asp:Label ID="Label8" runat="server" Text="zipcode"></asp:Label>
                    </td>
                    <td class="auto-style9">
                        <asp:TextBox ID="zip" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="zip" Display="Dynamic" ErrorMessage="zipcode is required" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8">
                        &nbsp;</td>
                    <td class="auto-style9">
                        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click1" Text="submit" />
&nbsp;&nbsp; </td>
                   <tr>
                    <td>
                         <a href="sevicesearch.aspx">search</a>
                    </td>
                       </tr>
                </tr>
                <tr>
                   
                    
                    
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
