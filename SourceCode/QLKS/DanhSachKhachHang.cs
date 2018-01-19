﻿using System;
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
	public partial class DanhSachKhachHang : Form
	{
		public int _loaiKH = 0;

		public DanhSachKhachHang(int loaiKH)
		{
			InitializeComponent();
			_loaiKH = loaiKH;
			Load();
		}

		private void Load()
		{
			if (_loaiKH == 1)
			{
				lbTittle.Text = "Danh sách khách hàng đang ở";
				bntChiTietThuePhong.Visible = true;
				bntTraPhong.Visible = true;

				KhachHangBUS khBus = new KhachHangBUS();
				var source = new BindingSource();
				source.DataSource = khBus.LayDanhSachKhachHangDangO();
				gridKhachHang.DataSource = source;
				TuychinhGridKhachHang();
			}
			else if (_loaiKH == 2)
			{
				lbTittle.Text = "Danh sách khách hàng đang đặt trước";
				bntChiTietThuePhong.Visible = true;

				KhachHangBUS khBus = new KhachHangBUS();
				var source = new BindingSource();
				source.DataSource = khBus.LayDanhSachKhachHangDatPhong();
				gridKhachHang.DataSource = source;
				TuychinhGridKhachHang();
			}
			else if (_loaiKH == 3)
			{
				lbTittle.Text = "Danh sách khách hàng cũ";
				bntDatPhong.Visible = true;

				KhachHangBUS khBus = new KhachHangBUS();
				var source = new BindingSource();
				source.DataSource = khBus.LayDanhSachKhachHangCu();
				gridKhachHang.DataSource = source;
				TuychinhGridKhachHang();
			}
		}

		private void TuychinhGridKhachHang()
		{
			gridKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			gridKhachHang.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		}

		private void bntChiTiet_Click(object sender, EventArgs e)
		{
			if (gridKhachHang.Rows.Count != 0)
			{
				ChiTietKhachHang ct = new ChiTietKhachHang();
				ct.MyParent = this;
				ChiTietKhachHang.maKH = Convert.ToInt32(gridKhachHang.CurrentRow.Cells[0].Value.ToString());
				ct.ShowDialog();
				Load();
			}
		}

		private void bntChiTietThuePhong_Click(object sender, EventArgs e)
		{
			if (gridKhachHang.Rows.Count != 0)
			{
				if (_loaiKH == 1)
				{
					PhieuThuePhong ct = new PhieuThuePhong();
					PhieuThuePhong.maKH = Convert.ToInt32(gridKhachHang.CurrentRow.Cells[0].Value.ToString());
					PhieuThuePhong.dangO = true;
					ct.ShowDialog();
					Load();
				}
				else if (_loaiKH == 2)
				{
					DanhSachDatPhongTheoKhachHang ds = new DanhSachDatPhongTheoKhachHang();
					DanhSachDatPhongTheoKhachHang.maKH = Convert.ToInt32(gridKhachHang.CurrentRow.Cells[0].Value.ToString());
					ds.ShowDialog();
				}
			}
		}

		private void bntDatPhong_Click(object sender, EventArgs e)
		{
			if (gridKhachHang.Rows.Count != 0)
			{
				DatPhong datPhong = new DatPhong();
				DatPhong.maKH = Convert.ToInt32(gridKhachHang.CurrentRow.Cells[0].Value.ToString());
				datPhong.ShowDialog();
				Load();
			}
		}

		private void bntTraPhong_Click(object sender, EventArgs e)
		{
			if (gridKhachHang.Rows.Count != 0)
			{
				TraPhong traPhong = new TraPhong();
				TraPhong.maKH = Convert.ToInt32(gridKhachHang.CurrentRow.Cells[0].Value.ToString());

				traPhong.ShowDialog();
				Load();
			}
		}
	}
}
