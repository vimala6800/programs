using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace serviceproviderform
{
    public partial class sevicesearch : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            bindGridView();
        }
       void bindGridView()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from seviceprovider";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            GridView1.DataSource = data;
            GridView1.DataBind();
        }
        void searchByservicetype()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from seviceprovider where servicetype=@servicetype";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.Parameters.AddWithValue("@servicetype", searchtextbox.Text);
            DataTable data = new DataTable();
            sda.Fill(data);
            GridView1.DataSource = data;
            GridView1.DataBind();
        }
        void searchBylocation()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from seviceprovider where location=@location";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.Parameters.AddWithValue("@location", searchtextbox.Text);
            DataTable data = new DataTable();
            sda.Fill(data);
            GridView1.DataSource = data;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedIndex ==0)
            {
                searchByservicetype();
            }
            else if (DropDownList1.SelectedIndex ==1)
            {
                searchBylocation();  
            }
            else
            {
                bindGridView();
            }
           
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("serviceprovider.aspx");
        }
    }
}