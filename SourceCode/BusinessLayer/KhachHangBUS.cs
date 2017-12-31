using DataAccesLayer;
using DataTranferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class KhachHangBUS
    {
        KhachHangDAO khachHangDAO = new KhachHangDAO();

        public KhachHangDTO LayKhachHangCoMaSo(int ma)
        {
            KhachHangDTO[] khachHangs = khachHangDAO.LayDanhSachKhachHang();

            int n = khachHangs.Length;
            for (int i = 0; i < n; i++)
            {
                if (khachHangs[i].Ma == ma)
                {
                    return khachHangs[i];
                }
            }

            return null;
        }
    }
}
