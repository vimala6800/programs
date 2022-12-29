<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="validationform.aspx.cs" Inherits="customvalidation.WebForm1" %>

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
            width: 192px;
        }
        .auto-style4 {
            height: 31px;
            width: 192px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label1" runat="server" Text="studentname"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="nam" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="nam" Display="Dynamic" ErrorMessage="name is required" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label2" runat="server" Text="studentemail"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="em" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="em" Display="Dynamic" ErrorMessage="email should be required" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label3" runat="server" Text="reenteremail"></asp:Label>
                </td>
                <td>&nbsp;
                    <asp:TextBox ID="rem" runat="server"></asp:TextBox>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ClientIDMode="Static" ControlToCompare="rem" ControlToValidate="em" Display="Dynamic" EnableClientScript="False" ErrorMessage="email should matched" ForeColor="Red">*</asp:CompareValidator>
&nbsp; </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label4" runat="server" Text="class"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="clas" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="clas" Display="Dynamic" ErrorMessage="class should be required" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label5" runat="server" Text="fees"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="fee" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="fee" Display="Dynamic" ErrorMessage="fees should be required" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label6" runat="server" Text="gender"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:RadioButton ID="female" runat="server" GroupName="gen" Text="female" />
                    <asp:RadioButton ID="male" runat="server" GroupName="gen" Text="male" />
                    <asp:CustomValidator ID="CustomValidator1" runat="server" Display="Dynamic" ErrorMessage="select gender" ForeColor="Red" OnServerValidate="CustomValidator1_ServerValidate">*</asp:CustomValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style2">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style2">
                    <asp:Button ID="Button1" runat="server" 
        </table>Text="submit" />
                </td>
            </tr>
    </form>
</body>
</html>
