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
			HienthiDanhsachtaikhoan();
			lbTaikhoan.Text = _taiKhoan.Tendangnhap;
			HienthiCBMChucVu();
			HienthithongtinTaikhoan();
		}

		private void HienthiDanhsachtaikhoan()
		{
			TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();
			gridTaikhoan.DataSource = taiKhoanBUS.LayDanhsachTK();
		}

		private void HienthiCBMChucVu()
		{
			NhanVienBUS nhanVienBUS = new NhanVienBUS();
			DataTable dataTable = new DataTable();
			dataTable = nhanVienBUS.LaydanhsachChucvu();

			cbmChucvu.DataSource = dataTable;
			cbmChucvu.DisplayMember = "Ten";
			cbmChucvu.ValueMember = "Ma";

			cbmChucvumoi.DataSource = dataTable;
			cbmChucvumoi.DisplayMember = "Ten";
			cbmChucvumoi.ValueMember = "Ma";
		}

		private void HienthithongtinTaikhoan()
		{
			NhanVienBUS nhanVienBUS = new NhanVienBUS();
			NhanVienDTO nhanVienDTO = new NhanVienDTO();

			nhanVienDTO = nhanVienBUS.LayNhanVienTheoTK(_taiKhoan.Ma);

			txtTen.Text = nhanVienDTO.Ten;
			txtSDT.Text = nhanVienDTO.SDT;
			if(nhanVienDTO.GioiTinh.Equals("Nam"))
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
