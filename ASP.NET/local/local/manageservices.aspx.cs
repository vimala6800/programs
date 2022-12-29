using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.Mime.MediaTypeNames;
using System.Configuration;

namespace local
{
    public partial class manageservices : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            services();
        }
        void services()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from services";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            GridView1.DataSource = data;
            GridView1.DataBind();
        }


        protected void Button1_Click1(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            SqlConnection con;
            try
            {
                //SqlConnection con = new SqlConnection(cs);
                using (con = new SqlConnection(cs))
                {
                    string query = "update services set servicename=@servicename, description=@description ,status=@status";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@servicename", DropDownList1.SelectedValue);
                    cmd.Parameters.AddWithValue("@description", TextBox1.Text);
                    cmd.Parameters.AddWithValue("@status", TextBox2.Text);


                    con.Open();
                    int status = cmd.ExecuteNonQuery();
                    if (status > 0)
                    {
                        result.Text = "Added successful";
                        result.Visible = true;
                    }
                    else
                    {
                        result.Text = "failed";
                        result.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                result.Text = ex.Message;
            }
            


            }
        }
    } 