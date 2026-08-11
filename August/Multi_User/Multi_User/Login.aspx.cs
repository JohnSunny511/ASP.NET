using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


namespace Multi_User
{
    public partial class userLogin : System.Web.UI.Page
    {
        ConnectionClass ob = new ConnectionClass();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string str = "select count(Reg_id) from login where username ='" + TextBox1.Text + "' and password = '" + TextBox2.Text + "'";
            string cid = ob.fn_ExeScalar(str);
            int cid1 = Convert.ToInt32(cid);
            if(cid1 == 1)
            {
                string str1 = "select Reg_id from Login where username = '" + TextBox1.Text + "' and password = '" + TextBox2.Text + "'";
                string regid = ob.fn_ExeScalar(str1);
                Session["regid"] = regid;

                string str2 = "select log_type from login where username = '" + TextBox1.Text + "' and password = '" + TextBox2.Text + "'";
                string logtype = ob.fn_ExeScalar(str2);
                if(logtype == "admin")
                {
                    Response.Redirect("adminHome.aspx");

                }
                else if (logtype == "user")
                {
                    Response.Redirect("userHome.aspx");
                }

            }
            else
            {
                Label3.Text = "Invalid username or password";

            }

        }
    }
}