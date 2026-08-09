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
    public partial class ProfileView : System.Web.UI.Page
    {
        ConnectionClass ob = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            string sel = "select name,age,address,photo from tb1 where id = " + Session["uid"] + "";
            SqlDataReader dr = ob.fn_exereader(sel);
            while (dr.Read()) {
                Label5.Text = dr["Name"].ToString();
                Label6.Text = dr["age"].ToString();
                Label7.Text = dr["Address"].ToString();
                Image1.ImageUrl = dr["Photo"].ToString();
            }

            DataSet ds = ob.fn_Adapter_DataSet(sel);
            GridView1.DataSource = ds;
            GridView1.DataBind();

            DataTable dt = ob.fn_Adapter_DataTable(sel);
            DataList1.DataSource = dt;
            DataList1.DataBind();
        }
    }
}