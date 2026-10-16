using System.Data;
using System.Data.SqlClient;

namespace COREMvcBasicApp.Models
{
    public class EmpDB
    {
        SqlConnection con = new SqlConnection(@"server=LAPTOP-QK9QR22V\SQLEXPRESS;database=NETCore1;Integrated security=true");

        public string InsertDB(Employee objcls)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_dbInsert", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@empname", objcls.ename);
                cmd.Parameters.AddWithValue("@empaddr", objcls.eaddr);
                cmd.Parameters.AddWithValue("@empsal", objcls.esal);
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

        public int LoginDB(Employee objcls)
        {
            try
            {
                int cid = 0;
                SqlCommand cmd = new SqlCommand("sp_login", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@eid", objcls.eid);
                cmd.Parameters.AddWithValue("@ena", objcls.ename);
                con.Open();
                cid = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                con.Close();
                return cid;
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

        public Employee SelectProfileDB(int id)
        {
            var getdata = new Employee();
            try
            {
                SqlCommand cmd = new SqlCommand("sp_selectProfile", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    getdata = new Employee
                    {
                        eid = Convert.ToInt32(sdr["id"]),
                        ename = sdr["name"].ToString(),
                        eaddr = sdr["addr"].ToString(),
                        esal = sdr["salary"].ToString()
                    };
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

        public List<Employee> SelectAll()
        {
            var getalldata = new List<Employee>();
            try
            {
                SqlCommand cmd = new SqlCommand("sp_selectAll", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    var o = new Employee
                    {
                        eid = Convert.ToInt32(sdr["id"]),
                        ename = sdr["name"].ToString(),
                        eaddr = sdr["addr"].ToString(),
                        esal = sdr["salary"].ToString()
                    };
                    getalldata.Add(o);
                }
                con.Close();
                return getalldata;
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
