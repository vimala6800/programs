<%@ Page Title="Signup" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ASPGetting_started.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1> Signup<table class="nav-justified" style="width: 55%">
        <tr>
            <td style="width: 477px">
                <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
            </td>
            <td style="width: 4px">
                <asp:TextBox ID="name" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 477px">
                <asp:Label ID="Label3" runat="server" Text="Email"></asp:Label>
            </td>
            <td style="width: 4px">
                <asp:TextBox ID="email" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 477px">
                <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
            </td>
            <td style="width: 4px">
                <asp:TextBox ID="password" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 477px">&nbsp;</td>
            <td style="width: 4px">
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="margin-left: 259" Text="submit" Width="472px" />
            </td>
        </tr>
        </table>
    </h1>
</asp:Content>
