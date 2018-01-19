using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccesLayer;
using DataTranferObject;

namespace BusinessLayer
{
    public class NhanVienBUS
    {
        NhanVienDAO nhanVienDAO = new NhanVienDAO();

        public NhanVienDTO[] LayDanhSachPhong()
        {
            return nhanVienDAO.LayDanhSachNhanVien();
        }

        public NhanVienDTO LayNhanVienCoMaSo(int ma)
        {
            NhanVienDTO nhanVien = new NhanVienDTO();
            NhanVienDTO[] nhanViens = nhanVienDAO.LayDanhSachNhanVien();

            int n = nhanViens.Length;
            for (int i = 0; i < n; i++)
            {
                if (nhanViens[i].Ma == ma)
                {
                    return nhanViens[i];
                }
            }

            return null;
        }

		public int LayMaNhanVien(int maTK)
		{
			return nhanVienDAO.LayMaNhanVien(maTK);
		}

		public DataTable LaydanhsachChucvu()
		{
			return nhanVienDAO.LaydanhsachChucvu();
		}

		public NhanVienDTO LayNhanVienTheoTK(int maTK)
		{
			return nhanVienDAO.LayNhanVienTheoTK(maTK);
		}

		public DataTable LaydanhsachNhanvienDataTable()
		{
			return nhanVienDAO.LaydanhsachNhanvienDataTable();
		}

		public bool ThemNhanvien(NhanVienDTO nv)
		{
			return nhanVienDAO.ThemNhanvien(nv);
		}

		public bool CapnhatNhanvien(NhanVienDTO nv)
		{
			return nhanVienDAO.CapnhatNhanvien(nv);
		}
	}
}
