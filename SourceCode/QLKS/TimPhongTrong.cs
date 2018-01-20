using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using DataTranferObject;

namespace PresentationLayer
{
	public partial class TimPhongTrong : Form
	{
		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;

		[System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
		public static extern bool ReleaseCapture();

		public TimPhongTrong()
		{
			InitializeComponent();
		}

		DataTable dt1 = new DataTable();
		public DatPhong MyParent { get; set; }

		private void bntHuy_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		public delegate void TransferPhongAndNgay(PhongDTO phong, DateTime ngayBD, DateTime ngayKT);
		TransferPhongAndNgay transferPhongAndNgay;

		private void TimPhongTrong_Load(object sender, EventArgs e)
		{
			gridviewPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			gridviewPhong.RowHeadersVisible = false;
			gridviewPhong.ColumnHeadersVisible = false;

			Hienthithoigian();
			LoadPhong();
		}

		private void functionTransferPhongAndNgay(PhongDTO ph, DateTime ngayBD, DateTime ngayKT)
		{
			if (transferPhongAndNgay != null)
			{
				transferPhongAndNgay(ph, ngayBD, ngayKT);
			}
		}

		// khai báo biến
		public bool isSoDoKSCall = false;
		public bool isDatPhongCall = false;
		public DateTime _thoigianNhan;
		public DateTime _thoiGianTra;

		private void LoadPhong()
		{

			DateTime s = dtpkNgayBD.Value.Date;
			TimeSpan ts = dtpkGioDB.Value.TimeOfDay;
			s = s.Date + ts;

			DateTime f = dtpkNgayKT.Value.Date;
			TimeSpan tf = dtpkGioKT.Value.TimeOfDay;
			f = f.Date + tf;

			int loaiphong = 1;
			if (rdbPhongdoi.Checked == true)
			{
				loaiphong = 2;
			}

			PhongBUS phongBUS = new PhongBUS();
			dt1 = phongBUS.LayDanhSachPhongTrong(s.ToString("yyyy-MM-dd HH:mm:ss"), f.ToString("yyyy-MM-dd HH:mm:ss"), loaiphong);
			DataTable dtgrid = new DataTable();
			dtgrid.Columns.Add("1");
			dtgrid.Columns.Add("2");
			dtgrid.Columns.Add("3");
			dtgrid.Columns.Add("4");
			dtgrid.Columns.Add("5");

			for (int i = 0; i < 3; i++)
			{
				DataRow r = dtgrid.NewRow();
				r[0] = (i + 1) + "0" + 1;
				r[1] = (i + 1) + "0" + 2;
				r[2] = (i + 1) + "0" + 3;
				r[3] = (i + 1) + "0" + 4;
				r[4] = (i + 1) + "0" + 5;
				dtgrid.Rows.Add(r);
			}

			gridviewPhong.DataSource = dtgrid;
			foreach (DataGridViewRow row in gridviewPhong.Rows)
			{
				row.Height = 40;
			}

			for (int i = 0; i < 5; i++)
			{
				DataGridViewButtonColumn c = (DataGridViewButtonColumn)gridviewPhong.Columns[i];
				c.FlatStyle = FlatStyle.Flat;
				c.DefaultCellStyle.ForeColor = Color.White;
				c.DefaultCellStyle.BackColor = Color.FromArgb(229, 57, 53);
			}
			gridviewPhong.AllowUserToResizeColumns = false;
			gridviewPhong.AllowUserToResizeRows = false;
			gridviewPhong.CurrentCell = null;

			if (dt1 != null)
			{
				foreach (DataRow r in dt1.Rows)
				{
					int maP = Convert.ToInt32(r["Ma"]);
					if (maP % 5 == 0)
					{
						DataGridViewButtonCell c = (DataGridViewButtonCell)gridviewPhong.Rows[maP / 5 - 1].Cells[4];
						c.Style.BackColor = Color.FromArgb(124, 179, 66);
					}
					else
					{
						DataGridViewButtonCell c = (DataGridViewButtonCell)gridviewPhong.Rows[maP / 5].Cells[maP % 5 - 1];
						c.Style.BackColor = Color.FromArgb(124, 179, 66);
					}
				}
			}
		}

		private void Hienthithoigian()
		{
			if(isDatPhongCall)
			{
				dtpkNgayBD.Value = _thoigianNhan.Date;
				dtpkNgayKT.Value = _thoiGianTra.Date;
				dtpkGioDB.Text = _thoigianNhan.TimeOfDay.ToString();
				dtpkGioKT.Text = _thoiGianTra.TimeOfDay.ToString();
				dtpkNgayBD.Enabled = false;
				dtpkNgayKT.Enabled = false;
			}
			else if(isSoDoKSCall)
			{
				dtpkNgayBD.Value = DateTime.Now.Date.AddDays(1);
				dtpkNgayKT.Value = DateTime.Now.Date.AddDays(1);
				dtpkGioDB.Value = DateTime.Now.Date.AddHours(1);
				dtpkGioKT.Value = DateTime.Now.Date.AddHours(2);
			}
		}

		//Kiểm tra thời gian dtpk
		private bool KTTG()
		{
			DateTime s = dtpkNgayBD.Value.Date;
			TimeSpan ts = dtpkGioDB.Value.TimeOfDay;
			s = s.Date + ts;

			DateTime f = dtpkNgayKT.Value.Date;
			TimeSpan tf = dtpkGioKT.Value.TimeOfDay;
			f = f.Date + tf;

			if (DateTime.Compare(f,s) < 0)
			{
				MessageBoxDS m = new MessageBoxDS();
				MessageBoxDS.thongbao = "Thời gian đến phải nhỏ hơn thời gian đi";
				MessageBoxDS.maHinh = 2;
				m.ShowDialog();
				return false;
			}
			else if (DateTime.Compare(s, DateTime.Now) < 0)
			{
				MessageBoxDS m = new MessageBoxDS();
				MessageBoxDS.thongbao = "Thời gian đến phải lớn hơn hoặc bằng hiện tại";
				MessageBoxDS.maHinh = 2;
				m.ShowDialog();
				return false;
			}
			else
				return true;
		}

		private void gridviewPhong_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (KTTG())
			{
				string str = gridviewPhong.CurrentCell.Value.ToString();
				string str2 = "";
				foreach (DataRow r in dt1.Rows)
				{
					int maP = Convert.ToInt32(r["Ma"]);
					if (maP % 5 == 0)
					{
						str2 = maP / 5 + "0" + 5;
					}
					else
					{
						str2 = maP / 5 + 1 + "0" + maP % 5;
					}
					if (str.CompareTo(str2) == 0)
					{
						//KhachHangDangO kh = new KhachHangDangO();

						DateTime s = dtpkNgayBD.Value.Date;
						TimeSpan ts = dtpkGioDB.Value.TimeOfDay;
						s = s.Date + ts;

						DateTime f = dtpkNgayKT.Value.Date;
						TimeSpan tf = dtpkGioKT.Value.TimeOfDay;
						f = f.Date + tf;

						if (isSoDoKSCall == true)
						{
							isSoDoKSCall = false;
							DatPhong datPhong = new DatPhong();
							DatPhong.maP = maP;
							DatPhong._thoiGianNhan = s;
							DatPhong._thoiGianTra = f;
							datPhong.ShowDialog();
						}
						else
						{
							MyParent.HienthithongTinDatPhong(maP, s, f);
						}
						this.Close();
					}
				}
				gridviewPhong.CurrentCell = null;
			}
		}

		private void panlTieuDe_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}

		private void rdbPhongdon_CheckedChanged(object sender, EventArgs e)
		{
			LoadPhong();
		}

		private void rdbPhongdoi_CheckedChanged(object sender, EventArgs e)
		{
			LoadPhong();
		}
	}
}
