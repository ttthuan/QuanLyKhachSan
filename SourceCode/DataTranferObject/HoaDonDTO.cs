using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataTranferObject
{
	public class HoaDonDTO
	{
		private int _Ma;
		private int _Maphieuthuephong;
		private int _Manhanvienlap;
		private DateTime _Ngaytao;
		private float _Tongtien;
		private string _Ghichu;

		public int Ma
		{
			get { return _Ma; }
			set
			{
				_Ma = value;
			}
		}

		public int Maphieuthuephong
		{
			get { return _Maphieuthuephong; }
			set
			{
				_Maphieuthuephong = value;
			}
		}

		public int Manhanvienlap
		{
			get { return _Manhanvienlap; }
			set
			{
				_Manhanvienlap = value;
			}
		}

		public DateTime Ngaytao
		{
			get { return _Ngaytao; }
			set
			{
				_Ngaytao = value;
			}
		}

		public float Tongtien
		{
			get { return _Tongtien; }
			set
			{
				_Tongtien = value;
			}
		}

		public string Ghichu
		{
			get { return _Ghichu; }
			set
			{
				_Ghichu = value;
			}
		}
	}
}
