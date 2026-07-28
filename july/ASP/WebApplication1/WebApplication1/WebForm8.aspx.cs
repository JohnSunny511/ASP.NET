using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm8 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Response.Write("hai");
            //Response.Redirect("page9.aspx");
            //Query String
            //"+ +"
            Response.Redirect("WebForm9.aspx?na="+TextBox1.Text+"&&ag="+TextBox2.Text+"");
        }

        protected void server_Click(object sender, EventArgs e)
        {
            Server.Transfer("WebForm10.aspx");

        }
    }
}