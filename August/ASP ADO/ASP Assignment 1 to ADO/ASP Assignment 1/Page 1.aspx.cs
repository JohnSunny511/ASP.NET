using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace ASP_Assignment_1
{
    public partial class Page_1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"server=LAPTOP-QK9QR22V\SQLEXPRESS;database=db2;Integrated Security=True");

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

        protected void Button2_Click(object sender, EventArgs e)
        {
            string sel2 = "";
            for (int i = 0; i < CheckBoxList1.Items.Count; i++)
            {
                if (CheckBoxList1.Items[i].Selected)
                {
                    sel2 += CheckBoxList1.Items[i].Text + " ";
                }
            }

            Label34.Text = sel2;

            string path2 = "~/Photo2/" + FileUpload1.FileName; //path
            FileUpload1.SaveAs(MapPath(path2));
            string str = "insert into tb2 values('" + TextBox1.Text + "'," + TextBox2.Text + ",'" + TextBox3.Text + "',"+TextBox4.Text+",'"+TextBox5.Text+"','"+RadioButtonList1.SelectedItem.Text+"','"+ DropDownList1.SelectedItem.Text+"','"+sel2+"','"+path2+"','"+TextBox6.Text+"','"+TextBox7.Text+"')";
            SqlCommand cmd = new SqlCommand(str, con);
            con.Open();
            int i1 = cmd.ExecuteNonQuery();
            con.Close();
            if(i1 == 1)
            {
                Label35.Text = "Inserted";
            }
        }

        protected void TextBox6_TextChanged(object sender, EventArgs e)
        {
            string sql = "SELECT COUNT(id) FROM tb2 WHERE Username = '" + TextBox6.Text + "'";

            SqlCommand cmd = new SqlCommand(sql, con);

            con.Open();
            string cid = cmd.ExecuteScalar().ToString();
            con.Close();

            int count = Convert.ToInt32(cid);


            if (count > 0)
            {
                Label36.Text = "Username already exists";
            }
            else
            {
                Label36.Text = "Username is available";
            }
        }
    }
}