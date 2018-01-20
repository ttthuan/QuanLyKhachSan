using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataTranferObject
{
	public class NhanVienDTO
	{
		private int _Ma;
		private string _Ten;
		private string _SDT;
		private string _DiaChi;
		private string _GioiTinh;
		private DateTime _NgaySinh;
		private int _Mataikhoan;
		private int _Maloainhanvien;

		public int Ma
		{
			get { return _Ma; }
			set
			{
				_Ma = value;
			}
		}

		public string Ten
		{
			get { return _Ten; }
			set
			{
				if (value.Length == 0)
				{
					throw new Exception("Ten name is required");
				}
				_Ten = value;
			}
		}

		public string SDT
		{
			get { return _SDT; }
			set
			{
				if (value.Length == 0)
				{
					throw new Exception("SDT name is required");
				}
				_SDT = value;
			}
		}

		public string DiaChi
		{
			get { return _DiaChi; }
			set
			{
				if (value.Length == 0)
				{
					throw new Exception("DiaChi name is required");
				}
				_DiaChi = value;
			}
		}

		public string GioiTinh
		{
			get { return _GioiTinh; }
			set
			{
				if (value.Length == 0)
				{
					throw new Exception("GioiTinh name is required");
				}
				_GioiTinh = value;
			}
		}

		public DateTime NgaySinh
		{
			get { return _NgaySinh; }
			set
			{
				_NgaySinh = value;
			}
		}

		public int Mataikhoan
		{
			get { return _Mataikhoan; }
			set
			{
				_Mataikhoan = value;
			}
		}

		public int Maloainhanvien
		{
			get { return _Maloainhanvien; }
			set
			{
				_Maloainhanvien = value;
			}
		}
	}
}
