using DataAccesLayer;
using DataTranferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class HoaDonBUS
    {
        HoaDonDAO hoaDonDAO = new HoaDonDAO();

        public List<CustomDisplayHoaDon> getCusTomHoaDons(DateTime dtBD, DateTime dtKT)
        {
            HoaDonDTO[] hoaDons = hoaDonDAO.LayDanhSachHoaDon();
            List<CustomDisplayHoaDon> lsDisplayHoaDon = new List<CustomDisplayHoaDon>();
            PhongBUS phongBUS = new PhongBUS();
            KhachHangBUS khachHangBUS = new KhachHangBUS();
            NhanVienBUS nhanVienBUS = new NhanVienBUS();
            PhieuSuDungDichVuDAO suDungDichVuDAO = new PhieuSuDungDichVuDAO();

            if (hoaDons != null)
            {
                PhieuThuePhongBUS phieuThuePhongBUS = new PhieuThuePhongBUS();
                PhieuThuePhongDTO[] phieuThuePhongs = phieuThuePhongBUS.LayDanhSachPhieuThuePhongTrangThai3();
                int lengthOfPhieuThuePhong = 0;

                if (phieuThuePhongs != null)
                {
                    lengthOfPhieuThuePhong = phieuThuePhongs.Length;
                    int n = hoaDons.Length;
                    int stt = 0;

                    for (int i = 0; i < n; i++)
                    {
                        for(int j = 0; j < lengthOfPhieuThuePhong; j++)
                        {
                            if(hoaDons[i].Maphieuthuephong == phieuThuePhongs[j].Ma)
                            {
                                if(dtBD <= phieuThuePhongs[j].ThoiGianNhanPhong && phieuThuePhongs[j].ThoiGianTraPhong <= dtKT)
                                {
                                    CustomDisplayHoaDon customDisplayHoaDon = new CustomDisplayHoaDon();
                                    customDisplayHoaDon.STT = ++stt;
                                    customDisplayHoaDon.MAHD = hoaDons[i].Ma;
                                    customDisplayHoaDon.TENPHONG = phongBUS.LayPhongTheoMaSo(phieuThuePhongs[j].MaPhong).Ten;
                                    customDisplayHoaDon.TENKH = khachHangBUS.LayKhachHangCoMaSo(phieuThuePhongs[j].MaKhachHang).Ten;
                                    customDisplayHoaDon.THOIGIANVAO = phieuThuePhongs[j].ThoiGianNhanPhong;
                                    customDisplayHoaDon.THOIGIANTRA = phieuThuePhongs[j].ThoiGianTraPhong;
                                    customDisplayHoaDon.TONG = hoaDons[i].Tongtien;
                                    customDisplayHoaDon.NVTAO = nhanVienBUS.LayNhanVienCoMaSo(hoaDons[i].Manhanvienlap).Ten;
                                    string strDichVu = suDungDichVuDAO.TinhTongTienSuDungDichVu(hoaDons[i].Maphieuthuephong);
                                    float tongDichVu = 0;
                                    if (!strDichVu.Equals(""))
                                    {
                                        tongDichVu = float.Parse(strDichVu);
                                    }
                                    customDisplayHoaDon.DICHVU = tongDichVu;
                                    lsDisplayHoaDon.Add(customDisplayHoaDon);
                                }
                            }
                        }
                    }
                }
            }
            
            return lsDisplayHoaDon;
        }

        public List<CustomDisplayHoaDon> getCusTomHoaDonsSearch(string key,DateTime dtBD, DateTime dtKT)
        {
            HoaDonDTO[] hoaDons = hoaDonDAO.LayDanhSachHoaDon();
            List<CustomDisplayHoaDon> lsDisplayHoaDon = new List<CustomDisplayHoaDon>();
            PhongBUS phongBUS = new PhongBUS();
            KhachHangBUS khachHangBUS = new KhachHangBUS();
            NhanVienBUS nhanVienBUS = new NhanVienBUS();
            PhieuSuDungDichVuDAO suDungDichVuDAO = new PhieuSuDungDichVuDAO();

            if (hoaDons != null)
            {
                PhieuThuePhongBUS phieuThuePhongBUS = new PhieuThuePhongBUS();
                PhieuThuePhongDTO[] phieuThuePhongs = phieuThuePhongBUS.LayDanhSachPhieuThuePhongTrangThai3();
                int lengthOfPhieuThuePhong = 0;

                if (phieuThuePhongs != null)
                {
                    lengthOfPhieuThuePhong = phieuThuePhongs.Length;
                    int n = hoaDons.Length;
                    int stt = 0;

                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < lengthOfPhieuThuePhong; j++)
                        {
                            if (hoaDons[i].Maphieuthuephong == phieuThuePhongs[j].Ma)
                            {
                                if (dtBD <= phieuThuePhongs[j].ThoiGianNhanPhong && phieuThuePhongs[j].ThoiGianTraPhong <= dtKT)
                                {
                                    CustomDisplayHoaDon customDisplayHoaDon = new CustomDisplayHoaDon();
                                    customDisplayHoaDon.STT = ++stt;
                                    customDisplayHoaDon.MAHD = hoaDons[i].Ma;
                                    customDisplayHoaDon.TENPHONG = phongBUS.LayPhongTheoMaSo(phieuThuePhongs[j].MaPhong).Ten;
                                    customDisplayHoaDon.TENKH = khachHangBUS.LayKhachHangCoMaSo(phieuThuePhongs[j].MaKhachHang).Ten;
                                    customDisplayHoaDon.THOIGIANVAO = phieuThuePhongs[j].ThoiGianNhanPhong;
                                    customDisplayHoaDon.THOIGIANTRA = phieuThuePhongs[j].ThoiGianTraPhong;
                                    customDisplayHoaDon.TONG = hoaDons[i].Tongtien;
                                    customDisplayHoaDon.NVTAO = nhanVienBUS.LayNhanVienCoMaSo(hoaDons[i].Manhanvienlap).Ten;
                                    string strDichVu = suDungDichVuDAO.TinhTongTienSuDungDichVu(hoaDons[i].Maphieuthuephong);
                                    float tongDichVu = 0;
                                    if (!strDichVu.Equals(""))
                                    {
                                        tongDichVu = float.Parse(strDichVu);
                                    }
                                    customDisplayHoaDon.DICHVU = tongDichVu;
                                    lsDisplayHoaDon.Add(customDisplayHoaDon);
                                }
                            }
                        }
                    }
                }
            }

            return lsDisplayHoaDon.Where(ls => ls.MAHD.ToString().Contains(key) || ls.STT.ToString().Contains(key) ||
            ls.TENKH.ToString().Contains(key) || ls.NVTAO.ToString().Contains(key) || ls.TENPHONG.ToString().Contains(key)||
            ls.THOIGIANTRA.ToString().Contains(key) || ls.THOIGIANVAO.ToString().Contains(key)).ToList();
        }

        public List<CustomDisplayHoaDon> getCusTomHoaDonsTheoNgay(DateTime dtBD, DateTime dtKT)
        {
            HoaDonDTO[] hoaDons = hoaDonDAO.LayDanhSachHoaDon();
            List<CustomDisplayHoaDon> lsDisplayHoaDon = new List<CustomDisplayHoaDon>();
            PhongBUS phongBUS = new PhongBUS();
            KhachHangBUS khachHangBUS = new KhachHangBUS();
            NhanVienBUS nhanVienBUS = new NhanVienBUS();
            PhieuSuDungDichVuDAO suDungDichVuDAO = new PhieuSuDungDichVuDAO();

            if (hoaDons != null)
            {
                PhieuThuePhongBUS phieuThuePhongBUS = new PhieuThuePhongBUS();
                PhieuThuePhongDTO[] phieuThuePhongs = phieuThuePhongBUS.LayDanhSachPhieuThuePhongTrangThai3();
                int lengthOfPhieuThuePhong = 0;

                if (phieuThuePhongs != null)
                {
                    lengthOfPhieuThuePhong = phieuThuePhongs.Length;
                    int n = hoaDons.Length;
                    int stt = 0;

                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < lengthOfPhieuThuePhong; j++)
                        {
                            if (hoaDons[i].Maphieuthuephong == phieuThuePhongs[j].Ma)
                            {
                                if (dtBD <= phieuThuePhongs[j].ThoiGianNhanPhong && phieuThuePhongs[j].ThoiGianTraPhong <= dtKT)
                                {
                                    CustomDisplayHoaDon customDisplayHoaDon = new CustomDisplayHoaDon();
                                    customDisplayHoaDon.STT = ++stt;
                                    customDisplayHoaDon.MAHD = hoaDons[i].Ma;
                                    customDisplayHoaDon.TENPHONG = phongBUS.LayPhongTheoMaSo(phieuThuePhongs[j].MaPhong).Ten;
                                    customDisplayHoaDon.TENKH = khachHangBUS.LayKhachHangCoMaSo(phieuThuePhongs[j].MaKhachHang).Ten;
                                    customDisplayHoaDon.THOIGIANVAO = phieuThuePhongs[j].ThoiGianNhanPhong;
                                    customDisplayHoaDon.THOIGIANTRA = phieuThuePhongs[j].ThoiGianTraPhong;
                                    customDisplayHoaDon.TONG = hoaDons[i].Tongtien;
                                    customDisplayHoaDon.NVTAO = nhanVienBUS.LayNhanVienCoMaSo(hoaDons[i].Manhanvienlap).Ten;
                                    string strDichVu = suDungDichVuDAO.TinhTongTienSuDungDichVu(hoaDons[i].Maphieuthuephong);
                                    float tongDichVu = 0;
                                    if (!strDichVu.Equals(""))
                                    {
                                        tongDichVu = float.Parse(strDichVu);
                                    }
                                    customDisplayHoaDon.DICHVU = tongDichVu;
                                    lsDisplayHoaDon.Add(customDisplayHoaDon);
                                }
                            }
                        }
                    }
                }
            }

            return lsDisplayHoaDon.Where(ls => ls.THOIGIANVAO >= dtBD && ls.THOIGIANTRA <= dtKT).ToList();
        }

        public bool LuuHoaDon(HoaDonDTO hoaDonDTO)
		{
			return hoaDonDAO.LuuHoaDon(hoaDonDTO);
		}
    }
}
