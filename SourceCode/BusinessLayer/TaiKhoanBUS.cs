using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataTranferObject;
using DataAccesLayer;
using System.Data;

namespace BusinessLayer
{
	public class TaiKhoanBUS
	{
		TaiKhoanDAO taiKhoanDAO = new TaiKhoanDAO();
		public TaiKhoanDTO KiemtraDangnhap(TaiKhoanDTO taiKhoan)
		{
			taiKhoan = taiKhoanDAO.KiemtraDangnhap(taiKhoan);
			return taiKhoan;
		}

		public bool ThaydoiMK(string ma, string mk)
		{
			return taiKhoanDAO.ThaydoiMK(ma, mk);
		}

		public DataTable LayDanhsachTK()
		{
			return taiKhoanDAO.LayDanhsachTK();
		}
	}
}
