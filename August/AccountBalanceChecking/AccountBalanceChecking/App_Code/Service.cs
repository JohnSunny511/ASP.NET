using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data.SqlClient;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
	SqlConnection con = new SqlConnection(@"server=LAPTOP-QK9QR22V\SQLEXPRESS;database=wcfdb;integrated security = true");

	public string checkBalance(string acno)
    {
		string str = "select AccBalance from tb1 where AccNo = " + acno + "";
		SqlCommand cmd = new SqlCommand(str, con);
		con.Open();
		string bal = " ";
		SqlDataReader dr = cmd.ExecuteReader();
		while (dr.Read())
        {
			bal = dr["AccBalance"].ToString();
        }
		con.Close();
		return bal;
    }

	public string GetData(int value)
	{
		return string.Format("You entered: {0}", value);
	}

	public CompositeType GetDataUsingDataContract(CompositeType composite)
	{
		if (composite == null)
		{
			throw new ArgumentNullException("composite");
		}
		if (composite.BoolValue)
		{
			composite.StringValue += "Suffix";
		}
		return composite;
	}
}
