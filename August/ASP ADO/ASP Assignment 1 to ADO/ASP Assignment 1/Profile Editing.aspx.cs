using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace ASP_Assignment_1
{
    public partial class Profile_Editing : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"server=LAPTOP-QK9QR22V\SQLEXPRESS;database=db2;Integrated security = true");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {   // to prevent page load from working again after pressing a button which is a postback since it will take the data from table again
            string seldetails = "select Name,Age,Address,Phone,Email,Photo from tb2 where id = " + Session["uid"] + "";
            SqlCommand cmd = new SqlCommand(seldetails, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                TextBox1.Text = dr["Name"].ToString();
                TextBox2.Text = dr["Age"].ToString();
                TextBox3.Text = dr["Address"].ToString();
                TextBox4.Text = dr["Phone"].ToString();
                TextBox5.Text = dr["Email"].ToString();
                Image1.ImageUrl = dr["Photo"].ToString();


            }
            con.Close();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sr = "UPDATE tb2 SET Age=" + TextBox2.Text +
                ", Address='" + TextBox3.Text +
                "' WHERE Id=" + Session["uid"];
            SqlCommand cmd = new SqlCommand(sr, con);
            con.Open();
            int i1 = cmd.ExecuteNonQuery();
            con.Close();
            if(i1 == 1)
            {
                Label7.Text = "Updated";
            }
        }
    }
}