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
    public partial class login : Form
    {
        conclss ob = new conclss();
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = "select count(id) from profile where username ='" + textBox1.Text + "'and password = '" + textBox2.Text + "'";
            string i = ob.fn_ExeScalar(s);
            if (i == "1")
            {
                label3.Text = "Logged In";
                string s1 = "select id from profile where username = '" + textBox1.Text + "'and password = '" + textBox2.Text + "'";
                string id = ob.fn_ExeScalar(s1);
                A.p1 = Convert.ToInt32(id);
                PView obj = new PView();
                obj.Show();
                this.Hide();
                
            }
            else
            {
                label3.Text = "Invalid username and password";
            }

        }

        public static class A
        {
            public static int p1
            {
                set;
                get;
            }

        }
    }
}
