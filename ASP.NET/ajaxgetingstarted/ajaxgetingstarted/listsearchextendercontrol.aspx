<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="listsearchextendercontrol.aspx.cs" Inherits="ajaxgetingstarted.listsearchextendercontrol" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 550px;
        }

        .MypromptCss
        {
            font-style:italic;
            font-weight:bold;
            color:purple;
            background-color:lightgray;
        }
        .auto-style3 {
            width: 185px;
            height: 152px;
        }
        .auto-style4 {
            height: 152px;
        }
        .auto-style5 {
            width: 185px;
            height: 54px;
        }
        .auto-style6 {
            height: 54px;
        }
        .auto-style7 {
            width: 185px;
            height: 39px;
        }
        .auto-style8 {
            height: 39px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <table cellpadding="4" cellspacing="4" class="auto-style1">
                <tr>
                    <td class="auto-style7">CHOOSE FRUIT:</td>
                    <td class="auto-style8"><asp:DropDownList ID="DropDownList1" runat="server" Width="186px" Height="20px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                            <asp:ListItem>WATERMELON</asp:ListItem>
                            <asp:ListItem>ORANGE</asp:ListItem>
                            <asp:ListItem>PEACH</asp:ListItem>
                            <asp:ListItem>PEAR</asp:ListItem>
                            <asp:ListItem>STRAWBERRY</asp:ListItem>
                            <asp:ListItem>RASPBERRY</asp:ListItem>
                            <asp:ListItem>APPLE</asp:ListItem>
                            <asp:ListItem>APRICOT</asp:ListItem>
                            <asp:ListItem>BANANA</asp:ListItem>
                            <asp:ListItem>BLUEBERRY</asp:ListItem>
                            <asp:ListItem>GRAPES</asp:ListItem>
                            <asp:ListItem>GUAVA</asp:ListItem>
                            <asp:ListItem>KIWI</asp:ListItem>
                            <asp:ListItem>MANGO</asp:ListItem>
                            <asp:ListItem>CUSTADAPPLE</asp:ListItem>
                            <asp:ListItem>PAPAYA</asp:ListItem>
                        </asp:DropDownList>
                        <ajaxToolkit:ListSearchExtender ID="DropDownList1_ListSearchExtender" runat="server" BehaviorID="DropDownList1_ListSearchExtender" TargetControlID="DropDownList1">
                        </ajaxToolkit:ListSearchExtender> </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:ListBox ID="ListBox1" runat="server" Height="140px" Width="188px">
                            <asp:ListItem>WATERMELON</asp:ListItem>
                            <asp:ListItem>ORANGE</asp:ListItem>
                            <asp:ListItem>PEACH</asp:ListItem>
                            <asp:ListItem>PEAR</asp:ListItem>
                            <asp:ListItem>STRAWBERRY</asp:ListItem>
                            <asp:ListItem>RASPBERRY</asp:ListItem>
                            <asp:ListItem>APPLE</asp:ListItem>
                            <asp:ListItem>APRICOT</asp:ListItem>
                            <asp:ListItem>BANANA</asp:ListItem>
                            <asp:ListItem>BLUEBERRY</asp:ListItem>
                            <asp:ListItem>GRAPES</asp:ListItem>
                            <asp:ListItem>GUAVA</asp:ListItem>
                            <asp:ListItem>KIWI</asp:ListItem>
                            <asp:ListItem>MANGO</asp:ListItem>
                            <asp:ListItem>CUSTADAPPLE</asp:ListItem>
                            <asp:ListItem>PAPAYA</asp:ListItem>
                        </asp:ListBox>
                        <ajaxToolkit:ListSearchExtender ID="ListBox1_ListSearchExtender" runat="server" BehaviorID="ListBox1_ListSearchExtender" TargetControlID="ListBox1" PromptText="Type to find" QueryTimeout="2000" PromptCssClass="MypromptCss">
                        </ajaxToolkit:ListSearchExtender>
                    </td>
                    <td class="auto-style4">
                        <asp:Button ID="Button1" runat="server" Text="SUBMIT" OnClick="Button1_Click" />
                        <br />
                        <br />
                        <asp:Label ID="Label1" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        
                    </td>
                    <td class="auto-style6">
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
