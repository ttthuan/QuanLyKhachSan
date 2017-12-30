using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
			}
			else if (_loaiKH == 2)
			{
				lbTittle.Text = "Danh sách khách hàng đang đặt trước";
				bntChiTietThuePhong.Visible = true;
			}
			else if (_loaiKH == 3)
			{
				lbTittle.Text = "Danh sách khách hàng cũ";
				bntDatPhong.Visible = true;
			}
		}
	}
}
