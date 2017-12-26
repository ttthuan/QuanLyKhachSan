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
	}
}
