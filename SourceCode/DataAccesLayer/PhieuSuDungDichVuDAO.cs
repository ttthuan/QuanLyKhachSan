using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTranferObject;

namespace DataAccesLayer
{
	public class PhieuSuDungDichVuDAO
	{
		DataProvider dataProvider = new DataProvider();
		public DataTable LayDanhSachSuDungDichVu(int maPhieuThuePhong)
		{
			string query = "Select Phieusudungdichvu.Maphieuthuephong,Phieusudungdichvu.Madichvu,Dichvu.Ten,Dichvu.Gia,Phieusudungdichvu.Soluong" +
				" from Phieusudungdichvu, Dichvu where Phieusudungdichvu.Madichvu = Dichvu.Ma and Maphieuthuephong = " + maPhieuThuePhong + "";
			DataTable tb = new DataTable();
			tb = dataProvider.ExecuteQuery_DataTble(query);
			return tb;
		}
		
		public bool CapNhatSuDungDichVu(PhieuSuDungDichVuDTO phieuSuDungDichVuDTO, bool them)
		{
			string query = "";
			if(them)
			{
				query = "INSERT INTO Phieusudungdichvu(Maphieuthuephong,Madichvu,Soluong)VALUES('" + phieuSuDungDichVuDTO.Maphieuthuephong + "','" + phieuSuDungDichVuDTO.Madichvu +
				"'," + phieuSuDungDichVuDTO.Soluong + " + Phieusudungdichvu.Soluong)";
			}
			else
			{
				query = "UPDATE Phieusudungdichvu SET Soluong = " + phieuSuDungDichVuDTO.Soluong + " + Soluong" +
					" where Maphieuthuephong = '" + phieuSuDungDichVuDTO.Maphieuthuephong + "' and Madichvu = '" + phieuSuDungDichVuDTO.Madichvu +"'";
			}
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

		public bool KiemtraSuDungDichVu(PhieuSuDungDichVuDTO phieuSuDungDichVuDTO)
		{
			string query = "Select * From Phieusudungdichvu where Maphieusudungdichvu = "+phieuSuDungDichVuDTO.Maphieuthuephong+" and Madichvu = "+phieuSuDungDichVuDTO.Madichvu+"";
			DataTable tb = new DataTable();
			tb = dataProvider.ExecuteQuery_DataTble(query);
			if (tb != null)
			{
				return true;
			}
			return false;
		}

		public bool XoaSuDungDichVu(PhieuSuDungDichVuDTO phieuSuDungDichVuDTO)
		{
			string query = "DELETE From Phieusudungdichvu where Maphieuthuephong = " + phieuSuDungDichVuDTO.Maphieuthuephong + " and Madichvu = " + phieuSuDungDichVuDTO.Madichvu + "";
			try
			{
				dataProvider.ExecuteQuery(query);
				return true;
			}catch
			{
				return false;
			}
		}
	}
}
