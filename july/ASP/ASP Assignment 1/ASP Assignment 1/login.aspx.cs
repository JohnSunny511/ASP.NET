using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_Assignment_1
{
    public partial class login : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"server=LAPTOP-1HM6SRVO\SQLEXPRESS;database=D_3;Integrated security=true");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            string sel = "select count(id) from t_5 where username='" + TextBox1.Text + "' and password='" + TextBox2.Text + "'";
            SqlCommand cmd = new SqlCommand(sel, con);
            con.Open();
            string cid = cmd.ExecuteScalar().ToString();
            con.Close();
            if (cid == "1")
            {
                Label3.Text = "Success";

            }
            else
            {
                Label3.Text = "Invalid username and password";
            }
        }
    }
}