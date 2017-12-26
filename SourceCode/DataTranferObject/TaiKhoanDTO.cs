using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataTranferObject
{
	public class TaiKhoanDTO
	{
		private int _Ma;
		private string _Tendangnhap;
		private string _Matkhau;

		public int Ma
		{
			get { return _Ma; }
			set
			{
				_Ma = value;
			}
		}

		public string Tendangnhap
		{
			get { return _Tendangnhap; }
			set
			{
				if (value.Length == 0)
				{
					throw new Exception("Tendangnhap name is required");
				}
				_Tendangnhap = value;
			}
		}

		public string Matkhau
		{
			get { return _Matkhau; }
			set
			{
				if (value.Length == 0)
				{
					throw new Exception("Matkhau name is required");
				}
				_Matkhau = value;
			}
		}
	}
}
