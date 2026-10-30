using System.Data;
using System.Data.SqlClient;
namespace CoreAPIAngular.Models
{
    public class DBclss
    {
        SqlConnection con = new SqlConnection(@"server=LAPTOP-QK9QR22V\SQLEXPRESS;database=DBAngularAPI;Integrated Security = true");

        public string InsertDB(Userclss objclss)
        {
            SqlCommand cmd = new SqlCommand("sp_UserInsert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@na", objclss.name);
            cmd.Parameters.AddWithValue("@ag", objclss.age);
            cmd.Parameters.AddWithValue("addr", objclss.addr);
            cmd.Parameters.AddWithValue("@email", objclss.email);
            cmd.Parameters.AddWithValue("@photo", objclss.photo);
            cmd.Parameters.AddWithValue("@una", objclss.uname);
            cmd.Parameters.AddWithValue("@pw", objclss.password);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            return ("Inserted Succesfully");
        }

        public string LoginDB(Userclss objcls)
        {
            try
            {
                string cid = "";
                SqlCommand cmd = new SqlCommand("sp_login", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@una", objcls.uname);
                cmd.Parameters.AddWithValue("@pw", objcls.password);
                con.Open();
                cid = cmd.ExecuteScalar().ToString();
                con.Close();
                return cid;
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


        public string GetUserID(Userclss objcls)
        {
            try
            {
                string id = "";
                SqlCommand cmd = new SqlCommand("sp_GetId", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@una", objcls.uname);
                cmd.Parameters.AddWithValue("@pw", objcls.password);
                con.Open();
                id = cmd.ExecuteScalar().ToString();
                con.Close();
                return id;
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


        public Userclss SelectProfileDB(int id)
        {
            var getdata = new Userclss();
            try
            {
                SqlCommand cmd = new SqlCommand("sp_selectProfile", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserId", id);
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    getdata = new Userclss
                    {
                        uid = Convert.ToInt32(sdr["UserId"]), //set
                        name = sdr["Name"].ToString(),
                        age = Convert.ToInt32(sdr["Age"]),
                        addr = sdr["Address"].ToString(),
                        email = sdr["Email"].ToString(),
                        photo = sdr["Photo"].ToString(),
                    };
                }
                con.Close();
                return getdata;
            }
            catch (Exception ex)
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
