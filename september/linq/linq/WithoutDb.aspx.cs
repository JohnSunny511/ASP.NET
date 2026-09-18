using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace linq
{
    public partial class WithoutDb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<emp> employees = new List<emp>();
            employees.Add(new emp { Name = "John", Age = 22, Salary = 240000 });
            employees.Add(new emp { Name = "Jake", Age = 241, Salary = 234000 });
            employees.Add(new emp { Name = "christo", Age = 22, Salary = 140000 });
            employees.Add(new emp { Name = "Jeese", Age = 21, Salary = 50000 });
            employees.Add(new emp { Name = "Jerin", Age = 26, Salary = 140000 });
            employees.Add(new emp { Name = "Joba", Age = 28, Salary = 60000 });
            employees.Add(new emp { Name = "criz", Age = 23, Salary = 160000 });
            employees.Add(new emp { Name = "shan", Age = 25, Salary = 1990000 });
            employees.Add(new emp { Name = "anston", Age = 27, Salary = 190000 });
            employees.Add(new emp { Name = "edwin", Age = 29, Salary = 50000 });
            employees.Add(new emp { Name = "ribin", Age = 26, Salary = 185000 });

            //select all employees from the employees
            //var match = from em in employees select em;

            //var match2 = from emp in employees where emp.Age > 22 && emp.Salary > 22000 select emp;
            //GridView1.DataSource = match2;
            //GridView1.DataBind();

            //var match21 = from emp in employees select emp.Name;
            //GridView1.DataSource = match21;
            //GridView1.DataBind();

            //var match3 = from emp in employees select new { EMPname = emp.Name,Age = emp.Age };
            //GridView1.DataSource = match3;
            //GridView1.DataBind();

            //var match4 = (from emp in employees select emp.Age).Distinct();
            //GridView1.DataSource = match4;
            //GridView1.DataBind();

            //var match5 = (from emp in employees select emp.Age).Min();
            //Response.Write(match5);

            //var match5 = from emp in employees where TestEmployee(emp) && emp.Age > 22 select emp;
            //GridView1.DataSource = match5;
            //GridView1.DataBind();

            //var match6 = from emp in employees orderby emp.Name ascending select emp;
            //GridView1.DataSource = match6;
            //GridView1.DataBind();

            //var match7 = from emp in employees orderby emp.Name descending select emp;
            //GridView1.DataSource = match7;
            //GridView1.DataBind();

            var match8 = from emp in employees orderby emp.Name select emp;
            GridView1.DataSource = match8;
            GridView1.DataBind();
        }

        static bool TestEmployee(emp em)
        {
            return em.Name.StartsWith("s");
        }
    }
}