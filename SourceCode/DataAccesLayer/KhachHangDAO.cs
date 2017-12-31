using DataTranferObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer
{
    public class KhachHangDAO
    {
        DataProvider dataProvider = new DataProvider();
        public KhachHangDTO[] LayDanhSachKhachHang()
        {
            KhachHangDTO[] khachHangs = null;
            string query = "Select * From Khachhang";
            DataTable tb = new DataTable();
            tb = dataProvider.ExecuteQuery_DataTble(query);
            khachHangs = new KhachHangDTO[tb.Rows.Count];

            int n = tb.Rows.Count;

            for (int i = 0; i < n; i++)
            {
                khachHangs[i] = ChuyenRowThanhObject(tb.Rows[i]);
            }
            return khachHangs;
        }

        public KhachHangDTO ChuyenRowThanhObject(DataRow row)
        {
            KhachHangDTO khachHang = new KhachHangDTO();
            khachHang.Ma = int.Parse(row[0].ToString());
            khachHang.Ten = row[1].ToString();
            khachHang.DiaChi = row[2].ToString();
            khachHang.Sdt = row[3].ToString();
            khachHang.GioiTinh = row[4].ToString();
            khachHang.Scmnd = row[5].ToString();
            khachHang.QuocTich = row[6].ToString();

            return khachHang;
        }
    }
}
