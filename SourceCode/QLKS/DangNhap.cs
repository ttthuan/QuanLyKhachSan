using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataTranferObject;
using BusinessLayer;

namespace PresentationLayer
{
	public partial class DangNhap : Form
	{
		public DangNhap()
		{
			InitializeComponent();
		}

		//Sự kiện các control
		private void picClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void bntDangNhap_Click(object sender, EventArgs e)
		{
			KiemtraDangnhap();
		}

		private void picReset_Click(object sender, EventArgs e)
		{
			txtTaiKhoan.Text = "";
			txtMatKhau.Text = "";
		}

		private void DangNhap_Load(object sender, EventArgs e)
		{
			txtTaiKhoan.ForeColor = Color.LightGray;
			txtTaiKhoan.Text = "Nhập Tài khoản";

			pictureBox5.Image = Image.FromFile(@"..\..\Resources\eye-off.png");
			txtMatKhau.ForeColor = Color.LightGray;
			txtMatKhau.Text = "Nhập Mật khẩu";
			txtMatKhau.PasswordChar = '\0';
		}

		private void txtTaiKhoan_MouseEnter(object sender, EventArgs e)
		{
			if (txtTaiKhoan.Text == "Nhập Tài khoản")
			{
				txtTaiKhoan.Text = "";
				txtTaiKhoan.ForeColor = Color.Black;
			}
		}

		private void txtTaiKhoan_MouseLeave(object sender, EventArgs e)
		{
			if (txtTaiKhoan.Text == "")
			{
				txtTaiKhoan.Text = "Nhập Tài khoản";
				txtTaiKhoan.ForeColor = Color.LightGray;
			}
		}

		private void txtTaiKhoan_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				KiemtraDangnhap();
			}
			else
			{
				if (txtTaiKhoan.Text == "Nhập Tài khoản")
				{
					txtTaiKhoan.Text = "";
					txtTaiKhoan.ForeColor = Color.Black;
				}
			}
		}

		private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				KiemtraDangnhap();
			}
			else
			{
				if (txtMatKhau.Text == "Nhập Mật khẩu")
				{
					txtMatKhau.Text = "";
				}
				txtMatKhau.ForeColor = Color.Black;
				txtMatKhau.PasswordChar = '*';
				pictureBox5.Image = Image.FromFile(@"..\..\Resources\eye.png");
			}
		}

		private void txtMatKhau_MouseEnter(object sender, EventArgs e)
		{
			if (txtMatKhau.Text == "Nhập Mật khẩu")
			{
				txtMatKhau.Text = "";
				txtMatKhau.ForeColor = Color.Black;
				if (pictureBox5.Image == Image.FromFile(@"..\..\Resources\eye.png"))
				{
					txtMatKhau.PasswordChar = '*';
				}
				else if (pictureBox5.Image == Image.FromFile(@"..\..\Resources\eye-off.png"))
				{
					txtMatKhau.PasswordChar = '\0';
				}
			}
		}

		private void txtMatKhau_MouseLeave(object sender, EventArgs e)
		{
			if (txtMatKhau.Text == "")
			{
				txtMatKhau.PasswordChar = '\0';
				txtMatKhau.Text = "Nhập Mật khẩu";
				txtMatKhau.ForeColor = Color.LightGray;
			}
		}

		private void pictureBox5_MouseDown(object sender, MouseEventArgs e)
		{
			pictureBox5.Image = Image.FromFile(@"..\..\Resources\eye-off.png");
			txtMatKhau.PasswordChar = '\0';
		}

		private void pictureBox5_MouseUp(object sender, MouseEventArgs e)
		{
			pictureBox5.Image = Image.FromFile(@"..\..\Resources\eye.png");
			txtMatKhau.PasswordChar = '*';
		}

		private void bntDangNhap_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				KiemtraDangnhap();
			}
		}


		//Hàm xử lý

		private void KiemtraDangnhap()
		{
			TaiKhoanDTO taiKhoan = new TaiKhoanDTO();
			taiKhoan.Ma = 1;
			taiKhoan.Tendangnhap = txtTaiKhoan.Text;
			taiKhoan.Matkhau = txtMatKhau.Text;

			TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();
			taiKhoan = taiKhoanBUS.KiemtraDangnhap(taiKhoan);

			if(taiKhoan != null)
			{
				this.Hide();
				ControllerSV objSV = new ControllerSV();
				objSV.taiKhoan = taiKhoan;
				FormMain form = new FormMain(objSV);
				form.ShowDialog();
				//Show();
				this.Close();
			}
			else
			{
				MessageBoxDS m = new MessageBoxDS();
				MessageBoxDS.thongbao = "Đăng nhập thất bại!";
				MessageBoxDS.maHinh = 3;
				m.ShowDialog();
			}
		}
	}
}
