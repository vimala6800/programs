<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="booking.aspx.cs" Inherits="local.booking" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Booking</title>
    <style type="text/css">
        .abc{
            background-color:lightsalmon;
        }
        .footer {
            position:fixed;
            left:0;
            bottom:0;
            width:100%;
            text-align:center;
            background-color: powderblue;
        }
    </style>
    <div style="background-color: powderblue; padding: 15px">
            <img src="images/logo2.jpg" alt="image" width="100" height="100"
                style="float: left" />
            <h1 style="font-size: 35px">Jayitri services</h1>
        </div>
</head>
<body  style="background-color:mediumaquamarine">
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <EditRowStyle BackColor="#7C6F57" />
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#E3EAEB" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F8FAFA" />
            <SortedAscendingHeaderStyle BackColor="#246B61" />
            <SortedDescendingCellStyle BackColor="#D4DFE1" />
            <SortedDescendingHeaderStyle BackColor="#15524A" />
        </asp:GridView>
            

        </div>
       <div class="footer">
            <p>©2022 Jayitri services local business.com, All Rights Reserved.</p>
            <p1 class="contact_row">Contact:7411003159</p1>
            <p1 class="contact_row">Email:vimala@gmail.com</p1>
            </div>
        
    </form>
</body>
</html>
