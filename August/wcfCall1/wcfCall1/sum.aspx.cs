using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace wcfCall1
{
    public partial class sum : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SumReference1.ServiceClient obj = new SumReference1.ServiceClient();
            int s = obj.sum(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox2.Text));
            Label3.Text = s.ToString();
        }
    }
}