using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer
{
	public class LoaiDichVuDAO
	{
		DataProvider dataProvider = new DataProvider();
		public DataTable LayDanhSachLoaiDichVu()
		{
			DataTable dataTable = new DataTable();
			string query = "Select * from Loaidichvu";
			dataTable = dataProvider.ExecuteQuery_DataTble(query);
			return dataTable;
		}

		public bool CapnhatLDV(string ten, string ma)
		{
			string query = "UPDATE Loaidichvu Set Ten = N'"+ten+"' where Ma = "+ma+"";
			try
			{
				dataProvider.ExecuteUpdateQuery(query);
				return true;
			}
			catch
			{
				return false;
			}
		}

		public bool ThemLDV(string ten)
		{
			string query = "insert into Loaidichvu(Ten) Values ("+ten+")";
			try
			{
				dataProvider.ExecuteUpdateQuery(query);
				return true;
			}
			catch
			{
				return false;
			}
		}
	}
}
