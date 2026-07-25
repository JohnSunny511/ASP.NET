using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Add_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(TextBox2.Text);
            int num2 = Convert.ToInt32(TextBox3.Text);

            Label3.Text = (num1 + num2).ToString();
        }

        protected void sub_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(TextBox2.Text);
            int num2 = Convert.ToInt32(TextBox3.Text);

            Label3.Text = (num1 - num2).ToString();

        }

        protected void pro_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(TextBox2.Text);
            int num2 = Convert.ToInt32(TextBox3.Text);

            Label3.Text = (num1 * num2).ToString();

        }

        protected void Qouatient_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(TextBox2.Text);
            int num2 = Convert.ToInt32(TextBox3.Text);

            Label3.Text = (num1 / num2).ToString();
        }
    }
}