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
    public partial class ProfileView : System.Web.UI.Page
    {
        conclss ob = new conclss();
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "profile_view";

            //input parameters
            cmd.Parameters.AddWithValue("@id", Session["uid"]);
            SqlDataReader dr = ob.fn_Reader(cmd);
            while (dr.Read())
            {
                TextBox1.Text = dr["name"].ToString();
                TextBox2.Text = dr["Age"].ToString();
                TextBox3.Text = dr["address"].ToString();
                TextBox4.Text = dr["username"].ToString();
            }
            //output parameters
            SqlParameter sp = new SqlParameter();
            sp.DbType = DbType.Int32;
            sp.ParameterName = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "profile_view";
            SqlCommand cm1 = new SqlCommand();
            cmd1.comma

            //input parameters
            cmd.Parameters.AddWithValue("@id", Session["uid"]);
            cmd.Parameters.AddWithValue("@ag", TextBox2.Text);
            cmd.Parameters.AddWithValue("@addr", TextBox3.Text);
            ob.fn_ExeNonQuery(cmd);
        }
    }
}