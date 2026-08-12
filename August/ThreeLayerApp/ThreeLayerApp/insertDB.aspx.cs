using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace ThreeLayerApp
{
    public partial class insertDB : System.Web.UI.Page
    {
        Class1 objbll = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = "~/images/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(s));

            int i = objbll.Fn_Insert(TextBox1.Text, Convert.ToInt32(TextBox2.Text), TextBox3.Text, s, TextBox4.Text, TextBox5.Text);
            if (i == 1)
            {
                Label7.Text = "Inserted";

            }
        }
    }
}