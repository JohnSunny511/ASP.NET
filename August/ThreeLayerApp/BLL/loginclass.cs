using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class loginclass
    {
        Concls ob = new Concls();

        public string login(string una, string pw)
        {
            string str = "select count(id) from tb1 where username = '" + una + "' and password = '" + pw + "'";
            string cid = ob.fn_ExeScalar(str);
            return cid;
        }

        public string GetId(string una, string pwd)
        {
            string str = "select Id from tb1 where username = '" + una + "' and password = '" + pwd + "'";
            string id = ob.fn_ExeScalar(str);
            return id;
        }
    }
}
