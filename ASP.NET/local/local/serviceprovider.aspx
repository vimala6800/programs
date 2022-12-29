<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="serviceprovider.aspx.cs" Inherits="local.serviceprovider" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
        .topbar {
            display: flex;
            justify-content:space-evenly;
            align-items: center;
            padding: 20px;
            background-color: gray;
            
        }

        .abc {
            font-weight: lighter;
            letter-spacing: 2px;
        }

        </style>
    <div style="background-color: powderblue; padding: 15px">
            <img src="images/logo2.jpg" alt="image" width="100" height="100"
                style="float: left" />
            <h1 style="font-size: 35px">Jayitri services</h1>
        </div>
</head>
<body style="background-color:honeydew">
    <form id="form1" runat="server">
         <%--topbar--%>
        <div class="topbar">
                <a class="abc_href" href="home.aspx">Home</a>
                <a class="abc_href" href="manageservices.aspx">Manage Services</a>
                <a class="abc_href" href="login.aspx">Logout</a>
        </div>
        <div class="footer">
            <p>©2022 Jayitri services local business.com, All Rights Reserved.</p>
            <p1 class="contact_row">Contact:7411003159</p1>
            <p1 class="contact_row">Email:vimala@gmail.com</p1>
            </div>
    </form>
</body>
</html>
