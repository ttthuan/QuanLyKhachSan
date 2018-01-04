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
		private int _maLoaiphong = 0;
		public static DateTime Ngayden;
		public static DateTime Ngaydi;

		public DatPhong()
		{
			InitializeComponent();
		}

		private void panlTieuDe_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}

		private void formLoad()
		{
			if(maKH != 0)
			{
				KhachHangDTO khachHangDTO = new KhachHangDTO();
				KhachHangBUS khachHangBUS = new KhachHangBUS();

				khachHangDTO = khachHangBUS.LayKhachHangCoMaSo(maKH);

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

				lbTitleTenPhong.Text = "...";
			}
		}

		private void bntHuy_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void bntDatPhong_Click(object sender, EventArgs e)
		{

		}

		private void DatPhong_Load(object sender, EventArgs e)
		{
			formLoad();
		}

		public void thongTinDatPhong(int maPhong, DateTime nhan, DateTime tra)
		{
			PhongDTO phongDTO = new PhongDTO();
			PhongBUS phongBUS = new PhongBUS();

			phongDTO = phongBUS.LayPhongTheoMaSo(maPhong);
			lbTang.Text = phongDTO.Tang.ToString();
			lbTitleTenPhong.Text = phongDTO.Ten.ToString();
			dtpkNgayBD.Value = nhan.Date;
			dtpkNgayKT.Value = tra.Date;
			cbmGioBatdau.SelectedItem = nhan.Hour.ToString();
			cbmGioketthuc.SelectedItem = tra.Hour.ToString();
			lbloaiPhong.Text = phongDTO.MaLoaiPhong.ToString();
		}
		private void btnHienTrangVsDatPhong_Click(object sender, EventArgs e)
		{
			TimPhongTrong pt = new TimPhongTrong();
			pt.MyParent = this;
			pt.ShowDialog();
		}
	}
}
