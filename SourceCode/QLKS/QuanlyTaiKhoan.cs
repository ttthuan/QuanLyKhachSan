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

		}

		private void btnCapnhat_Click(object sender, EventArgs e)
		{

		}

		private void btnReset_Click(object sender, EventArgs e)
		{

		}
	}
}
