﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace formbasedsecurity
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            FormsAuthentication.

            if (AuthenticateUser(txtUserName.Text, txtPassword.Text))
                if (FormsAuthentication.Authenticate(txtUserName.Text, txtPassword.Text))
                {
                    FormsAuthentication.RedirectFromLoginPage(txtUserName.Text, false);
                    FormsAuthentication.RedirectFromLoginPage(txtUserName.Text, chkBoxRememberMe.Checked);
                }
                else
                {
                    lblMessage.Text = "Invalid User Name and/or password";
                }

            private bool AuthenticateUser(string username, string password)
            {
                // ConfigurationManager class is in System.Configuration namespace
                string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                // SqlConnection is in System.Data.SqlClient namespace
                using (SqlConnection con = new SqlConnection(CS))
                {
                    SqlCommand cmd = new SqlCommand("spAuthenticateUser", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // FormsAuthentication is in System.Web.Security
                    string EncryptedPassword = FormsAuthentication.HashPasswordForStoringInConfigFile(password, "SHA1");
                    // SqlParameter is in System.Data namespace
                    SqlParameter paramUsername = new SqlParameter("@UserName", username);
                    SqlParameter paramPassword = new SqlParameter("@Password", EncryptedPassword);

                    cmd.Parameters.Add(paramUsername);
                    cmd.Parameters.Add(paramPassword);

                    con.Open();
                    //int ReturnCode = (int)cmd.ExecuteScalar();
                    // return ReturnCode == 1;
                }
            }
        }
    } }