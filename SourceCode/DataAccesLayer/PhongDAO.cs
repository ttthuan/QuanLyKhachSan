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
                phongs[0] = ChuyenRowThanhObject(tb.Rows[i]);
            }
            return phongs;
        }

        public PhongDTO ChuyenRowThanhObject(DataRow row)
        {
            PhongDTO phong = new PhongDTO();
            phong.MA = int.Parse(row[0].ToString());
            phong.TEN = row[1].ToString();
            phong.TANG = int.Parse(row[2].ToString());
            phong.MALOAIPHONG = int.Parse(row[3].ToString());

            return phong;
        }
    }
}
