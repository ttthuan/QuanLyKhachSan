using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTranferObject;

namespace DataAccesLayer
{
    public class NhanVienDAO
    {
        DataProvider dataProvider = new DataProvider();
        public NhanVienDTO[] LayDanhSachNhanVien()
        {
            NhanVienDTO[] nhanViens = null;
            string query = "Select * From Nhanvien";
            DataTable tb = new DataTable();
            tb = dataProvider.ExecuteQuery_DataTble(query);
            nhanViens = new NhanVienDTO[tb.Rows.Count];

            int n = tb.Rows.Count;

            for (int i = 0; i < n; i++)
            {
                nhanViens[i] = ChuyenRowThanhObject(tb.Rows[i]);
            }
            return nhanViens;
        }

		public NhanVienDTO LayNhanVienTheoTK(int maTK)
		{
			string query = "Select * From Nhanvien where Mataikhoan = "+maTK+"";
			DataTable tb = new DataTable();
			tb = dataProvider.ExecuteQuery_DataTble(query);
			NhanVienDTO nhanVienDTO = new NhanVienDTO();
			foreach (DataRow r in tb.Rows)
			{
				nhanVienDTO = ChuyenRowThanhObject(r);
			}
			return nhanVienDTO;
		}

		public NhanVienDTO ChuyenRowThanhObject(DataRow row)
        {
            NhanVienDTO nhanVien = new NhanVienDTO();
            nhanVien.Ma = int.Parse(row[0].ToString());
            nhanVien.Ten = row[1].ToString();
            nhanVien.SDT = row[2].ToString();
            nhanVien.DiaChi = row[3].ToString();
            nhanVien.GioiTinh = row[4].ToString();
            nhanVien.NgaySinh = DateTime.Parse(row[5].ToString());
            nhanVien.Mataikhoan = int.Parse(row[6].ToString());
            nhanVien.Maloainhanvien = int.Parse(row[7].ToString());

            return nhanVien;
        }

		public int LayMaNhanVien(int maTK)
		{
			string query = "Select Ma From Nhanvien Where Mataikhoan = "+maTK+"";
			DataTable tb = new DataTable();
			tb = dataProvider.ExecuteQuery_DataTble(query);
			int resut = int.Parse(tb.Rows[0][0].ToString());
			return resut;
		}

		public DataTable LaydanhsachChucvu()
		{
			string query = "Select * From Loainhanvien";
			return dataProvider.ExecuteQuery_DataTble(query);
		}

		public DataTable LaydanhsachNhanvienDataTable()
		{
			string query = "Select * From Nhanvien nv,Taikhoan tk where nv.Mataikhoan = tk.Ma";
			return dataProvider.ExecuteQuery_DataTble(query);
		}

		public bool ThemNhanvien(NhanVienDTO nv)
		{
			string query = "insert into Nhanvien(Ten,SDT,DiaChi,Gioitinh,Ngaysinh,Mataikhoan,Maloainhanvien) " +
				"Values (N'"+nv.Ten+"','"+nv.SDT+"',N'"+nv.DiaChi+"',N'"+nv.GioiTinh+"','"+nv.NgaySinh.ToString("yyyy-MM-dd") + "'" +
				", '"+nv.Mataikhoan+"',"+nv.Maloainhanvien+")";
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

		public bool CapnhatNhanvien(NhanVienDTO nv)
		{
			string query = "update Nhanvien set Ten = N'" + nv.Ten + "', SDT = '" + nv.SDT + "', DiaChi = N'" + nv.DiaChi + 
				"', Gioitinh = '" + nv.GioiTinh + "', Ngaysinh = '" + nv.NgaySinh.ToString("yyyy-MM-dd") + "'" +
				",Maloainhanvien = " + nv.Maloainhanvien + " where Ma = "+nv.Ma+"";
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
