using DataTranferObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer
{
    public class PhieuThuePhongDAO
    {
        DataProvider dataProvider = new DataProvider();
        public PhieuThuePhongDTO[] LayDanhSachPhieuThuePhong()
        {
            PhieuThuePhongDTO[] phieuThuePhongs = null;
            string query = "Select * From PhieuThuePhong";
            DataTable tb = new DataTable();
            tb = dataProvider.ExecuteQuery_DataTble(query);
            phieuThuePhongs = new PhieuThuePhongDTO[tb.Rows.Count];

            int n = tb.Rows.Count;

            for (int i = 0; i < n; i++)
            {
                phieuThuePhongs[i] = ChuyenRowThanhObject(tb.Rows[i]);
            }
            return phieuThuePhongs;
        }

        public PhieuThuePhongDTO ChuyenRowThanhObject(DataRow row)
        {
            PhieuThuePhongDTO phieuThuePhong = new PhieuThuePhongDTO();
            phieuThuePhong.Ma = int.Parse(row[0].ToString());
            phieuThuePhong.MaPhong = int.Parse(row[1].ToString());
            phieuThuePhong.MaKhachHang = int.Parse(row[2].ToString());
            phieuThuePhong.ThoiGianNhanPhong = DateTime.Parse(row[3].ToString());
            phieuThuePhong.ThoiGianTraPhong = DateTime.Parse(row[4].ToString());
            phieuThuePhong.MaLoaiThuePhong = int.Parse(row[5].ToString());
            phieuThuePhong.Gia = float.Parse(row[6].ToString());
            phieuThuePhong.TrangThai = int.Parse(row[7].ToString());

            return phieuThuePhong;
        }

		public DataTable DanhSachDatPhong(int maKH)
		{
			DataTable table = new DataTable();
			string query = "Select Phieuthuephong.Ma,Phieuthuephong.Thoigiannhanphong,Phieuthuephong.Thoigiantraphong," +
				"Phong.Ten as Tenphong, Khachhang.Ten as Tenkhachhang From Phieuthuephong,Phong,KhachHang Where Phieuthuephong.Maphong = Phong.Ma " +
				" and Phieuthuephong.Makhachhang = Khachhang.Ma and Phieuthuephong.Makhachhang = " + maKH + " " +
				" and Phieuthuephong.TrangThai = 1";
			table = dataProvider.ExecuteQuery_DataTble(query);
			return table;
		}

		public PhieuThuePhongDTO LayPhieuthuephongTheoma(int maPhieuthue)
		{
			PhieuThuePhongDTO phieuThuePhongDTO = new PhieuThuePhongDTO();
			string query = "Select * From Phieuthuephong Where Ma = " + maPhieuthue + "";
			DataTable tb = new DataTable();
			tb = dataProvider.ExecuteQuery_DataTble(query);
			if (tb.Rows.Count > 0 && tb != null)
			{
				foreach (DataRow row in tb.Rows)
				{
					phieuThuePhongDTO.Ma = int.Parse(row[0].ToString());
					phieuThuePhongDTO.MaPhong = int.Parse(row[1].ToString());
					phieuThuePhongDTO.MaKhachHang = int.Parse(row[2].ToString());
					phieuThuePhongDTO.ThoiGianNhanPhong = DateTime.Parse(row[3].ToString());
					phieuThuePhongDTO.ThoiGianTraPhong = DateTime.Parse(row[4].ToString());
					phieuThuePhongDTO.MaLoaiThuePhong = int.Parse(row[5].ToString());
					phieuThuePhongDTO.Gia = float.Parse(row[6].ToString());
				}
				return phieuThuePhongDTO;
			}
			return null;
		}

		public PhieuThuePhongDTO DangO_KhachHang(int maKH)
		{
			PhieuThuePhongDTO phieuThuePhongDTO = new PhieuThuePhongDTO();
			string query = "Select * From Phieuthuephong Where TrangThai = 2 and Makhachhang = " + maKH + "";
			DataTable tb = new DataTable();
			tb = dataProvider.ExecuteQuery_DataTble(query);
			if (tb.Rows.Count > 0 && tb != null)
			{
				foreach (DataRow row in tb.Rows)
				{
					phieuThuePhongDTO.Ma = int.Parse(row[0].ToString());
					phieuThuePhongDTO.MaPhong = int.Parse(row[1].ToString());
					phieuThuePhongDTO.MaKhachHang = int.Parse(row[2].ToString());
					phieuThuePhongDTO.ThoiGianNhanPhong = DateTime.Parse(row[3].ToString());
					phieuThuePhongDTO.ThoiGianTraPhong = DateTime.Parse(row[4].ToString());
					phieuThuePhongDTO.MaLoaiThuePhong = int.Parse(row[5].ToString());
					phieuThuePhongDTO.Gia = float.Parse(row[6].ToString());
				}
				return phieuThuePhongDTO;
			}
			return null;
		}

		public PhieuThuePhongDTO DangO_Phong(int maP)
		{
			PhieuThuePhongDTO phieuThuePhongDTO = new PhieuThuePhongDTO();
			string query = "Select * From Phieuthuephong Where TrangThai = 2 and Maphong = " + maP + "";
			DataTable tb = new DataTable();
			tb = dataProvider.ExecuteQuery_DataTble(query);
			if (tb.Rows.Count > 0 && tb != null)
			{
				foreach (DataRow row in tb.Rows)
				{
					phieuThuePhongDTO.Ma = int.Parse(row[0].ToString());
					phieuThuePhongDTO.MaPhong = int.Parse(row[1].ToString());
					phieuThuePhongDTO.MaKhachHang = int.Parse(row[2].ToString());
					phieuThuePhongDTO.ThoiGianNhanPhong = DateTime.Parse(row[3].ToString());
					phieuThuePhongDTO.ThoiGianTraPhong = DateTime.Parse(row[4].ToString());
					phieuThuePhongDTO.MaLoaiThuePhong = int.Parse(row[5].ToString());
					phieuThuePhongDTO.Gia = float.Parse(row[6].ToString());
				}
				return phieuThuePhongDTO;
			}
			return null;
		}

		public bool ThemPhieuThuePhong(PhieuThuePhongDTO phieuThuePhongDTO)
		{
			string query = "INSERT INTO Phieuthuephong(Maphong,Makhachhang,Thoigiannhanphong,Thoigiantraphong," +
				"Maloaithuephong,Gia,TrangThai,TraTruoc) VALUES ('" + phieuThuePhongDTO .MaPhong+ "','" + phieuThuePhongDTO.MaKhachHang +
				"','" + phieuThuePhongDTO.ThoiGianNhanPhong.ToString("yyyy-MM-dd HH:mm:ss") + "','" + phieuThuePhongDTO.ThoiGianTraPhong.ToString("yyyy-MM-dd HH:mm:ss") + 
				"','" + phieuThuePhongDTO.MaLoaiThuePhong +
				"','" + phieuThuePhongDTO.Gia + "','" + phieuThuePhongDTO.TrangThai + "','" + phieuThuePhongDTO.TraTruoc + "')";
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

		public bool HuyDatPhong(int maPhieuThuePhong)
		{
			string query = "UPDATE Phieuthuephong SET TrangThai = 4 WHERE Ma = " + maPhieuThuePhong + "";
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

		public bool CapNhatTinhTrang(int maTinhTrang, int maPhieuThuePhong)
		{
			string query = "UPDATE Phieuthuephong SET TrangThai = "+maTinhTrang+" WHERE Ma = " + maPhieuThuePhong + "";
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
