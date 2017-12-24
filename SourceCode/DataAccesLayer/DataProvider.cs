using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace DataAccesLayer
{
	class DataProvider
	{
		public bool Connect()
		{
			SqlConnection conn = new SqlConnection();
			conn.ConnectionString = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
			try
			{
				conn.Open();
				return true;
			}
			catch
			{
				return false;
			}
		}
	}
}
