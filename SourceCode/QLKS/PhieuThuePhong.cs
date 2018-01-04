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

		public static int maKH;
		public static int maPhieuthuephong = -1;

		public PhieuThuePhong()
		{
			InitializeComponent();
			HienthiComboboxLoaiDichVu();
			HienthiComboboxDichVuTheoLoai(int.Parse(cbmLoaiDV.SelectedValue.ToString()));
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

			KhachHangDTO khachHangDTO = new KhachHangDTO();
			KhachHangBUS khachHangBUS = new KhachHangBUS();
			khachHangDTO = khachHangBUS.LayKhachHangCoMaSo(phieuThuePhongDTO.MaKhachHang);

			PhongDTO phongDTO = new PhongDTO();
			PhongBUS phongBUS = new PhongBUS();
			phongDTO = phongBUS.LayPhongTheoMaSo(phieuThuePhongDTO.MaPhong);

			HienthiComboboxLoaiGia();

			lbTenKH.Text = khachHangDTO.Ten;
			lbCMND.Text = khachHangDTO.Scmnd;
			lbTenPhong.Text = phongDTO.Ten;
			lbTang.Text = phongDTO.Tang.ToString();
			dtpkGioDB.Value = phieuThuePhongDTO.ThoiGianNhanPhong;
			dtpkGioKT.Value = phieuThuePhongDTO.ThoiGianTraPhong;
			dtpkNgayBD.Value = phieuThuePhongDTO.ThoiGianNhanPhong;
			dtpkNgayKT.Value = phieuThuePhongDTO.ThoiGianTraPhong;
			cbmLoaiDangKy.SelectedValue = phieuThuePhongDTO.MaLoaiThuePhong;
			lbLoaiPhong.Text = phongBUS.LayLoaiPhong(phongDTO.MaLoaiPhong);

			HienthiGiaPhong(int.Parse(cbmLoaiDangKy.SelectedValue.ToString()),phongDTO.MaLoaiPhong);
		}

		private void HienthiGiaPhong(int maLoaiGia, int maLoaiPhong)
		{
			PhongBUS phongBUS = new PhongBUS();
			txtGiaPhong.Text = phongBUS.LayGiaPhong(maLoaiGia, maLoaiPhong).ToString();
		}

		private void HienthiComboboxLoaiGia()
		{
			LoaiGiaBUS loaiGiaBUS = new LoaiGiaBUS();
			cbmLoaiDangKy.DataSource = loaiGiaBUS.LayDanhSachLoaiGia();
			cbmLoaiDangKy.DisplayMember = "Tenloaigia";
			cbmLoaiDangKy.ValueMember = "Maloaigia";
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
	}
}
