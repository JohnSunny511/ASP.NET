using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Visible = true;
            Label2.Visible = true;
            Label1.Text = DropDownList1.SelectedItem.Text;
            Label2.Text = DropDownList1.SelectedItem.Value;

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label3.Text = RadioButtonList1.SelectedItem.Text;
            Label4.Text = RadioButtonList1.SelectedItem.Value;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Label5.Text = ListBox1.SelectedItem.Text;
            Label6.Text = ListBox1.SelectedItem.Value;

        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label5.Visible = true;
            Label6.Visible = true;
            Label5.Text = ListBox1.SelectedItem.Text;
            Label6.Text = ListBox1.SelectedItem.Value;

        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label3.Visible = true;
            Label4.Visible = true;
            Label3.Text = RadioButtonList1.SelectedItem.Text;
            Label4.Text = RadioButtonList1.SelectedItem.Value;
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label1.Visible = true;
            Label2.Visible = true;
            Label1.Text = DropDownList1.SelectedItem.Text;
            Label2.Text = DropDownList1.SelectedItem.Value;

        }

        protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label7.Visible = true;
            Label8.Visible = true;
            string sel1 = "",sel2 = "";
            for(int i = 0; i < CheckBoxList1.Items.Count; i++)
            {
                if (CheckBoxList1.Items[i].Selected)
                {
                    sel1 += CheckBoxList1.Items[i].Text + " ";
                    sel2 += CheckBoxList1.Items[i].Value + " ";
                }

            }
            Label7.Text = sel1;
            Label8.Text = sel2;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string path = "~/Photos/" + FileUpload1.FileName; // path
            FileUpload1.SaveAs(MapPath(path)); //image save into folder in the solution explorer
            Label10.Text = path;
            Image1.ImageUrl = path;
        }
    }
}