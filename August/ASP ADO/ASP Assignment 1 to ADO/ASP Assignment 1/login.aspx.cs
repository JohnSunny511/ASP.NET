using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace ASP_Assignment_1
{
    public partial class login : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"server=LAPTOP-QK9QR22V\SQLEXPRESS;database=db2;Integrated security=true");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sel = "select count(id) from tb2 where username='" + TextBox1.Text + "' and password='" + TextBox2.Text + "'";
            SqlCommand cmd = new SqlCommand(sel, con);
            con.Open();
            string cid = cmd.ExecuteScalar().ToString();
            con.Close();
            if (cid == "1")
            {
                string selid = "Select id from tb2 where Username='" + TextBox1.Text + "' and password='" + TextBox2.Text + "'";
                SqlCommand cmd1 = new SqlCommand(selid, con);
                con.Open();
                string id = cmd1.ExecuteScalar().ToString();
                con.Close();
                Session["uid"] = id;
                Response.Redirect("Profile Editing.aspx");



                Label3.Text = "Success";

            }
            else
            {
                Label3.Text = "Invalid username and password";
            }

        }
    }
}