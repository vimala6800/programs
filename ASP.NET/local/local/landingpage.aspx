<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="landingpage.aspx.cs" Inherits="local.landingpage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>welcome to local business</title>
    <style>
        body {
            margin: 0;
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



        .abc_href {
            text-decoration: none;
            color: black;
            font-weight: lighter;
            letter-spacing: 2px;
        }



            .abc_href:hover {
                color: lightgoldenrodyellow;
                font-weight: bolder;
            }

        .description {
            background-color: honeydew;
            padding-bottom: 1rem;
            margin-bottom: -64px;
        }



        .desc {
            margin: 0 4rem;
            padding-top: 2rem;
            font-style: italic;
        }

        .services {
            background-color: lightskyblue;
            margin-top: 50px;
        }

        .service_heading {
            text-align: center;
            padding-top: 2rem;
        }

        .service_row {
            display: flex;
            justify-content: space-evenly;
            align-items: center;
            padding:25px;
            background-color:linen;
        }

        .service_img {
            width: 45%;
            height: 45%;
        }

         .footer {
            position:fixed;
            left:0;
            bottom:0;
            width:100%;
            text-align:center;
            background-color: powderblue;
        }
    

        .contact_row {
            font-size: 14px;
            margin: 5px;
        }
    </style>



    <div>
        <div style="background-color: powderblue; padding: 15px">
            <img src="images/logo2.jpg" alt="image" width="100" height="100"
                style="float: left" />
            <h1 style="font-size: 35px">Jayitri services</h1>
        </div>
    </div>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <%--topbar--%>
            <div class="topbar">

                <a class="abc_href" href="home.aspx">Home</a>
                <a class="abc_href" href="login.aspx">Login</a>
                
                <a class="abc_href" href="serviceprovider.aspx">Service Provider</a>
                
            </div>
        </div>

        <div class="description">
            <p1 class="desc">
                A local business is any business that serves a local market and is not part of a national chain, and they are essential.
                local businesses are often the backbone of the local economy. 
                This is especially true when you take the time to look at this infographic on Broadly for a better explanation of how vital these types of businesses are to economies.
                <br />

            </p1>
        </div>
        <div class="services">
            <h1 class="service_heading">Services</h1>
            <div class="service_row">
                <img class="services" src="images/computers.jpg" />
                
                <img class="services" src="images/doctors.jpg" />
                
                <img class="services" src="images/electrial.jpg" />
               </div>
                <div class="service_row">
                <img class="services" src="images/internet.jpg" />
                <img class="services" src="images/mechanical.jpg" />
                <img class="services" src="images/mobile.jpg" />

            </div>
        </div>
        <div class="footer">
            <p>©2022 Jayitri services local business.com, All Rights Reserved.</p>
            <p1 class="contact_row">Contact:7411003159</p1>
            <p1 class="contact_row">Email:vimala@gmail.com</p1>
            
               
            </div>
      
    </form>

</body>
</html>
