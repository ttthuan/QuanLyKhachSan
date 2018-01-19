using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccesLayer;

namespace BusinessLayer
{
	public class DichVuBUS
	{
		DichVuDAO dichVuDAO = new DichVuDAO();

		public DataTable LayDanhSachDichVuTheoLoai(int loaiDichVu)
		{
			return dichVuDAO.LayDanhSachDichVuTheoLoai(loaiDichVu);
		}
	}
}
