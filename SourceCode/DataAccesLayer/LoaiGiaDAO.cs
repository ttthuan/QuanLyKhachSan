using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer
{
	public class LoaiGiaDAO
	{
		DataProvider dataProvider = new DataProvider();
		public DataTable LayDanhSachLoaiGia()
		{
			string query = "Select * From LoaiGia";
			DataTable tb = new DataTable();
			tb = dataProvider.ExecuteQuery_DataTble(query);
			return tb;
		}
	}
}
