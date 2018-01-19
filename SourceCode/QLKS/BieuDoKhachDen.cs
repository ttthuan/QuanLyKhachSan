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
    public partial class BieuDoKhachDen : Form
    {
        // khai báo biến
        int year = DateTime.Now.Year, month = DateTime.Now.Month;
        int lastDay = 0;
        Loading loading = null;
        bool isRun = false;
        List<BusinessLayer.BieuDoKhachDen> ls = null;
        PhieuThuePhongBUS phieuThuePhongBUS = new PhieuThuePhongBUS();

        public BieuDoKhachDen()
        {
            InitializeComponent();
            cbbYear.SelectedIndex = 3;
            cbbMonth.SelectedIndex = 1;
        }

        public void draw()
        {
            tbLuotKhach.ColumnStyles.Clear();
            tbLuotKhach.RowStyles.Clear();
            tbLuotKhach.ColumnCount = 31 + 1;
            tbLuotKhach.RowCount = 4;
            //tbLuotKhach.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            tbLuotKhach.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70));
            for (int i = 0; i < 32; i++)
            {
                tbLuotKhach.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F / (lastDay)));
            }

            for (int i = 0; i < 4; i++)
            {
                tbLuotKhach.RowStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F / 4));
            }
        }

        public void loadData()
        {
            if(tbLuotKhach.Controls.Count != 0)
            {
                tbLuotKhach.Controls.Clear();
            }
            
            //table LuotKhach.
            for (int i = 0; i <= lastDay; i++)
            {
                // khởi tạo một label
                Label lb = new Label();
                if (i == 0)
                // label thời gian
                {
                    lb.Text = "Thời gian";
                }
                else
                {
                    // lable ngày
                    lb.Text = string.Format("{0}", i);
                }
                lb.Font = new Font("Noto Sans", 6, FontStyle.Regular);
                lb.TextAlign = ContentAlignment.MiddleCenter;
                tbLuotKhach.Controls.Add(lb, i, 0);
                lb.Dock = DockStyle.Fill;
            }

            // đổ dữ liệu vào table
            ls = phieuThuePhongBUS.LayDanhSachSoKhachDenTrongThang(year, month);

            if(ls != null)
            {
                for (int i = 0; i <= lastDay; i++)
                {
                    // khởi tạo một label
                    Label lb1 = new Label();
                    Label lb2 = new Label();
                    Label lb3 = new Label();
                    if (i == 0)
                    // label thời gian
                    {
                        lb1.Text = "Thuê ngày";
                        lb2.Text = "Qua đêm";
                        lb3.Text = "Thuê giờ";
                    }
                    else
                    {
                        // lable ngày
                        lb1.Text = ls[i - 1].NUMBERTHUENGAY.ToString();
                        lb2.Text = ls[i - 1].NUMBERQUADEM.ToString();
                        lb3.Text = ls[i - 1].NUMBERTHUEGIO.ToString();
                    }
                    lb1.Font = new Font("Noto Sans", 6, FontStyle.Regular);
                    lb1.TextAlign = ContentAlignment.MiddleCenter;

                    lb2.Font = new Font("Noto Sans", 6, FontStyle.Regular);
                    lb2.TextAlign = ContentAlignment.MiddleCenter;

                    lb3.Font = new Font("Noto Sans", 6, FontStyle.Regular);
                    lb3.TextAlign = ContentAlignment.MiddleCenter;

                    tbLuotKhach.Controls.Add(lb1, i, 1);
                    tbLuotKhach.Controls.Add(lb2, i, 2);
                    tbLuotKhach.Controls.Add(lb3, i, 3);

                    lb1.Dock = DockStyle.Fill;
                    lb2.Dock = DockStyle.Fill;
                    lb3.Dock = DockStyle.Fill;
                }
            }
            
        }

        private void backgroundWorkerApp_DoWork(object sender, DoWorkEventArgs e)
        {
            tbLuotKhach.Invoke((MethodInvoker)delegate {
                if (isRun == false)
                {
                    draw();
                    isRun = true;
                }
                loadData();
            });

            chartLuotKhach.Invoke((MethodInvoker)delegate {
                loadChart();
            });
        }

        private void backgroundWorkerApp_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            
        }

        private void backgroundWorkerApp_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(loading != null)
            {
                loading.Close();
            }
        }

        public void loadChart()
        {
            // load on chart
            //List<DA.CustomeKH> ls = BUS.BUS_DATPHONG.getCustomeKHs(year, month, 1);

            

            if(ls != null)
            {
                List<KhachDenTrongTuan> list = new List<KhachDenTrongTuan>();
                KhachDenTrongTuan khachDenTrongTuan1 = new KhachDenTrongTuan();
                KhachDenTrongTuan khachDenTrongTuan2 = new KhachDenTrongTuan();
                KhachDenTrongTuan khachDenTrongTuan3 = new KhachDenTrongTuan();
                KhachDenTrongTuan khachDenTrongTuan4 = new KhachDenTrongTuan();
                list.Add(khachDenTrongTuan1);
                list.Add(khachDenTrongTuan2);
                list.Add(khachDenTrongTuan3);
                list.Add(khachDenTrongTuan4);
                list[0].WEEKNUMBER = 1;
                list[1].WEEKNUMBER = 2;
                list[2].WEEKNUMBER = 3;
                list[3].WEEKNUMBER = 4;

                foreach (var item in ls)
                {
                    if (item.DAY <= 7)
                    {
                        list[0].NUMBERQUADEM_INWEEK += item.NUMBERQUADEM;
                        list[0].NUMBERTHUEGIO_INWEEK += item.NUMBERTHUEGIO;
                        list[0].NUMBERTHUENGAY_INWEEK += item.NUMBERTHUENGAY;
                    }
                    else if (item.DAY <= 14)
                    {
                        list[1].NUMBERQUADEM_INWEEK += item.NUMBERQUADEM;
                        list[1].NUMBERTHUEGIO_INWEEK += item.NUMBERTHUEGIO;
                        list[1].NUMBERTHUENGAY_INWEEK += item.NUMBERTHUENGAY;
                    }
                    else if (item.DAY <= 21)
                    {
                        list[2].NUMBERQUADEM_INWEEK += item.NUMBERQUADEM;
                        list[2].NUMBERTHUEGIO_INWEEK += item.NUMBERTHUEGIO;
                        list[2].NUMBERTHUENGAY_INWEEK += item.NUMBERTHUENGAY;
                    }
                    else
                    {
                        list[3].NUMBERQUADEM_INWEEK += item.NUMBERQUADEM;
                        list[3].NUMBERTHUEGIO_INWEEK += item.NUMBERTHUEGIO;
                        list[3].NUMBERTHUENGAY_INWEEK += item.NUMBERTHUENGAY;
                    }
                }

                chartLuotKhach.DataSource = list;

                chartLuotKhach.Series["ThueNgay"].XValueMember = "WEEKNUMBER";
                chartLuotKhach.Series["ThueNgay"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
                chartLuotKhach.Series["ThueNgay"].YValueMembers = "NUMBERTHUENGAY_INWEEK";
                chartLuotKhach.Series["ThueNgay"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;

                chartLuotKhach.Series["QuaDem"].XValueMember = "WEEKNUMBER";
                chartLuotKhach.Series["QuaDem"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
                chartLuotKhach.Series["QuaDem"].YValueMembers = "NUMBERQUADEM_INWEEK";
                chartLuotKhach.Series["QuaDem"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;

                chartLuotKhach.Series["ThueGio"].XValueMember = "WEEKNUMBER";
                chartLuotKhach.Series["ThueGio"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
                chartLuotKhach.Series["ThueGio"].YValueMembers = "NUMBERTHUEGIO_INWEEK";
                chartLuotKhach.Series["ThueGio"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if(thongBaoLoi((ComboBox)cbbYear, "Năm không được bỏ trống", new CancelEventArgs()) == true)
            {
                if(thongBaoLoi((ComboBox)cbbMonth, "Tháng không được bỏ trống", new CancelEventArgs()) == true)
                {
                    if(thongBaoLoiDanSoAm((ComboBox)cbbMonth) == true)
                    {
                        loading = new Loading();
                        loading.Show();
                        year = int.Parse(cbbYear.Text.ToString());
                        month = int.Parse(cbbMonth.Text.ToString());
                        lastDay = DateTime.DaysInMonth(year, month);

                        backgroundWorkerApp.RunWorkerAsync();
                    }
                }
            }
        }
        
        public bool thongBaoLoiDanSoAm(ComboBox control)
        {
            if (!string.IsNullOrWhiteSpace(control.Text))
            {
                int value;
                if (int.TryParse(control.Text, out value))
                // là số
                {
                    if (value <= 0)
                    {
                        control.SelectAll();
                        control.Focus();
                        errorProviderApp.SetError(control, "Không được dán số âm!");
                        return false;
                    }
                    if(control.Name == "cbbMonth")
                    {
                        if(value > 12)
                        {
                            control.SelectAll();
                            control.Focus();
                            errorProviderApp.SetError(control, "Tháng không quá 12!");
                            return false;
                        }
                    }
                    return true;
                }
                else
                // không là số
                {
                    control.SelectAll();
                    control.Focus();
                    errorProviderApp.SetError(control, "Chỉ được dán số nguyên!");
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void cbbYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyKeyPressIsNumber(e);
        }

        private void cbbMonth_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyKeyPressIsNumber(e);
        }

        private void cbbYear_TextChanged(object sender, EventArgs e)
        {
            thongBaoLoiDanSoAm(cbbYear);
        }

        private void cbbMonth_TextChanged(object sender, EventArgs e)
        {
            thongBaoLoiDanSoAm(cbbMonth);
        }

        private void cbbYear_Validating(object sender, CancelEventArgs e)
        {
            thongBaoLoi((ComboBox)sender, "Năm không được bỏ trống", e);
        }

        private void cbbMonth_Validating(object sender, CancelEventArgs e)
        {
            thongBaoLoi((ComboBox)sender, "Tháng không được bỏ trống", e);
        }

        // hàm thông báo lỗi validation cho control textbox
        public bool thongBaoLoi(Control control, string messenger, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(control.Text))
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
        
        private void onlyKeyPressIsNumber(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
