using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecom
{
    public partial class student : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into student(@name,@gender,@class)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@name", nam.Text);
          //  cmd.Parameters.AddWithValue("@gender", gen.Text);
            cmd.Parameters.AddWithValue("@class", clas.Text);
           // ClientScript.RegisterStartupScript(typeof(Page), "script", "alert('name: " + nam.Text + "\\ngender: " + gen.Text + "\\nclass:" + clas.Text + "');", true);
        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            
        }
    }
}