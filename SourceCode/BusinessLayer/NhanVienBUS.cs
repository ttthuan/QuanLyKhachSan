using System;
using System.Collections.Generic;
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
    }
}
