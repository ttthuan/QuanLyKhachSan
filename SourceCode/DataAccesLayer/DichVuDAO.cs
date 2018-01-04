using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer
{
	public class DichVuDAO
	{
		DataProvider dataProvider = new DataProvider();
		public DataTable LayDanhSachDichVuTheoLoai(int loaiDichVu)
		{
			DataTable dataTable = new DataTable();
			string query = "Select * from Dichvu where Maloaidichvu = "+loaiDichVu+"";
			dataTable = dataProvider.ExecuteQuery_DataTble(query);
			return dataTable;
		}
	}
}
