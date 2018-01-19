using DataAccesLayer;
using DataTranferObject;
using System;
using System.Collections.Generic;
using System.Data;
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

        public int LaySoLuongPhongLonNhatTrongCacTang()
        {
            return phongDAO.LaySoLuongPhongLonNhatTrongCacTang();
        }

		public DataTable LayDanhSachPhongTrong(string time1, string time2, int maLoaiPhong)
		{
			return phongDAO.LayDanhSachPhongTrong(time1, time2, maLoaiPhong);
		}

		public PhongDTO LayPhongTheoMaSo(int maPhong)
		{
			return phongDAO.LayPhongTheoMaSo(maPhong);
		}

		public float LayGiaPhong(int maLoaiGia,int maLoaiPhong)
		{
			return phongDAO.LayGiaPhong(maLoaiGia,maLoaiPhong);
		}

		public string LayLoaiPhong(int maLoaiPhong)
		{
			return phongDAO.LayLoaiPhong(maLoaiPhong);
		}

		public string LayLoaiDangKy(int maLoaiDangKy)
		{
			return phongDAO.LayLoaiDangKy(maLoaiDangKy);
		}
	}
}
