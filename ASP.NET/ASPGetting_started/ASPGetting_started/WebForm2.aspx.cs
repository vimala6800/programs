using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPGetting_started
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string nam = name.Text;
            string ema = email.Text;
            string pass = password.Text;
            string mob =mobile.Text;
            DateTime dob1 = dob.SelectedDate;
            string s;
            if(female.Checked)
            {
                s = female.Text;
            }
            else
            {
                s = male.Text;
            }
           
            string edu;
            if (pg.Checked)
            {
                edu = pg.Text;
            }
            else if (ug.Checked)
            {
                edu = ug.Text;
            }
            else
            {
                edu = others.Text;
            }
            string lo = loc.Text;

           
            Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Registration Successful')</script>");


        }
    }
}