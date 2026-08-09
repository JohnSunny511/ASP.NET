using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace TwoLayerApplication
{
    public class ConnectionClass
    {
        SqlConnection con;
        SqlCommand cmd;

        public ConnectionClass()
        {
            con = new SqlConnection(@"server=LAPTOP-QK9QR22V\SQLEXPRESS;database=TwoThreeLayer;integrated security = true");
        }

        public int  fn_ExecuteNonQuery(string sqlquery)   // Insert,Delete,Update
        {
            if(con.State == ConnectionState.Open)
            {
                con.Close();
            }

            cmd = new SqlCommand(sqlquery, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }

        public string fn_ExeScalar(string sqlquery) // Select with scalar functions
        {
            if(con.State == ConnectionState.Open)
            {
                con.Close();
            }

            cmd = new SqlCommand(sqlquery, con);
            con.Open();
            string s = cmd.ExecuteScalar().ToString();
            con.Close();
            return s;
        }

        public SqlDataReader fn_exereader(string sqlquery)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            cmd = new SqlCommand(sqlquery, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public DataSet fn_Adapter_DataSet(string sqlquery)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            SqlDataAdapter da = new SqlDataAdapter(sqlquery, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public DataTable fn_Adapter_DataTable(string sqlquery)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            SqlDataAdapter da = new SqlDataAdapter(sqlquery, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}