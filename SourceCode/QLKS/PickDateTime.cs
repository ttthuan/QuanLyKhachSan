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
    public partial class PickDateTime : Form
    {
        public DateTime batDau;
        public DateTime ketThuc;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public PickDateTime()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            batDau = dtpkNgayBD.Value;
            ketThuc = dtpkNgayKT.Value;
            if(thongBaoLoi(dtpkNgayBD, "Ngày bắt đầu lớn hơn ngày kết thúc", new CancelEventArgs()) == true)
            {
                Close();
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        // hàm thông báo lỗi validation cho control textbox
        public bool thongBaoLoi(Control control, string messenger, CancelEventArgs e)
        {
            batDau = dtpkNgayBD.Value;
            ketThuc = dtpkNgayKT.Value;
            if (batDau.CompareTo(ketThuc) > 0)
            {
                e.Cancel = true;
                control.Focus();
                errorProviderApp.SetError(control, messenger);
                return false;
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(control, "");
                return true;
            }
        }

        private void dtpkNgayBD_Validating(object sender, CancelEventArgs e)
        {
            thongBaoLoi(dtpkNgayBD, "Ngày bắt đầu lớn hơn ngày kết thúc", e);
        }

        private void dtpkNgayKT_Validating(object sender, CancelEventArgs e)
        {
            thongBaoLoi(dtpkNgayBD, "Ngày bắt đầu lớn hơn ngày kết thúc", e);
        }
    }
}
