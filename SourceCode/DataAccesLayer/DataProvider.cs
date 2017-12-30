using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace DataAccesLayer
{
	class DataProvider
	{
		private SqlConnection conn = new SqlConnection();
		private SqlDataAdapter dt;
		private SqlCommand cm;

		public bool Connect()
		{
			conn.ConnectionString = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
			try
			{
				conn.Open();
				Console.Write("Connected!");
				return true;
			}
			catch
			{
				return false;
			}
		}

		public void DisConnect()
		{
			try
			{
				conn.Close();
				Console.Write("DisConnect!");
			}
			catch
			{
			}
		}

		public void ExecuteNonQuery(string sql)
		{
			cm = new SqlCommand(sql);
			cm.Connection = this.conn;
			cm.CommandType = CommandType.Text;
			cm.ExecuteNonQuery();
            DisConnect();
		}

		public void ExecuteUpdateQuery(string sql)
		{
			Connect();
			ExecuteNonQuery(sql);
			DisConnect();
		}

		public DataSet ExecuteQuery(string strSelect)
		{
			Connect();
			DataSet dataset = new DataSet();
			cm = new SqlCommand();
			cm.Connection = this.conn;
			dt = new SqlDataAdapter(strSelect, conn);
			try
			{
				dt.Fill(dataset);
			}
			catch (SqlException ex)
			{

			}
			DisConnect();
			return dataset;
		}

		public DataTable ExecuteQuery_DataTble(string strSelect)
		{
			try
			{
				return ExecuteQuery(strSelect).Tables[0];
			}
			catch
			{
				return null;
			}
		}
	}
}
