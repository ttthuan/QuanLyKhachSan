﻿using DataAccesLayer;
using DataTranferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class PhieuThuePhongBUS
    {
        PhieuThuePhongDAO phieuThuePhongDAO = new PhieuThuePhongDAO();

        public PhieuThuePhongDTO[] LayDanhSachPhieuThuePhongTrangThai1Va2()
        {
            PhieuThuePhongDTO[] phieuThuePhongs = phieuThuePhongDAO.LayDanhSachPhieuThuePhong();
            List<PhieuThuePhongDTO> lsPhieuThuePhong = new List<PhieuThuePhongDTO>();

            int n = phieuThuePhongs.Length;
            for(int i = 0; i < n; i++)
            {
                if(phieuThuePhongs[i].TrangThai == 1 || phieuThuePhongs[i].TrangThai == 2)
                {
                    lsPhieuThuePhong.Add(phieuThuePhongs[i]);
                }
            }

            return lsPhieuThuePhong.ToArray();
        }
    }
}