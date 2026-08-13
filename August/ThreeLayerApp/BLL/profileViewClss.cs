using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data.SqlClient;
using System.Data;

namespace BLL
{
    public class profileViewClss
    {
        Concls ob = new Concls();

        public SqlDataReader fn_GetData(int id)
        {
            string str = "select name,age,address,photo from  tb1 where id = " + id + "";
            SqlDataReader dr = ob.fn_exereader(str);
            return dr;
        }

        public DataSet fn_Grid(int id)
        {
            string str = "select name,age,address,photo from  tb1 where id = " + id + "";
            DataSet ds = ob.fn_Adapter_DataSet(str);
            return ds;
        }
    }
}
