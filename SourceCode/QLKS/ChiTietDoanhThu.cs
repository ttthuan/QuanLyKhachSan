using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace PresentationLayer
{
    public partial class ChiTietDoanhThu : Form
    {
        // khai báo biến
        List<BusinessLayer.CustomDisplayHoaDon> ls = null;
        int index = 0;
        int max = 10;
        int page = 0;
        DateTime bd = new DateTime(2018, 1, 1, 0, 0, 0);
        DateTime kt = DateTime.Now;
        SaveFileDialog saveDialog;
        Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
        int numberLuotThue = 0;
        int sumDoanhThu = 0;
        int sumDichVu = 0;

        private HoaDonBUS hoaDonBUS = new HoaDonBUS();

        public ChiTietDoanhThu()
        {
            InitializeComponent();

            ls = hoaDonBUS.getCusTomHoaDons(bd, kt);
            load();
        }
        
        public List<BusinessLayer.CustomDisplayHoaDon> paging(int index, int max)
        {
            return ls.Skip(index).Take(max).ToList();
        }

        public void load()
        {
            lbThoiGian.Text = bd.Date.ToShortDateString() + " - " + kt.Date.ToShortDateString();
            max = int.Parse(cbbNumber.SelectedItem.ToString());
            index = 0;
            page = 0;
            dtgvHoaDon.DataSource = paging(index, max);
            
            dtgvHoaDon.Columns[0].HeaderText = "Stt";
            dtgvHoaDon.Columns[1].HeaderText = "Mã HĐ";
            dtgvHoaDon.Columns[2].HeaderText = "Phòng";
            dtgvHoaDon.Columns[3].HeaderText = "Tên Khách hàng";
            dtgvHoaDon.Columns[4].HeaderText = "Thời gian vào";
            dtgvHoaDon.Columns[5].HeaderText = "Thời gian ra";
            dtgvHoaDon.Columns[6].HeaderText = "Tổng tiền";
            dtgvHoaDon.Columns[7].HeaderText = "Nhân viên lập";

            dtgvHoaDon.Columns[0].Width = 40;
            dtgvHoaDon.Columns[1].Width = 70;
            dtgvHoaDon.Columns[2].Width = 70;
            dtgvHoaDon.Columns[3].Width = 130;
            dtgvHoaDon.Columns[4].Width = 110;
            dtgvHoaDon.Columns[5].Width = 110;
            dtgvHoaDon.Columns[6].Width = 80;
            dtgvHoaDon.Columns[7].Width = 130;
            
        }

        private void showPageNumber()
        {
            btnShow.Text = (page + 1).ToString();
            lbIndex.Text = index.ToString();
            lbMax.Text = (index+max-1).ToString();
            lbSum.Text = ls.Count().ToString();
            if(page >= ls.Count() / max)
            {
                lbMax.Text = (ls.Count()-1).ToString();
            }

            //dtgvHoaDon.Columns.Remove("TIENPHONG");
            //dtgvHoaDon.Columns.Remove("TIENPHUTHU");
            //dtgvHoaDon.Columns.Remove("GIAMTRU");
            //dtgvHoaDon.Columns.Remove("DICHVU");

            hiLight();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            index = 0;
            page = 0;
            dtgvHoaDon.DataSource = paging(index, max);
            showPageNumber();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            page = ls.Count() / max;
            index = page * 10;
            dtgvHoaDon.DataSource = paging(index, max);
            showPageNumber();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            page = page - 1;
            if (page < 0)
                page = ls.Count() / max;
            index = page * max;
            dtgvHoaDon.DataSource = paging(index, max);
            showPageNumber();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            page = page + 1;
            if(page > ls.Count() / max)
            {
                page = 0;
            }
            index = page * max;
            dtgvHoaDon.DataSource = paging(index, max);
            showPageNumber();
        }

        private void btnChonThoiGian_Click(object sender, EventArgs e)
        {
            PickDateTime formPickTime = new PickDateTime();
            formPickTime.ShowDialog();
            if (formPickTime.batDau != null && formPickTime.ketThuc != null)
            {
                bd = formPickTime.batDau;
                kt = formPickTime.ketThuc;
                ls = hoaDonBUS.getCusTomHoaDons(bd, kt);

                lbThoiGian.Text = bd.Date.ToShortDateString() + " - " + kt.Date.ToShortDateString();

                max = int.Parse(cbbNumber.SelectedItem.ToString());
                index = 0;
                page = 0;
                dtgvHoaDon.DataSource = paging(index, max);
                showPageNumber();
                setThongTinDoanhThu();
            }
        }

        private void cbbNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            max = int.Parse(cbbNumber.SelectedItem.ToString());
            index = 0;
            page = 0;
            dtgvHoaDon.DataSource = paging(index, max);
            showPageNumber();
        }

        public void hiLight()
        {
            for(int i = 0; i < dtgvHoaDon.RowCount; i++)
            {
                if(i % 2 != 0)
                {
                    dtgvHoaDon.Rows[i].DefaultCellStyle.BackColor = CSS.rowHilight;
                }
            }
        }

        private void txtSearching_TextChanged(object sender, EventArgs e)
        {
            if(!(string.IsNullOrEmpty(txtSearching.Text) || string.IsNullOrWhiteSpace(txtSearching.Text)))
            {
                ls = hoaDonBUS.getCusTomHoaDonsSearch(txtSearching.Text, bd, kt);
                lbThoiGian.Text = bd.Date.ToShortDateString() + " - " + kt.Date.ToShortDateString();
                max = int.Parse(cbbNumber.SelectedItem.ToString());
                index = 0;
                page = 0;
                dtgvHoaDon.DataSource = paging(index, max);
                showPageNumber();
                setThongTinDoanhThu();
            }
            else
            {
                ls = hoaDonBUS.getCusTomHoaDons(bd, kt);
                lbThoiGian.Text = bd.Date.ToShortDateString() + " - " + kt.Date.ToShortDateString();
                max = int.Parse(cbbNumber.SelectedItem.ToString());
                index = 0;
                page = 0;
                dtgvHoaDon.DataSource = paging(index, max);
                showPageNumber();
                setThongTinDoanhThu();
            }
        }

        private void ChiTietDoanhThu_Load(object sender, EventArgs e)
        {
            showPageNumber();
            setThongTinDoanhThu();
        }

        public void setThongTinDoanhThu()
        {
            if(ls != null)
            {
                numberLuotThue = ls.Count();
                sumDoanhThu = int.Parse(ls.Sum(h=>h.TONG).ToString());
                sumDichVu = int.Parse(ls.Sum(h => h.DICHVU).ToString());

                lbLuotThue.Text = numberLuotThue.ToString();
                lbTongTien.Text = sumDoanhThu.ToString();
                lbDichVu.Text = sumDichVu.ToString();
            }
        }

        struct DataParameter{
            public string fileName;
            public List<BusinessLayer.CustomDisplayHoaDon> ls;
            public int TongLuotThue;
            public int TongDoahThu;
            public int TongDichVu;
        }
        DataParameter parameter;

        private void btnGhiFile_Click(object sender, EventArgs e)
        {
            //Getting the location and file name of the excel to save from user. 
            if (!backgroundWorkerApp.IsBusy)
            {
                saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveDialog.FilterIndex = 2;

                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    // chuyền param qua dowork
                    parameter.fileName = saveDialog.FileName;
                    parameter.ls = ls;
                    parameter.TongLuotThue = numberLuotThue;
                    parameter.TongDoahThu = sumDoanhThu;
                    parameter.TongDichVu = sumDichVu;
                    pbloadding.Visible = true;
                    backgroundWorkerApp.RunWorkerAsync(parameter);
                }
            }
        }

        private void backgroundWorkerApp_DoWork(object sender, DoWorkEventArgs e)
        {
            string fileName = ((DataParameter)e.Argument).fileName;
            List<BusinessLayer.CustomDisplayHoaDon> lsData = ((DataParameter)e.Argument).ls;
            // Creating a Excel object. 
            Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = null;

            try
            {
                worksheet = workbook.ActiveSheet;

                worksheet.Name = "DanhSachHoaDon";
                
                worksheet.Cells[4, 5] = String.Format("Thống kê hóa đơn đã checkin từ {0} đến {1}", bd.ToShortDateString(), kt.ToShortDateString());

                // loop for header text
                for(int i = 0; i < dtgvHoaDon.ColumnCount; i++)
                {
                    worksheet.Cells[7, i + 1] = dtgvHoaDon.Columns[i].HeaderText;
                }

                int cellRowIndex = 8;

                foreach (BusinessLayer.CustomDisplayHoaDon item in lsData)
                {
                    worksheet.Cells[cellRowIndex, 1] = item.STT.ToString();
                    worksheet.Cells[cellRowIndex, 2] = item.MAHD.ToString();
                    worksheet.Cells[cellRowIndex, 3] = item.TENPHONG.ToString();
                    worksheet.Cells[cellRowIndex, 4] = item.TENKH.ToString();
                    worksheet.Cells[cellRowIndex, 5] = item.THOIGIANVAO.ToShortDateString();
                    worksheet.Cells[cellRowIndex, 6] = item.THOIGIANTRA.ToShortDateString();
                    worksheet.Cells[cellRowIndex, 7] = item.TONG.ToString();
                    worksheet.Cells[cellRowIndex++, 8] = item.NVTAO.ToString();
                }

                cellRowIndex += 2;
                worksheet.Cells[cellRowIndex, 5] = "Tổng doanh thu theo danh sách hóa đơn ở bảng trên";
                // in table tổng kết
                cellRowIndex += 3;
                // worksheet.Cells[cellRowIndex, 1] = item.STT.ToString();
                worksheet.Cells[cellRowIndex, 2] = "Lượt thuê";
                worksheet.Cells[cellRowIndex, 3] = "Dịch vụ";
                worksheet.Cells[cellRowIndex, 4] = "Tổng tiền";

                cellRowIndex++;
                worksheet.Cells[cellRowIndex, 1] = "Tổng kết";
                worksheet.Cells[cellRowIndex, 2] = ((DataParameter)e.Argument).TongLuotThue.ToString();
                worksheet.Cells[cellRowIndex, 3] = ((DataParameter)e.Argument).TongDichVu.ToString();
                worksheet.Cells[cellRowIndex, 4] = ((DataParameter)e.Argument).TongDoahThu.ToString();

                workbook.SaveAs(fileName);


            }
            catch (System.Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                excel.Quit();
                workbook = null;
                excel = null;
            }
        }

        private void backgroundWorkerApp_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void backgroundWorkerApp_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                Thread.Sleep(100);
                MessageBoxDS mess = new MessageBoxDS();
                MessageBoxDS.thongbao = "Xuất file hoàn thành";
                MessageBoxDS.maHinh = 1;
                mess.Show();
            }
            else
            {
                Thread.Sleep(100);
                MessageBoxDS mess = new MessageBoxDS();
                MessageBoxDS.thongbao = "Xuất file thất bại";
                MessageBoxDS.maHinh = 3;
                mess.Show();
            }
            pbloadding.Visible = false;
        }
    }
}
