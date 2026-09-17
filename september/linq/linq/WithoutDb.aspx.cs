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

            var match2 = from emp in employees where emp.Age > 22 && emp.Salary > 22000 select emp;
            GridView1.DataSource = match2;
            GridView1.DataBind();
        }
    }
}