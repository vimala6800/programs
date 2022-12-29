<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="student.aspx.cs" Inherits="Ecom.student" %>

<!DOCTYPE html>
<script runat="server">

    protected void Button1_Click(object sender, EventArgs e)
    {

    }
</script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 79%;
        }
        .auto-style4 {
            width: 59px;
        }
        .auto-style5 {
            width: 59px;
            height: 31px;
        }
        .auto-style6 {
            height: 31px;
        }
        .auto-style7 {
            width: 59px;
            height: 29px;
        }
        .auto-style8 {
            height: 29px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label1" runat="server" Text="studentname"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="nam" runat="server" Width="180px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="nam" Display="Dynamic" ErrorMessage="name is required" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label2" runat="server" Text="srtudentemail"></asp:Label>
                </td>
                <td>&nbsp;<asp:TextBox ID="em" runat="server"></asp:TextBox>
                    &nbsp;<asp:RequiredFieldValidator runat="server" ControlToValidate="em" Display="Dynamic" ErrorMessage="email should be required" ForeColor="Red">*</asp:RequiredFieldValidator>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label3" runat="server" Text="reenteremail"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="remail" runat="server"></asp:TextBox>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="remail" ControlToValidate="em" Display="Dynamic" ErrorMessage="email should be matched" ForeColor="Red">*</asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label4" runat="server" Text="class"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="clas" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="clas" Display="Dynamic" ErrorMessage="class is required" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">
                    <asp:Label ID="Label5" runat="server" Text="fees"></asp:Label>
                </td>
                <td class="auto-style8">
                    <asp:TextBox ID="fee" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="fee" Display="Dynamic" ErrorMessage="fees should be selected" ForeColor="Red">*</asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;&nbsp; </td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label6" runat="server" Text="gender"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:RadioButton ID="female" runat="server" GroupName="gen" Text="female" />
                    <asp:RadioButton ID="male" runat="server" GroupName="gen" Text="male" />
                    <asp:CustomValidator ID="CustomValidator1" runat="server" Display="Dynamic" ErrorMessage="please select gender" ForeColor="Red" OnServerValidate="CustomValidator1_ServerValidate">*</asp:CustomValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                    &nbsp;</td>
                <td class="auto-style6">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="submit" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
