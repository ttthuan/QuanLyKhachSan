using DataAccesLayer;
using DataTranferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class PhongBUS
    {
        PhongDAO phongDAO = new PhongDAO();

        public PhongDTO[] LayDanhSachPhong()
        {
            return phongDAO.LayDanhSachPhong();
        }
    }
}
