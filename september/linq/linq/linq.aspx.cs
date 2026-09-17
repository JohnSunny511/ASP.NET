using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace linq
{
    public partial class linq : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string[] str = { "Reg", "Green", "Blue", "Black", "Yellow", "White" };

            //select items which have length greater than 4
            //var matches = from s in str where s.Length > 4 select s;

            var matches = from s in str where s.StartsWith("B") select s;

            foreach(string s in matches)
            {
                Response.Write(s + "<br>");
            }


            int[] num = { 12, 13, 14, 15, 16, 17, 18 }; 

            //select even numbres from integer array
            var matches2 = from n in num where n % 2 == 0 select n;

            
            foreach (int n in num)
            {
                Response.Write(n + "<br>");
            }
        }
    }
}