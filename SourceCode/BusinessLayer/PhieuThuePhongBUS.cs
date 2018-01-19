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
    public class PhieuThuePhongBUS
    {
        PhieuThuePhongDAO phieuThuePhongDAO = new PhieuThuePhongDAO();

        public PhieuThuePhongDTO[] LayDanhSachPhieuThuePhongTrangThai1Va2()
        {
            PhieuThuePhongDTO[] phieuThuePhongs = phieuThuePhongDAO.LayDanhSachPhieuThuePhong();
            List<PhieuThuePhongDTO> lsPhieuThuePhong = new List<PhieuThuePhongDTO>();

            int n = phieuThuePhongs.Length;
            for(int i = 0; i < n; i++)
            {
                if(phieuThuePhongs[i].TrangThai == 1 || phieuThuePhongs[i].TrangThai == 2)
                {
                    lsPhieuThuePhong.Add(phieuThuePhongs[i]);
                }
            }

            return lsPhieuThuePhong.ToArray();
        }

        public PhieuThuePhongDTO[] LayDanhSachPhieuThuePhongTrangThai3()
        {
            PhieuThuePhongDTO[] phieuThuePhongs = phieuThuePhongDAO.LayDanhSachPhieuThuePhong();
            List<PhieuThuePhongDTO> lsPhieuThuePhong = new List<PhieuThuePhongDTO>();

            int n = phieuThuePhongs.Length;
            for (int i = 0; i < n; i++)
            {
                if (phieuThuePhongs[i].TrangThai == 3)
                {
                    lsPhieuThuePhong.Add(phieuThuePhongs[i]);
                }
            }

            if (lsPhieuThuePhong.Count > 0)
                return lsPhieuThuePhong.ToArray();
            else
                return null;
        }

        public PhieuThuePhongDTO CoPhaiPhongCoNguoiDangO(int maPhong)
        {
            PhieuThuePhongDTO[] phieuThuePhongs = phieuThuePhongDAO.LayDanhSachPhieuThuePhong();

            int n = phieuThuePhongs.Length;
            for (int i = 0; i < n; i++)
            {
                if (phieuThuePhongs[i].MaPhong == maPhong && phieuThuePhongs[i].TrangThai == 2)
                {
                    return phieuThuePhongs[i];
                }
            }
            return null;
        }

		public DataTable DanhSachDatPhong(int maKH)
		{
			return phieuThuePhongDAO.DanhSachDatPhong(maKH);
		}

		public PhieuThuePhongDTO LayPhieuthuephongTheoma(int maPhieuthue)
		{
			return phieuThuePhongDAO.LayPhieuthuephongTheoma(maPhieuthue);
		}

		public PhieuThuePhongDTO DangO_KhachHang(int maKH)
		{
			return phieuThuePhongDAO.DangO_KhachHang(maKH);
		}

		public bool ThemPhieuThuePhong(PhieuThuePhongDTO phieuThuePhongDTO)
		{
			return phieuThuePhongDAO.ThemPhieuThuePhong(phieuThuePhongDTO);
		}

		public bool HuyDatPhong(int maPhieuThuePhong)
		{
			return phieuThuePhongDAO.HuyDatPhong(maPhieuThuePhong);
		}
	}
}
