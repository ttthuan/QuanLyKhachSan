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
	public partial class PhieuSuDungDichVu : Form
	{
		public PhieuThuePhong MyParent { get; set; }
		public TraPhong MyParent1 { get; set; }
		public static int maPhieuthuephong = 0;
		public static int slDVThem;
		public PhieuSuDungDichVu()
		{
			InitializeComponent();
			HienthiComboboxLoaiDichVu();
			HienthiDichVuTheoLoai(int.Parse(cbmLoaiDV.SelectedValue.ToString()));
		}

		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;

		[System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
		public static extern bool ReleaseCapture();

		private void panlTieuDe_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}

		private void PhieuSuDungDichVu_Load(object sender, EventArgs e)
		{
			if(maPhieuthuephong != 0)
			{
				HienthiSuDungDichVu();
			}
		}

		private void HienthiSuDungDichVu()
		{
			PhieuSuDungDichVuBUS phieuSuDungDichVuBUS = new PhieuSuDungDichVuBUS();
			gridDVdangSD.DataSource = phieuSuDungDichVuBUS.LayDanhSachSuDungDichVu(maPhieuthuephong);

			gridDVdangSD.Columns["Maphieuthuephong"].Visible = false;
			gridDVdangSD.Columns["Madichvu"].Visible = false;

			gridDVdangSD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			gridDVdangSD.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			gridDVdangSD.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			gridDVdangSD.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(206, 187, 214);

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

		private void HienthiDichVuTheoLoai(int maLoaiDichVu)
		{
			DichVuBUS dichVuBUS = new DichVuBUS();
			gridDSDV.DataSource = dichVuBUS.LayDanhSachDichVuTheoLoai(int.Parse(cbmLoaiDV.SelectedValue.ToString()));

			gridDSDV.Columns["Ma"].Visible = false;
			gridDSDV.Columns[2].HeaderText = "Dịch Vụ";
			gridDSDV.Columns[3].HeaderText = "Đơn vị tính";
			gridDSDV.Columns["Maloaidichvu"].Visible = false;
			gridDSDV.Columns[5].HeaderText = "Giá";

			gridDSDV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			gridDSDV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			gridDSDV.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			gridDSDV.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(206, 187, 214);
		}

		private void CapnhatSuDungDichVu(PhieuSuDungDichVuDTO phieuSuDungDichVuDTO)
		{
			PhieuSuDungDichVuBUS phieuSuDungDichVuBUS = new PhieuSuDungDichVuBUS();
			if (phieuSuDungDichVuBUS.CapnhatSuDungDichVu(phieuSuDungDichVuDTO))
			{
				MessageBoxDS m = new MessageBoxDS();
				MessageBoxDS.thongbao = "Cập nhật sử dụng dịch vụ thành công!";
				MessageBoxDS.maHinh = 1;
				m.ShowDialog();
			}
			else
			{
				MessageBoxDS m = new MessageBoxDS();
				MessageBoxDS.thongbao = "Cập nhật sử dụng dịch vụ thất bại!";
				MessageBoxDS.maHinh = 3;
				m.ShowDialog();
			}
		}

		private void XoaSuDungDichVu(PhieuSuDungDichVuDTO phieuSuDungDichVuDTO)
		{
			PhieuSuDungDichVuBUS phieuSuDungDichVuBUS = new PhieuSuDungDichVuBUS();
			if (phieuSuDungDichVuBUS.XoaSuDungDichVu(phieuSuDungDichVuDTO))
			{
				MessageBoxDS m = new MessageBoxDS();
				MessageBoxDS.thongbao = "Xóa sử dụng dịch vụ thành công!";
				MessageBoxDS.maHinh = 1;
				m.ShowDialog();
			}
			else
			{
				MessageBoxDS m = new MessageBoxDS();
				MessageBoxDS.thongbao = "Xóa sử dụng dịch vụ thất bại!";
				MessageBoxDS.maHinh = 3;
				m.ShowDialog();
			}
		}

		private void bntHuy_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void cbmLoaiDV_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				HienthiDichVuTheoLoai(int.Parse(cbmLoaiDV.SelectedValue.ToString()));
			}
			catch
			{

			}
		}

		private void gridDVdangSD_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (gridDVdangSD.CurrentCell.ColumnIndex == 0)
			{
				SoLuongDVthem sl = new SoLuongDVthem();
				sl.ShowDialog();

				PhieuSuDungDichVuDTO phieuSuDungDichVuDTO = new PhieuSuDungDichVuDTO();
				phieuSuDungDichVuDTO.Maphieuthuephong = maPhieuthuephong;
				phieuSuDungDichVuDTO.Madichvu = Convert.ToInt32(gridDVdangSD.CurrentRow.Cells["Madichvu"].Value);
				phieuSuDungDichVuDTO.Soluong = slDVThem;

				CapnhatSuDungDichVu(phieuSuDungDichVuDTO);

				HienthiSuDungDichVu();
			}
			else if (gridDVdangSD.CurrentCell.ColumnIndex == 1)
			{
				SoLuongDVthem sl = new SoLuongDVthem();
				sl.ShowDialog();
				if (slDVThem > Convert.ToInt32(gridDVdangSD.CurrentRow.Cells[7].Value)
					|| slDVThem == Convert.ToInt32(gridDVdangSD.CurrentRow.Cells[7].Value))
				{
					MessageBoxDS m = new MessageBoxDS();
					MessageBoxDS.thongbao = "Số lượng trừ bớt phải nhỏ hơn hiện dùng";
					MessageBoxDS.maHinh = 2;
					m.ShowDialog();
				}
				else
				{
					PhieuSuDungDichVuDTO phieuSuDungDichVuDTO = new PhieuSuDungDichVuDTO();
					phieuSuDungDichVuDTO.Maphieuthuephong = maPhieuthuephong;
					phieuSuDungDichVuDTO.Madichvu = Convert.ToInt32(gridDVdangSD.CurrentRow.Cells["Madichvu"].Value);
					phieuSuDungDichVuDTO.Soluong = -slDVThem;

					CapnhatSuDungDichVu(phieuSuDungDichVuDTO);

					HienthiSuDungDichVu();
				}

			}

			else if (gridDVdangSD.CurrentCell.ColumnIndex == 2)
			{
				PhieuSuDungDichVuDTO phieuSuDungDichVuDTO = new PhieuSuDungDichVuDTO();
				phieuSuDungDichVuDTO.Maphieuthuephong = maPhieuthuephong;
				phieuSuDungDichVuDTO.Madichvu = Convert.ToInt32(gridDVdangSD.CurrentRow.Cells["Madichvu"].Value);

				XoaSuDungDichVu(phieuSuDungDichVuDTO);

				HienthiSuDungDichVu();
			}
		}

		private void gridDSDV_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (gridDSDV.CurrentCell.ColumnIndex == 0)
			{
				SoLuongDVthem sl = new SoLuongDVthem();
				sl.ShowDialog();

				PhieuSuDungDichVuDTO phieuSuDungDichVuDTO = new PhieuSuDungDichVuDTO();
				phieuSuDungDichVuDTO.Maphieuthuephong = maPhieuthuephong;
				phieuSuDungDichVuDTO.Madichvu = Convert.ToInt32(gridDSDV.CurrentRow.Cells["Ma"].Value);
				phieuSuDungDichVuDTO.Soluong = slDVThem;

				CapnhatSuDungDichVu(phieuSuDungDichVuDTO);

				HienthiSuDungDichVu();
			}
		}

		private void PhieuSuDungDichVu_FormClosed(object sender, FormClosedEventArgs e)
		{
			MyParent1.HienthiTongTienDichVu();
			MyParent1.HienthiTongTienPhaiTra();
		}
	}
}
