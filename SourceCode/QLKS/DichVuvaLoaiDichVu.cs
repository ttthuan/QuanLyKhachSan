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
	public partial class DichVuvaLoaiDichVu : Form
	{
		public DichVuvaLoaiDichVu()
		{
			InitializeComponent();
			
		}

		private void DichVuvaLoaiDichVu_Load(object sender, EventArgs e)
		{
			HienthiLoaidichvu();
			HienthiDichvu();
			HienthiCBMLoai();
			HienthiThongtinDV();
			HienthiThongtinLDV();
		}

		private void HienthiLoaidichvu()
		{
			LoaiDichVuBUS loaiDichVuBUS = new LoaiDichVuBUS();
			gridLoai.DataSource = loaiDichVuBUS.LayDanhSachLoaiDichVu();

			gridLoai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			gridLoai.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			gridLoai.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			gridLoai.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(206, 187, 214);
		}

		private void HienthiCBMLoai()
		{
			LoaiDichVuBUS loaiDichVuBUS = new LoaiDichVuBUS();
			cbmLoai.DataSource = loaiDichVuBUS.LayDanhSachLoaiDichVu();
			cbmLoai.DisplayMember = "Ten";
			cbmLoai.ValueMember = "Ma";
		}
		private void HienthiDichvu()
		{
			DichVuBUS dichVuBUS = new DichVuBUS();
			if (rbLoai.Checked)
			{
				gridDV.DataSource = dichVuBUS.LayDanhSachDichVuTheoLoai(int.Parse(cbmLoai.SelectedValue.ToString()));
				gridDV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
				gridDV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
				gridDV.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(206, 187, 214);
				gridDV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			}
			else
			{
				gridDV.DataSource = dichVuBUS.LayDanhSachDichVu();
				gridDV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
				gridDV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
				gridDV.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(206, 187, 214);
				gridDV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			}
			
		}

		private void HienthiThongtinLDV()
		{
			txtTenLoai.Text = gridLoai.CurrentRow.Cells[1].Value.ToString();
		}

		private void HienthiThongtinDV()
		{
			txtTenDV.Text = gridDV.CurrentRow.Cells[1].Value.ToString();
			txtDonvi.Text = gridDV.CurrentRow.Cells[2].Value.ToString();
			txtGia.Text = gridDV.CurrentRow.Cells[4].Value.ToString();
			cbmLoai.SelectedValue = gridDV.CurrentRow.Cells[3].Value.ToString();
		}

		private void cbmLoai_SelectedIndexChanged(object sender, EventArgs e)
		{
			HienthiDichvu();
		}

		private void rbTatca_CheckedChanged(object sender, EventArgs e)
		{
			HienthiDichvu();
		}

		private void gridLoai_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			HienthiThongtinLDV();
			HienthiDichvu();
		}

		private void gridDV_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			HienthiThongtinDV();
		}

		private void bntCapNhatLoai_Click(object sender, EventArgs e)
		{
			LoaiDichVuBUS loaiDichVuBUS = new LoaiDichVuBUS();
			if(loaiDichVuBUS.CapnhatLDV(txtTenLoai.Text, gridLoai.CurrentRow.Cells[0].Value.ToString()))
			{
				MessageBoxDS m = new MessageBoxDS();
				MessageBoxDS.thongbao = "Cập nhập loại dịch vụ thành công";
				MessageBoxDS.maHinh = 1;
				m.ShowDialog();
			}
			else
			{
				MessageBoxDS m = new MessageBoxDS();
				MessageBoxDS.thongbao = "Cập nhập loại dịch vụ thất bại";
				MessageBoxDS.maHinh = 3;
				m.ShowDialog();
			}
			DichVuvaLoaiDichVu_Load(sender,e);
		}

		private void bntThemLoai_Click(object sender, EventArgs e)
		{
			LoaiDichVuBUS loaiDichVuBUS = new LoaiDichVuBUS();
			if (loaiDichVuBUS.ThemLDV(txtTenLoai.Text))
			{
				MessageBoxDS m = new MessageBoxDS();
				MessageBoxDS.thongbao = "Thêm loại dịch vụ thành công";
				MessageBoxDS.maHinh = 1;
				m.ShowDialog();
			}
			else
			{
				MessageBoxDS m = new MessageBoxDS();
				MessageBoxDS.thongbao = "Thêm loại dịch vụ thất bại";
				MessageBoxDS.maHinh = 3;
				m.ShowDialog();
			}
			DichVuvaLoaiDichVu_Load(sender, e);
		}

		private void bntCapNhatDV_Click(object sender, EventArgs e)
		{
			DichVuDTO dichVuDTO = new DichVuDTO();
			dichVuDTO._Ma = int.Parse(gridDV.CurrentRow.Cells[0].Value.ToString());
			dichVuDTO._Ten = txtTenDV.Text;
			dichVuDTO._Donvitinh = txtDonvi.Text;
			dichVuDTO._Maloaidichvu = int.Parse(cbmLoai.SelectedValue.ToString());
			dichVuDTO._Gia = float.Parse(txtGia.Text);
			DichVuBUS dichVuBUS = new DichVuBUS();
			if(dichVuBUS.CapnhatDV(dichVuDTO))
			{
				MessageBoxDS m = new MessageBoxDS();
				MessageBoxDS.thongbao = "Cập nhật dịch vụ thành công";
				MessageBoxDS.maHinh = 1;
				m.ShowDialog();
				DichVuvaLoaiDichVu_Load(sender, e);
			}
			else
			{
				MessageBoxDS m = new MessageBoxDS();
				MessageBoxDS.thongbao = "Cập nhật dịch vụ thất bại";
				MessageBoxDS.maHinh = 3;
				m.ShowDialog();
			}
		}

		private void bntThemDV_Click(object sender, EventArgs e)
		{
			DichVuDTO dichVuDTO = new DichVuDTO();
			dichVuDTO._Ma = int.Parse(gridDV.CurrentRow.Cells[0].Value.ToString());
			dichVuDTO._Ten = txtTenDV.Text;
			dichVuDTO._Donvitinh = txtDonvi.Text;
			dichVuDTO._Maloaidichvu = int.Parse(cbmLoai.SelectedValue.ToString());
			dichVuDTO._Gia = float.Parse(txtGia.Text);
			DichVuBUS dichVuBUS = new DichVuBUS();
			if (dichVuBUS.ThemDV(dichVuDTO))
			{
				MessageBoxDS m = new MessageBoxDS();
				MessageBoxDS.thongbao = "Thêm dịch vụ thành công";
				MessageBoxDS.maHinh = 1;
				m.ShowDialog();
				DichVuvaLoaiDichVu_Load(sender, e);
			}
			else
			{
				MessageBoxDS m = new MessageBoxDS();
				MessageBoxDS.thongbao = "Thêm dịch vụ thất bại";
				MessageBoxDS.maHinh = 3;
				m.ShowDialog();
			}
		}
	}
}
