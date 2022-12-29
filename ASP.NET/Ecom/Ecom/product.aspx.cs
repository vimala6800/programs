using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Ecom
{
    public partial class products : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(cs);
            string query = "insert into product values(@code,@name,@description,@manufacturer,@price)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@code", cod.Text);
            cmd.Parameters.AddWithValue("@name", nam.Text);
            cmd.Parameters.AddWithValue("@description", desc.Text);
            cmd.Parameters.AddWithValue("@manufacturer", manu.Text);
            cmd.Parameters.AddWithValue("@price", pric.Text);



            ClientScript.RegisterStartupScript(typeof(Page), "script", "alert('pcode: " + cod.Text + "\\nname: " + nam.Text + "\\ndescription:" + desc.Text + "\\nmanufacturer:" + manu.Text + "\\nprice:" + pric.Text + "');", true);

        }
    }
}

       