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
	public partial class QuanlyTaiKhoan : Form
	{
		private static TaiKhoanDTO _taiKhoan = null;
		public QuanlyTaiKhoan(TaiKhoanDTO taiKhoan)
		{
			InitializeComponent();
			_taiKhoan = taiKhoan;
			Hienthi();
		}

		private void Hienthi()
		{
			HienthiDanhsachNhanvien();
			HienthiCBMChucVu();
		}

		private void HienthiDanhsachNhanvien()
		{
			NhanVienBUS nhanVienBUS = new NhanVienBUS();
			gridNhanVien.DataSource = nhanVienBUS.LaydanhsachNhanvienDataTable();
			gridNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			gridNhanVien.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			gridNhanVien.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			gridNhanVien.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(206, 187, 214);
		}

		private void HienthiCBMChucVu()
		{
			NhanVienBUS nhanVienBUS = new NhanVienBUS();
			cbmChucvu.DataSource = nhanVienBUS.LaydanhsachChucvu();
			cbmChucvu.DisplayMember = "Ten";
			cbmChucvu.ValueMember = "Ma";
			
		}

		private void HienthithongtinTaikhoan()
		{
			txtTaiKhoan.Text = gridNhanVien.CurrentRow.Cells[9].Value.ToString();
			txtSDT.Text = gridNhanVien.CurrentRow.Cells[2].Value.ToString();
			txtDiaChi.Text = gridNhanVien.CurrentRow.Cells[3].Value.ToString();
			cbmChucvu.SelectedValue = gridNhanVien.CurrentRow.Cells[7].Value.ToString();
			if(gridNhanVien.CurrentRow.Cells[4].Value.ToString().Equals("Nam"))
			{
				rbNam.Checked = true;
			}
			else
			{
				rbNu.Checked = true;
			}
			txtTen.Text = gridNhanVien.CurrentRow.Cells[1].Value.ToString();
			dtpkNgaySinh.Text = gridNhanVien.CurrentRow.Cells[5].Value.ToString();
		}

		private void gridNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			HienthithongtinTaikhoan();
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();
			try
			{
				if (taiKhoanBUS.KiemtraTrungThemNV(txtTaiKhoan.Text))
				{
					NhanVienDTO nhanVienDTO = new NhanVienDTO();
					nhanVienDTO.Ten = txtTen.Text;
					nhanVienDTO.SDT = txtSDT.Text;
					nhanVienDTO.Maloainhanvien = int.Parse(cbmChucvu.SelectedValue.ToString());
					nhanVienDTO.NgaySinh = dtpkNgaySinh.Value.Date;
					nhanVienDTO.Mataikhoan = int.Parse(taiKhoanBUS.ThemTaikhoan(txtTaiKhoan.Text));
					nhanVienDTO.DiaChi = txtDiaChi.Text;
					if (rbNam.Checked)
					{
						nhanVienDTO.GioiTinh = "Nam";
					}
					else
					{
						nhanVienDTO.GioiTinh = "Nữ";
					}

					NhanVienBUS nhanVienBUS = new NhanVienBUS();
					if (nhanVienBUS.ThemNhanvien(nhanVienDTO))
					{
						MessageBoxDS m = new MessageBoxDS();
						MessageBoxDS.thongbao = "Thêm nhân viên thành công";
						MessageBoxDS.maHinh = 1;
						m.ShowDialog();
						Hienthi();
					}
					else
					{
						MessageBoxDS m = new MessageBoxDS();
						MessageBoxDS.thongbao = "Thêm nhân viên thất bại";
						MessageBoxDS.maHinh = 3;
						m.ShowDialog();
					}

				}
				else
				{
					MessageBoxDS m = new MessageBoxDS();
					MessageBoxDS.thongbao = "Tên đăng nhập đã tồn tại";
					MessageBoxDS.maHinh = 2;
					m.ShowDialog();
				}
			}
			catch
			{
				MessageBoxDS m = new MessageBoxDS();
				MessageBoxDS.thongbao = "Nhập chưa đầy đủ thông tin";
				MessageBoxDS.maHinh = 2;
				m.ShowDialog();
			}
		}

		private void btnCapnhat_Click(object sender, EventArgs e)
		{
			TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();
			try
			{
				if (taiKhoanBUS.KiemtraTrungCapnhatDN(gridNhanVien.CurrentRow.Cells[0].Value.ToString(), txtTaiKhoan.Text))
				{
					NhanVienDTO nhanVienDTO = new NhanVienDTO();
					nhanVienDTO.Ma = int.Parse(gridNhanVien.CurrentRow.Cells[0].Value.ToString());
					nhanVienDTO.Ten = txtTen.Text;
					nhanVienDTO.SDT = txtSDT.Text;
					nhanVienDTO.Maloainhanvien = int.Parse(cbmChucvu.SelectedValue.ToString());
					nhanVienDTO.NgaySinh = dtpkNgaySinh.Value.Date;
					nhanVienDTO.Mataikhoan = int.Parse(taiKhoanBUS.ThemTaikhoan(txtTaiKhoan.Text));
					nhanVienDTO.DiaChi = txtDiaChi.Text;
					if (rbNam.Checked)
					{
						nhanVienDTO.GioiTinh = "Nam";
					}
					else
					{
						nhanVienDTO.GioiTinh = "Nữ";
					}

					NhanVienBUS nhanVienBUS = new NhanVienBUS();
					if (nhanVienBUS.CapnhatNhanvien(nhanVienDTO))
					{
						MessageBoxDS m = new MessageBoxDS();
						MessageBoxDS.thongbao = "Cập nhật nhân viên thành công";
						MessageBoxDS.maHinh = 1;
						m.ShowDialog();
						Hienthi();
					}
					else
					{
						MessageBoxDS m = new MessageBoxDS();
						MessageBoxDS.thongbao = "Cập nhật nhân viên thất bại";
						MessageBoxDS.maHinh = 3;
						m.ShowDialog();
					}

				}
				else
				{
					MessageBoxDS m = new MessageBoxDS();
					MessageBoxDS.thongbao = "Tên đăng nhập đã tồn tại";
					MessageBoxDS.maHinh = 2;
					m.ShowDialog();
				}
			}
			catch
			{
				MessageBoxDS m = new MessageBoxDS();
				MessageBoxDS.thongbao = "Nhập chưa đầy đủ thông tin";
				MessageBoxDS.maHinh = 2;
				m.ShowDialog();
			}
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();
			if (taiKhoanBUS.ResetMK(gridNhanVien.CurrentRow.Cells[6].Value.ToString()))
			{
				MessageBoxDS m = new MessageBoxDS();
				MessageBoxDS.thongbao = "Reset mật khẩu thành công";
				MessageBoxDS.maHinh = 1;
				m.ShowDialog();
				Hienthi();
			}
			else
			{
				MessageBoxDS m = new MessageBoxDS();
				MessageBoxDS.thongbao = "Reset mật khẩu thất bại";
				MessageBoxDS.maHinh = 3;
				m.ShowDialog();
			}
		}
	}
}
