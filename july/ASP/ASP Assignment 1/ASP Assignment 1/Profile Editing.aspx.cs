using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_Assignment_1
{
    public partial class Profile_Editing : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string sel = "select count(Id) from UserRegister where Username='" + TextBox1.Text + "' and Password = 
            SqlCommand cmd = new SqlCommand(sel, con);
            con.Open();
            string cid = cmd.ExecuteScalar

        }
    }
}