using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccesLayer;

namespace BusinessLayer
{
	public class LoaiGiaBUS
	{
		LoaiGiaDAO loaiGiaDAO = new LoaiGiaDAO();
		public DataTable LayDanhSachLoaiGia()
		{
			return loaiGiaDAO.LayDanhSachLoaiGia();
		}
	}
}
