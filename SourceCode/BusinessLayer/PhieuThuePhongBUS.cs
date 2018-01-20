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

        public List<BieuDoKhachDen> LayDanhSachSoKhachDenTrongThang(int year, int month)
        {
            List<BieuDoKhachDen> list = new List<BieuDoKhachDen>();
            int lastDayInMounth = DateTime.DaysInMonth(year, month);
            for (int i = 1; i <= lastDayInMounth; i++)
            {
                list.Add(LaySoLuongKhachDenTrongNgay(new DateTime(year, month, i)));
            }
            return list;
        }

        public BieuDoKhachDen LaySoLuongKhachDenTrongNgay(DateTime date)
        {
            BieuDoKhachDen bieuDoKhachDen = new BieuDoKhachDen();
            bieuDoKhachDen.DAY = date.Day;

            PhieuThuePhongDTO[] phieuThuePhongs = phieuThuePhongDAO.LayDanhSachPhieuThuePhong();

            foreach (var temp in phieuThuePhongs.Where(dp => dp.ThoiGianNhanPhong.Date == date.Date)
                    .OrderBy(dp => dp.MaLoaiThuePhong)
                    .GroupBy(dp => dp.MaLoaiThuePhong).Select(group => new { MALOAIDK = group.Key, NUMBER = group.Count() }))
            {
                if (temp.MALOAIDK == 1)
                {
                    bieuDoKhachDen.NUMBERTHUENGAY = temp.NUMBER;
                }
                else if (temp.MALOAIDK == 2)
                {
                    bieuDoKhachDen.NUMBERQUADEM = temp.NUMBER;
                }
                else
                {
                    bieuDoKhachDen.NUMBERTHUEGIO = temp.NUMBER;
                }
            }

            return bieuDoKhachDen;
        }

        public void DuyetVaCapNhatTrangThai()
        {
            PhieuThuePhongDTO[] phieuThuePhongs = phieuThuePhongDAO.LayDanhSachPhieuThuePhong();
            DateTime date = DateTime.Now;
            List<PhieuThuePhongDTO> list = phieuThuePhongs.Where(tp => tp.TrangThai == 1 && tp.ThoiGianTraPhong < date).ToList();
            if(list.Count > 0)
            {
                foreach(var item in list)
                {
                    HuyDatPhong(item.Ma);
                }
            }
        }

        public void CapNhatTrangThaiPhieuThuePhongCoMaPhong(int maPhong)
        {
            PhieuThuePhongDTO[] phieuThuePhongs = phieuThuePhongDAO.LayDanhSachPhieuThuePhong();
            if(phieuThuePhongs != null)
            {
                try
                {
                    DateTime date = DateTime.Now;
                    PhieuThuePhongDTO phieuThuePhong = phieuThuePhongs.Where(tp => tp.TrangThai == 1 && tp.MaPhong == maPhong && tp.ThoiGianNhanPhong <= date).FirstOrDefault();
                    if (phieuThuePhong != null)
                    {
                        CapNhatTinhTrang(phieuThuePhong.Ma, 2);
                    }
                }catch(Exception ex)
                {
                    throw ex.InnerException;
                }
                
            }
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

		public PhieuThuePhongDTO DangO_Phong(int maP)
		{
			return phieuThuePhongDAO.DangO_Phong(maP);
		}

		public bool ThemPhieuThuePhong(PhieuThuePhongDTO phieuThuePhongDTO)
		{
			return phieuThuePhongDAO.ThemPhieuThuePhong(phieuThuePhongDTO);
		}

		public bool HuyDatPhong(int maPhieuThuePhong)
		{
			return phieuThuePhongDAO.HuyDatPhong(maPhieuThuePhong);
		}

		public bool CapNhatTinhTrang(int maPhieuThuePhong, int maTrangThai)
		{
			return phieuThuePhongDAO.CapNhatTinhTrang(maTrangThai, maPhieuThuePhong);
		}
	}
}
