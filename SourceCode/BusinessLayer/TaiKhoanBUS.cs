using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataTranferObject;
using DataAccesLayer;

namespace BusinessLayer
{
	public class TaiKhoanBUS
	{
		public TaiKhoanDTO KiemtraDangnhap(TaiKhoanDTO taiKhoan)
		{
			TaiKhoanDAO taiKhoanDAO = new TaiKhoanDAO();
			taiKhoan = taiKhoanDAO.KiemtraDangnhap(taiKhoan);
			return taiKhoan;
		}
	}
}
