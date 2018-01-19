using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccesLayer;
using DataTranferObject;

namespace BusinessLayer
{
	public class DichVuBUS
	{
		DichVuDAO dichVuDAO = new DichVuDAO();

		public DataTable LayDanhSachDichVuTheoLoai(int loaiDichVu)
		{
			return dichVuDAO.LayDanhSachDichVuTheoLoai(loaiDichVu);
		}

		public DataTable LayDanhSachDichVu()
		{
			return dichVuDAO.LayDanhSachDichVu();
		}

		public bool CapnhatDV(DichVuDTO dichVuDTO)
		{
			return dichVuDAO.CapnhatDV(dichVuDTO);
		}

		public bool ThemDV(DichVuDTO dichVuDTO)
		{
			return dichVuDAO.ThemDV(dichVuDTO);
		}
	}
}
