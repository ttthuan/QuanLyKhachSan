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
	}
}
