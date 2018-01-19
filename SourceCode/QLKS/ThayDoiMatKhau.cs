using DataTranferObject;
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
	public partial class ThayDoiMatKhau : Form
	{
		public static TaiKhoanDTO taiKhoan;
		public ThayDoiMatKhau()
		{
			InitializeComponent();
		}

		private void btnThaydoi_Click(object sender, EventArgs e)
		{
			TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();
			if(txtMKcu.Text.Equals(taiKhoan.Matkhau))
			{
				if (taiKhoanBUS.ThaydoiMK(taiKhoan.Ma.ToString(), txtMKmoi.Text))
				{
					MessageBoxDS m = new MessageBoxDS();
					MessageBoxDS.thongbao = "Thay đổi mật khẩu thành công";
					taiKhoan.Matkhau = txtMKmoi.Text;
					MessageBoxDS.maHinh = 1;
					m.ShowDialog();
				}
				else
				{
					MessageBoxDS m = new MessageBoxDS();
					MessageBoxDS.thongbao = "Thay đổi mật khẩu thất bại";
					MessageBoxDS.maHinh = 3;
					m.ShowDialog();
				}
			}
			else
			{
				MessageBoxDS m = new MessageBoxDS();
				MessageBoxDS.thongbao = "Mật khẩu cũ không đúng";
				MessageBoxDS.maHinh = 2;
				m.ShowDialog();
			}
		}
	}
}
