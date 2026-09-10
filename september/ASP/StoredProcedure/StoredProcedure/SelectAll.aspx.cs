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
    public partial class SelectAll : System.Web.UI.Page
    {
        conclss ob = new conclss();
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "selectAll";
            DataSet ds = ob.fn_AdapterDataset(cmd);
            GridView1.DataSource = ds;
            GridView1.DataBind();

        }
    }
}