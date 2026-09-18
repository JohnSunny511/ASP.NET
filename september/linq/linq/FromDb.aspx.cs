using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace linq
{
    public partial class FromDb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-QK9QR22V\SQLEXPRESS;Initial Catalog = LinqDB;Integrated Security = True");
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select * from tb1", con);
            da.Fill(ds);
            //Select all employee details from employee table
            var m = from emp in ds.Tables[0].AsEnumerable() select emp;
            GridView1.DataSource = m.AsDataView();
            GridView1.DataBind();

            var m2 = from emp in ds.Tables[0].AsEnumerable() where emp.Field<decimal>("salary") > 25000 select emp;
            GridView1.DataSource = m2.AsDataView();
            GridView1.DataBind();

            //Find maximum id
            var m3 = (from emp in ds.Tables[0].AsEnumerable() select emp.Field<int>("id")).Max();
            Response.Write(m3);


        }
    }
}