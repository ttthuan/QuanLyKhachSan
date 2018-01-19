using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
	public class TraPhongBUS
	{
		public float TinhTongTien(float giaPhong, float tienDichVu, int maLoaiGia, int soNgay, float giamTru, float phuThu,float traTruoc)
		{
			float tongtien = 0;
			if(maLoaiGia == 1)
			{
				tongtien = giaPhong * soNgay + tienDichVu + phuThu - giamTru - traTruoc;
			}
			else
			{
				tongtien = giaPhong + tienDichVu + phuThu - giamTru - traTruoc;
			}
			return tongtien;
		}
	}
}
