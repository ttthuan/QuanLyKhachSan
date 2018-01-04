﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccesLayer;

namespace BusinessLayer
{
	public class LoaiDichVuBUS
	{
		LoaiDichVuDAO loaiDichVuDAO = new LoaiDichVuDAO();

		public DataTable LayDanhSachLoaiDichVu()
		{
			return loaiDichVuDAO.LayDanhSachLoaiDichVu();
		}
	}
}
