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
	public class PhieuSuDungDichVuBUS
	{
		PhieuSuDungDichVuDAO phieuSuDungDichVuDAO = new PhieuSuDungDichVuDAO();

		public DataTable LayDanhSachSuDungDichVu(int maPhieuThuePhong)
		{
			return phieuSuDungDichVuDAO.LayDanhSachSuDungDichVu(maPhieuThuePhong);
		}

		public bool CapnhatSuDungDichVu(PhieuSuDungDichVuDTO phieuSuDungDichVuDTO)
		{
			bool them = false;
			if(phieuSuDungDichVuDAO.KiemtraSuDungDichVu(phieuSuDungDichVuDTO))
			{
				them = true;
			}
			return phieuSuDungDichVuDAO.CapNhatSuDungDichVu(phieuSuDungDichVuDTO, them);
		}

		public bool XoaSuDungDichVu(PhieuSuDungDichVuDTO phieuSuDungDichVuDTO)
		{
			return phieuSuDungDichVuDAO.XoaSuDungDichVu(phieuSuDungDichVuDTO);
		}

		public string TinhTongTienSuDungDichVu(int maPhieuSuDungDichVu)
		{
			return phieuSuDungDichVuDAO.TinhTongTienSuDungDichVu(maPhieuSuDungDichVu);
		}
	}
}
