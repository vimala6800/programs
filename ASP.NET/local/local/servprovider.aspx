<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="servprovider.aspx.cs" Inherits="local.servprovider" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    </head>
<body>
    <form id="form1" runat="server">
        <div>

        </div>
        <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        </asp:GridView>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Button" />
    </form>
</body>
</html>
