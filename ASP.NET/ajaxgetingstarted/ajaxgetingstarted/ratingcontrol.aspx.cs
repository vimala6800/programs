using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ajaxgetingstarted
{
    public partial class ratingcontrol : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Rating1_Click(object sender, AjaxControlToolkit.RatingEventArgs e)
        {
            Label1.Text = "you gave us.." +e.Value.ToString()+"stars";
            Label1.Visible=true;
        }
    }
}