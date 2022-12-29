using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace local
{
    public partial class registration : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                // Read the connection string from web.config.
                // ConfigurationManager class is in System.Configuration namespace
                string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                // SqlConnection is in System.Data.SqlClient namespace
                using (SqlConnection con = new SqlConnection(CS))
                {
                    SqlCommand cmd = new SqlCommand("spRegisterUser", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter namee = new SqlParameter("@name", nam.Text);
                    SqlParameter ema = new SqlParameter("@email", em.Text);
                    SqlParameter Mob = new SqlParameter("@mobile", mob.Text);
                    SqlParameter City = new SqlParameter("@city", cit.Text);
                    SqlParameter LOCa = new SqlParameter("@location", loc.Text);
                    SqlParameter Add = new SqlParameter("@address", add.Text);
                    SqlParameter Zipe = new SqlParameter("@zipcode", zc.Text);
                    SqlParameter passs = new SqlParameter("@password", pass.Text);
                    SqlParameter Confim = new SqlParameter("@confirmpassword", cpas.Text);
                    SqlParameter Role = new SqlParameter("@roleid", role.Text);
                    // FormsAuthentication calss is in System.Web.Security namespace
                    string encryptedPassword = FormsAuthentication.
                        HashPasswordForStoringInConfigFile(pass.Text, "SHA1");
                    SqlParameter password = new SqlParameter("@Password", pass.Text);
                    SqlParameter email = new SqlParameter("@Email", em.Text);

                    cmd.Parameters.Add(namee);
                    cmd.Parameters.Add(ema);
                    cmd.Parameters.Add(Mob);
                    cmd.Parameters.Add(City);
                    cmd.Parameters.Add(LOCa);
                    cmd.Parameters.Add(Add);
                    cmd.Parameters.Add(Zipe);
                    cmd.Parameters.Add(passs);
                    cmd.Parameters.Add(Confim);
                    cmd.Parameters.Add(Role);
                    con.Open();
                    int ReturnCode = (int)cmd.ExecuteScalar();
                    if (ReturnCode == -1)
                    {
                        labell.Text = "User Name already in use, please choose another user name";
                    }
                    else
                    {
                        Response.Redirect("~/login.aspx");
                    }
                }
            }


        }
    }
}