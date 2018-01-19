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
    public partial class DoanhThuGanDay : Form
    {
        // khái báo biến
        int numberLuotThue = 0;
        //int sumPhuThu = 0;
        //int sumTienPhong = 0;
        int sumTienDichVu = 0;
        //int sumGiamTru = 0;
        int sumDoanhThu = 0;

        private HoaDonBUS hoaDonBUS = new HoaDonBUS();

        public DoanhThuGanDay()
        {
            InitializeComponent();
            loadData();
        }
        

        public void loadData()
        {
            // thống kê hôm nay
            List<CustomDisplayHoaDon> lsToday = hoaDonBUS.getCusTomHoaDons(DateTime.Now, DateTime.Now);
            showData(lsToday);
            lbLuotThueHN.Text = numberLuotThue.ToString();
            lbTienDichVuHN.Text = sumTienDichVu.ToString();
            lbTongDoanhThuHN.Text = sumDoanhThu.ToString();

            // thống kê hôm qua
            List<CustomDisplayHoaDon> lsYesterday = hoaDonBUS.getCusTomHoaDonsTheoNgay(DateTime.Now.AddDays(-1), DateTime.Now);
            showData(lsYesterday);
            lbLuotThueHQ.Text = numberLuotThue.ToString();
            lbTienDichVuHQ.Text = sumTienDichVu.ToString();
            lbTongDoanhThuHQ.Text = sumDoanhThu.ToString();

            // thống kê 7 ngày
            List<CustomDisplayHoaDon> ls7Days = hoaDonBUS.getCusTomHoaDonsTheoNgay(DateTime.Now.AddDays(-7), DateTime.Now);
            showData(ls7Days);
            lbLuotThue7.Text = numberLuotThue.ToString();
            lbTienDichVu7.Text = sumTienDichVu.ToString();
            lbTongDoanhThu7.Text = sumDoanhThu.ToString();

            List<CustomDisplayHoaDon> ls30Days = hoaDonBUS.getCusTomHoaDonsTheoNgay(DateTime.Now.AddMonths(-1), DateTime.Now);
            showData(ls30Days);
            lbLuotThue30.Text = numberLuotThue.ToString();
            lbTienDichVu30.Text = sumTienDichVu.ToString();
            lbTongDoanhThu30.Text = sumDoanhThu.ToString();
        }

        public void showData(List<CustomDisplayHoaDon> ls)
        {
            numberLuotThue = 0;
            sumTienDichVu = 0;
            sumDoanhThu = 0;

            if(ls != null && ls.Count != 0)
            {
                numberLuotThue = ls.Count();
                sumTienDichVu = int.Parse(ls.Sum(h => h.DICHVU).ToString());
                sumDoanhThu = int.Parse(ls.Sum(h => h.TONG).ToString());
            }
        }

        private void btnTongKet_Click(object sender, EventArgs e)
        {
            List<CustomDisplayHoaDon> ls = null;
            ls = hoaDonBUS.getCusTomHoaDonsTheoNgay(dtpkNgayBD.Value, dtplNgayKT.Value);

            if (ls != null)
            {
                numberLuotThue = ls.Count();
                sumTienDichVu = int.Parse(ls.Sum(h => h.DICHVU).ToString());
                sumDoanhThu = int.Parse(ls.Sum(h=>h.TONG).ToString());

                lbLuotThue.Text = numberLuotThue.ToString();
                lbTongDoanhThu.Text = sumDoanhThu.ToString();
                lbTienDichVu.Text = sumTienDichVu.ToString();
            }
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            loadData();
        }

        // hàm thông báo lỗi validation cho control textbox
        public bool thongBaoLoi(Control control, string messenger, CancelEventArgs e)
        {
            DateTime batDau = dtpkNgayBD.Value;
            DateTime ketThuc = dtplNgayKT.Value;
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

        private void dtplNgayKT_Validating(object sender, CancelEventArgs e)
        {
            thongBaoLoi(dtplNgayKT, "Ngày kết thúc nhỏ hơn ngày bắt đầu", e);
        }
    }
}
