using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using DataTranferObject;

namespace PresentationLayer
{
	public partial class ChiTietKhachHang : Form
	{
		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;

		[System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
		public static extern bool ReleaseCapture();

		public DanhSachKhachHang MyParent { get; set; }
		public static int maKH;

		public ChiTietKhachHang()
		{
			InitializeComponent();
		}

		public void formLoad()
		{
			KhachHangDTO khDTO = new KhachHangDTO();
			KhachHangBUS khBUS = new KhachHangBUS();

			khDTO = khBUS.LayKhachHangCoMaSo(maKH);
			txtTenKH.Text = khDTO.Ten;
			txtDiaChi.Text = khDTO.DiaChi;
			txtSDT.Text = khDTO.Sdt;
			txtCMND.Text = khDTO.Scmnd;
			txtQuocTich.Text = khDTO.QuocTich;
			if (khDTO.GioiTinh.Equals("Nam"))
			{
				rbNam.Checked = true;
			}
			else
			{
				rbNu.Checked = true;
			}
		}

		private void bntHuy_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void ChiTietKhachHang_Load(object sender, EventArgs e)
		{
			formLoad();
		}

		private void panlTieuDe_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}

		private void bntCapNhat_Click(object sender, EventArgs e)
		{
			KhachHangDTO khachHangDTO = new KhachHangDTO();
			khachHangDTO.Ma = maKH;
			khachHangDTO.Ten = txtTenKH.Text;
			khachHangDTO.DiaChi = txtDiaChi.Text;
			khachHangDTO.Sdt = txtSDT.Text;
			khachHangDTO.QuocTich = txtQuocTich.Text;
			khachHangDTO.Scmnd = txtCMND.Text;
			if(rbNam.Checked == true)
			{
				khachHangDTO.GioiTinh = "Nam";
			}
			else
			{
				khachHangDTO.GioiTinh = "Nữ";
			}

			KhachHangBUS khachHangBUS = new KhachHangBUS();
			if(khachHangBUS.CapnhatThongTinKhachHang(khachHangDTO))
			{
				MessageBoxDS m = new MessageBoxDS();
				MessageBoxDS.thongbao = "Cập nhập Khách hàng thành công";
				MessageBoxDS.maHinh = 1;
				m.ShowDialog();
			}
			else
			{
				MessageBoxDS m = new MessageBoxDS();
				MessageBoxDS.thongbao = "Cập nhập Khách hàng thất bại";
				MessageBoxDS.maHinh = 2;
				m.ShowDialog();
			}
		}
	}
}
