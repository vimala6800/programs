using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace local
{
    public partial class servprovider : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

            protected void Button1_Click1(object sender, EventArgs e)
            {

                foreach (GridViewRow row in GridView1.Rows)
                {
                    bool select1 = Convert.ToBoolean(GridView1.SelectedIndex);
                    if (select1)
                    {
                       SqlConnection con = new SqlConnection(cs);


                    }
                }

            }
        }

    }
    

