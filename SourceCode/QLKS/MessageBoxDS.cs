using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataTranferObject
{
	public partial class MessageBoxDS : Form
	{
		public static string thongbao = "";
		public static int maHinh = 1;
		public MessageBoxDS()
		{
			InitializeComponent();
		}


		private void bntDangNhap_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void MessageBoxDS_Load(object sender, EventArgs e)
		{
			txtthongbao.Text = thongbao;
			if (maHinh == 1)
			{
				pictureBox1.Image = Image.FromFile(@"..\..\Resources\success.png");
			}
			else if (maHinh == 2)
			{
				pictureBox1.Image = Image.FromFile(@"..\..\Resources\warnig.png");
			}
			else if (maHinh == 3)
			{
				pictureBox1.Image = Image.FromFile(@"..\..\Resources\fail.png");
			}
		}
	}
}
