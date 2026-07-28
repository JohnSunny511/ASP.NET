using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_Assignment_1
{
    public partial class Page_1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender,EventArgs e)
        {
            Panel1.Visible = true;
            Label23.Text = TextBox1.Text;
            Label24.Text = TextBox2.Text;
            Label25.Text = TextBox3.Text;
            Label26.Text = TextBox4.Text;
            Label27.Text = TextBox5.Text;
            Label28.Text = RadioButtonList1.SelectedItem.Text;
            Label29.Text = DropDownList1.SelectedItem.Text;

            string sel1 = "";
            for (int i = 0; i < CheckBoxList1.Items.Count; i++)
            {
                if (CheckBoxList1.Items[i].Selected)
                {
                    sel1 += CheckBoxList1.Items[i].Text + " ";
                }

            }

            Label33.Text = sel1;

            string path = "~/Photos/" + FileUpload1.FileName; // path
            FileUpload1.SaveAs(MapPath(path)); //image save into folder in the solution explorer
            Image1.ImageUrl = path;

            Label31.Text = TextBox6.Text;
            Label34.Text = TextBox7.Text;
        }
    }
}