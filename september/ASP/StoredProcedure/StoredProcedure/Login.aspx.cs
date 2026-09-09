using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace StoredProcedure
{
    public partial class Login : System.Web.UI.Page
    {
        conclss ob = new conclss();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "login";

            //input parameters
            cmd.Parameters.AddWithValue("@una", TextBox1.Text);
            cmd.Parameters.AddWithValue("@pw", TextBox2.Text);

            string cid = ob.fn_Scalar(cmd);
            if(cid == "1")
            {
                SqlCommand cmd1 = new SqlCommand();
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.CommandText = "sp_GetId";

                //input parameters
                cmd1.Parameters.AddWithValue("@una", TextBox1.Text);
                cmd1.Parameters.AddWithValue("@pw", TextBox2.Text);
                string id = ob.fn_Scalar(cmd1);
                Session["uid"] = id;
                Response.Redirect("ProfileView.aspx");
            }
            else
            {
                Label1.Text = "Invalid Username or Password";

            }
        }
    }
}