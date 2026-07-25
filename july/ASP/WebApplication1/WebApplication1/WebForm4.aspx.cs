using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Label1.Visible = true;
            Label1.Text = "Welcome";
        }

        protected void ImageButton1_Click1(object sender, ImageClickEventArgs e)
        {
            Label1.Text = "Welcome";
            Label1.Visible = true;
        }
    }
}