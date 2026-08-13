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
    public partial class ProfileView : System.Web.UI.Page
    {
        profileViewClss ob = new profileViewClss();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Session["uid"]);
            SqlDataReader dr = ob.fn_GetData(id);
            while (dr.Read())
            {
                Label4.Text = dr["name"].ToString();
                Label5.Text = dr["age"].ToString();
                Label6.Text = dr["address"].ToString();
                Image1.ImageUrl = dr["Photo"].ToString();
            }

            DataSet ds = ob.fn_Grid(id);
            GridView1.DataSource = ds;
            GridView1.DataBind();

        }
    }
}