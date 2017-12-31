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
                        
                        if(phieuThuePhongs[j].TrangThai == 1)
                            // khách hàng chưa nhận phòng
                        {
                            string time = String.Format("{0:MM/dd/yyyy HH:mm}", phieuThuePhongs[j].ThoiGianNhanPhong);
                            KhachHangDTO khachHang = khachHangBUS.LayKhachHangCoMaSo(phieuThuePhongs[j].MaKhachHang);
                            string tenKhachHang = "";

                            if(khachHang != null)
                            {
                                tenKhachHang = khachHang.Ten;
                            }
                            customePhong.ThayDoiTrangThaiDaDat(time, tenKhachHang);
                        }
                        else if(phieuThuePhongs[j].TrangThai == 2)
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
                                    strtime = time/60 + " giờ ";
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

                flowBody.Controls.Add(customePhong);
            }
        }

        //public void formLoad()
        //{
        //    if (flowFloor.Controls.Count != 0)
        //        flowFloor.Controls.Clear();
        //    if (flowBody.Controls.Count != 0)
        //        flowBody.Controls.Clear();

        //    btnPhongTrong.Text = BUS.BUS_PHONG.getPhongs(1).Count().ToString() + " Trống";
        //    btnPhongDangDon.Text = BUS.BUS_PHONG.getPhongs(2).Count().ToString() + " Đang dọn";
        //    btnPhongDangO.Text = BUS.BUS_PHONG.getPhongs(3).Count().ToString() + " Đang ở";
        //    btnPhongChoKhach.Text = BUS.BUS_PHONG.getPhongs(4).Count().ToString() + " Chờ khách";
        //    btnQuaHan.Text = BUS.BUS_PHONG.getPhongs(5).Count().ToString() + " Quá hạn";
        //    btnTongSoPhong.Text = "Tổng phòng: " + BUS.BUS_PHONG.getPhongs().Count().ToString();

        //    List<TANG> lsTang = BUS.BUS_TANG.getTangs();

        //    foreach (TANG t in lsTang)
        //    {
        //        Button btnTang = new Button();
        //        btnTang.FlatAppearance.BorderSize = 0;
        //        btnTang.FlatStyle = FlatStyle.Flat;
        //        btnTang.BackColor = Color.FromArgb(33, 33, 33);
        //        btnTang.Text = t.TENTANG;
        //        btnTang.Font = new Font("Noto Sans", 10, FontStyle.Bold);
        //        btnTang.ForeColor = Color.WhiteSmoke;
        //        btnTang.Margin = new Padding(1, 1, 1, 1);
        //        btnTang.Size = new Size(60, 60);
        //        flowFloor.Controls.Add(btnTang);
        //    }


        //    Button btnPhong = null;
        //    foreach (TANG t in lsTang)
        //    {
        //        List<PHONG> lsPhong = BUS.BUS_PHONG.getPhongs(t);
        //        foreach (PHONG p in lsPhong)
        //        {
        //            btnPhong = new Button();
        //            btnPhong.FlatAppearance.BorderSize = 0;
        //            btnPhong.FlatStyle = FlatStyle.Flat;
                    
        //            btnPhong.Text = p.TENPHONG.Trim();
        //            btnPhong.Font = new Font("Noto Sans", 11);
        //            btnPhong.ForeColor = Color.WhiteSmoke;
        //            btnPhong.Margin = new Padding(1, 1, 1, 1);
        //            btnPhong.Size = new Size(150, 60);
        //            btnPhong.TextAlign = ContentAlignment.MiddleCenter;
        //            DATPHONG datPhong;// = BUS_DATPHONG.getDatPhong(p, false);
        //            datPhong = BUS.BUS_DATPHONG.getDatPhongTrongNgayHienTai(p, DateTime.Now);

        //            // btn thông báo số ngày
        //            Button btnThongBao = new Button();
        //            btnThongBao.FlatAppearance.BorderSize = 0;
        //            btnThongBao.FlatStyle = FlatStyle.Flat;
        //            btnThongBao.BackColor = Color.Transparent;
        //            btnThongBao.Font = new Font("Noto Sans", 7, FontStyle.Bold);
        //            btnThongBao.ForeColor = Color.WhiteSmoke;
        //            btnThongBao.Size = new Size(150, 20);
        //            btnThongBao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        //            btnThongBao.TextAlign = ContentAlignment.TopRight;

        //            // kiểm tra tình trạng phòng =3, 4, 5 thì thêm thông tin khách hàng vào
        //            Button btnTenKH = null;
        //            if (p.MATINHTRANG >= 3)
        //            {
        //                //btn số lượng khách hàng và tên khách hàng đang ở
        //                btnTenKH = new Button();
        //                btnTenKH.FlatAppearance.BorderSize = 0;
        //                btnTenKH.FlatStyle = FlatStyle.Flat;
        //                btnTenKH.BackColor = Color.Transparent;
        //                btnTenKH.Font = new Font("Noto Sans", 7, FontStyle.Bold);
        //                btnTenKH.ForeColor = Color.WhiteSmoke;
        //                btnTenKH.Size = new Size(150, 20);
        //                btnTenKH.Dock = DockStyle.Bottom;
        //                btnTenKH.TextAlign = ContentAlignment.BottomCenter;

        //                if(p.MATINHTRANG == 5)
        //                {
        //                    datPhong = BUS.BUS_DATPHONG.getDatPhongChoPhongQuaHan(p, DateTime.Now);
        //                }

        //                // get tên khách hàng và số người
        //                StringBuilder strBDTenKH = new StringBuilder();
        //                KHACHHANG kh = null;
        //                if(datPhong != null)
        //                {
        //                    kh = BUS_KHACHHANG.getKhachHang(datPhong.MAKHACHANG);
        //                    strBDTenKH.Append("(")
        //                        .Append(datPhong.SOLUONGKH)
        //                        .Append(") ")
        //                        .Append(kh.TEN);

        //                    btnTenKH.Text = strBDTenKH.ToString();
        //                }
                        

        //                // nếu tình trạng phòng = 3(đang ở), = 5(quá hạn) thì mới hiển thị thông tin
        //                // còn = 4 (đã đăng ký cần phải xem xét lại thời gian
        //                if(p.MATINHTRANG == 3 || p.MATINHTRANG == 5)
        //                {
        //                    btnPhong.Controls.Add(btnTenKH);
        //                }
        //            }

        //            // gồm ngày và giờ
        //            StringBuilder strBDThongTin = new StringBuilder();

        //            // context menu strip
        //            ContextMenuStrip ctmns = new ContextMenuStrip();

        //            int time = 0;
        //            // tình trạng phòng
        //            switch (p.MATINHTRANG)
        //            {
        //                case 1:
        //                    // phòng trống
        //                    btnPhong.BackColor = CSS.GREEN;
        //                    btnThongBao.FlatAppearance.MouseOverBackColor = CSS.GREEN;
        //                    btnThongBao.FlatAppearance.MouseDownBackColor = CSS.GREEN;

        //                    // toolstrip đặt phòng trước
        //                    ToolStripItem tsDatPhongTruoc;
        //                    tsDatPhongTruoc = new ToolStripButton();
        //                    tsDatPhongTruoc.Image = Gui.Properties.Resources.ic_mode_edit;
        //                    tsDatPhongTruoc.Text = "Đặt phòng trước";
        //                    tsDatPhongTruoc.Click += Tsitem_Click;
        //                    tsDatPhongTruoc.Size = new Size(150, 15);
        //                    tsDatPhongTruoc.Name = "tsDatPhongTruoc";
        //                    tsDatPhongTruoc.TextAlign = ContentAlignment.MiddleLeft;
        //                    tsDatPhongTruoc.ImageAlign = ContentAlignment.MiddleLeft;
        //                    ctmns.Items.Add(tsDatPhongTruoc);

        //                    // toolstrip chuyển tình trạng sang đang dọn
        //                    ToolStripItem tsDangDon;
        //                    tsDangDon = new ToolStripButton();
        //                    tsDangDon.Image = Gui.Properties.Resources.ic_mode_edit;
        //                    tsDangDon.Text = "Chuyển sang đang dọn";
        //                    tsDangDon.Click += Tsitem_Click;
        //                    tsDangDon.Size = new Size(150, 15);
        //                    tsDangDon.Name = "tsDangDon";
        //                    tsDangDon.TextAlign = ContentAlignment.MiddleLeft;
        //                    tsDangDon.ImageAlign = ContentAlignment.MiddleLeft;
        //                    ctmns.Items.Add(tsDangDon);

        //                    break;
        //                case 2:
        //                    // đang dọn
        //                    btnPhong.BackColor = CSS.BLUE;
        //                    btnThongBao.FlatAppearance.MouseOverBackColor = CSS.BLUE;
        //                    btnThongBao.FlatAppearance.MouseDownBackColor = CSS.BLUE;

        //                    // toolstrip chuyển tình trạng sang còn trống
        //                    ToolStripItem tsConTrong;
        //                    tsConTrong = new ToolStripButton();
        //                    tsConTrong.Image = Gui.Properties.Resources.ic_mode_edit;
        //                    tsConTrong.Text = "Chuyển sang còn trống";
        //                    tsConTrong.Click += Tsitem_Click;
        //                    tsConTrong.Size = new Size(150, 15);
        //                    tsConTrong.Name = "tsConTrong";
        //                    tsConTrong.TextAlign = ContentAlignment.MiddleLeft;
        //                    tsConTrong.ImageAlign = ContentAlignment.MiddleLeft;
        //                    ctmns.Items.Add(tsConTrong);

        //                    break;
        //                case 3:
        //                    // đang ở

        //                    ToolStripItem tsThanhToanPhong;
        //                    if (datPhong == null)
        //                    {
        //                        // phòng trống
        //                        btnPhong.BackColor = CSS.GREEN;
        //                        btnThongBao.FlatAppearance.MouseOverBackColor = CSS.GREEN;
        //                        btnThongBao.FlatAppearance.MouseDownBackColor = CSS.GREEN;

        //                        // toolstrip đặt phòng trước
        //                        tsDatPhongTruoc = new ToolStripButton();
        //                        tsDatPhongTruoc.Image = Gui.Properties.Resources.ic_mode_edit;
        //                        tsDatPhongTruoc.Text = "Đặt phòng trước";
        //                        tsDatPhongTruoc.Click += Tsitem_Click;
        //                        tsDatPhongTruoc.Size = new Size(150, 15);
        //                        tsDatPhongTruoc.Name = "tsDatPhongTruoc";
        //                        tsDatPhongTruoc.TextAlign = ContentAlignment.MiddleLeft;
        //                        tsDatPhongTruoc.ImageAlign = ContentAlignment.MiddleLeft;
        //                        ctmns.Items.Add(tsDatPhongTruoc);

        //                        // toolstrip chuyển tình trạng sang đang dọn
        //                        //ToolStripItem tsDangDon;
        //                        tsDangDon = new ToolStripButton();
        //                        tsDangDon.Image = Gui.Properties.Resources.ic_mode_edit;
        //                        tsDangDon.Text = "Chuyển sang đang dọn";
        //                        tsDangDon.Click += Tsitem_Click;
        //                        tsDangDon.Size = new Size(150, 15);
        //                        tsDangDon.Name = "tsDangDon";
        //                        tsDangDon.TextAlign = ContentAlignment.MiddleLeft;
        //                        tsDangDon.ImageAlign = ContentAlignment.MiddleLeft;
        //                        ctmns.Items.Add(tsDangDon);
        //                    }
        //                    else
        //                    {
        //                        time = (int)(DateTime.Now - datPhong.NGAYDEN).TotalMinutes;

        //                        btnPhong.BackColor = CSS.RED;
        //                        btnThongBao.FlatAppearance.MouseOverBackColor = CSS.RED;
        //                        btnThongBao.FlatAppearance.MouseDownBackColor = CSS.RED;
        //                        btnTenKH.FlatAppearance.MouseDownBackColor = CSS.RED;
        //                        btnTenKH.FlatAppearance.MouseOverBackColor = CSS.RED;

        //                        // toolstrip thanh toán phòng
        //                        tsThanhToanPhong = new ToolStripButton();
        //                        tsThanhToanPhong.Image = Gui.Properties.Resources.ic_mode_edit;
        //                        tsThanhToanPhong.Text = "Thanh Toán Phòng";
        //                        tsThanhToanPhong.Click += Tsitem_Click;
        //                        tsThanhToanPhong.Size = new Size(150, 15);
        //                        tsThanhToanPhong.Name = "tsThanhToanPhong";
        //                        tsThanhToanPhong.TextAlign = ContentAlignment.MiddleLeft;
        //                        tsThanhToanPhong.ImageAlign = ContentAlignment.MiddleLeft;
        //                        tsThanhToanPhong.Tag = datPhong;
        //                        ctmns.Items.Add(tsThanhToanPhong);

        //                        // toolstrip đặt phòng trước
        //                        //ToolStripItem tsDatPhongTruoc;
        //                        tsDatPhongTruoc = new ToolStripButton();
        //                        tsDatPhongTruoc.Image = Gui.Properties.Resources.ic_mode_edit;
        //                        tsDatPhongTruoc.Text = "Đặt phòng trước";
        //                        tsDatPhongTruoc.Click += Tsitem_Click;
        //                        tsDatPhongTruoc.Size = new Size(150, 15);
        //                        tsDatPhongTruoc.Name = "tsDatPhongTruoc";
        //                        tsDatPhongTruoc.TextAlign = ContentAlignment.MiddleLeft;
        //                        tsDatPhongTruoc.ImageAlign = ContentAlignment.MiddleLeft;
        //                        ctmns.Items.Add(tsDatPhongTruoc);
        //                    }
        //                    break;
        //                case 4:
        //                    // đã đăng ký

        //                    // kiểm tra phòng đã đăng ký có thời gian đăng ký nằm trong khoảng thời gian hiện
        //                    // tại hay không, nếu có thì mới hiển thị lên, ngược lại thì vẫn để trống
        //                    datPhong = BUS.BUS_DATPHONG.getDatPhongTrongNgayHienTai(p, DateTime.Now);
        //                    if(datPhong != null)
        //                        // có đăng ký phòng trong thời gian hiện tại
        //                    {
        //                        btnPhong.BackColor = CSS.ORANGE;
        //                        btnThongBao.FlatAppearance.MouseOverBackColor = CSS.ORANGE;
        //                        btnThongBao.FlatAppearance.MouseDownBackColor = CSS.ORANGE;
        //                        strBDThongTin.Append(datPhong.NGAYDEN.Day)
        //                            .Append("-")
        //                            .Append(datPhong.NGAYDI.Day)
        //                            .Append("/")
        //                            .Append(datPhong.NGAYDI.Month);

        //                        btnTenKH.FlatAppearance.MouseDownBackColor = CSS.ORANGE;
        //                        btnTenKH.FlatAppearance.MouseOverBackColor = CSS.ORANGE;
        //                        btnPhong.Controls.Add(btnTenKH);

        //                        // toolstrip nhận phòng
        //                        ToolStripItem tsNhanPhong;
        //                        tsNhanPhong = new ToolStripButton();
        //                        tsNhanPhong.Image = Gui.Properties.Resources.ic_mode_edit;
        //                        tsNhanPhong.Text = "Nhận phòng";
        //                        tsNhanPhong.Click += Tsitem_Click;
        //                        tsNhanPhong.Size = new Size(150, 15);
        //                        tsNhanPhong.Name = "tsNhanPhong";
        //                        tsNhanPhong.TextAlign = ContentAlignment.MiddleLeft;
        //                        tsNhanPhong.ImageAlign = ContentAlignment.MiddleLeft;
        //                        //tsNhanPhong.Tag = datPhong;
        //                        ctmns.Items.Add(tsNhanPhong);
        //                    }
        //                    else
        //                    // không có đăng ký phòng trong thời gian hiện tại
        //                    {
        //                        btnPhong.BackColor = CSS.GREEN;
        //                        btnThongBao.FlatAppearance.MouseOverBackColor = CSS.GREEN;
        //                        btnThongBao.FlatAppearance.MouseDownBackColor = CSS.GREEN;
                                
        //                        // toolstrip chuyển tình trạng sang đang dọn
        //                        //ToolStripItem tsDangDon;
        //                        tsDangDon = new ToolStripButton();
        //                        tsDangDon.Image = Gui.Properties.Resources.ic_mode_edit;
        //                        tsDangDon.Text = "Chuyển sang đang dọn";
        //                        tsDangDon.Click += Tsitem_Click;
        //                        tsDangDon.Size = new Size(150, 15);
        //                        tsDangDon.Name = "tsDangDon";
        //                        tsDangDon.TextAlign = ContentAlignment.MiddleLeft;
        //                        tsDangDon.ImageAlign = ContentAlignment.MiddleLeft;
        //                        ctmns.Items.Add(tsDangDon);
        //                    }

        //                    // toolstrip đặt phòng trước
        //                    //ToolStripItem tsDatPhongTruoc;
        //                    tsDatPhongTruoc = new ToolStripButton();
        //                    tsDatPhongTruoc.Image = Gui.Properties.Resources.ic_mode_edit;
        //                    tsDatPhongTruoc.Text = "Đặt phòng trước";
        //                    tsDatPhongTruoc.Click += Tsitem_Click;
        //                    tsDatPhongTruoc.Size = new Size(150, 15);
        //                    tsDatPhongTruoc.Name = "tsDatPhongTruoc";
        //                    tsDatPhongTruoc.TextAlign = ContentAlignment.MiddleLeft;
        //                    tsDatPhongTruoc.ImageAlign = ContentAlignment.MiddleLeft;
        //                    ctmns.Items.Add(tsDatPhongTruoc);

        //                    break;
        //                case 5:
        //                    // quá hạn
        //                    btnPhong.BackColor = CSS.BROWN;
        //                    btnThongBao.FlatAppearance.MouseOverBackColor = CSS.BROWN;
        //                    btnThongBao.FlatAppearance.MouseDownBackColor = CSS.BROWN;
        //                    time = (int)(DateTime.Now - datPhong.NGAYDI).TotalMinutes;

        //                    btnTenKH.FlatAppearance.MouseDownBackColor = CSS.BROWN;
        //                    btnTenKH.FlatAppearance.MouseOverBackColor = CSS.BROWN;

        //                    // toolstrip thanh toán phòng
        //                    tsThanhToanPhong = new ToolStripButton();
        //                    tsThanhToanPhong.Image = Gui.Properties.Resources.ic_mode_edit;
        //                    tsThanhToanPhong.Text = "Thanh Toán Phòng";
        //                    tsThanhToanPhong.Click += Tsitem_Click;
        //                    tsThanhToanPhong.Size = new Size(150, 15);
        //                    tsThanhToanPhong.Name = "tsThanhToanPhong";
        //                    tsThanhToanPhong.TextAlign = ContentAlignment.MiddleLeft;
        //                    tsThanhToanPhong.ImageAlign = ContentAlignment.MiddleLeft;
        //                    tsThanhToanPhong.Tag = datPhong;
        //                    ctmns.Items.Add(tsThanhToanPhong);

        //                    // toolstrip đặt phòng trước
        //                    //ToolStripItem tsDatPhongTruoc;
        //                    tsDatPhongTruoc = new ToolStripButton();
        //                    tsDatPhongTruoc.Image = Gui.Properties.Resources.ic_mode_edit;
        //                    tsDatPhongTruoc.Text = "Đặt phòng trước";
        //                    tsDatPhongTruoc.Click += Tsitem_Click;
        //                    tsDatPhongTruoc.Size = new Size(150, 15);
        //                    tsDatPhongTruoc.Name = "tsDatPhongTruoc";
        //                    tsDatPhongTruoc.TextAlign = ContentAlignment.MiddleLeft;
        //                    tsDatPhongTruoc.ImageAlign = ContentAlignment.MiddleLeft;
        //                    ctmns.Items.Add(tsDatPhongTruoc);

        //                    break;
        //            }

        //            // chỉ dành cho phòng đang ở và quá hạn
        //            if (time != 0)
        //            {
        //                if (time < 60) // nhỏ hơn 60 phút
        //                {
        //                    strBDThongTin.Append(time)
        //                        .Append(" phút ")
        //                        .Append(datPhong.NGAYDEN.Day)
        //                        .Append("-")
        //                        .Append(datPhong.NGAYDI.Day);
        //                }
        //                else if (time < 60 * 24) // nhỏ hơn 24h
        //                {
        //                    strBDThongTin.Append(time / 60)
        //                        .Append(" giờ ")
        //                        .Append(datPhong.NGAYDEN.Day)
        //                        .Append("-")
        //                        .Append(datPhong.NGAYDI.Day);
        //                }
        //                else // lớn hơn 24h
        //                {
        //                    strBDThongTin.Append(time / (60 * 24))
        //                        .Append(" ngày ")
        //                        .Append(datPhong.NGAYDEN.Day)
        //                        .Append("-")
        //                        .Append(datPhong.NGAYDI.Day);
        //                }
        //                strBDThongTin.Append("/")
        //                    .Append(datPhong.NGAYDI.Month);
        //            }

        //            btnThongBao.Text = strBDThongTin.ToString();

        //            btnPhong.Controls.Add(btnThongBao);
        //            // add phòng zo button phòng
        //            btnPhong.Tag = p;
                    
        //            // add button phòng zo context menu trip
        //            ctmns.Tag = btnPhong;
        //            btnPhong.ContextMenuStrip = ctmns;

        //            flowBody.Controls.Add(btnPhong);
        //        }
        //        flowBody.SetFlowBreak(btnPhong, true);
        //    }
        //}

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

        private void Tsitem_Click(object sender, EventArgs e)
        {
            ToolStripItem s = sender as ToolStripItem;

            //if (s != null)
            //{
            //    Button btnGet = (Button)s.GetCurrentParent().Tag;
            //    if (s.Name.Equals("tsThanhToanPhong"))
            //    {
            //        ThanhToanPhong formThanhToan = new ThanhToanPhong();
            //        this.transferDatPhong = formThanhToan.functionGetferDatPhong;
            //        this.functionTransferDatPhong((DATPHONG)s.Tag, nhanVien);
            //        formThanhToan.ShowDialog(this);
            //        if(ThanhToanPhong.result == true)
            //            // thanh toán thành công
            //        {
            //            formLoad();
            //            ThanhToanPhong.result = false;
            //        }
            //    }
            //    else if (s.Name.Equals("tsDatPhongTruoc"))
            //    {
            //        DatPhong frmDatPhong = new DatPhong();
            //        this.transferPhong = frmDatPhong.functionGetPhong;
            //        this.Transfer((PHONG)btnGet.Tag);
            //        frmDatPhong.ShowDialog();
            //        if(DatPhong.result == true)
            //        {
            //            formLoad();
            //            DatPhong.result = false;
            //        }
            //    }
            //    else if (s.Name.Equals("tsNhanPhong"))
            //    {
            //        // nhận phòng
            //        // chuyển tình trạng phòng về đang ở (3)
            //        BUS.BUS_PHONG.updateTinhTrangPhong((PHONG)btnGet.Tag, 3);
            //        formLoad();
            //    } else if (s.Name.Equals("tsDangDon"))
            //    {
            //        // chuyển tình trạng sang đang dọn (2)
            //        BUS.BUS_PHONG.updateTinhTrangPhong((PHONG)btnGet.Tag, 2);
            //        formLoad();
            //    }else if (s.Name.Equals("tsConTrong"))
            //    {
            //        // chuyển tình trạng sang còn trống (1)
            //        BUS.BUS_PHONG.updateTinhTrangPhong((PHONG)btnGet.Tag, 1);
            //        formLoad();
            //    }
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefesh_MouseUp(object sender, MouseEventArgs e)
        {
            //formLoad();
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

            if((tick % 300) == 0)
                // 60 phút trôi qua
            {
                checkAndChangeTinhTrangPhong();
                //formLoad();
            }
        }

        private void checkAndChangeTinhTrangPhong()
        {
            //List<DATPHONG> ls = BUS.BUS_DATPHONG.getDatPhongDangToiQuaHan(DateTime.Now);
            //if(ls != null)
            //{
            //    foreach(DATPHONG item in ls)
            //    {
            //        BUS.BUS_PHONG.updateTinhTrangPhong(item.MAPHONG, 5);
            //    }
            //}
        }
    }
}
