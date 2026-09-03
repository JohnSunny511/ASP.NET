using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp_exam_practice
{
    public partial class profileView : System.Web.UI.Page
    {
        conclss ob = new conclss();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string path = "~/photos/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(path));
            string s = "insert into login values ('" + TextBox1.Text + "'," + TextBox2.Text + ",'" + path + "','" + TextBox3.Text + "','" + TextBox4.Text + "')";
            int i = ob.fn_exeNonQuery(s);
            if(i == 1)
            {
                Label1.Text = "Inserted";
                Response.Redirect("profileView.aspx");
            }
            else
            {
                Label1.Text = "Error Inserting";
            }

        }
    }
}