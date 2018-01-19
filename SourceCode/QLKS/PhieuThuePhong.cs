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
	public partial class PhieuThuePhong : Form
	{
		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;

		[System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
		public static extern bool ReleaseCapture();

		public static int maKH = 0;
		public static int maP = 0;
		public static int maPhieuthuephong = -1;
		public static bool dangO = false;

		public PhieuThuePhong()
		{
			InitializeComponent();
			HienthiComboboxLoaiDichVu();
			HienthiComboboxDichVuTheoLoai(int.Parse(cbmLoaiDV.SelectedValue.ToString()));
			HienthiComboboxLoaiGia();
			if(dangO)
			{
				bntTraPhong.Text = "Trả phòng";
			}
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

		private void PhieuThuePhong_Load(object sender, EventArgs e)
		{
			if (maPhieuthuephong != -1)
			{
				Hienthithongtinthuephong(maPhieuthuephong);
			}
		}

		private void Hienthithongtinthuephong(int maPhieuthue)
		{
			PhieuThuePhongDTO phieuThuePhongDTO = new PhieuThuePhongDTO();
			PhieuThuePhongBUS phieuThuePhongBUS = new PhieuThuePhongBUS();
			phieuThuePhongDTO = phieuThuePhongBUS.LayPhieuthuephongTheoma(maPhieuthuephong);

			maP = phieuThuePhongDTO.MaPhong;

			PhongDTO phongDTO = new PhongDTO();
			PhongBUS phongBUS = new PhongBUS();
			phongDTO = phongBUS.LayPhongTheoMaSo(phieuThuePhongDTO.MaPhong);

			HienthiComboboxLoaiGia();
			HienthiKhachhang(phieuThuePhongDTO.MaKhachHang);
			
			lbTenPhong.Text = phongDTO.Ten;
			lbTang.Text = phongDTO.Tang.ToString();
			dtpkGioBD.Value = phieuThuePhongDTO.ThoiGianNhanPhong;
			dtpkGioKT.Value = phieuThuePhongDTO.ThoiGianTraPhong;
			dtpkNgayBD.Value = phieuThuePhongDTO.ThoiGianNhanPhong;
			dtpkNgayKT.Value = phieuThuePhongDTO.ThoiGianTraPhong;
			cbmLoaiDangKy.SelectedValue = phieuThuePhongDTO.MaLoaiThuePhong;
			lbLoaiPhong.Text = phongBUS.LayLoaiPhong(phongDTO.MaLoaiPhong);

			HienthiGiaPhong(int.Parse(cbmLoaiDangKy.SelectedValue.ToString()),phongDTO.MaLoaiPhong);
			HienthiThoiGian();
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

		private void HienthiComboboxLoaiGia()
		{
			LoaiGiaBUS loaiGiaBUS = new LoaiGiaBUS();
			cbmLoaiDangKy.DataSource = loaiGiaBUS.LayDanhSachLoaiGia();
			cbmLoaiDangKy.DisplayMember = "Tenloaigia";
			cbmLoaiDangKy.ValueMember = "Maloaigia";
		}

		private void HienthiTraTruoc()
		{
			lbTraTruoc.Text = (int.Parse(lbGiaPhong.Text) / 2).ToString();
		}

		private void HienthiComboboxLoaiDichVu()
		{
			LoaiDichVuBUS loaiDichVuBUS = new LoaiDichVuBUS();
			DataTable dataTable = new DataTable();
			dataTable = loaiDichVuBUS.LayDanhSachLoaiDichVu();
			cbmLoaiDV.DataSource = dataTable;
			cbmLoaiDV.ValueMember = "Ma";
			cbmLoaiDV.DisplayMember = "Ten";
		}

		private void HienthiComboboxDichVuTheoLoai( int maLoaiDichVu)
		{
			DichVuBUS dichVuBUS = new DichVuBUS();
			DataTable dataTable = new DataTable();
			dataTable = dichVuBUS.LayDanhSachDichVuTheoLoai(maLoaiDichVu);
			if(dataTable.Rows.Count > 0)
			{
				cbmDV.DataSource = dataTable;
				cbmDV.ValueMember = "Ma";
				cbmDV.DisplayMember = "Ten";
			}
			else
			{
				cbmDV.Text = "";
			}
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

		private void cbmLoaiDV_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				HienthiComboboxDichVuTheoLoai(int.Parse(cbmLoaiDV.SelectedValue.ToString()));
			}
			catch
			{

			}
		}

		private void lbThemsudungDV_MouseHover(object sender, EventArgs e)
		{
			lbThem.Visible = true;
		}

		private void lbThemsudungDV_MouseLeave(object sender, EventArgs e)
		{
			lbThem.Visible = false;
		}

		private void picboxChiTietDV_MouseHover(object sender, EventArgs e)
		{
			lbtbDVdd.Visible = true;
		}

		private void picboxChiTietDV_MouseLeave(object sender, EventArgs e)
		{
			lbtbDVdd.Visible = false;
		}

		private void cbmLoaiDangKy_SelectedIndexChanged(object sender, EventArgs e)
		{
			PhongBUS phongBUS = new PhongBUS();
			if (maP != 0)
			{
				HienthiGiaPhong(int.Parse(cbmLoaiDangKy.SelectedValue.ToString()), phongBUS.LayPhongTheoMaSo(maP).MaLoaiPhong);
				HienthiTraTruoc();
			}
			HienthiThoiGian();
		}

		private void dtpkGioBD_ValueChanged(object sender, EventArgs e)
		{
			HienthiThoiGian();
		}

		private void lbThemsudungDV_Click(object sender, EventArgs e)
		{
			PhieuSuDungDichVuDTO phieuSuDungDichVuDTO = new PhieuSuDungDichVuDTO();
			phieuSuDungDichVuDTO.Maphieuthuephong = maPhieuthuephong;
			phieuSuDungDichVuDTO.Madichvu = int.Parse(cbmDV.SelectedValue.ToString());
			phieuSuDungDichVuDTO.Soluong = int.Parse(txtSoLuong.Text);

			PhieuSuDungDichVuBUS phieuSuDungDichVuBUS = new PhieuSuDungDichVuBUS();
			if(phieuSuDungDichVuBUS.CapnhatSuDungDichVu(phieuSuDungDichVuDTO))
			{
				MessageBoxDS m = new MessageBoxDS();
				MessageBoxDS.thongbao = "Thêm sử dụng dịch vụ thành công!";
				MessageBoxDS.maHinh = 1;
				m.ShowDialog();
			}
			else
			{
				MessageBoxDS m = new MessageBoxDS();
				MessageBoxDS.thongbao = "Thêm sử dụng dịch vụ thất bại!";
				MessageBoxDS.maHinh = 3;
				m.ShowDialog();
			}
		}

		private void picboxChiTietDV_Click(object sender, EventArgs e)
		{
			PhieuSuDungDichVu phieuSuDungDichVu = new PhieuSuDungDichVu();
			PhieuSuDungDichVu.maPhieuthuephong = maPhieuthuephong;
			phieuSuDungDichVu.MyParent = this;
			phieuSuDungDichVu.ShowDialog();
		}

		private void bntCapNhat_Click(object sender, EventArgs e)
		{
			if(dangO)
			{

			}
			else
			{
				PhieuThuePhongBUS phieuThuePhongBUS = new PhieuThuePhongBUS();
				if(phieuThuePhongBUS.HuyDatPhong(maPhieuthuephong))
				{
					MessageBoxDS m = new MessageBoxDS();
					MessageBoxDS.thongbao = "Hủy đặt phòng thành công!";
					MessageBoxDS.maHinh = 1;
					m.ShowDialog();
				}
				else
				{
					MessageBoxDS m = new MessageBoxDS();
					MessageBoxDS.thongbao = "Hủy đặt phòng thất bại!";
					MessageBoxDS.maHinh = 3;
					m.ShowDialog();
				}
			}
		}
	}
}
