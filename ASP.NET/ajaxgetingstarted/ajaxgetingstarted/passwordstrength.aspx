<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="passwordstrength.aspx.cs" Inherits="ajaxgetingstarted.passwordstrength" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 151px;
        }
        .auto-style3 {
            width: 248px;
        }
        .BarBorder
        {
            border:2px black ridge;
            width:120px;
        }
        
        .Poor
        {
            background-color:darkred;
        }
        .Weak
        {
            background-color:red;
        }
        .Average
        {
            background-color:orange;
        }
        .Good
        {
            background-color:lightgreen;
        }
        .Strong
        {
            background-color:green;
        }

    </style>
</head>
<body strengthindicatortype="BarIndicator">
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:Label ID="Label1" runat="server" Text="Enter Password"></asp:Label>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <ajaxToolkit:PasswordStrength ID="PasswordStrength1" runat="server" MinimumLowerCaseCharacters="3" MinimumNumericCharacters="2" MinimumSymbolCharacters="1" MinimumUpperCaseCharacters="2" PreferredPasswordLength="8" PrefixText="Password Strength: " RequiresUpperAndLowerCaseCharacters="True" TargetControlID="TextBox1" HelpStatusLabelID="Label2" TextStrengthDescriptions="Poor;Weak;Average;Good;Strong" BarBorderCssClass="BarBorder" StrengthIndicatorType="BarIndicator" HelpHandlePosition="RightSide" StrengthStyles="Poor;Weak;Average;Good;Strong" /><br />
                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                </ContentTemplate>
            </asp:UpdatePanel>
                
                        
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
