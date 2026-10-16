using System.Data;
using System.Data.SqlClient;

namespace Core_Mvc_Advanced.Models

{
    public class StudentDB
    {
        SqlConnection con = new SqlConnection(@"server=LAPTOP-QK9QR22V\SQLEXPRESS;database=core_mvc_Advanced;Integrated security=true");

        public string InsertFn(InsertClss objcls)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_insertNewTab", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@stid", objcls.stId);
                cmd.Parameters.AddWithValue("@did", objcls.dId);
                cmd.Parameters.AddWithValue("@sna", objcls.sname);
                cmd.Parameters.AddWithValue("@sag", objcls.sage);
                cmd.Parameters.AddWithValue("@sgen", objcls.Gender);
                cmd.Parameters.AddWithValue("@squal", objcls.Qual);
                cmd.Parameters.AddWithValue("@sph", objcls.sphoto);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return ("Inserted Successfully");
            }
            catch (Exception ex)
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                return ex.Message.ToString();
            }
        }
        
        public List<Stclass> Selectstates()
        {
            var getdata = new List<Stclass>();
            try
            {
                SqlCommand cmd = new SqlCommand("sp_state", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    var ob = new Stclass
                    {
                        stId = Convert.ToInt32(sdr["sid"]),
                        stName = sdr["sname"].ToString()
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

        public List<Dclass> Selectdistrics(int stateId)
        {
            var getdata = new List<Dclass>();
            try
            {
                SqlCommand cmd = new SqlCommand("sp_districs", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@stid", stateId);
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
                if(con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                throw;
            }
        }

        public List<InsertClss> DisplayAll()
        {
            var getalldata = new List<InsertClss>();
            try
            {
                SqlCommand cmd = new SqlCommand("sp_SelectAllNew", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    var o = new InsertClss
                    {
                        sname = sdr["sId"].ToString(),
                        stName = sdr["sname"].ToString(),
                        dName = sdr["Dname"].ToString(),
                        sage = Convert.ToInt32(sdr["Sage"].ToString()),
                        Gender = sdr["Sgender"].ToString(),
                        Qual = sdr["SQual"].ToString(),
                        sphoto = sdr["SPhoto"].ToString(),
                    };
                    getalldata.Add(o);
                }
                con.Close();
                return getalldata;
            }
            catch (Exception)
            {
                if(con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                throw;
            }
        }



    }
}
