using DataTranferObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer
{
    public class KhachHangDAO
    {
        DataProvider dataProvider = new DataProvider();
        public KhachHangDTO[] LayDanhSachKhachHang()
        {
            KhachHangDTO[] khachHangs = null;
            string query = "Select * From Khachhang";
            DataTable tb = new DataTable();
            tb = dataProvider.ExecuteQuery_DataTble(query);
            khachHangs = new KhachHangDTO[tb.Rows.Count];

            int n = tb.Rows.Count;

            for (int i = 0; i < n; i++)
            {
                khachHangs[i] = ChuyenRowThanhObject(tb.Rows[i]);
            }
            return khachHangs;
        }

        public KhachHangDTO ChuyenRowThanhObject(DataRow row)
        {
            KhachHangDTO khachHang = new KhachHangDTO();
            khachHang.Ma = int.Parse(row[0].ToString());
            khachHang.Ten = row[1].ToString();
            khachHang.DiaChi = row[2].ToString();
            khachHang.Sdt = row[3].ToString();
            khachHang.GioiTinh = row[4].ToString();
            khachHang.Scmnd = row[5].ToString();
            khachHang.QuocTich = row[6].ToString();

            return khachHang;
        }

		//Láy danh sách khách hàng đang ở
		public KhachHangDTO[] LayDanhSachKhachHangDangO()
		{
			KhachHangDTO[] khachHangs = null;
			string query = "Select * From KhachHang where Ma in " +
				"( Select Makhachhang From Phieuthuephong where Thoigiantraphong >= GETDATE() and Thoigiannhanphong < GETDATE())";
			DataTable tb = new DataTable();
			tb = dataProvider.ExecuteQuery_DataTble(query);
			khachHangs = new KhachHangDTO[tb.Rows.Count];

			int n = tb.Rows.Count;

			for (int i = 0; i < n; i++)
			{
				khachHangs[i] = ChuyenRowThanhObject(tb.Rows[i]);
			}
			return khachHangs;
		}

		//Láy danh sách khách hàng đang đặt phòng trước
		public KhachHangDTO[] LayDanhSachKhachHangDatPhong()
		{
			KhachHangDTO[] khachHangs = null;
			string query = "Select * From KhachHang where Ma in " +
				"( Select Makhachhang From Phieuthuephong where Thoigiannhanphong >= GETDATE())";
			DataTable tb = new DataTable();
			tb = dataProvider.ExecuteQuery_DataTble(query);
			khachHangs = new KhachHangDTO[tb.Rows.Count];

			int n = tb.Rows.Count;

			for (int i = 0; i < n; i++)
			{
				khachHangs[i] = ChuyenRowThanhObject(tb.Rows[i]);
			}
			return khachHangs;
		}

		public KhachHangDTO[] LayDanhSachKhachHangCu()
		{
			KhachHangDTO[] khachHangs = null;
			string query = "Select * From KhachHang where Ma not in (" +
				"Select Makhachhang From Phieuthuephong where  Thoigiannhanphong >= GETDATE() " +
				"or Thoigiantraphong >= GETDATE() and Thoigiannhanphong<GETDATE())";
			DataTable tb = new DataTable();
			tb = dataProvider.ExecuteQuery_DataTble(query);
			khachHangs = new KhachHangDTO[tb.Rows.Count];

			int n = tb.Rows.Count;

			for (int i = 0; i < n; i++)
			{
				khachHangs[i] = ChuyenRowThanhObject(tb.Rows[i]);
			}
			return khachHangs;
		}

		public bool CapnhatThongTinKhachHang(KhachHangDTO khachhangDTO)
		{
			string query = "UPDATE KhachHang SET Ten = N'"+khachhangDTO.Ten+"', Diachi = N'"+ khachhangDTO.DiaChi +
				"',SDT = '"+ khachhangDTO.Sdt +"',Gioitinh = N'"+ khachhangDTO.GioiTinh +"',SoCMND = '"+ khachhangDTO.Scmnd +
				"',Quoctich = N'"+ khachhangDTO.QuocTich +"' WHERE Ma = "+khachhangDTO.Ma+" ";
			try
			{
				dataProvider.ExecuteUpdateQuery(query);
				return true;
			}catch
			{
				return false;
			}
		}
	}
}
