using System.Data;
using System.Data.SqlClient;

namespace MVC_Core_WebApiApp.Model
{
    public class DBclss
    {
            SqlConnection con = new SqlConnection(@"server=LAPTOP-QK9QR22V\SQLEXPRESS;database=NETCore1;Integrated Security=True");
            public string insertdb(Employeecls objcls)
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
                    return ("Record Inserted Successfully");
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

        public string DeleteDB(int id)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("sp_delete", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return ("Deleted");
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


        public List<Employeecls> displayall()
        {
            var getalldata = new List<Employeecls>();
            try
            {
                SqlCommand cmd = new SqlCommand("sp_selectAll", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    var o = new Employeecls
                    {
                        eid = Convert.ToInt32(sdr["id"]),
                        ename = sdr["name"].ToString(),
                        eaddr = sdr["addr"].ToString(),
                        esal = sdr["salary"].ToString(),
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

        public string UpdateDB(Employeecls objcls)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("sp_update", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@eid", objcls.eid);
                cmd.Parameters.AddWithValue("@ename", objcls.ename);
                cmd.Parameters.AddWithValue("@esal", objcls.esal);
                cmd.Parameters.AddWithValue("@eaddr", objcls.eaddr);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return ("ok updated");
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


        public int logincheck(Employeecls objcls)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_login", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@eid", objcls.eid);
                    cmd.Parameters.AddWithValue("@ena", objcls.ename);
                    con.Open();
                    int result = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                    con.Close();
                    return result;
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
            public Employeecls selectprofiledb(int id)
            {
                var getdata = new Employeecls();
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_selectprofile", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", id);
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        getdata = new Employeecls()
                        {
                            eid = Convert.ToInt32(sdr["emp_id"]),
                            ename = sdr["emp_name"].ToString(),
                            eaddr = sdr["emp_address"].ToString(),
                            esal = sdr["emp_salary"].ToString(),
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
            
        }
}
