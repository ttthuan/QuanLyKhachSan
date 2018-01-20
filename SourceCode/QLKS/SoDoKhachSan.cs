using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataTranferObject;
using BusinessLayer;

namespace PresentationLayer
{
    public partial class SoDoKhachSan : Form
    {
        // khai báo delegate
        //public delegate void TransferPhong(PHONG phong);
        //TransferPhong transferPhong;

        //public delegate void TransferDatPhong(DATPHONG datPhong, NHANVIEN nhanVien);
        //TransferDatPhong transferDatPhong;

        //// khái báo biến
        //public NHANVIEN nhanVien = null;
        int tick = 0;
		//List<CustomePhong> 

		public static TaiKhoanDTO taiKhoan = null;
        public SoDoKhachSan()
        {
            InitializeComponent();

            //formLoad();
            LoadPhong();
            timerAutoChange.Start();
        }

        //public void functionGetThongTinDangNhap(NHANVIEN nhanVien)
        //{
        //    this.nhanVien = nhanVien;
        //}

        public void LoadPhong()
        {
            flowBody.Controls.Clear();
            PhongBUS phongBUS = new PhongBUS();
            PhongDTO[] phongs = phongBUS.LayDanhSachPhong();

            PhieuThuePhongBUS phieuThuePhongBUS = new PhieuThuePhongBUS();
            PhieuThuePhongDTO[] phieuThuePhongs = phieuThuePhongBUS.LayDanhSachPhieuThuePhongTrangThai1Va2();

            KhachHangBUS khachHangBUS = new KhachHangBUS();

            int i;
            int j, coTrongPhieuThuePhong = 0;
            int numberPhong = phongBUS.LaySoLuongPhongLonNhatTrongCacTang();
            int with_sizeCustomePhong = flowBody.Size.Width / numberPhong - numberPhong-1;

            for (i = 0; i < phongs.Length; i++)
            {
                // khai báo control customePhong
                CustomePhong customePhong = new CustomePhong(phongs[i]);
                customePhong.Size = new Size(with_sizeCustomePhong, customePhong.Size.Height);

                coTrongPhieuThuePhong = 0;

                for(j = 0; j < phieuThuePhongs.Length; j++)
                {
                    if(phongs[i].Ma == phieuThuePhongs[j].MaPhong)
                    {
                        coTrongPhieuThuePhong = 1;

                        if (phieuThuePhongs[j].TrangThai == 1)
                        // khách hàng chưa nhận phòng
                        {
                            PhieuThuePhongDTO phieuThuePhongKiemTra = phieuThuePhongBUS.CoPhaiPhongCoNguoiDangO(phongs[i].Ma);
                            if (phieuThuePhongKiemTra != null)
                            {
                                string strtime = String.Format("{0:MM/dd/yyyy HH:mm}", phieuThuePhongKiemTra.ThoiGianTraPhong);
                                KhachHangDTO khachHang = khachHangBUS.LayKhachHangCoMaSo(phieuThuePhongKiemTra.MaKhachHang);
                                string tenKhachHang = "";

                                if (khachHang != null)
                                {
                                    tenKhachHang = khachHang.Ten;
                                }

                                customePhong.ThayDoiTrangThaiDangO(strtime, tenKhachHang);

                                // kiểm tra khách hàng có quá hạn hay không
                                int time = (int)(DateTime.Now - phieuThuePhongKiemTra.ThoiGianTraPhong).TotalMinutes;
                                if (time > 0)
                                {
                                    if (time < 60) // nhỏ hơn 60 phút
                                    {
                                        strtime = time + " phút ";
                                    }
                                    else if (time < 60 * 24) // nhỏ hơn 24h
                                    {
                                        strtime = time / 60 + " giờ ";
                                    }
                                    else // lớn hơn 24h
                                    {
                                        strtime = time / (60 * 24) + " ngày ";
                                    }
                                    strtime += String.Format("{0:MM/dd/yyyy HH:mm}", phieuThuePhongKiemTra.ThoiGianTraPhong);
                                    customePhong.ThayDoiTrangThaiQuaHan(strtime, tenKhachHang);
                                }
                            }
                            else
                            {
                                string time = String.Format("{0:MM/dd/yyyy HH:mm}", phieuThuePhongs[j].ThoiGianNhanPhong);
                                KhachHangDTO khachHang = khachHangBUS.LayKhachHangCoMaSo(phieuThuePhongs[j].MaKhachHang);
                                string tenKhachHang = "";

                                if (khachHang != null)
                                {
                                    tenKhachHang = khachHang.Ten;
                                }
                                customePhong.ThayDoiTrangThaiDaDat(time, tenKhachHang);
                            }
                        }
                        else if (phieuThuePhongs[j].TrangThai == 2)
                        // khách hàng đã nhận phòng
                        {
                            string strtime = String.Format("{0:MM/dd/yyyy HH:mm}", phieuThuePhongs[j].ThoiGianTraPhong);
                            KhachHangDTO khachHang = khachHangBUS.LayKhachHangCoMaSo(phieuThuePhongs[j].MaKhachHang);
                            string tenKhachHang = "";

                            if (khachHang != null)
                            {
                                tenKhachHang = khachHang.Ten;
                            }

                            customePhong.ThayDoiTrangThaiDangO(strtime, tenKhachHang);

                            // kiểm tra khách hàng có quá hạn hay không
                            int time = (int)(DateTime.Now - phieuThuePhongs[j].ThoiGianTraPhong).TotalMinutes;
                            if (time > 0)
                            {
                                if (time < 60) // nhỏ hơn 60 phút
                                {
                                    strtime = time + " phút ";
                                }
                                else if (time < 60 * 24) // nhỏ hơn 24h
                                {
                                    strtime = time / 60 + " giờ ";
                                }
                                else // lớn hơn 24h
                                {
                                    strtime = time / (60 * 24) + " ngày ";
                                }
                                strtime += String.Format("{0:MM/dd/yyyy HH:mm}", phieuThuePhongs[j].ThoiGianTraPhong);
                                customePhong.ThayDoiTrangThaiQuaHan(strtime, tenKhachHang);
                            }
                        }
                         
                        break;
                    }
                }
                
                if(coTrongPhieuThuePhong == 0)
                {
                    customePhong.ThayDoiTrangThaiTrong();
                }

                customePhong.EventDatPhong += CustomePhong_EventDatPhong;
                customePhong.EventNhanPhong += CustomePhong_EventNhanPhong;
                customePhong.EventThanhToanPhong += CustomePhong_EventThanhToanPhong;

                flowBody.Controls.Add(customePhong);
            }
        }

        private void CustomePhong_EventThanhToanPhong(object sender, ProcessEventArgs e)
        {
			// call thanh toan phong
			TraPhong traPhong = new TraPhong();
			TraPhong.maTaiKhoan = taiKhoan.Ma;
			TraPhong.maP = e.PHONG.Ma;
			TraPhong.isSodoKScall = true;
			traPhong.ShowDialog();
			if (TraPhong.result)
			{
				LoadPhong();
			}
		}

        private void CustomePhong_EventNhanPhong(object sender, ProcessEventArgs e)
        {
            // call nhận phòng
            try
            {
                PhieuThuePhongBUS phieuThuePhong = new PhieuThuePhongBUS();
                phieuThuePhong.CapNhatTrangThaiPhieuThuePhongCoMaPhong(e.PHONG.Ma);
            }catch(Exception ex)
            {
                MessageBoxDS m = new MessageBoxDS();
                MessageBoxDS.thongbao = "Thời gian nhận phòng chưa đến";
                MessageBoxDS.maHinh = 3;
                m.ShowDialog();
            }
            
        }

        private void CustomePhong_EventDatPhong(object sender, ProcessEventArgs e)
        {
			// call dăt phòng

			DatPhong datPhong = new DatPhong();
			DatPhong.maP = e.PHONG.Ma;
			DatPhong.isSodoKScall = true;
			datPhong.ShowDialog();
			if (DatPhong.result)
			{
				LoadPhong();
			}
		}



        //public void Transfer(PHONG phong)
        //{
        //    if(transferPhong != null)
        //    {
        //        transferPhong(phong);
        //    }
        //}

        //public void functionTransferDatPhong(DATPHONG datPhong, NHANVIEN nhanVien)
        //{
        //    if(transferDatPhong != null)
        //    {
        //        transferDatPhong(datPhong, nhanVien);
        //    }
        //}


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefesh_MouseUp(object sender, MouseEventArgs e)
        {
            LoadPhong();
        }

        private void btnHienTrangVsDatPhong_Click(object sender, EventArgs e)
        {
            //ChonPhongTuDSKhachHang chonPhong = new ChonPhongTuDSKhachHang();
            //chonPhong.isSoDoKSCall = true;
            //chonPhong.ShowDialog();
        }

        private void timerAutoChange_Tick(object sender, EventArgs e)
        {
            tick++;
            if(tick >= int.MaxValue)
            {
                tick = 0;
            }

            if((tick % 30) == 0)
                // 60 phút trôi qua
            {
                checkAndChangeTinhTrangPhong();
                LoadPhong();
            }
        }

        private void checkAndChangeTinhTrangPhong()
        {
            PhieuThuePhongBUS phieuThuePhongBUS = new PhieuThuePhongBUS();
            phieuThuePhongBUS.DuyetVaCapNhatTrangThai();
        }
    }
}
