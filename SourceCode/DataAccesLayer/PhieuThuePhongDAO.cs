using DataTranferObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer
{
    public class PhieuThuePhongDAO
    {
        DataProvider dataProvider = new DataProvider();
        public PhieuThuePhongDTO[] LayDanhSachPhieuThuePhong()
        {
            PhieuThuePhongDTO[] phieuThuePhongs = null;
            string query = "Select * From PhieuThuePhong";
            DataTable tb = new DataTable();
            tb = dataProvider.ExecuteQuery_DataTble(query);
            phieuThuePhongs = new PhieuThuePhongDTO[tb.Rows.Count];

            int n = tb.Rows.Count;

            for (int i = 0; i < n; i++)
            {
                phieuThuePhongs[i] = ChuyenRowThanhObject(tb.Rows[i]);
            }
            return phieuThuePhongs;
        }

        public PhieuThuePhongDTO ChuyenRowThanhObject(DataRow row)
        {
            PhieuThuePhongDTO phieuThuePhong = new PhieuThuePhongDTO();
            phieuThuePhong.Ma = int.Parse(row[0].ToString());
            phieuThuePhong.MaPhong = int.Parse(row[1].ToString());
            phieuThuePhong.MaKhachHang = int.Parse(row[2].ToString());
            phieuThuePhong.ThoiGianNhanPhong = DateTime.Parse(row[3].ToString());
            phieuThuePhong.ThoiGianTraPhong = DateTime.Parse(row[4].ToString());
            phieuThuePhong.MaLoaiThuePhong = int.Parse(row[5].ToString());
            phieuThuePhong.Gia = float.Parse(row[6].ToString());
            phieuThuePhong.TrangThai = int.Parse(row[7].ToString());

            return phieuThuePhong;
        }
    }
}
