using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace TwoLayerApplication
{
    public partial class Login : System.Web.UI.Page
    {
        ConnectionClass obj = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string str = "SELECT COUNT(id) FROM tb1 WHERE Username='" + TextBox1.Text +
                 "' AND Password='" + TextBox2.Text + "'";

            string count = obj.fn_ExeScalar(str);

            if (count == "1")
            {
                string s = "SELECT COUNT(id) FROM tb1 WHERE Username='" + TextBox1.Text +
                 "' AND Password='" + TextBox2.Text + "'";
                string id = obj.fn_ExeScalar(s);
                Session["uid"] = id;
                Response.Redirect("ProfileView.aspx");
                Label3.Text = "Login Success";
            }
            else
            {
                Label3.Text = "Invalid Username or Password";
            }

        }
    }
}