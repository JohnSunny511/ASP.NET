using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace asp_exam_practice
{
    public partial class profileView1 : System.Web.UI.Page


    {
        conclss ob = new conclss();
        protected void Page_Load(object sender, EventArgs e)
        {

            grid_bind();
            ds_bind();



        }

        public void grid_bind()
        {
            string s = "select name,age,photo from login";
            DataSet ds = new DataSet();
            ds = ob.fn_Adapter_Dataset(s);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        public void ds_bind()
        {
            string s = "select name,age,photo from login";
            DataSet ds = new DataSet();
            ds = ob.fn_Adapter_Dataset(s);
            DataList1.DataSource = ds;
            DataList1.DataBind();
        }
    }
}