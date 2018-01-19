using DataTranferObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FormMain : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private bool themeToggle = true;

        // khai báo color
        Color TEXT_PRIMARY = CSS.DARK_TEXT_PRIMARY;
        Color TEXT_HOVER = CSS.DARK_TEXT_HOVER;
        Color TITLE_PRIMERY = CSS.DARK_TITLE_PRIMARY;
        Color BUTTON_PRIMERY = CSS.DARK_BUTTON;
        Color BUTTON_PRIMERY_ACTIVE = CSS.DARK_ACTIVEBUTTON;
        Color BACKGROUND_PANEL = CSS.DARK_BACKGROUND_PANEL;
        Color BUTTON_HOVER = CSS.DARK_BUTTON_HOVER;

        // khai báo các form trong menu
        Form dichVu = null;
        Form soDoKhachSan = null;
        Form khachHang = null;
        Form chiTietDoanhThu = null;
        Form doanhThuGanDay = null;
        Form loaiPhong = null;
        Form bieuDoKhachDen = null;
        Form dmk = null;
        Form quanlytaikhoan = null;
		Form thaydoimatkau = null;

        public Label plbDangXuat = null;

        // khai báo height của pnDoanhTHu
        int heightOfPanelDoanhThu = 0;
        // khai báo height của pnKhachHang
        int heightOfPanelKhachHang = 0;
        // height cuar pnTaiKhoan
        int heightOfPanelTaiKhoan = 0;
        
        // khai báo delegate
        public delegate void callBtnMouseEvent(object sender, MouseEventArgs e);

		//Tai khoản đăng nhập
		TaiKhoanDTO taiKhoan = new TaiKhoanDTO();
        
        public FormMain(ControllerSV objSV)
        {
			taiKhoan = objSV.taiKhoan;
            InitializeComponent();

            cbbChangeTheme.SelectedIndex = 0;
            ChangeTheme();

            // khởi tạo sự kiện cho group button doanh thu
            btnDoanhThuGanDay.MouseHover += button_MouseHover;
            btnDoanhThuGanDay.MouseLeave += button_MouseLeave;
            btnDoanhThuGanDay.MouseUp += BtnDoanhThuGanDay_MouseUp;

            btnChiTietDoanhThu.MouseHover += button_MouseHover;
            btnChiTietDoanhThu.MouseLeave += button_MouseLeave;
            btnChiTietDoanhThu.MouseUp += BtnChiTietDoanhThu_MouseUp;

            btnPhanTichBieuDo.MouseHover += button_MouseHover;
            btnPhanTichBieuDo.MouseLeave += button_MouseLeave;
            btnPhanTichBieuDo.MouseUp += BtnPhanTichBieuDo_MouseUp;

            // khởi tạo sự kiện cho group button khách hàng
            btnKhachHangDangO.MouseHover += button_MouseHover;
            btnKhachHangDangO.MouseLeave += button_MouseLeave;
            btnKhachHangDangO.MouseUp += BtnKhachHangDangO_MouseUp;

            btnKhachHangDangDat.MouseHover += button_MouseHover;
            btnKhachHangDangDat.MouseLeave += button_MouseLeave;
            btnKhachHangDangDat.MouseUp += BtnKhachHangDatPhong_MouseUp;

            btnKhachHangCu.MouseHover += button_MouseHover;
            btnKhachHangCu.MouseLeave += button_MouseLeave;
            btnKhachHangCu.MouseUp += BtnDanhSachKhachHang_MouseUp;

            // khởi tạo sự kiện cho group button tài khoản
            btnDoiMatKhau.MouseHover += button_MouseHover;
            btnDoiMatKhau.MouseLeave += button_MouseLeave;
            btnDoiMatKhau.MouseUp += BtnDoiMatKhau_MouseUp;

            btnQuanLyTaiKhoan.MouseHover += button_MouseHover;
            btnQuanLyTaiKhoan.MouseLeave += button_MouseLeave;
            btnQuanLyTaiKhoan.MouseUp += BtnQuanLyTaiKhoan_MouseUp;
            
            
            // sự kiện dropdow panel cho group button
            btnKhachHang.MouseDown += Button_MouseDown;
            btnSoDoKhachSan.MouseDown += Button_MouseDown;
            btnLoaiPhong.MouseDown += Button_MouseDown;
            btnDichVu.MouseDown += Button_MouseDown;
            btnDoanhThu.MouseDown += Button_MouseDown;
            btnChiTietDoanhThu.MouseDown += Button_MouseDown;
            btnDoanhThuGanDay.MouseDown += Button_MouseDown;
            btnPhanTichBieuDo.MouseDown += Button_MouseDown;
            btnTaiKhoan.MouseDown += Button_MouseDown;
            btnAbout.MouseDown += Button_MouseDown;

            // khởi tạo height của pnDoanhThu
            heightOfPanelDoanhThu = SIZE.HEIGHT_BUTTON;
            heightOfPanelKhachHang = SIZE.HEIGHT_BUTTON;
            heightOfPanelTaiKhoan = SIZE.HEIGHT_BUTTON;

            plbDangXuat = lbDangXuat;

			//taikhoan
			//lbTaiKhoan.Text = objSV.taiKhoan.Tendangnhap;
		}

        private void BtnQuanLyTaiKhoan_MouseUp(object sender, MouseEventArgs e)
        {

			setColorActiveForButton((Button)sender);

			if (quanlytaikhoan == null)
			{
				quanlytaikhoan = new QuanlyTaiKhoan(taiKhoan);
				quanlytaikhoan.Dock = DockStyle.Fill;
				quanlytaikhoan.TopLevel = false;
				pnBody.Controls.Add(quanlytaikhoan);

				quanlytaikhoan.Show();
			}

			onlyShowOneFormOnPannelBody(quanlytaikhoan);
        }

        private void BtnDoiMatKhau_MouseUp(object sender, MouseEventArgs e)
        {
			setColorActiveForButton((Button)sender);
			dmk = new ThayDoiMatKhau();
			ThayDoiMatKhau.taiKhoan = taiKhoan;
			dmk.Dock = DockStyle.Fill;
			dmk.TopLevel = false;
			pnBody.Controls.Add(dmk);
			dmk.Show();
			onlyShowOneFormOnPannelBody(dmk);
		}

        private void BtnDanhSachKhachHang_MouseUp(object sender, MouseEventArgs e)
        {
			setColorActiveForButton((Button)sender);
			khachHang = new DanhSachKhachHang(3);
			DanhSachKhachHang.maTaiKhoan = taiKhoan.Ma;
			khachHang.Dock = DockStyle.Fill;
			khachHang.TopLevel = false;
			pnBody.Controls.Add(khachHang);
			khachHang.Show();
			onlyShowOneFormOnPannelBody(khachHang);
		}

        private void BtnKhachHangDatPhong_MouseUp(object sender, MouseEventArgs e)
        {
			setColorActiveForButton((Button)sender);
			khachHang = new DanhSachKhachHang(2);
			DanhSachKhachHang.maTaiKhoan = taiKhoan.Ma;
			khachHang.Dock = DockStyle.Fill;
			khachHang.TopLevel = false;
			pnBody.Controls.Add(khachHang);
			khachHang.Show();
			onlyShowOneFormOnPannelBody(khachHang);
		}

        private void BtnKhachHangDangO_MouseUp(object sender, MouseEventArgs e)
        {
			setColorActiveForButton((Button)sender);
			khachHang = new DanhSachKhachHang(1);
			DanhSachKhachHang.maTaiKhoan = taiKhoan.Ma;
			khachHang.Dock = DockStyle.Fill;
			khachHang.TopLevel = false;
			pnBody.Controls.Add(khachHang);
			khachHang.Show();
			onlyShowOneFormOnPannelBody(khachHang);
		}

        private void Button_MouseDown(object sender, MouseEventArgs e)
        {
            checkGroupButtonClick((Button)sender);
        }

        private void BtnPhanTichBieuDo_MouseUp(object sender, MouseEventArgs e)
        {
            setColorActiveForButton((Button)sender);

           
            onlyShowOneFormOnPannelBody(bieuDoKhachDen);
        }

        private void BtnChiTietDoanhThu_MouseUp(object sender, MouseEventArgs e)
        {
            setColorActiveForButton((Button)sender);

            if(chiTietDoanhThu == null)
            {
                chiTietDoanhThu = new ChiTietDoanhThu();
                chiTietDoanhThu.Dock = DockStyle.Fill;
                chiTietDoanhThu.TopLevel = false;
                pnBody.Controls.Add(chiTietDoanhThu);

                chiTietDoanhThu.Show();
            }
           
            onlyShowOneFormOnPannelBody(chiTietDoanhThu);
        }

        private void BtnDoanhThuGanDay_MouseUp(object sender, MouseEventArgs e)
        {
            setColorActiveForButton((Button)sender);

           
            onlyShowOneFormOnPannelBody(doanhThuGanDay);
        }


		// button close windown
		private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_MouseHover(object sender, EventArgs e)
        {
            changeTextColorForButton((Button)sender);
        }

        // write mouse hover for buttons left
        void changeTextColorForButton(Button btn)
        {
            btn.ForeColor = TEXT_HOVER;
        }

        void restoreTexColorForButton(Button btn)
        {
            btn.ForeColor = TEXT_PRIMARY;
        }

        void setColorActiveForButton(Button btn)
        {
            btnSoDoKhachSan.BackColor = BUTTON_PRIMERY;
            btnLoaiPhong.BackColor = BUTTON_PRIMERY;
            btnDichVu.BackColor = BUTTON_PRIMERY;
            btnDoanhThu.BackColor = BUTTON_PRIMERY;
            //btnThongKe.BackColor = CSS.DARKPRIMARY;
            btnKhachHang.BackColor = BUTTON_PRIMERY;
            btnChiTietDoanhThu.BackColor = BUTTON_PRIMERY;
            btnDoanhThuGanDay.BackColor = BUTTON_PRIMERY;
            btnPhanTichBieuDo.BackColor = BUTTON_PRIMERY;
            btnKhachHangDangO.BackColor = BUTTON_PRIMERY;
            btnKhachHangDangDat.BackColor = BUTTON_PRIMERY;
            btnKhachHangCu.BackColor = BUTTON_PRIMERY;
            btnTaiKhoan.BackColor = BUTTON_PRIMERY;
            btnDoiMatKhau.BackColor = BUTTON_PRIMERY;
            btnQuanLyTaiKhoan.BackColor = BUTTON_PRIMERY;
            btnAbout.BackColor = BUTTON_PRIMERY;

            btn.BackColor = BUTTON_PRIMERY_ACTIVE;
        }

        void checkGroupButtonClick(Button btn)
        {
            // group DoanhThu
            if (!(btn == btnDoanhThu || btn == btnChiTietDoanhThu || btn == btnDoanhThuGanDay || btn == btnPhanTichBieuDo))
            {
                resetDefaulForMenuDropdown(tmDanhThu, pnDoanhThu,ref heightOfPanelDoanhThu);
            }
            // group KhachHang
            if(!(btn == btnKhachHang || btn == btnKhachHangDangO || btn == btnKhachHangDangDat || btn == btnKhachHangCu))
            {
                resetDefaulForMenuDropdown(tmKhachHang, pnKhachHang, ref heightOfPanelKhachHang);
            }
            // group TaiKhoan
            if (!(btn  == btnTaiKhoan || btn == btnDoiMatKhau || btn == btnQuanLyTaiKhoan))
            {
                resetDefaulForMenuDropdown(tmTaiKhoan, pnTaiKhoan, ref heightOfPanelTaiKhoan);
            }
        }

        private void resetDefaulForMenuDropdown(Timer tm, Panel pn, ref int height)
        {
            tm.Stop();
            pn.Height = SIZE.HEIGHT_BUTTON;
            height = SIZE.HEIGHT_BUTTON;
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            restoreTexColorForButton((Button)sender);
        }

        // chỉ show một form trên PannelBody
        private void onlyShowOneFormOnPannelBody(Form form)
        {
            if(form != null)
            {
                if (form.Tag == null || form.Tag.Equals(1) == false)
                {
                    foreach (Form c in pnBody.Controls)
                    {
                        c.Tag = 0;
                        c.Visible = false;
                    }

                    form.Tag = 1;
                    form.Visible = true;
                }
            }
        }

        // write mouse down and drag for title windown
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        // xử lý animation for menudropdown
        private void processAnimation(ref int height, Timer tm, Panel pn)
        {
            int num = pn.Controls.Count;
            if (height >= SIZE.HEIGHT_BUTTON * num)
            {
                tm.Stop();
                height = SIZE.HEIGHT_BUTTON * num;
            }
            else
            {
                pn.Height = height;
                height += SIZE.SPEEDANIMATION;
            }
        }

        // animation of menu doanh thu dropdow
        private void tmDanhThu_Tick(object sender, EventArgs e)
        {
            processAnimation(ref heightOfPanelDoanhThu, tmDanhThu, pnDoanhThu);
        }

        // animation of menu khach hang dropdow
        private void tmKhachHang_Tick(object sender, EventArgs e)
        {
            processAnimation(ref heightOfPanelKhachHang, tmKhachHang, pnKhachHang);
        }

        private void btnThongKe_MouseUp(object sender, MouseEventArgs e)
        {
            setColorActiveForButton((Button)sender);
        }
        

        private void btnSoDoKhachSan_MouseUp(object sender, MouseEventArgs e)
        {
            setColorActiveForButton((Button)sender);

            if (soDoKhachSan == null)
            {
                soDoKhachSan = new SoDoKhachSan();
                soDoKhachSan.Dock = DockStyle.Fill;
                soDoKhachSan.TopLevel = false;
                pnBody.Controls.Add(soDoKhachSan);
                //transferThongTinDangNhap = ((SoDoKhachSan)soDoKhachSan).functionGetThongTinDangNhap;
                //functionTransferThongTinDangNhap(nhanVien);
                soDoKhachSan.Show();
            }

            onlyShowOneFormOnPannelBody(soDoKhachSan);
        }

        private void btnLoaiPhong_MouseUp(object sender, MouseEventArgs e)
        {
            setColorActiveForButton((Button)sender);

            
            onlyShowOneFormOnPannelBody(loaiPhong);
        }

        private void btnDichVu_MouseUp(object sender, MouseEventArgs e)
        {
            setColorActiveForButton((Button)sender);
			if (dichVu == null)
			{
				dichVu = new DichVuvaLoaiDichVu();
				dichVu.Dock = DockStyle.Fill;
				dichVu.TopLevel = false;
				pnBody.Controls.Add(dichVu);
				dichVu.Show();
			}
			onlyShowOneFormOnPannelBody(dichVu);
        }

        // expand group button DoanhThu
        private void btnDoanhThu_MouseUp(object sender, MouseEventArgs e)
        {
            setColorActiveForButton((Button)sender);
            tmDanhThu.Start();
        }

        private void btnKhachHang_MouseUp(object sender, MouseEventArgs e)
        {
            setColorActiveForButton((Button)sender);
            tmKhachHang.Start();
        }

        private void btnTaiKhoan_MouseUp(object sender, MouseEventArgs e)
        {
            setColorActiveForButton((Button)sender);
            tmTaiKhoan.Start();
        }
        
        // phân quyền cho người dùng
        private void phanQuyen()
        {
            //if(nhanVien.MALOAINHANVIEN == 2)
            //{
            //    btnDoanhThu.Enabled = false;
            //    //btnThongKe.Enabled = false;
            //    btnQuanLyTaiKhoan.Enabled = false;
            //}
            //else
            //{
            //    btnDoanhThu.Enabled = true;
            //    //btnThongKe.Enabled = true;
            //}
            
        }

        public void lbDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap dangNhap = new DangNhap();
            dangNhap.ShowDialog();
            this.Close();
        }

        private void lbHello_Click(object sender, EventArgs e)
        {
            
        }

        private void tmTaiKhoan_Tick(object sender, EventArgs e)
        {
            processAnimation(ref heightOfPanelTaiKhoan, tmTaiKhoan, pnTaiKhoan);
        }

        private void btnAbout_MouseUp(object sender, MouseEventArgs e)
        {

        }

        public void ChangeTheme()
        {
            if (themeToggle)
            {
                TEXT_PRIMARY = CSS.WHITE_TEXT_PRIMARY;
                TEXT_HOVER = CSS.WHITE_TEXT_HOVER;
                TITLE_PRIMERY = CSS.WHITE_TITLE_PRIMARY;
                BUTTON_PRIMERY = CSS.WHITE_BUTTON;
                BUTTON_PRIMERY_ACTIVE = CSS.WHITE_ACTIVEBUTTON;
                BACKGROUND_PANEL = CSS.WHITE_BACKGROUND_PANEL;
                BUTTON_HOVER = CSS.WHITE_BUTTON_HOVER;

                // change icon
                IconLoGo.Image = Properties.Resources.white_bank;
                btnClose.Image = Properties.Resources.white_close_circle_outline;

                // change icon for in menu
                btnKhachHang.Image = Properties.Resources.white_account_multiple_outline;
                btnSoDoKhachSan.Image = Properties.Resources.white_map;
                btnLoaiPhong.Image = Properties.Resources.white_home_modern;
                btnDichVu.Image = Properties.Resources.white_food;
                btnDoanhThu.Image = Properties.Resources.white_cash_usd;
                btnTaiKhoan.Image = Properties.Resources.white_account;
                btnAbout.Image = Properties.Resources.white_about;

                // btn child Doanh Thu
                btnChiTietDoanhThu.Image = Properties.Resources.white_cash_multiple;
                btnDoanhThuGanDay.Image = Properties.Resources.white_cash_100;
                btnPhanTichBieuDo.Image = Properties.Resources.white_chart_bar;

                // btn child Khach Hang
                btnKhachHangDangO.Image = Properties.Resources.white_in_home;
                btnKhachHangDangDat.Image = Properties.Resources.white_check_in;
                btnKhachHangCu.Image = Properties.Resources.white_people_out;

                // btn child tai khoan
                btnDoiMatKhau.Image = Properties.Resources.white_lock_reset;
                btnQuanLyTaiKhoan.Image = Properties.Resources.white_folder_account;
            }
            else
            {
                TEXT_PRIMARY = CSS.DARK_TEXT_PRIMARY;
                TEXT_HOVER = CSS.DARK_TEXT_HOVER;
                TITLE_PRIMERY = CSS.DARK_TITLE_PRIMARY;
                BUTTON_PRIMERY = CSS.DARK_BUTTON;
                BUTTON_PRIMERY_ACTIVE = CSS.DARK_ACTIVEBUTTON;
                BACKGROUND_PANEL = CSS.DARK_BACKGROUND_PANEL;
                BUTTON_HOVER = CSS.DARK_BUTTON_HOVER;

                // change icon
                IconLoGo.Image = Properties.Resources.dark_bank;
                btnClose.Image = Properties.Resources.dark_close_circle_outline;

                // change icon for in menu
                btnKhachHang.Image = Properties.Resources.dark_account_multiple_outline;
                btnSoDoKhachSan.Image = Properties.Resources.dark_map;
                btnLoaiPhong.Image = Properties.Resources.dark_home_modern;
                btnDichVu.Image = Properties.Resources.dark_food;
                btnDoanhThu.Image = Properties.Resources.dark_cash_usd;
                btnTaiKhoan.Image = Properties.Resources.dark_account;
                btnAbout.Image = Properties.Resources.dark_about;

                // btn child Doanh Thu
                btnChiTietDoanhThu.Image = Properties.Resources.dark_cash_multiple;
                btnDoanhThuGanDay.Image = Properties.Resources.dark_cash_100;
                btnPhanTichBieuDo.Image = Properties.Resources.dark_chart_bar;

                // btn child Khach Hang
                btnKhachHangDangO.Image = Properties.Resources.dark_in_home;
                btnKhachHangDangDat.Image = Properties.Resources.dark_check_in;
                btnKhachHangCu.Image = Properties.Resources.dark_people_out;

                // btn child tai khoan
                btnDoiMatKhau.Image = Properties.Resources.dark_lock_reset;
                btnQuanLyTaiKhoan.Image = Properties.Resources.dark_folder_account;
            }

            pnTitle.BackColor = TITLE_PRIMERY;
            lbTitleText.ForeColor = TEXT_PRIMARY;
            lbTitleText.BackColor = TITLE_PRIMERY;
            lbTaiKhoan.ForeColor = TEXT_PRIMARY;
            pnMenu.BackColor = BACKGROUND_PANEL;
            pnDoanhThu.BackColor = BACKGROUND_PANEL;
            pnKhachHang.BackColor = BACKGROUND_PANEL;
            pnTaiKhoan.BackColor = BACKGROUND_PANEL;

            //*******change color button********//
            btnKhachHang.BackColor = BUTTON_PRIMERY;
            btnSoDoKhachSan.BackColor = BUTTON_PRIMERY;
            btnLoaiPhong.BackColor = BUTTON_PRIMERY;
            btnDichVu.BackColor = BUTTON_PRIMERY;
            btnDoanhThu.BackColor = BUTTON_PRIMERY;
            btnTaiKhoan.BackColor = BUTTON_PRIMERY;
            btnAbout.BackColor = BUTTON_PRIMERY;

            // btn child Doanh Thu
            btnChiTietDoanhThu.BackColor = BUTTON_PRIMERY;
            btnDoanhThuGanDay.BackColor = BUTTON_PRIMERY;
            btnPhanTichBieuDo.BackColor = BUTTON_PRIMERY;

            // btn child Khach Hang
            btnKhachHangDangO.BackColor = BUTTON_PRIMERY;
            btnKhachHangDangDat.BackColor = BUTTON_PRIMERY;
            btnKhachHangCu.BackColor = BUTTON_PRIMERY;

            // btn child tai khoan
            btnDoiMatKhau.BackColor = BUTTON_PRIMERY;
            btnQuanLyTaiKhoan.BackColor = BUTTON_PRIMERY;

            //**********Change color button hover******//
            btnKhachHang.FlatAppearance.MouseDownBackColor = BUTTON_HOVER;
            btnKhachHang.FlatAppearance.MouseOverBackColor = BUTTON_HOVER;
            btnSoDoKhachSan.FlatAppearance.MouseDownBackColor = BUTTON_HOVER;
            btnSoDoKhachSan.FlatAppearance.MouseOverBackColor = BUTTON_HOVER;
            btnLoaiPhong.FlatAppearance.MouseDownBackColor = BUTTON_HOVER;
            btnLoaiPhong.FlatAppearance.MouseOverBackColor = BUTTON_HOVER;
            btnDichVu.FlatAppearance.MouseDownBackColor = BUTTON_HOVER;
            btnDichVu.FlatAppearance.MouseOverBackColor = BUTTON_HOVER;
            btnDoanhThu.FlatAppearance.MouseDownBackColor = BUTTON_HOVER;
            btnDoanhThu.FlatAppearance.MouseOverBackColor = BUTTON_HOVER;
            btnTaiKhoan.FlatAppearance.MouseDownBackColor = BUTTON_HOVER;
            btnTaiKhoan.FlatAppearance.MouseOverBackColor = BUTTON_HOVER;
            btnAbout.FlatAppearance.MouseDownBackColor = BUTTON_HOVER;
            btnAbout.FlatAppearance.MouseOverBackColor = BUTTON_HOVER;

            // btn child Doanh Thu
            btnChiTietDoanhThu.FlatAppearance.MouseDownBackColor = BUTTON_HOVER;
            btnChiTietDoanhThu.FlatAppearance.MouseOverBackColor = BUTTON_HOVER;
            btnDoanhThuGanDay.FlatAppearance.MouseDownBackColor = BUTTON_HOVER;
            btnDoanhThuGanDay.FlatAppearance.MouseOverBackColor = BUTTON_HOVER;
            btnPhanTichBieuDo.FlatAppearance.MouseDownBackColor = BUTTON_HOVER;
            btnPhanTichBieuDo.FlatAppearance.MouseOverBackColor = BUTTON_HOVER;

            // btn child Khach Hang
            btnKhachHangDangO.FlatAppearance.MouseDownBackColor = BUTTON_HOVER;
            btnKhachHangDangO.FlatAppearance.MouseOverBackColor = BUTTON_HOVER;
            btnKhachHangDangDat.FlatAppearance.MouseDownBackColor = BUTTON_HOVER;
            btnKhachHangDangDat.FlatAppearance.MouseOverBackColor = BUTTON_HOVER;
            btnKhachHangCu.FlatAppearance.MouseDownBackColor = BUTTON_HOVER;
            btnKhachHangCu.FlatAppearance.MouseOverBackColor = BUTTON_HOVER;

            // btn child tai khoan
            btnDoiMatKhau.FlatAppearance.MouseDownBackColor = BUTTON_HOVER;
            btnDoiMatKhau.FlatAppearance.MouseOverBackColor = BUTTON_HOVER;
            btnQuanLyTaiKhoan.FlatAppearance.MouseDownBackColor = BUTTON_HOVER;
            btnQuanLyTaiKhoan.FlatAppearance.MouseOverBackColor = BUTTON_HOVER;

            btnClose.FlatAppearance.MouseDownBackColor = BUTTON_HOVER;
            btnClose.FlatAppearance.MouseOverBackColor = BUTTON_HOVER;

            //*********change color font*********//
            btnKhachHang.ForeColor = TEXT_PRIMARY;
            btnSoDoKhachSan.ForeColor = TEXT_PRIMARY;
            btnLoaiPhong.ForeColor = TEXT_PRIMARY;
            btnDichVu.ForeColor = TEXT_PRIMARY;
            btnDoanhThu.ForeColor = TEXT_PRIMARY;
            btnTaiKhoan.ForeColor = TEXT_PRIMARY;
            btnAbout.ForeColor = TEXT_PRIMARY;

            // btn child Doanh Thu
            btnChiTietDoanhThu.ForeColor = TEXT_PRIMARY;
            btnDoanhThuGanDay.ForeColor = TEXT_PRIMARY;
            btnPhanTichBieuDo.ForeColor = TEXT_PRIMARY;

            // btn child Khach Hang
            btnKhachHangDangO.ForeColor = TEXT_PRIMARY;
            btnKhachHangDangDat.ForeColor = TEXT_PRIMARY;
            btnKhachHangCu.ForeColor = TEXT_PRIMARY;

            // btn child tai khoan
            btnDoiMatKhau.ForeColor = TEXT_PRIMARY;
            btnQuanLyTaiKhoan.ForeColor = TEXT_PRIMARY;
            themeToggle = !themeToggle;
        }

        int cbbThemeSelectedIndex = 0;
        private void cbbChangeTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbThemeSelectedIndex != ((ComboBox)sender).SelectedIndex)
            {
                ChangeTheme();
                cbbThemeSelectedIndex = ((ComboBox)sender).SelectedIndex;
            }
            
        }
	}
}
