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
	}
}
