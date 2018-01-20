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
	public partial class DatPhong : Form
	{
		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;

		[System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
		public static extern bool ReleaseCapture();

		public static int maKH = 0;
		public static int maP = 0;
		public static bool isSodoKScall = false;
		public static bool result = false;
		public static DateTime _thoiGianNhan;
		public static DateTime _thoiGianTra;

		public DatPhong()
		{
			InitializeComponent();
			HienthiComboboxLoaiGia();
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
			maP = 0;
			maKH = 0;
			this.Close();
		}

		private void bntDatPhong_Click(object sender, EventArgs e)
		{
			PhieuThuePhongDTO phieuThuePhongDTO = new PhieuThuePhongDTO();
			phieuThuePhongDTO.MaPhong = maP;
			if(maKH != 0)
			{
				phieuThuePhongDTO.MaKhachHang = maKH;
			}
			else
			{
				phieuThuePhongDTO.MaKhachHang =  ThemKhachHang();
			}
			
			if(isSodoKScall)
			{
				DateTime s = dtpkNgayBD.Value.Date;
				TimeSpan ts = dtpkGioBD.Value.TimeOfDay;
				_thoiGianNhan = s.Date + ts;

				DateTime f = dtpkNgayKT.Value.Date;
				TimeSpan tf = dtpkGioKT.Value.TimeOfDay;
				_thoiGianTra = f.Date + tf;
			}

			phieuThuePhongDTO.ThoiGianNhanPhong = _thoiGianNhan;
			phieuThuePhongDTO.ThoiGianTraPhong = _thoiGianTra;
			phieuThuePhongDTO.MaLoaiThuePhong = int.Parse(cbmLoaiDangKy.SelectedValue.ToString());
			phieuThuePhongDTO.Gia = float.Parse(lbGiaPhong.Text);
			phieuThuePhongDTO.TrangThai = 1;
			phieuThuePhongDTO.TraTruoc = float.Parse(lbTraTruoc.Text);

			PhieuThuePhongBUS phieuThuePhongBUS = new PhieuThuePhongBUS();
			if(phieuThuePhongBUS.ThemPhieuThuePhong(phieuThuePhongDTO))
			{
				MessageBoxDS m = new MessageBoxDS();
				MessageBoxDS.thongbao = "Đặt phòng thành công!";
				MessageBoxDS.maHinh = 1;
				m.ShowDialog();
				result = true;
			}
			else
			{
				MessageBoxDS m = new MessageBoxDS();
				MessageBoxDS.thongbao = "Đặt phòng thất bại!";
				MessageBoxDS.maHinh = 3;
				m.ShowDialog();
			}
		}

		private void DatPhong_Load(object sender, EventArgs e)
		{
			formLoad();
		}

		private void formLoad()
		{
			HienthiComboboxLoaiGia();
			if (!isSodoKScall)
			{
				if (maKH != 0)
				{
					KhachHangDTO khachHangDTO = new KhachHangDTO();
					KhachHangBUS khachHangBUS = new KhachHangBUS();

					khachHangDTO = khachHangBUS.LayKhachHangCoMaSo(maKH);

					dtpkNgayKT.Value = DateTime.Now.Date.AddDays(1);

					txtTenKH.Text = khachHangDTO.Ten;
					txtDiaChi.Text = khachHangDTO.DiaChi;
					txtCMND.Text = khachHangDTO.Scmnd;
					txtQuocTich.Text = khachHangDTO.QuocTich;
					txtSDT.Text = khachHangDTO.Sdt;
					if (khachHangDTO.GioiTinh.Equals("Nam"))
					{
						rbNam.Checked = true;
					}
					else
					{
						rbNu.Checked = true;
					}
					btnHienTrangVsDatPhong.Visible = true;
				}
			}
			else
			{
				HienthithongTinDatPhong(maP,DateTime.Now.AddMinutes(5).Date,DateTime.Now.AddHours(1).Date);
			}
		}

		public void HienthithongTinDatPhong(int maPhong, DateTime nhan, DateTime tra)
		{
			maP = maPhong;
			PhongDTO phongDTO = new PhongDTO();
			PhongBUS phongBUS = new PhongBUS();

			phongDTO = phongBUS.LayPhongTheoMaSo(maPhong);
			lbTang.Text = phongDTO.Tang.ToString();
			lbPhong.Text = phongDTO.Ten.ToString();
			dtpkNgayBD.Value = nhan.Date;
			dtpkNgayKT.Value = tra.Date;
			dtpkGioBD.Text = nhan.TimeOfDay.ToString();
			dtpkGioKT.Text = tra.TimeOfDay.ToString();
			lbloaiPhong.Text = phongBUS.LayLoaiPhong(phongDTO.MaLoaiPhong);
			HienthiGiaPhong(int.Parse(cbmLoaiDangKy.SelectedValue.ToString()),phongDTO.MaLoaiPhong);
			HienthiTraTruoc();
			_thoiGianNhan = nhan;
			_thoiGianTra = tra;
		}

		private void HienthiGiaPhong(int maLoaiGia, int maLoaiPhong)
		{
			PhongBUS phongBUS = new PhongBUS();
			if(cbmLoaiDangKy.Text.Equals("theo ngay"))
			{
				TimeSpan Time = dtpkNgayKT.Value - dtpkNgayBD.Value;
				int TongSoNgay = Time.Days;
				if(TongSoNgay ==0)
				{
					TongSoNgay = 1;
				}
				lbGiaPhong.Text = (float.Parse(phongBUS.LayGiaPhong(maLoaiGia, maLoaiPhong).ToString()) * TongSoNgay).ToString();
			}
			else
			{
				lbGiaPhong.Text = phongBUS.LayGiaPhong(maLoaiGia, maLoaiPhong).ToString();
			}
		}

		private void HienthiTraTruoc()
		{
			lbTraTruoc.Text = (int.Parse(lbGiaPhong.Text) / 2).ToString();
		}

		private void HienthiComboboxLoaiGia()
		{
			LoaiGiaBUS loaiGiaBUS = new LoaiGiaBUS();
			cbmLoaiDangKy.DataSource = loaiGiaBUS.LayDanhSachLoaiGia();
			cbmLoaiDangKy.DisplayMember = "Tenloaigia";
			cbmLoaiDangKy.ValueMember = "Maloaigia";
		}

		private void HienthiThoiGian()
		{
			string loaiDK = cbmLoaiDangKy.Text;
			DateTime s = dtpkNgayBD.Value.Date;
			TimeSpan ts = dtpkGioBD.Value.TimeOfDay;

			switch (loaiDK)
			{
				case "theo ngay":
					dtpkGioKT.Enabled = true;
					dtpkNgayKT.Enabled = true;
					dtpkGioBD.Enabled = true;
					dtpkNgayBD.Enabled = true;

					dtpkGioBD.Text = DateTime.Now.AddMinutes(5).TimeOfDay.ToString();
					dtpkGioKT.Text = DateTime.Now.AddHours(1).TimeOfDay.ToString();
					break;

				case "qua dem":
					dtpkGioKT.Enabled = false;
					dtpkNgayKT.Enabled = false;
					dtpkGioBD.Enabled = false;
					dtpkGioBD.Text = DateTime.Now.AddMinutes(5).TimeOfDay.ToString();
					dtpkGioKT.Text = "06:00:00 SA";
					dtpkNgayKT.Value = dtpkNgayBD.Value.AddDays(1);
					break;

				case "1h":
					dtpkGioKT.Enabled = false;
					dtpkNgayKT.Enabled = false;
					dtpkGioBD.Enabled = true;
					
					s = s.Date + ts;
					s = s.AddHours(1);

					dtpkGioBD.Text = DateTime.Now.AddMinutes(5).TimeOfDay.ToString();
					dtpkGioKT.Text = DateTime.Now.AddHours(1).TimeOfDay.ToString();
					dtpkNgayKT.Value = s.Date;
					break;

				case "2h":
					dtpkGioKT.Enabled = false;
					dtpkNgayKT.Enabled = false;
					dtpkGioBD.Enabled = true;
					s = s.Date + ts;
					s = s.AddHours(2);

					dtpkGioBD.Text = DateTime.Now.AddMinutes(5).TimeOfDay.ToString();
					dtpkGioKT.Text = DateTime.Now.AddHours(2).TimeOfDay.ToString();
					dtpkNgayKT.Value = s.Date;
					break;

				case "3h":
					dtpkGioKT.Enabled = false;
					dtpkNgayKT.Enabled = false;
					dtpkGioBD.Enabled = true;
					s = s.Date + ts;
					s = s.AddHours(3);

					dtpkGioBD.Text = DateTime.Now.AddMinutes(5).TimeOfDay.ToString();
					dtpkGioKT.Text = DateTime.Now.AddHours(3).TimeOfDay.ToString();
					dtpkNgayKT.Value = s.Date;
					break;

				case "4h":
					dtpkGioKT.Enabled = false;
					dtpkNgayKT.Enabled = false;
					dtpkGioBD.Enabled = true;
					s = s.Date + ts;
					s = s.AddHours(4);

					dtpkGioBD.Text = DateTime.Now.AddMinutes(5).TimeOfDay.ToString();
					dtpkGioKT.Text = DateTime.Now.AddHours(4).TimeOfDay.ToString(); ;
					dtpkNgayKT.Value = s.Date;
					break;
			}
		}

		private int ThemKhachHang()
		{
			int maKH = 0;
			KhachHangDTO khachHangDTO = new KhachHangDTO();
			try
			{
				khachHangDTO.Ten = txtTenKH.Text;
				khachHangDTO.DiaChi = txtDiaChi.Text;
				khachHangDTO.Sdt = txtSDT.Text;
				khachHangDTO.Scmnd = txtCMND.Text;
				khachHangDTO.QuocTich = txtQuocTich.Text;
				if(rbNam.Checked == true)
				{
					khachHangDTO.GioiTinh = "Nam";
				}
				else
				{
					khachHangDTO.GioiTinh = "Nữ";
				}
				KhachHangBUS khachHangBUS = new KhachHangBUS();
				maKH = khachHangBUS.ThemKhachHang(khachHangDTO);
			}catch
			{
				MessageBoxDS m = new MessageBoxDS();
				MessageBoxDS.thongbao = "Thông tin khách hàng nhập thiếu hoặc không chính xác !";
				MessageBoxDS.maHinh = 3;
				m.ShowDialog();
			}
			
			return maKH;
		}

		private void btnHienTrangVsDatPhong_Click(object sender, EventArgs e)
		{
			TimPhongTrong pt = new TimPhongTrong();
			pt.MyParent = this;
			pt.isDatPhongCall = true;
			DateTime s = dtpkNgayBD.Value.Date;
			TimeSpan ts = dtpkGioBD.Value.TimeOfDay;
			s = s.Date + ts;

			DateTime f = dtpkNgayKT.Value.Date;
			TimeSpan tf = dtpkGioKT.Value.TimeOfDay;
			f = f.Date + tf;

			pt._thoigianNhan = s;
			pt._thoiGianTra = f;
			pt.ShowDialog();
		}

		private void cbmLoaiDangKy_SelectedIndexChanged(object sender, EventArgs e)
		{
			PhongBUS phongBUS = new PhongBUS();
			if (maP != 0)
			{
				HienthiGiaPhong(int.Parse(cbmLoaiDangKy.SelectedValue.ToString()),phongBUS.LayPhongTheoMaSo(maP).MaLoaiPhong);
				HienthiTraTruoc();
			}
			HienthiThoiGian();
		}

		private void dtpkNgayBD_ValueChanged(object sender, EventArgs e)
		{
			HienthiTraTruoc();
			HienthiThoiGian();
		}

		private void dtpkNgayKT_ValueChanged(object sender, EventArgs e)
		{
			HienthiTraTruoc();

		}

		private void cbmLoaiDangKy_KeyDown(object sender, KeyEventArgs e)
		{
			e.SuppressKeyPress = true;
		}

		private void dtpkGioBD_ValueChanged(object sender, EventArgs e)
		{
			HienthiThoiGian();
		}

		private void btnTimKH_Click(object sender, EventArgs e)
		{
			KhachHangBUS khachHangBUS = new KhachHangBUS();
			KhachHangDTO khachHangDTO = new KhachHangDTO();

			khachHangDTO = khachHangBUS.LayKHtheoSCMND(txtCMND.Text);
			if(khachHangDTO != null)
			{
				txtTenKH.Text = khachHangDTO.Ten;
				txtDiaChi.Text = khachHangDTO.DiaChi;
				txtCMND.Text = khachHangDTO.Scmnd;
				txtQuocTich.Text = khachHangDTO.QuocTich;
				txtSDT.Text = khachHangDTO.Sdt;
				if (khachHangDTO.GioiTinh.Equals("Nam"))
				{
					rbNam.Checked = true;
				}
				else
				{
					rbNu.Checked = true;
				}
			}
		}
	}
}
