<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ratingcontrol.aspx.cs" Inherits="ajaxgetingstarted.ratingcontrol" %>

<!DOCTYPE html>
<script runat="server">
</script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style4 {
            width: 473px;
        }
        .StarEmpty
        {
            background-image:url('images/Empty_Star.jfif');
            height:50px;
            width:50px;
        }
        .StarFilled
        {
            background-image:url('images/Filled_Star.png');
            height:50px;
            width:50px;
        }
        .auto-style5 {
            width: 173px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <table >
                <tr>
                    <td class="auto-style5">Rate our website:</td>
                    <td class="auto-style4">
                        <ajaxToolkit:Rating ID="Rating1" runat="server" CurrentRating="1" AutoPostBack="True" EmptyStarCssClass="StarEmpty" FilledStarCssClass="StarFilled" StarCssClass="StarEmpty" WaitingStarCssClass="StarFilled" OnClick="Rating1_Click">
                        </ajaxToolkit:Rating>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style4">
                        <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
