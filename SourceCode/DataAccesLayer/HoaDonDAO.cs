using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTranferObject;

namespace DataAccesLayer
{
    public class HoaDonDAO
    {
        DataProvider dataProvider = new DataProvider();
        public HoaDonDTO[] LayDanhSachHoaDon()
        {
            HoaDonDTO[] hoaDons = null;
            string query = "Select * From Hoadon";
            DataTable tb = new DataTable();
            tb = dataProvider.ExecuteQuery_DataTble(query);
            hoaDons = new HoaDonDTO[tb.Rows.Count];

            int n = tb.Rows.Count;

            for (int i = 0; i < n; i++)
            {
                hoaDons[i] = ChuyenRowThanhObject(tb.Rows[i]);
            }
            return hoaDons;
        }

        public HoaDonDTO ChuyenRowThanhObject(DataRow row)
        {
            HoaDonDTO hoaDon = new HoaDonDTO();
            hoaDon.Ma = int.Parse(row[0].ToString());
            hoaDon.Maphieuthuephong = int.Parse(row[1].ToString());
            hoaDon.Manhanvienlap = int.Parse(row[2].ToString());
            hoaDon.Ngaytao = DateTime.Parse(row[3].ToString());
            hoaDon.Tongtien = float.Parse(row[4].ToString());

            return hoaDon;
        }
    }
}
