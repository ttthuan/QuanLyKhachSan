using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTranferObject;

namespace DataAccesLayer
{
	public class DichVuDAO
	{
		DataProvider dataProvider = new DataProvider();

		public DataTable LayDanhSachDichVu()
		{
			DataTable dataTable = new DataTable();
			string query = "Select * from Dichvu";
			dataTable = dataProvider.ExecuteQuery_DataTble(query);
			return dataTable;
		}

		public DataTable LayDanhSachDichVuTheoLoai(int loaiDichVu)
		{
			DataTable dataTable = new DataTable();
			string query = "Select * from Dichvu where Maloaidichvu = "+loaiDichVu+"";
			dataTable = dataProvider.ExecuteQuery_DataTble(query);
			return dataTable;
		}

		public float LayGiaDichVu(int maDichVu)
		{
			return 0;
		}

		public bool CapnhatDV(DichVuDTO dichVuDTO)
		{
			string query = "UPDATE Dichvu Set Ten = N'" + dichVuDTO._Ten + "', Donvitinh = N'"+dichVuDTO._Donvitinh+"', " +
							"Maloaidichvu = "+dichVuDTO._Maloaidichvu+", Gia = "+dichVuDTO._Gia+" where Ma = " + dichVuDTO._Ma + "";
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

		public bool ThemDV(DichVuDTO dichVuDTO)
		{
			string query = "insert into Dichvu(Ten,Donvitinh,Maloaidichvu,Gia) " +
				"Values (N'" + dichVuDTO._Ten + "',N'"+dichVuDTO._Donvitinh+"',"+dichVuDTO._Maloaidichvu+","+dichVuDTO._Gia+")";
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
