using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data.SqlClient;
using System.Data;

namespace ThreeLayerApp
{
    public partial class login : System.Web.UI.Page
    {
        loginclass ob = new loginclass();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string cid = ob.login(TextBox1.Text, TextBox2.Text);
            if(cid == "1")
            {
                string id = ob.GetId(TextBox1.Text,TextBox2.Text);
                Session["uid"] = id;
                Response.Redirect("ProfileView.aspx");
                Label1.Text = "Success";

            }
            else
            {
                Label1.Text = "Invalid Username and pssword";

            }
        }
    }
}