using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Class1
    {
        public int Fn_Insert(string na, int ag, string addr, string ph, string una, string pw)
        {
            Concls obj = new Concls();

            string ins = "insert into tb1 values('" + na + "', " + ag + ", '" + addr + "', '" + ph + "', '" + una + "', '" + pw + "')";
            int i = obj.fn_ExecuteNonQuery(ins);
            return i;
        }
    }
}
