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

namespace PresentationLayer
{
	public partial class DanhSachDatPhongTheoKhachHang : Form
	{

		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;

		[System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
		public static extern bool ReleaseCapture();

		public DanhSachKhachHang MyParent { get; set; }
		public static int maKH;
		public DanhSachDatPhongTheoKhachHang()
		{
			InitializeComponent();
		}

		private void DanhSachDatPhongTheoKhachHang_Load(object sender, EventArgs e)
		{
			PhieuThuePhongBUS phieuThuePhongBUS = new PhieuThuePhongBUS();
			gridDanhsachphong.DataSource = phieuThuePhongBUS.DanhSachDatPhong(maKH);
			gridDanhsachphong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			gridDanhsachphong.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			gridDanhsachphong.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		}

		private void bntHuy_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void panlTieuDe_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}

		private void btnChiTiet_Click(object sender, EventArgs e)
		{
			if (gridDanhsachphong.Rows.Count != 0)
			{
				Xemchitietdatphong(Convert.ToInt32(gridDanhsachphong.CurrentRow.Cells[0].Value.ToString()));
			}
		}

		private void Xemchitietdatphong(int maPhieuthuephong)
		{
			this.Hide();
			PhieuThuePhong phieuThuePhong = new PhieuThuePhong();
			PhieuThuePhong.maPhieuthuephong = maPhieuthuephong;
			phieuThuePhong.ShowDialog();
			this.Close();
		}

		private void btnNhanPhong_Click(object sender, EventArgs e)
		{
			PhieuThuePhongBUS phieuThuePhongBUS = new PhieuThuePhongBUS();
			if(phieuThuePhongBUS.CapNhatTinhTrang(Convert.ToInt32(gridDanhsachphong.CurrentRow.Cells[0].Value.ToString()), 2))
			{
				MyParent.Load();
			}
		}
	}
}
