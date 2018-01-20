using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DataTranferObject;

namespace DataAccesLayer
{
	public class TaiKhoanDAO
	{
		DataProvider dataProvider = new DataProvider();

		public DataTable LayDanhsachTK()
		{
			string query = "Select * From Taikhoan";
			DataTable tb = new DataTable();
			tb = dataProvider.ExecuteQuery_DataTble(query);
			
			return tb;
		}

		public TaiKhoanDTO KiemtraDangnhap(TaiKhoanDTO taiKhoan)
		{
			string query = "Select * From Taikhoan Where Tendangnhap = '"+taiKhoan.Tendangnhap+"' and Matkhau = '"+taiKhoan.Matkhau+"'";
			DataTable tb = new DataTable();
			tb = dataProvider.ExecuteQuery_DataTble(query);
			if(tb.Rows.Count > 0 && tb != null)
			{
				foreach (DataRow row in tb.Rows)
				{
					taiKhoan.Ma = int.Parse(row[0].ToString());
					taiKhoan.Tendangnhap = row[1].ToString();
					taiKhoan.Matkhau = row[2].ToString();
				}
				return taiKhoan;
			}
			return null;
		}

		public bool ThaydoiMK(string ma, string mk)
		{
			string query = "UPDATE Taikhoan Set Matkhau = N'" + mk + "' where Ma = " + ma + "";
			try
			{
				dataProvider.ExecuteUpdateQuery(query);
				return true;
			}
			catch
			{
				return false;
			}
		}

		public bool KiemtraTrungThemNV(string tenDN)
		{
			string query = "Select * From Taikhoan Where Tendangnhap = N'" + tenDN + "'";
			DataTable tb = new DataTable();
			tb = dataProvider.ExecuteQuery_DataTble(query);
			if (tb.Rows.Count > 0 && tb != null)
			{
				return false;
			}
			return true;
		}

		public bool KiemtraTrungCapnhatNV(string maNV,string tenDN)
		{
			string query = "Select * From Nhanvien nv,Taikhoan tk Where nv.Mataikhoan = tk.Ma and tk.Tendangnhap = N'"+tenDN+"' and nv.Ma != "+maNV+"";
			DataTable tb = new DataTable();
			tb = dataProvider.ExecuteQuery_DataTble(query);
			if (tb.Rows.Count > 0 && tb != null)
			{
				return false;
			}
			return true;
		}

		public string ThemTaikhoan(string tenTK)
		{
			string query = "insert into Taikhoan(Tendangnhap, Matkhau) Values('"+ tenTK + "','123')";
			try
			{
				dataProvider.ExecuteUpdateQuery(query);
				string query1 = "select max(Ma) from Taikhoan";
				DataTable tb = new DataTable();
				tb = dataProvider.ExecuteQuery_DataTble(query1);
				return tb.Rows[0][0].ToString();
			}
			catch
			{
				return "";
			}
		}

		public bool ResetMK(string ma)
		{
			string query = "UPDATE Taikhoan Set Matkhau = N'123' where Ma = " + ma + "";
			try
			{
				dataProvider.ExecuteUpdateQuery(query);
				return true;
			}
			catch
			{
				return false;
			}
		}
	}
}
