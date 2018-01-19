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
	public partial class SoLuongDVthem : Form
	{
		public SoLuongDVthem()
		{
			InitializeComponent();
		}
		public PhieuSuDungDichVu MyParent1 { get; set; }

		private void onlyKeyPressIsNumber(KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void txtSL_KeyPress(object sender, KeyPressEventArgs e)
		{
			onlyKeyPressIsNumber(e);
		}

		private void bntOk_Click(object sender, EventArgs e)
		{
			if (txtSL.Text == "" || txtSL.Text == "0")
			{
				MessageBoxDS m = new MessageBoxDS();
				MessageBoxDS.thongbao = "Cần nhập số lượng lớn hơn 0";
				MessageBoxDS.maHinh = 2;
				m.ShowDialog();
			}
			else
			{
				PhieuSuDungDichVu.slDVThem = Convert.ToInt32(txtSL.Text);
				this.Close();
			}
		}

		private void SoLuongDVthem_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				this.bntOk_Click(sender, e);
			}
		}
	}
}
