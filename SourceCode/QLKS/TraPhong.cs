using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataTranferObject;
using BusinessLayer;

namespace PresentationLayer
{
	public partial class TraPhong : Form
	{
		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;

		[System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
		public static extern bool ReleaseCapture();

		public static int maKH;
		public static int maP;
		public static int maPhieuthuephong;
		private static int maLoaiThuePhong =-1;
		public static int maTaiKhoan = 0;
		public static bool isSodoKScall = false;
		public static bool result = false;

		public TraPhong()
		{
			InitializeComponent();
		}

		private void TraPhong_Load(object sender, EventArgs e)
		{
			if(isSodoKScall)
			{
				PhieuThuePhongDTO phieuThuePhongDTO = new PhieuThuePhongDTO();
				PhieuThuePhongBUS phieuThuePhongBUS = new PhieuThuePhongBUS();
				phieuThuePhongDTO = phieuThuePhongBUS.DangO_Phong(maP);

				maLoaiThuePhong = phieuThuePhongDTO.MaLoaiThuePhong;
				maPhieuthuephong = phieuThuePhongDTO.Ma;

				PhongDTO phongDTO = new PhongDTO();
				PhongBUS phongBUS = new PhongBUS();
				phongDTO = phongBUS.LayPhongTheoMaSo(phieuThuePhongDTO.MaPhong);

				HienthiKhachhang(phieuThuePhongDTO.MaKhachHang);

				lbTenPhong.Text = phongDTO.Ten;
				dtpkGioBD.Value = phieuThuePhongDTO.ThoiGianNhanPhong;
				dtpkGioKT.Value = phieuThuePhongDTO.ThoiGianTraPhong;
				dtpkNgayBD.Value = phieuThuePhongDTO.ThoiGianNhanPhong;
				dtpkNgayKT.Value = phieuThuePhongDTO.ThoiGianTraPhong;
				lbLoaiDangKy.Text = phongBUS.LayLoaiDangKy(phieuThuePhongDTO.MaLoaiThuePhong);
				lbLoaiPhong.Text = phongBUS.LayLoaiPhong(phongDTO.MaLoaiPhong);

				HienthiGiaPhong(phieuThuePhongDTO.MaLoaiThuePhong, phongDTO.MaLoaiPhong);
				HienthiThoiGian();
				HienthiTongTienDichVu();
				HienthiTongTienPhaiTra();
			}
			else
			{
				PhieuThuePhongDTO phieuThuePhongDTO = new PhieuThuePhongDTO();
				PhieuThuePhongBUS phieuThuePhongBUS = new PhieuThuePhongBUS();
				phieuThuePhongDTO = phieuThuePhongBUS.DangO_KhachHang(maKH);

				maLoaiThuePhong = phieuThuePhongDTO.MaLoaiThuePhong;
				maPhieuthuephong = phieuThuePhongDTO.Ma;

				maP = phieuThuePhongDTO.MaPhong;

				PhongDTO phongDTO = new PhongDTO();
				PhongBUS phongBUS = new PhongBUS();
				phongDTO = phongBUS.LayPhongTheoMaSo(phieuThuePhongDTO.MaPhong);

				HienthiKhachhang(phieuThuePhongDTO.MaKhachHang);

				lbTenPhong.Text = phongDTO.Ten;
				dtpkGioBD.Value = phieuThuePhongDTO.ThoiGianNhanPhong;
				dtpkGioKT.Value = phieuThuePhongDTO.ThoiGianTraPhong;
				dtpkNgayBD.Value = phieuThuePhongDTO.ThoiGianNhanPhong;
				dtpkNgayKT.Value = phieuThuePhongDTO.ThoiGianTraPhong;
				lbLoaiDangKy.Text = phongBUS.LayLoaiDangKy(phieuThuePhongDTO.MaLoaiThuePhong);
				lbLoaiPhong.Text = phongBUS.LayLoaiPhong(phongDTO.MaLoaiPhong);

				HienthiGiaPhong(phieuThuePhongDTO.MaLoaiThuePhong, phongDTO.MaLoaiPhong);
				HienthiThoiGian();
				HienthiTongTienDichVu();
				HienthiTongTienPhaiTra();
			}
		}

		private void HienthiThoiGian()
		{
			string loaiDK = lbLoaiDangKy.Text;
			DateTime s = dtpkNgayBD.Value.Date;
			TimeSpan ts = dtpkGioBD.Value.TimeOfDay;

			switch (loaiDK)
			{
				case "theo ngay":
					dtpkGioKT.Enabled = true;
					dtpkNgayKT.Enabled = true;
					dtpkGioBD.Enabled = true;
					dtpkNgayBD.Enabled = true;
					break;

				case "qua dem":
					dtpkGioKT.Enabled = false;
					dtpkNgayKT.Enabled = false;
					dtpkGioBD.Enabled = false;
					dtpkGioBD.Text = "10:00:00 CH";
					dtpkGioKT.Text = "06:00:00 SA";
					dtpkNgayKT.Value = dtpkNgayBD.Value.AddDays(1);
					break;

				case "1h":
					dtpkGioKT.Enabled = false;
					dtpkNgayKT.Enabled = false;
					dtpkGioBD.Enabled = true;

					s = s.Date + ts;
					s = s.AddHours(1);

					dtpkGioKT.Text = s.TimeOfDay.ToString();
					dtpkNgayKT.Value = s.Date;
					break;

				case "2h":
					dtpkGioKT.Enabled = false;
					dtpkNgayKT.Enabled = false;
					dtpkGioBD.Enabled = true;
					s = s.Date + ts;
					s = s.AddHours(2);

					dtpkGioKT.Text = s.TimeOfDay.ToString();
					dtpkNgayKT.Value = s.Date;
					break;

				case "3h":
					dtpkGioKT.Enabled = false;
					dtpkNgayKT.Enabled = false;
					dtpkGioBD.Enabled = true;
					s = s.Date + ts;
					s = s.AddHours(3);

					dtpkGioKT.Text = s.TimeOfDay.ToString();
					dtpkNgayKT.Value = s.Date;
					break;

				case "4h":
					dtpkGioKT.Enabled = false;
					dtpkNgayKT.Enabled = false;
					dtpkGioBD.Enabled = true;
					s = s.Date + ts;
					s = s.AddHours(4);

					dtpkGioKT.Text = s.TimeOfDay.ToString();
					dtpkNgayKT.Value = s.Date;
					break;
			}
		}

		private void HienthiKhachhang(int maKH)
		{
			KhachHangDTO khachHangDTO = new KhachHangDTO();
			KhachHangBUS khachHangBUS = new KhachHangBUS();
			khachHangDTO = khachHangBUS.LayKhachHangCoMaSo(maKH);

			lbTenKH.Text = khachHangDTO.Ten;
			lbCMND.Text = khachHangDTO.Scmnd;
		}

		private void HienthiGiaPhong(int maLoaiGia, int maLoaiPhong)
		{
			PhongBUS phongBUS = new PhongBUS();
			lbGiaPhong.Text = phongBUS.LayGiaPhong(maLoaiGia, maLoaiPhong).ToString();
			HienthiTraTruoc();
		}

		private void HienthiTraTruoc()
		{
			if(maLoaiThuePhong != 1)
			{
				lbTraTruoc.Text = (int.Parse(lbGiaPhong.Text) / 2).ToString();
			}
			else
			{

				TimeSpan Time = dtpkNgayKT.Value.Date - dtpkNgayBD.Value.Date;
				int TongSoNgay = Time.Days;
				lbTraTruoc.Text = ((int.Parse(lbGiaPhong.Text) / 2)*TongSoNgay).ToString();
			}
		}

		public void HienthiTongTienDichVu()
		{
			PhieuSuDungDichVuBUS phieuSuDungDichVuBUS = new PhieuSuDungDichVuBUS();
			lbTongTienDichVu.Text = phieuSuDungDichVuBUS.TinhTongTienSuDungDichVu(maPhieuthuephong);
			if(lbTongTienDichVu.Text.Equals(""))
			{
				lbTongTienDichVu.Text = "0";
			}
		}

		public void HienthiTongTienPhaiTra()
		{
			TimeSpan Time = dtpkNgayKT.Value.Date - dtpkNgayBD.Value.Date;
			int TongSoNgay = Time.Days;
			if(TongSoNgay == 0)
			{
				TongSoNgay = 1;
			}

			if (txtPhuThu.Text.Equals(""))
			{
				txtPhuThu.Text = "0";
			}

			if (txtGiamTru.Text.Equals(""))
			{
				txtGiamTru.Text = "0";
			}

			TraPhongBUS traPhongBUS = new TraPhongBUS();
			lbTongTien.Text = traPhongBUS.TinhTongTien(float.Parse(lbGiaPhong.Text),
				float.Parse(lbTongTienDichVu.Text), maLoaiThuePhong, TongSoNgay,
				float.Parse(txtGiamTru.Text), float.Parse(txtPhuThu.Text), float.Parse(lbTraTruoc.Text)).ToString();
		}

		private void panlTieuDe_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}

		private void bntHuy_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void bntTraPhong_Click(object sender, EventArgs e)
		{
			try
			{
				//Lưu hóa đơn
				HoaDonDTO hoaDonDTO = new HoaDonDTO();
				hoaDonDTO.Maphieuthuephong = maPhieuthuephong;

				NhanVienBUS nhanVienBUS = new NhanVienBUS();
				hoaDonDTO.Manhanvienlap = nhanVienBUS.LayMaNhanVien(maTaiKhoan);

				hoaDonDTO.Ghichu = txtGhiChu.Text;
				hoaDonDTO.Tongtien = float.Parse(lbTongTien.Text);
				hoaDonDTO.Ngaytao = DateTime.Now.Date;

				HoaDonBUS hoaDonBUS = new HoaDonBUS();
				hoaDonBUS.LuuHoaDon(hoaDonDTO);

				//Cập nhật trạng thái phiếu thuê phòng.
				PhieuThuePhongBUS phieuThuePhongBUS = new PhieuThuePhongBUS();
				phieuThuePhongBUS.CapNhatTinhTrang(maPhieuthuephong, 3);

				MessageBoxDS m = new MessageBoxDS();
				MessageBoxDS.thongbao = "Trả phòng thành công";
				MessageBoxDS.maHinh = 1;
				m.ShowDialog();

				result = true;
			}
			catch
			{
				MessageBoxDS m = new MessageBoxDS();
				MessageBoxDS.thongbao = "Trả phòng thất bại";
				MessageBoxDS.maHinh = 3;
				m.ShowDialog();
			}
		}

		private void bntXemdsDv_Click(object sender, EventArgs e)
		{
			PhieuSuDungDichVu phieuSuDungDichVu = new PhieuSuDungDichVu();
			PhieuSuDungDichVu.maPhieuthuephong = maPhieuthuephong;
			phieuSuDungDichVu.MyParent1 = this;
			phieuSuDungDichVu.ShowDialog();
		}

		private void txtPhuThu_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
				e.Handled = true;
		}

		private void txtGiamTru_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
				e.Handled = true;
		}

		private void txtPhuThu_KeyUp(object sender, KeyEventArgs e)
		{
			HienthiTongTienPhaiTra();
		}

		private void txtGiamTru_KeyUp(object sender, KeyEventArgs e)
		{
			HienthiTongTienPhaiTra();
		}
	}
}
