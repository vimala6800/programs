<%@ Page Title="Signup form" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="ASPGetting_started.WebForm2" %>

<script runat="server">

    protected void Page_Load(object sender, EventArgs e)
    {

    }
</script>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table class="nav-justified">
        <tr>
            <td style="width: 240px">
                <asp:Label ID="Label2" runat="server" Text="Name" Font-Size="Medium"></asp:Label>
            </td>
            <td style="width: 709px">
                <asp:TextBox ID="name" runat="server" Font-Size="Medium"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Display="Dynamic" ErrorMessage="Name is required" Font-Size="Medium" ForeColor="Red" ControlToValidate="name"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
            <td style="width: 240px; height: 39px;">
                <asp:Label ID="Label1" runat="server" Text="Email" Font-Size="Medium"></asp:Label>
            </td>
            <td style="width: 709px; height: 39px;">
                <asp:TextBox ID="email" runat="server" Font-Size="Medium" TextMode="Email"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" Display="Dynamic" ErrorMessage="Email is required" Font-Size="Medium" ForeColor="Red" ControlToValidate="email"></asp:RequiredFieldValidator>
            </td>
            <td style="height: 39px"></td>
            <td style="height: 39px"></td>
        </tr>
        <tr>
            <td style="width: 240px">
                <asp:Label ID="Label3" runat="server" Text="password" Font-Size="Medium"></asp:Label>
            </td>
            <td style="width: 709px">
                <asp:TextBox ID="password" runat="server" Font-Size="Medium" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" Display="Dynamic" ErrorMessage="Password is required" Font-Size="Medium" ForeColor="Red" ControlToValidate="password"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 240px">
                <asp:Label ID="Label8" runat="server" Font-Size="Medium" Text="ConfirmPassword"></asp:Label>
            </td>
            <td style="width: 709px">
                <asp:TextBox ID="confirmpassword" runat="server" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" Display="Dynamic" ErrorMessage="Password shoud be matched" Font-Size="Medium" ForeColor="Red" ControlToValidate="confirmpassword"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 240px">
                <asp:Label ID="Label4" runat="server" Text="Mobile" Font-Size="Medium"></asp:Label>
            </td>
            <td style="width: 709px">
                <asp:TextBox ID="mobile" runat="server" Font-Size="Medium" TextMode="Phone"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" Display="Dynamic" ErrorMessage="Number is required" Font-Size="Medium" ForeColor="Red" ControlToValidate="mobile"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 240px">
                <asp:Label ID="Label5" runat="server" Text="DOB" Font-Size="Medium"></asp:Label>
            </td>
            <td style="width: 709px">
                <asp:Calendar ID="dob" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="Small" ForeColor="Black" Height="180px" Width="200px" SelectedDate="2022-09-22">
                    <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                    <NextPrevStyle VerticalAlign="Bottom" />
                    <OtherMonthDayStyle ForeColor="#808080" />
                    <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                    <SelectorStyle BackColor="#CCCCCC" />
                    <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                    <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <WeekendDayStyle BackColor="#FFFFCC" />
                </asp:Calendar>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 240px">
                <asp:Label ID="Label6" runat="server" Text="Sex" Font-Size="Medium"></asp:Label>
            </td>
            <td style="width: 709px">
                <asp:RadioButton name="gender" ID="female" runat="server" value= "1" Text="female" Font-Size="Medium" GroupName="gender" />
                <asp:RadioButton name="gender" ID="male" runat="server" value= "2" Text="male" Font-Size="Medium" GroupName="gender" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="Gender should be selected" Font-Size="Medium" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 240px">
                <asp:Label ID="Label7" runat="server" Text="Education" Font-Size="Medium"></asp:Label>
            </td>
            <td style="width: 709px">
                <asp:CheckBox ID="pg" runat="server" Text="PG" Font-Size="Medium" />
                <asp:CheckBox ID="ug" runat="server" Text="UG" Font-Size="Medium" />
                <asp:CheckBox ID="others" runat="server" Text="others" Font-Size="Medium" />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 240px">
                <asp:Label ID="location" runat="server" Text="Location" Font-Size="Medium"></asp:Label>
            </td>
            <td style="width: 709px">
                <asp:DropDownList ID="loc" runat="server" Font-Size="Medium">
                    <asp:ListItem>Banglore</asp:ListItem>
                    <asp:ListItem>Hyderabad</asp:ListItem>
                    <asp:ListItem>Chennai</asp:ListItem>
                    <asp:ListItem>Delhi</asp:ListItem>
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" Display="Dynamic" ErrorMessage="Location is required" Font-Size="Medium" ForeColor="Red" ControlToValidate="loc"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 240px">
                &nbsp;</td>
            <td style="width: 709px" id="re">
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 240px">&nbsp;</td>
            <td style="width: 709px">
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" Font-Size="Medium" />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        </table>
    
</asp:Content>
