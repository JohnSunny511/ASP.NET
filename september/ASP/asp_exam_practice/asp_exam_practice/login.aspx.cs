using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace asp_exam_practice
{
    public partial class login : System.Web.UI.Page
    {
        conclss ob = new conclss();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = "select log_id from login where username = '"+TextBox1.Text+ "' and password = '" + TextBox2.Text + "'";

            string id = ob.fn_exScalar(s);

            if(id != "")
            {
                Session["uid"] = id;
                Response.Redirect("profileView.aspx");
            }
            else
            {
                Label1.Text = "Invalid User";
            }

        }
    }
}