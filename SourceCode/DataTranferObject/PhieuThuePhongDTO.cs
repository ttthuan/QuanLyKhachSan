using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTranferObject
{
    public class PhieuThuePhongDTO
    {
        public int Ma { get; set; }
        public int MaPhong { get; set; }
        public int MaKhachHang { get; set; }
        public DateTime ThoiGianNhanPhong { get; set; }
        public DateTime ThoiGianTraPhong { get; set; }
        public int MaLoaiThuePhong { get; set; }
        public float Gia { get; set; }
        public int TrangThai { get; set; }
		public float TraTruoc { get; set; }
	}
}
