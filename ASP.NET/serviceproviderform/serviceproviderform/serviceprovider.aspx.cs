using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace serviceproviderform
{
    public partial class serviceprovider : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        



            protected void Button2_Click1(object sender, EventArgs e)
        {

                SqlConnection con = new SqlConnection(cs);
                string query = "insert into seviceprovider values(@name,@email,@mobile,@servicetype,@address,@location,@city,@zipcode)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", nam.Text);
                cmd.Parameters.AddWithValue("@email", em.Text);
                cmd.Parameters.AddWithValue("@mobile", mob.Text);
                cmd.Parameters.AddWithValue("@servicetype", source.Text);
                cmd.Parameters.AddWithValue("@address", add.Text);
                cmd.Parameters.AddWithValue("@location", loc.Text);
                cmd.Parameters.AddWithValue("@city", cit.Text);
                cmd.Parameters.AddWithValue("@zipcode", zip.Text);

                con.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "script", "alert('name: " + nam.Text + "\\nemail: " + em.Text + "\\nmobile:" + mob.Text + "\\nsourcetype:" + source.Text + "\\naddress:" + add.Text + "\\nlocation:" + loc.Text + "\\ncity:" + cit.Text + "\\nzipcode:" + zip.Text + "');", true);
                    ClearControls();
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('submission Failed !!')</script>");
                }
                con.Close();
            }
            void ClearControls()
            {
                nam.Text = em.Text = mob.Text = source.Text = add.Text = loc.Text = cit.Text = zip.Text = "";
            }

        
    }
   
}
    
    
