using DataTranferObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer
{
    public class PhongDAO
    {
        DataProvider dataProvider = new DataProvider();
        public PhongDTO[] LayDanhSachPhong( )
        {
            PhongDTO[] phongs = null;
            string query = "Select * From Phong";
            DataTable tb = new DataTable();
            tb = dataProvider.ExecuteQuery_DataTble(query);
            phongs = new PhongDTO[tb.Rows.Count];

            int n = tb.Rows.Count;

            for (int i = 0; i < n; i++)
            {
                phongs[i] = ChuyenRowThanhObject(tb.Rows[i]);
            }
            return phongs;
        }

        public PhongDTO ChuyenRowThanhObject(DataRow row)
        {
            PhongDTO phong = new PhongDTO();
            phong.Ma = int.Parse(row[0].ToString());
            phong.Ten = row[1].ToString();
            phong.Tang = int.Parse(row[2].ToString());
            phong.MaLoaiPhong = int.Parse(row[3].ToString());

            return phong;
        }

        public int LaySoLuongPhongLonNhatTrongCacTang()
        {
            string query = "select p.Tang , COUNT(p.Ma) as Maxnumber " +
                "from Phong as p " +
                "group by p.Tang having COUNT(p.Ma) >= all ( " +
                "select COUNT(ph.Ma) as countmax " +
                "from Phong as ph " +
                "group by ph.Tang" +
                ")";
            DataTable tb = new DataTable();
            tb = dataProvider.ExecuteQuery_DataTble(query);
            return int.Parse(tb.Rows[0][1].ToString());
        }

		public DataTable LayDanhSachPhongTrong(string time1, string time2, int maLoaiPhong)
		{
			DataTable dataTable = new DataTable();
			string query = "Select * From Phong where Ma not in " +
				"(Select Maphong From Phieuthuephong where(TrangThai = 1 or TrangThai = 2) " +
				"and Thoigiannhanphong >= '"+ time1 + "' " +
				"and Thoigiantraphong <= '"+ time2 + "' )";
			dataTable = dataProvider.ExecuteQuery_DataTble(query);
			return dataTable;
		}

		public PhongDTO LayPhongTheoMaSo(int maPhong)
		{
			PhongDTO phongDTO = new PhongDTO();
			string query = "Select * from Phong where Ma = "+maPhong+"";
			DataTable tb = new DataTable();
			tb = dataProvider.ExecuteQuery_DataTble(query);
			if(tb.Rows.Count != 0)
			{
				phongDTO.Ma = maPhong;
				phongDTO.Ten = tb.Rows[0]["Ten"].ToString();
				phongDTO.Tang = int.Parse(tb.Rows[0]["Tang"].ToString());
				phongDTO.MaLoaiPhong = int.Parse(tb.Rows[0]["Maloaiphong"].ToString());
			}
			return phongDTO;
		}

		public float LayGiaPhong(int maLoaiGia, int maLoaiPhong)
		{
			float giaPhong = 0;
			string query = "Select Gia from Giaphong where Maloaigia = "+maLoaiGia+" and Maloaiphong = "+maLoaiPhong+"";
			DataTable tb = new DataTable();
			tb = dataProvider.ExecuteQuery_DataTble(query);
			if (tb.Rows.Count != 0)
			{
				giaPhong = float.Parse(tb.Rows[0]["Gia"].ToString());
			}
			return giaPhong;
		}

		public string LayLoaiPhong(int maLoaiPhong)
		{
			string query = "Select Ten from Loaiphong where Ma =  " + maLoaiPhong + "";
			string loaiPhong = "";
			DataTable tb = new DataTable();
			tb = dataProvider.ExecuteQuery_DataTble(query);
			if (tb.Rows.Count != 0)
			{
				loaiPhong = tb.Rows[0]["Ten"].ToString();
			}
			return loaiPhong;
		}
		
		public string LayLoaiDangKy(int maLoaiDangKy)
		{
			string query = "Select Tenloaigia from LoaiGia where Maloaigia =  " + maLoaiDangKy + "";
			string loaiDangKy = "";
			DataTable tb = new DataTable();
			tb = dataProvider.ExecuteQuery_DataTble(query);
			if (tb.Rows.Count != 0)
			{
				loaiDangKy = tb.Rows[0]["Tenloaigia"].ToString();
			}
			return loaiDangKy;
		}
	}
}
