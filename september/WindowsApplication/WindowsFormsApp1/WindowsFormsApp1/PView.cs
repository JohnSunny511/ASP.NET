using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class PView : Form
    {
        conclss ob = new conclss();
        public PView()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void PView_Load(object sender, EventArgs e)
        {
            int getid = Convert.ToInt32(login.A.p1);

            string s = "select * from profile where id =" + getid;
            SqlDataReader dr = ob.fn_exereader(s);
            while (dr.Read())
            {
                label14.Text = dr["name"].ToString();
                label13.Text = dr["addr"].ToString();
                label12.Text = dr["gender"].ToString();
                label11.Text = dr["state"].ToString();
                DateTime date = Convert.ToDateTime(dr["Date"].ToString());
                label10.Text = date.ToShortDateString();
                label9.Text = dr["qualification"].ToString();
                label8.Text = dr["username"].ToString();
            }

            DataSet ds = ob.fn_Adapter_DataSet(s);
            dataGridView1.DataSource = ds.Tables[0];

            DataTable dt = ob.fn_Adapter_DataTable(s);
            dataGridView2.DataSource = dt;

        }
    }
}
