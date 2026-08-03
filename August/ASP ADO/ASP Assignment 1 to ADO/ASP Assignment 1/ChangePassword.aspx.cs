using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace ASP_Assignment_1
{
    public partial class ChangePassword : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"server=LAPTOP-QK9QR22V\SQLEXPRESS;database=db2;Integrated security = true");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string s = "select password from tb2 where id = " + Session["uid"] + "";
                SqlCommand cmd = new SqlCommand(s,con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    TextBox1.Text = dr["password"].ToString();
                }
                con.Close();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string str = "update tb2 set Password='" + TextBox2.Text + "' where Id=" + Session["uid"];

            SqlCommand cmd = new SqlCommand(str, con);

            con.Open();
            int i1 = cmd.ExecuteNonQuery();
            con.Close();

            if (i1 == 1)
            {
                Label4.Text = "Password Changed";
            }
        }
    }
}