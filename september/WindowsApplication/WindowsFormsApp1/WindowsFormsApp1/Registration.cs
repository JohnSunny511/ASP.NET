using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Registration : Form
    {
        conclss ob = new conclss();
        public Registration()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = "";
            if (radioButton1.Checked)
            {
                s = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                s = radioButton2.Text;
            }
            string d = "";
            foreach(string i in checkedListBox1.CheckedItems)
            {
                d = d + i + " , ";
            }

            string newdt = Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString()).ToString("yyyy-MM-dd");
            string str = "insert into profile values('" + textBox1.Text + "','" + richTextBox1.Text + "','" + s + "','" +comboBox1.SelectedItem.ToString()+ "','" + newdt + "','" +d+"','"+textBox2.Text+"','"+textBox3.Text+ "')";
            int i1 = ob.fn_ExecuteNonQuery(str);
            if(i1 != 0)
            {
                label9.Text = "inserted";
            }

        }
    }
}
