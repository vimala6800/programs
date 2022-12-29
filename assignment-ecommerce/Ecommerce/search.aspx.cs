using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecommerce
{
    public partial class seach : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            bindGridView();
        }
        void bindGridView()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from products";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            GridView1.DataSource = data;
            GridView1.DataBind();
        }

        void searchByname()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from products where pname=@pname";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.Parameters.AddWithValue("@pname", searchtextbox.Text);
            DataTable data = new DataTable();
            sda.Fill(data);
            GridView1.DataSource = data;
            GridView1.DataBind();
        }
        void searchBymanufacturer()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from products where pmanufacturer=@pmanufacturer";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.Parameters.AddWithValue("@pmanufacturer", searchtextbox.Text);
            DataTable data = new DataTable();
            sda.Fill(data);
            GridView1.DataSource = data;
            GridView1.DataBind();
        }
        protected void Button1_Click1(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedValue == "pname")
            {
                searchByname();
            }
            else if (DropDownList1.SelectedValue == " pmanufacturer")
            {
                searchBymanufacturer();
            }
        }
        
    }
}