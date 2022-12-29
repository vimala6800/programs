using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace customvalidation
{
    public partial class cookie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("user");
            cookie["username"] = TextBox1.Text;
            Response.Cookies.Add(cookie);
           // Response.Redirect("cookie1.aspx");
        }
    }
}