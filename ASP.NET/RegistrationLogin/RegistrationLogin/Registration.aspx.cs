using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RegistrationLogin
{
    public partial class Registration : System.Web.UI.Page
    {
        
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into reg1 values(@name,@mobile,@email,@password,@DOB,@sex,@education,@location)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@name", name.Text);
            cmd.Parameters.AddWithValue("@mobile", mobile.Text);
            cmd.Parameters.AddWithValue("@email", email.Text);
            cmd.Parameters.AddWithValue("@password", password.Text);

            DateTime dob1 = dob.SelectedDate;
            cmd.Parameters.AddWithValue("@DOB", dob.SelectedDate);
            string gen = gender.Text;
            cmd.Parameters.AddWithValue("@sex", gender.Text);
            string edu = ug.Text;
            cmd.Parameters.AddWithValue("@education", ug.Text);
            string location = loc.Text;
            cmd.Parameters.AddWithValue("@location", loc.Text);

            ClientScript.RegisterStartupScript(typeof(Page), "script", "alert(' Name:" + name.Text + "Mobile:"+ mobile.Text+ "Email"+ email.Text + "Password :" + password.Text + "DOB:"+ dob.SelectedDate+"Sex:"+ gender.Text+"Education:"+ug.Text+"');", true);
        }
        

        protected void name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}