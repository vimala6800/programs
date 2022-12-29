using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace local
{
    public partial class myservices : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            Showall();
        }
        void Showall()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "SELECT users.name,email,mobile,city, location, address, zipcode, services.servicename as sevicename,description,status from  users CROSS JOIN services  where users.roleid=3";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            GridView1.DataSource = data;
            GridView1.DataBind();
        }

        protected void Rating1_Click(object sender, AjaxControlToolkit.RatingEventArgs e)
        {
            Label1.Text = "you gave us.." + e.Value.ToString() + "stars";
            Label1.Visible = true;
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
    
}