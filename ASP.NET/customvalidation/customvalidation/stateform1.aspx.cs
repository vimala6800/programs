using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace customvalidation
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string name;
            string password;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.Add("user", TextBox1.Text);
            Session.Add("password", TextBox1.Text);
            
            TextBox1.Text = string.Empty;
           TextBox1.Text = string.Empty;

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (ViewState["user"] != null)
            {
                TextBox1.Text = ViewState["user"].ToString();
            }
            if (ViewState["password"] != null)
            {
                TextBox1.Text = ViewState["password"].ToString();
            }
        }
    }
}