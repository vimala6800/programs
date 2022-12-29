using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services.Description;

namespace local
{
    public partial class customerlogin : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

            Showall();
        }
        void Showall()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "SELECT users.name,email,mobile,city, location, address, zipcode, services.servicename as servicename,description,status from  users CROSS JOIN services  where users.roleid=3";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            GridView1.DataSource = data;
            GridView1.DataBind();
        }


        void servicename()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "SELECT users.name,email,mobile,city, location, address, zipcode, services.servicename as servicename,description,status from  users CROSS JOIN services  where users.roleid=3 and services.servicename='" + TextBox1.Text.Trim() + "';";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            GridView1.DataSource = data;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            Showall();
            servicename();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("myservices.aspx");

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
             /*try
             {
                 SqlConnection con = new SqlConnection(cs);
                 con.Open();
                 string queryselect = "select serviceid,userid from serviceprovider,users where users.name='" + TextBox1.Text + "' and serviceprovider.userid=userss.userid";



                 string query = "insert into servicebooking values(@serviceid,@serviceproviderid,@userid,@datetime,@description,@status,@providerdescription)";
                 SqlCommand cmd = new SqlCommand(query, con);
                 cmd.Parameters.AddWithValue("@name", ServiceProviderId.Text);
                 cmd.Parameters.AddWithValue("@serviceid", ServiceID.Text);
                 cmd.Parameters.AddWithValue("@userid", UserId.Text);
                 cmd.Parameters.AddWithValue("@description", BDate.Text);
                 cmd.Parameters.AddWithValue("@status", CdescTextBox.Text.Trim());
                 cmd.Parameters.AddWithValue("@serviceproviderid", "Pending");
                 cmd.Parameters.AddWithValue("@providerdescription", "");
                 con.Open();
                 int a = cmd.ExecuteNonQuery();
                 if (a > 0)
                 {
                     ClientScript.RegisterStartupScript(this.GetType(), "script", "<script>alert('Booking Successfull !!')</script>");


                 }
                 else
                 {
                     Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Booking Failed !!')</script>");
                 }
                 con.Close();
             }
             catch (Exception ex)
             {
                 Response.Write(ex.Message);
             }
         }
*/

        }
    }
        

  }


    

