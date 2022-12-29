using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RegistrationLogin
{
    public partial class Dashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["email"]!=null)
            {
                Response.Write("welcome to my site mr/mrs:email" + Session["email"].ToString());    

            }
            else
            {
                Response.Redirect("Loginform.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(Session["email"]!=null)
            {
                Session["email"] = null;
                Response.Redirect("Loginform.aspx");
            }
        }
    }
}