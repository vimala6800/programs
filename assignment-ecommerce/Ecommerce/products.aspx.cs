using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecommerce
{
    public partial class products : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ProductButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into products values(@pcode,@pname,@pdescription,@pmanufacturer,@price)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@pcode", code.Text);
            cmd.Parameters.AddWithValue("@pname", name.Text);
            cmd.Parameters.AddWithValue("@pdescription", desc.Text);
            cmd.Parameters.AddWithValue("@pmanufacturer", man.Text);
            cmd.Parameters.AddWithValue("@price", pric.Text);

            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                ClientScript.RegisterStartupScript(typeof(Page), "script", "alert('pcode: " + code.Text + "\\npname: " + name.Text + "\\npdescription:"+desc.Text+"\\npmanufacturer:"+man.Text+"\\nprice:"+pric.Text+ "');", true);
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
            code.Text = name.Text = desc.Text = man.Text = pric.Text = "";

        }
    }
}
    