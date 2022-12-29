using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace local
{
    public partial class login : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (AuthenticateUser(TextBox1.Text, TextBox2.Text))
            //  if (FormsAuthentication.Authenticate(txtUserName.Text, txtPassword.Text))
            {
                //    FormsAuthentication.RedirectFromLoginPage(txtUserName.Text, false);
                FormsAuthentication.RedirectFromLoginPage(TextBox1.Text, CheckBox1.Checked);
            }
            else
            {
                Label.Text = "Invalid User Name and/or password";
            }
            Response.Redirect("customerafterlogin.aspx");
        }

        private bool AuthenticateUser(string username, string password)
        {
            // ConfigurationManager class is in System.Configuration namespace
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            // SqlConnection is in System.Data.SqlClient namespace
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("AuthenticateUser", con);
                cmd.CommandType = CommandType.StoredProcedure;

                // FormsAuthentication is in System.Web.Security
                string EncryptedPassword = FormsAuthentication.HashPasswordForStoringInConfigFile(password, "SHA1");
                // SqlParameter is in System.Data namespace
                SqlParameter Email = new SqlParameter("@email",TextBox1.Text);
                SqlParameter Password = new SqlParameter("@password", TextBox2.Text);

                cmd.Parameters.Add(Email);
                cmd.Parameters.Add(Password);

                con.Open();
                int ReturnCode = (int)cmd.ExecuteScalar();
                return ReturnCode == 1;
            }
        }
    }
}
