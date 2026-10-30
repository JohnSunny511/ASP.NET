using System.Data;
using System.Data.SqlClient;

namespace TokenCoreApiApp.Models
{
    //For employess database connectivity we create dbclass(this file)
    public class EmpDBclss
    {
        SqlConnection con = new SqlConnection(@"server=LAPTOP-QK9QR22V\SQLEXPRESS;database=APIJwtTokenAuthenticationDB;integrated security = true");

        public List<EmpDetailsclss> SelectDB()
        {
            var list = new List<EmpDetailsclss>();
            SqlCommand cmd = new SqlCommand("sp_selectAll", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                var o = new EmpDetailsclss
                {
                    EmpId = Convert.ToInt32(sdr["Emp_Id"]),
                    EmpName = sdr["Emp_Name"].ToString(),
                    EmpAge = Convert.ToInt32(sdr["Emp_Age"]),
                    EmpAddr = sdr["Emp_Address"].ToString(),
                    EmpEmail = sdr["Emp_Email"].ToString()
                };
                list.Add(o);
            }
            con.Close();
            return list;
        }

        public Loginclss LoginDB(LoginModel objclss)
        {
            var getdata = new Loginclss();
            SqlCommand cmd = new SqlCommand("sp_Login", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@uid", objclss.UserID);
            cmd.Parameters.AddWithValue("@userpwd", objclss.UserPWD);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                getdata = new Loginclss
                {
                    LogId = Convert.ToInt32(sdr["Log_Id"]),
                    UserID = sdr["User_Id"].ToString(),
                    UserPWD = sdr["User_Pwd"].ToString()
                };
            }
            con.Close();
            return getdata;
        }
    }
}
