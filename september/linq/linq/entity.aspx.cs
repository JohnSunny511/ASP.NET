using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace linq
{
    public partial class entity : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataContext dc = new DataContext(@"data source = LAPTOP-QK9QR22V\SQLEXPRESS;initial catalog = LinqDB;Integrated Security = True");

            Table<tb1> tb1 = dc.GetTable<tb1>();
            if (!IsPostBack)
            {
                

                GridView1.DataSource = tb1;
                GridView1.DataBind();

                //select employess gaving salary greatre than 25000
                var m = from emp in tb1 where emp.salary > 25000 select emp;
                GridView1.DataSource = m;
                GridView1.DataBind();

                //select name and job from the table
                var m2 = from emp in tb1 select new { Name = emp.Name, Job = emp.job };
                GridView1.DataSource = m2;
                GridView1.DataBind();

                //select max value of id
                var m3 = (from emp in tb1 select emp.Id).Max();
                Response.Write(m3);

                var m4 = from emp in tb1 select new { getid = emp.Id, getname = emp.Name };
                DropDownList1.DataSource = m4;
                DropDownList1.DataTextField = "getname";
                DropDownList1.DataValueField = "getid";
                DropDownList1.DataBind();

            }
            
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataContext dc = new DataContext(@"data source = LAPTOP-QK9QR22V\SQLEXPRESS;initial catalog = LinqDB;Integrated Security = True");

            Table<tb1> tb1 = dc.GetTable<tb1>();
            var m = from emp in tb1 where emp.Id == Convert.ToInt32(DropDownList1.SelectedItem.Value) select emp ;

            foreach(tb1 em in m)
            {
                TextBox1.Text = em.Id.ToString();
                TextBox2.Text = em.Name;
                TextBox3.Text = em.job;
                TextBox4.Text = em.salary.ToString();

            }

            GridView1.DataSource = m;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataContext dc = new DataContext(@"data source = LAPTOP-QK9QR22V\SQLEXPRESS;initial catalog = LinqDB;Integrated Security = True");

            Table<tb1> tb1 = dc.GetTable<tb1>();

            tb1 emp = new tb1 { Id = Convert.ToInt32(TextBox1.Text), Name = TextBox2.Text, job = TextBox3.Text, salary = Convert.ToDecimal(TextBox4.Text) };
            tb1.InsertOnSubmit(emp);
            dc.SubmitChanges();
            GridView1.DataSource = tb1;
            GridView1.DataBind();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            DataContext dc = new DataContext(@"data source = LAPTOP-QK9QR22V\SQLEXPRESS;initial catalog = LinqDB;Integrated Security = True");

            Table<tb1> tb1 = dc.GetTable<tb1>();

            tb1 em = (from emp in tb1 where emp.Id == Convert.ToInt32(DropDownList1.SelectedItem.Value) select emp).FirstOrDefault();
            tb1.DeleteOnSubmit(em);
            dc.SubmitChanges();
            GridView1.DataSource = tb1;
            GridView1.DataBind();

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            DataContext dc = new DataContext(@"data source = LAPTOP-QK9QR22V\SQLEXPRESS;initial catalog = LinqDB;Integrated Security = True");

            Table<tb1> tb1 = dc.GetTable<tb1>();
            tb1 em = (from emp in tb1
                      where emp.Id == Convert.ToInt32(DropDownList1.SelectedItem.Value)
                      select emp).FirstOrDefault(); em.Name = TextBox2.Text;
            em.job = TextBox3.Text;
            em.salary = Convert.ToDecimal(TextBox4.Text);
            dc.SubmitChanges();
            GridView1.DataSource = tb1;
            GridView1.DataBind();
        }
    }
}