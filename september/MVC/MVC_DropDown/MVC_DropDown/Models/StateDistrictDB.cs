using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace MVC_DropDown.Models
{
    public class StateDistrictDB
    {
        string conString = ConfigurationManager.ConnectionStrings["TestCon"].ConnectionString;                   //configuration manager is used to connect db from web config sql connection string
        SqlConnection con;
        public StateDistrictDB()
        {
            con = new SqlConnection(conString);
        }

        public List<stclass> Selectstates()
        {
            var getdata = new List<stclass>();
            try
            {
                SqlCommand cmd = new SqlCommand("sp_state", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    var ob = new stclass
                    {
                        sId = Convert.ToInt32(sdr["stateId"]),
                        sName = sdr["stateName"].ToString()
                    };
                    getdata.Add(ob);
                }
                con.Close();
                return getdata;
            }
            catch (Exception)
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                throw;
            }
        }


        public List<Dclass> SelectDistrict(int sid)
        {
            var getdata = new List<Dclass>();
            try
            {
                SqlCommand cmd = new SqlCommand("sp_district", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sid", sid);
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    var o = new Dclass
                    {
                        dId = Convert.ToInt32(sdr["Did"]),
                        dName = sdr["Dname"].ToString()
                    };
                    getdata.Add(o);
                }
                con.Close();
                return getdata;
            }
            catch (Exception)
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                throw;
            }
        }
    }
}