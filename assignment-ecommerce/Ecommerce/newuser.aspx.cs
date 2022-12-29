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
    public partial class newuser : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into newuser values(@name,@email,@mobile,@address,@location,@password,@zipcode)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@name", Name.Text);
            cmd.Parameters.AddWithValue("@email", Email.Text);
            cmd.Parameters.AddWithValue("@mobile", Mobile.Text);
            cmd.Parameters.AddWithValue("@address",Address.Text);
            cmd.Parameters.AddWithValue("@location",Location.Text);
            cmd.Parameters.AddWithValue("@password", Password.Text);
            cmd.Parameters.AddWithValue("@zipcode",Zipcode.Text);

            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                ClientScript.RegisterStartupScript(typeof(Page), "script", "alert('name: " + Name.Text +"\\nemail:"+Email.Text+"\\nmobile:"+Mobile.Text+"\\naddress:"+Address.Text+"\\nlocation:"+Location.Text+ "\\npassword: " + Password.Text +"\\nzipcode:"+Zipcode.Text+ "');", true);
                ClearControls();
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Registration Failed !!')</script>");
            }
            con.Close();
        }

        void ClearControls()
        {
            Name.Text = Email.Text = Mobile.Text = Address.Text=Location.Text=Password.Text = Zipcode.Text = "";

        }
    }
    
}