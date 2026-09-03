using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace asp_exam_practice
{

    public class conclss
    {
        SqlCommand cmd;
        SqlConnection con;

        public conclss(){
            con = new SqlConnection(@"server=LAPTOP-QK9QR22V\SQLEXPRESS;database=aspexm;Integrated Security=true");
            }

        public int fn_exeNonQuery(string sql)
        {
            if(con.State == ConnectionState.Open)
            {
                con.Close();
            }
            cmd = new SqlCommand(sql, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }

        public string fn_exScalar(string s)
        {
            if(con.State == ConnectionState.Open)
            {
                con.Close();
            }
            cmd = new SqlCommand(s, con);
            con.Open();
            s = cmd.ExecuteScalar().ToString();
            con.Close();
            return s;
        }

        public SqlDataReader fn_Reader(string s)
        {
            if(con.State == ConnectionState.Open)
            {
                con.Close();
            }
            cmd = new SqlCommand(s,con);
            con.Open();
            SqlDataReader r = cmd.ExecuteReader();
            return r;
        }

        public DataSet fn_Adapter_Dataset(string s)
        {
            if(con.State == ConnectionState.Open)
            {
                con.Close();
            }
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(s, con);
            da.Fill(ds);
            return ds;
        }

        public DataTable fn_Adapter_Datatable(string s)
        {
            if(con.State == ConnectionState.Open)
            {
                con.Close();
            }
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(s, con);
            da.Fill(dt);
            return dt;
        }




    }
}