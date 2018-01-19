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
                                    //customDisplayHoaDon.DICHVU = 
                                    lsDisplayHoaDon.Add(customDisplayHoaDon);
                                }
                            }
                        }
                    }
                }
            }
            
            return lsDisplayHoaDon;
        }

		public bool LuuHoaDon(HoaDonDTO hoaDonDTO)
		{
			return hoaDonDAO.LuuHoaDon(hoaDonDTO);
		}
	}
}
