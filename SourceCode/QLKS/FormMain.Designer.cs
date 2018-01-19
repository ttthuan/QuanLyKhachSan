namespace PresentationLayer
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.pnTitle = new System.Windows.Forms.Panel();
			this.cbbChangeTheme = new System.Windows.Forms.ComboBox();
			this.lbTaiKhoan = new System.Windows.Forms.Label();
			this.lbDangXuat = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			this.IconLoGo = new System.Windows.Forms.Button();
			this.lbTitleText = new System.Windows.Forms.Label();
			this.pnMenu = new System.Windows.Forms.FlowLayoutPanel();
			this.btnSoDoKhachSan = new System.Windows.Forms.Button();
			this.btnLoaiPhong = new System.Windows.Forms.Button();
			this.btnDichVu = new System.Windows.Forms.Button();
			this.pnDoanhThu = new System.Windows.Forms.Panel();
			this.btnPhanTichBieuDo = new System.Windows.Forms.Button();
			this.btnDoanhThuGanDay = new System.Windows.Forms.Button();
			this.btnChiTietDoanhThu = new System.Windows.Forms.Button();
			this.btnDoanhThu = new System.Windows.Forms.Button();
			this.pnKhachHang = new System.Windows.Forms.Panel();
			this.btnKhachHangCu = new System.Windows.Forms.Button();
			this.btnKhachHangDangDat = new System.Windows.Forms.Button();
			this.btnKhachHangDangO = new System.Windows.Forms.Button();
			this.btnKhachHang = new System.Windows.Forms.Button();
			this.pnTaiKhoan = new System.Windows.Forms.Panel();
			this.btnQuanLyTaiKhoan = new System.Windows.Forms.Button();
			this.btnDoiMatKhau = new System.Windows.Forms.Button();
			this.btnTaiKhoan = new System.Windows.Forms.Button();
			this.btnAbout = new System.Windows.Forms.Button();
			this.tmDanhThu = new System.Windows.Forms.Timer(this.components);
			this.pnBody = new System.Windows.Forms.Panel();
			this.tmKhachHang = new System.Windows.Forms.Timer(this.components);
			this.tmTaiKhoan = new System.Windows.Forms.Timer(this.components);
			this.pnTitle.SuspendLayout();
			this.pnMenu.SuspendLayout();
			this.pnDoanhThu.SuspendLayout();
			this.pnKhachHang.SuspendLayout();
			this.pnTaiKhoan.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnTitle
			// 
			this.pnTitle.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
			this.pnTitle.BackColor = System.Drawing.Color.White;
			this.pnTitle.Controls.Add(this.cbbChangeTheme);
			this.pnTitle.Controls.Add(this.lbTaiKhoan);
			this.pnTitle.Controls.Add(this.lbDangXuat);
			this.pnTitle.Controls.Add(this.btnClose);
			this.pnTitle.Controls.Add(this.IconLoGo);
			this.pnTitle.Controls.Add(this.lbTitleText);
			this.pnTitle.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnTitle.Location = new System.Drawing.Point(0, 0);
			this.pnTitle.Name = "pnTitle";
			this.pnTitle.Size = new System.Drawing.Size(1015, 45);
			this.pnTitle.TabIndex = 1;
			this.pnTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
			// 
			// cbbChangeTheme
			// 
			this.cbbChangeTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbbChangeTheme.FormattingEnabled = true;
			this.cbbChangeTheme.Items.AddRange(new object[] {
            "White",
            "Dark"});
			this.cbbChangeTheme.Location = new System.Drawing.Point(639, 13);
			this.cbbChangeTheme.Name = "cbbChangeTheme";
			this.cbbChangeTheme.Size = new System.Drawing.Size(65, 21);
			this.cbbChangeTheme.TabIndex = 5;
			this.cbbChangeTheme.SelectedIndexChanged += new System.EventHandler(this.cbbChangeTheme_SelectedIndexChanged);
			// 
			// lbTaiKhoan
			// 
			this.lbTaiKhoan.AutoSize = true;
			this.lbTaiKhoan.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lbTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lbTaiKhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.lbTaiKhoan.Location = new System.Drawing.Point(766, 15);
			this.lbTaiKhoan.Name = "lbTaiKhoan";
			this.lbTaiKhoan.Size = new System.Drawing.Size(114, 16);
			this.lbTaiKhoan.TabIndex = 4;
			this.lbTaiKhoan.Text = "Chào: Kiệt Trương";
			this.lbTaiKhoan.Click += new System.EventHandler(this.lbHello_Click);
			// 
			// lbDangXuat
			// 
			this.lbDangXuat.AutoSize = true;
			this.lbDangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lbDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lbDangXuat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(104)))), ((int)(((byte)(200)))));
			this.lbDangXuat.Location = new System.Drawing.Point(904, 15);
			this.lbDangXuat.Name = "lbDangXuat";
			this.lbDangXuat.Size = new System.Drawing.Size(67, 16);
			this.lbDangXuat.TabIndex = 3;
			this.lbDangXuat.Text = "Đăng xuất";
			this.lbDangXuat.Click += new System.EventHandler(this.lbDangXuat_Click);
			// 
			// btnClose
			// 
			this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
			this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Image = global::PresentationLayer.Properties.Resources.white_close_circle_outline;
			this.btnClose.Location = new System.Drawing.Point(982, 9);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(28, 26);
			this.btnClose.TabIndex = 2;
			this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// IconLoGo
			// 
			this.IconLoGo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.IconLoGo.FlatAppearance.BorderSize = 0;
			this.IconLoGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.IconLoGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.IconLoGo.ForeColor = System.Drawing.Color.White;
			this.IconLoGo.Image = global::PresentationLayer.Properties.Resources.white_bank;
			this.IconLoGo.Location = new System.Drawing.Point(6, 4);
			this.IconLoGo.Name = "IconLoGo";
			this.IconLoGo.Size = new System.Drawing.Size(23, 35);
			this.IconLoGo.TabIndex = 1;
			this.IconLoGo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.IconLoGo.UseVisualStyleBackColor = true;
			// 
			// lbTitleText
			// 
			this.lbTitleText.AutoSize = true;
			this.lbTitleText.BackColor = System.Drawing.Color.White;
			this.lbTitleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lbTitleText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.lbTitleText.Location = new System.Drawing.Point(35, 9);
			this.lbTitleText.Name = "lbTitleText";
			this.lbTitleText.Size = new System.Drawing.Size(195, 24);
			this.lbTitleText.TabIndex = 0;
			this.lbTitleText.Text = "Quản Lý Khách Sạn";
			// 
			// pnMenu
			// 
			this.pnMenu.AllowDrop = true;
			this.pnMenu.BackColor = System.Drawing.Color.White;
			this.pnMenu.Controls.Add(this.btnSoDoKhachSan);
			this.pnMenu.Controls.Add(this.btnLoaiPhong);
			this.pnMenu.Controls.Add(this.btnDichVu);
			this.pnMenu.Controls.Add(this.pnDoanhThu);
			this.pnMenu.Controls.Add(this.pnKhachHang);
			this.pnMenu.Controls.Add(this.pnTaiKhoan);
			this.pnMenu.Controls.Add(this.btnAbout);
			this.pnMenu.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnMenu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.pnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.pnMenu.Location = new System.Drawing.Point(0, 45);
			this.pnMenu.Margin = new System.Windows.Forms.Padding(0);
			this.pnMenu.Name = "pnMenu";
			this.pnMenu.Size = new System.Drawing.Size(210, 642);
			this.pnMenu.TabIndex = 0;
			// 
			// btnSoDoKhachSan
			// 
			this.btnSoDoKhachSan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.btnSoDoKhachSan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnSoDoKhachSan.FlatAppearance.BorderSize = 0;
			this.btnSoDoKhachSan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(65)))));
			this.btnSoDoKhachSan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(65)))));
			this.btnSoDoKhachSan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSoDoKhachSan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnSoDoKhachSan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.btnSoDoKhachSan.Image = global::PresentationLayer.Properties.Resources.white_map;
			this.btnSoDoKhachSan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSoDoKhachSan.Location = new System.Drawing.Point(0, 0);
			this.btnSoDoKhachSan.Margin = new System.Windows.Forms.Padding(0);
			this.btnSoDoKhachSan.Name = "btnSoDoKhachSan";
			this.btnSoDoKhachSan.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.btnSoDoKhachSan.Size = new System.Drawing.Size(210, 40);
			this.btnSoDoKhachSan.TabIndex = 0;
			this.btnSoDoKhachSan.Text = "  Sơ Đồ Khách Sạn";
			this.btnSoDoKhachSan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSoDoKhachSan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSoDoKhachSan.UseVisualStyleBackColor = false;
			this.btnSoDoKhachSan.MouseLeave += new System.EventHandler(this.button_MouseLeave);
			this.btnSoDoKhachSan.MouseHover += new System.EventHandler(this.button_MouseHover);
			this.btnSoDoKhachSan.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnSoDoKhachSan_MouseUp);
			// 
			// btnLoaiPhong
			// 
			this.btnLoaiPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.btnLoaiPhong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnLoaiPhong.FlatAppearance.BorderSize = 0;
			this.btnLoaiPhong.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(65)))));
			this.btnLoaiPhong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(65)))));
			this.btnLoaiPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnLoaiPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.btnLoaiPhong.Image = global::PresentationLayer.Properties.Resources.white_home_modern;
			this.btnLoaiPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnLoaiPhong.Location = new System.Drawing.Point(0, 40);
			this.btnLoaiPhong.Margin = new System.Windows.Forms.Padding(0);
			this.btnLoaiPhong.Name = "btnLoaiPhong";
			this.btnLoaiPhong.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.btnLoaiPhong.Size = new System.Drawing.Size(210, 40);
			this.btnLoaiPhong.TabIndex = 1;
			this.btnLoaiPhong.Text = "  Loại Phòng";
			this.btnLoaiPhong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnLoaiPhong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnLoaiPhong.UseVisualStyleBackColor = false;
			this.btnLoaiPhong.MouseLeave += new System.EventHandler(this.button_MouseLeave);
			this.btnLoaiPhong.MouseHover += new System.EventHandler(this.button_MouseHover);
			this.btnLoaiPhong.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnLoaiPhong_MouseUp);
			// 
			// btnDichVu
			// 
			this.btnDichVu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.btnDichVu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnDichVu.FlatAppearance.BorderSize = 0;
			this.btnDichVu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(65)))));
			this.btnDichVu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(65)))));
			this.btnDichVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
			this.btnDichVu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.btnDichVu.Image = global::PresentationLayer.Properties.Resources.white_food;
			this.btnDichVu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDichVu.Location = new System.Drawing.Point(0, 80);
			this.btnDichVu.Margin = new System.Windows.Forms.Padding(0);
			this.btnDichVu.Name = "btnDichVu";
			this.btnDichVu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.btnDichVu.Size = new System.Drawing.Size(210, 40);
			this.btnDichVu.TabIndex = 2;
			this.btnDichVu.Text = "  Dịch Vụ";
			this.btnDichVu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDichVu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnDichVu.UseVisualStyleBackColor = false;
			this.btnDichVu.MouseLeave += new System.EventHandler(this.button_MouseLeave);
			this.btnDichVu.MouseHover += new System.EventHandler(this.button_MouseHover);
			this.btnDichVu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnDichVu_MouseUp);
			// 
			// pnDoanhThu
			// 
			this.pnDoanhThu.BackColor = System.Drawing.Color.White;
			this.pnDoanhThu.Controls.Add(this.btnPhanTichBieuDo);
			this.pnDoanhThu.Controls.Add(this.btnDoanhThuGanDay);
			this.pnDoanhThu.Controls.Add(this.btnChiTietDoanhThu);
			this.pnDoanhThu.Controls.Add(this.btnDoanhThu);
			this.pnDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pnDoanhThu.Location = new System.Drawing.Point(0, 120);
			this.pnDoanhThu.Margin = new System.Windows.Forms.Padding(0);
			this.pnDoanhThu.Name = "pnDoanhThu";
			this.pnDoanhThu.Size = new System.Drawing.Size(210, 160);
			this.pnDoanhThu.TabIndex = 0;
			// 
			// btnPhanTichBieuDo
			// 
			this.btnPhanTichBieuDo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.btnPhanTichBieuDo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnPhanTichBieuDo.FlatAppearance.BorderSize = 0;
			this.btnPhanTichBieuDo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(65)))));
			this.btnPhanTichBieuDo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(65)))));
			this.btnPhanTichBieuDo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPhanTichBieuDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPhanTichBieuDo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.btnPhanTichBieuDo.Image = global::PresentationLayer.Properties.Resources.white_chart_bar;
			this.btnPhanTichBieuDo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnPhanTichBieuDo.Location = new System.Drawing.Point(0, 119);
			this.btnPhanTichBieuDo.Margin = new System.Windows.Forms.Padding(0);
			this.btnPhanTichBieuDo.Name = "btnPhanTichBieuDo";
			this.btnPhanTichBieuDo.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
			this.btnPhanTichBieuDo.Size = new System.Drawing.Size(210, 40);
			this.btnPhanTichBieuDo.TabIndex = 6;
			this.btnPhanTichBieuDo.Text = "  Phân Tích Biểu Đồ";
			this.btnPhanTichBieuDo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnPhanTichBieuDo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPhanTichBieuDo.UseVisualStyleBackColor = false;
			// 
			// btnDoanhThuGanDay
			// 
			this.btnDoanhThuGanDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.btnDoanhThuGanDay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnDoanhThuGanDay.FlatAppearance.BorderSize = 0;
			this.btnDoanhThuGanDay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(65)))));
			this.btnDoanhThuGanDay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(65)))));
			this.btnDoanhThuGanDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDoanhThuGanDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDoanhThuGanDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.btnDoanhThuGanDay.Image = global::PresentationLayer.Properties.Resources.white_cash_100;
			this.btnDoanhThuGanDay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDoanhThuGanDay.Location = new System.Drawing.Point(0, 80);
			this.btnDoanhThuGanDay.Margin = new System.Windows.Forms.Padding(0);
			this.btnDoanhThuGanDay.Name = "btnDoanhThuGanDay";
			this.btnDoanhThuGanDay.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
			this.btnDoanhThuGanDay.Size = new System.Drawing.Size(210, 40);
			this.btnDoanhThuGanDay.TabIndex = 5;
			this.btnDoanhThuGanDay.Text = "  Danh Thu Gần Đây";
			this.btnDoanhThuGanDay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDoanhThuGanDay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnDoanhThuGanDay.UseVisualStyleBackColor = false;
			// 
			// btnChiTietDoanhThu
			// 
			this.btnChiTietDoanhThu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.btnChiTietDoanhThu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnChiTietDoanhThu.FlatAppearance.BorderSize = 0;
			this.btnChiTietDoanhThu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(65)))));
			this.btnChiTietDoanhThu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(65)))));
			this.btnChiTietDoanhThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnChiTietDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnChiTietDoanhThu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.btnChiTietDoanhThu.Image = global::PresentationLayer.Properties.Resources.white_cash_multiple;
			this.btnChiTietDoanhThu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnChiTietDoanhThu.Location = new System.Drawing.Point(0, 40);
			this.btnChiTietDoanhThu.Margin = new System.Windows.Forms.Padding(0);
			this.btnChiTietDoanhThu.Name = "btnChiTietDoanhThu";
			this.btnChiTietDoanhThu.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
			this.btnChiTietDoanhThu.Size = new System.Drawing.Size(210, 40);
			this.btnChiTietDoanhThu.TabIndex = 4;
			this.btnChiTietDoanhThu.Text = "  Chi Tiết Doanh Thu";
			this.btnChiTietDoanhThu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnChiTietDoanhThu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnChiTietDoanhThu.UseVisualStyleBackColor = false;
			// 
			// btnDoanhThu
			// 
			this.btnDoanhThu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.btnDoanhThu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnDoanhThu.FlatAppearance.BorderSize = 0;
			this.btnDoanhThu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(65)))));
			this.btnDoanhThu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(65)))));
			this.btnDoanhThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
			this.btnDoanhThu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.btnDoanhThu.Image = global::PresentationLayer.Properties.Resources.white_cash_usd;
			this.btnDoanhThu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDoanhThu.Location = new System.Drawing.Point(0, 0);
			this.btnDoanhThu.Margin = new System.Windows.Forms.Padding(0);
			this.btnDoanhThu.Name = "btnDoanhThu";
			this.btnDoanhThu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.btnDoanhThu.Size = new System.Drawing.Size(210, 40);
			this.btnDoanhThu.TabIndex = 3;
			this.btnDoanhThu.Text = "  Doanh Thu";
			this.btnDoanhThu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDoanhThu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnDoanhThu.UseVisualStyleBackColor = false;
			this.btnDoanhThu.MouseLeave += new System.EventHandler(this.button_MouseLeave);
			this.btnDoanhThu.MouseHover += new System.EventHandler(this.button_MouseHover);
			this.btnDoanhThu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnDoanhThu_MouseUp);
			// 
			// pnKhachHang
			// 
			this.pnKhachHang.BackColor = System.Drawing.Color.White;
			this.pnKhachHang.Controls.Add(this.btnKhachHangCu);
			this.pnKhachHang.Controls.Add(this.btnKhachHangDangDat);
			this.pnKhachHang.Controls.Add(this.btnKhachHangDangO);
			this.pnKhachHang.Controls.Add(this.btnKhachHang);
			this.pnKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pnKhachHang.Location = new System.Drawing.Point(0, 280);
			this.pnKhachHang.Margin = new System.Windows.Forms.Padding(0);
			this.pnKhachHang.Name = "pnKhachHang";
			this.pnKhachHang.Size = new System.Drawing.Size(210, 160);
			this.pnKhachHang.TabIndex = 0;
			// 
			// btnKhachHangCu
			// 
			this.btnKhachHangCu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.btnKhachHangCu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnKhachHangCu.FlatAppearance.BorderSize = 0;
			this.btnKhachHangCu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(65)))));
			this.btnKhachHangCu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(65)))));
			this.btnKhachHangCu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnKhachHangCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnKhachHangCu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.btnKhachHangCu.Image = global::PresentationLayer.Properties.Resources.white_people_out;
			this.btnKhachHangCu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnKhachHangCu.Location = new System.Drawing.Point(0, 120);
			this.btnKhachHangCu.Margin = new System.Windows.Forms.Padding(0);
			this.btnKhachHangCu.Name = "btnKhachHangCu";
			this.btnKhachHangCu.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
			this.btnKhachHangCu.Size = new System.Drawing.Size(210, 40);
			this.btnKhachHangCu.TabIndex = 6;
			this.btnKhachHangCu.Text = "  Khách Hàng Cũ";
			this.btnKhachHangCu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnKhachHangCu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnKhachHangCu.UseVisualStyleBackColor = false;
			// 
			// btnKhachHangDangDat
			// 
			this.btnKhachHangDangDat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.btnKhachHangDangDat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnKhachHangDangDat.FlatAppearance.BorderSize = 0;
			this.btnKhachHangDangDat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(65)))));
			this.btnKhachHangDangDat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(65)))));
			this.btnKhachHangDangDat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnKhachHangDangDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnKhachHangDangDat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.btnKhachHangDangDat.Image = global::PresentationLayer.Properties.Resources.white_check_in;
			this.btnKhachHangDangDat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnKhachHangDangDat.Location = new System.Drawing.Point(0, 80);
			this.btnKhachHangDangDat.Margin = new System.Windows.Forms.Padding(0);
			this.btnKhachHangDangDat.Name = "btnKhachHangDangDat";
			this.btnKhachHangDangDat.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
			this.btnKhachHangDangDat.Size = new System.Drawing.Size(210, 40);
			this.btnKhachHangDangDat.TabIndex = 5;
			this.btnKhachHangDangDat.Text = "  Khách Hàng Đang Đặt";
			this.btnKhachHangDangDat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnKhachHangDangDat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnKhachHangDangDat.UseVisualStyleBackColor = false;
			// 
			// btnKhachHangDangO
			// 
			this.btnKhachHangDangO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.btnKhachHangDangO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnKhachHangDangO.FlatAppearance.BorderSize = 0;
			this.btnKhachHangDangO.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(65)))));
			this.btnKhachHangDangO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(65)))));
			this.btnKhachHangDangO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnKhachHangDangO.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnKhachHangDangO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.btnKhachHangDangO.Image = global::PresentationLayer.Properties.Resources.white_in_home;
			this.btnKhachHangDangO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnKhachHangDangO.Location = new System.Drawing.Point(0, 40);
			this.btnKhachHangDangO.Margin = new System.Windows.Forms.Padding(0);
			this.btnKhachHangDangO.Name = "btnKhachHangDangO";
			this.btnKhachHangDangO.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
			this.btnKhachHangDangO.Size = new System.Drawing.Size(210, 40);
			this.btnKhachHangDangO.TabIndex = 4;
			this.btnKhachHangDangO.Text = "  Khách Hàng Đang Ở";
			this.btnKhachHangDangO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnKhachHangDangO.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnKhachHangDangO.UseVisualStyleBackColor = false;
			// 
			// btnKhachHang
			// 
			this.btnKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.btnKhachHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnKhachHang.FlatAppearance.BorderSize = 0;
			this.btnKhachHang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(65)))));
			this.btnKhachHang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(65)))));
			this.btnKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
			this.btnKhachHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.btnKhachHang.Image = global::PresentationLayer.Properties.Resources.white_account_multiple_outline;
			this.btnKhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnKhachHang.Location = new System.Drawing.Point(0, 0);
			this.btnKhachHang.Margin = new System.Windows.Forms.Padding(0);
			this.btnKhachHang.Name = "btnKhachHang";
			this.btnKhachHang.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.btnKhachHang.Size = new System.Drawing.Size(210, 40);
			this.btnKhachHang.TabIndex = 5;
			this.btnKhachHang.Text = "  Khách Hàng";
			this.btnKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnKhachHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnKhachHang.UseVisualStyleBackColor = false;
			this.btnKhachHang.MouseLeave += new System.EventHandler(this.button_MouseLeave);
			this.btnKhachHang.MouseHover += new System.EventHandler(this.button_MouseHover);
			this.btnKhachHang.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnKhachHang_MouseUp);
			// 
			// pnTaiKhoan
			// 
			this.pnTaiKhoan.BackColor = System.Drawing.Color.White;
			this.pnTaiKhoan.Controls.Add(this.btnQuanLyTaiKhoan);
			this.pnTaiKhoan.Controls.Add(this.btnDoiMatKhau);
			this.pnTaiKhoan.Controls.Add(this.btnTaiKhoan);
			this.pnTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pnTaiKhoan.Location = new System.Drawing.Point(0, 440);
			this.pnTaiKhoan.Margin = new System.Windows.Forms.Padding(0);
			this.pnTaiKhoan.Name = "pnTaiKhoan";
			this.pnTaiKhoan.Size = new System.Drawing.Size(210, 120);
			this.pnTaiKhoan.TabIndex = 3;
			// 
			// btnQuanLyTaiKhoan
			// 
			this.btnQuanLyTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.btnQuanLyTaiKhoan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnQuanLyTaiKhoan.FlatAppearance.BorderSize = 0;
			this.btnQuanLyTaiKhoan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(65)))));
			this.btnQuanLyTaiKhoan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(65)))));
			this.btnQuanLyTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnQuanLyTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnQuanLyTaiKhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.btnQuanLyTaiKhoan.Image = global::PresentationLayer.Properties.Resources.white_folder_account;
			this.btnQuanLyTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnQuanLyTaiKhoan.Location = new System.Drawing.Point(0, 80);
			this.btnQuanLyTaiKhoan.Margin = new System.Windows.Forms.Padding(0);
			this.btnQuanLyTaiKhoan.Name = "btnQuanLyTaiKhoan";
			this.btnQuanLyTaiKhoan.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
			this.btnQuanLyTaiKhoan.Size = new System.Drawing.Size(210, 40);
			this.btnQuanLyTaiKhoan.TabIndex = 5;
			this.btnQuanLyTaiKhoan.Text = "  Quản Lý Tài Khoản";
			this.btnQuanLyTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnQuanLyTaiKhoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnQuanLyTaiKhoan.UseVisualStyleBackColor = false;
			// 
			// btnDoiMatKhau
			// 
			this.btnDoiMatKhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.btnDoiMatKhau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnDoiMatKhau.FlatAppearance.BorderSize = 0;
			this.btnDoiMatKhau.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(65)))));
			this.btnDoiMatKhau.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(65)))));
			this.btnDoiMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDoiMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDoiMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.btnDoiMatKhau.Image = global::PresentationLayer.Properties.Resources.white_lock_reset;
			this.btnDoiMatKhau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDoiMatKhau.Location = new System.Drawing.Point(0, 40);
			this.btnDoiMatKhau.Margin = new System.Windows.Forms.Padding(0);
			this.btnDoiMatKhau.Name = "btnDoiMatKhau";
			this.btnDoiMatKhau.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
			this.btnDoiMatKhau.Size = new System.Drawing.Size(210, 40);
			this.btnDoiMatKhau.TabIndex = 4;
			this.btnDoiMatKhau.Text = "  Đổi mật khẩu";
			this.btnDoiMatKhau.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDoiMatKhau.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnDoiMatKhau.UseVisualStyleBackColor = false;
			// 
			// btnTaiKhoan
			// 
			this.btnTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.btnTaiKhoan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnTaiKhoan.FlatAppearance.BorderSize = 0;
			this.btnTaiKhoan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(65)))));
			this.btnTaiKhoan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(65)))));
			this.btnTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
			this.btnTaiKhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.btnTaiKhoan.Image = global::PresentationLayer.Properties.Resources.white_account;
			this.btnTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnTaiKhoan.Location = new System.Drawing.Point(0, 0);
			this.btnTaiKhoan.Margin = new System.Windows.Forms.Padding(0);
			this.btnTaiKhoan.Name = "btnTaiKhoan";
			this.btnTaiKhoan.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.btnTaiKhoan.Size = new System.Drawing.Size(210, 40);
			this.btnTaiKhoan.TabIndex = 5;
			this.btnTaiKhoan.Text = "  Tài Khoản";
			this.btnTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnTaiKhoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnTaiKhoan.UseVisualStyleBackColor = false;
			this.btnTaiKhoan.MouseLeave += new System.EventHandler(this.button_MouseLeave);
			this.btnTaiKhoan.MouseHover += new System.EventHandler(this.button_MouseHover);
			this.btnTaiKhoan.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnTaiKhoan_MouseUp);
			// 
			// btnAbout
			// 
			this.btnAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.btnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnAbout.FlatAppearance.BorderSize = 0;
			this.btnAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(65)))));
			this.btnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(65)))));
			this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
			this.btnAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.btnAbout.Image = global::PresentationLayer.Properties.Resources.white_about;
			this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAbout.Location = new System.Drawing.Point(0, 560);
			this.btnAbout.Margin = new System.Windows.Forms.Padding(0);
			this.btnAbout.Name = "btnAbout";
			this.btnAbout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.btnAbout.Size = new System.Drawing.Size(210, 40);
			this.btnAbout.TabIndex = 6;
			this.btnAbout.Text = "About";
			this.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnAbout.UseVisualStyleBackColor = false;
			this.btnAbout.MouseLeave += new System.EventHandler(this.button_MouseLeave);
			this.btnAbout.MouseHover += new System.EventHandler(this.button_MouseHover);
			this.btnAbout.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnAbout_MouseUp);
			// 
			// tmDanhThu
			// 
			this.tmDanhThu.Interval = 10;
			this.tmDanhThu.Tick += new System.EventHandler(this.tmDanhThu_Tick);
			// 
			// pnBody
			// 
			this.pnBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(226)))), ((int)(((byte)(225)))));
			this.pnBody.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnBody.Location = new System.Drawing.Point(210, 45);
			this.pnBody.Margin = new System.Windows.Forms.Padding(0);
			this.pnBody.Name = "pnBody";
			this.pnBody.Size = new System.Drawing.Size(805, 642);
			this.pnBody.TabIndex = 3;
			// 
			// tmKhachHang
			// 
			this.tmKhachHang.Interval = 10;
			this.tmKhachHang.Tick += new System.EventHandler(this.tmKhachHang_Tick);
			// 
			// tmTaiKhoan
			// 
			this.tmTaiKhoan.Interval = 10;
			this.tmTaiKhoan.Tick += new System.EventHandler(this.tmTaiKhoan_Tick);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1015, 687);
			this.Controls.Add(this.pnBody);
			this.Controls.Add(this.pnMenu);
			this.Controls.Add(this.pnTitle);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = " from1";
			this.pnTitle.ResumeLayout(false);
			this.pnTitle.PerformLayout();
			this.pnMenu.ResumeLayout(false);
			this.pnDoanhThu.ResumeLayout(false);
			this.pnKhachHang.ResumeLayout(false);
			this.pnTaiKhoan.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button IconLoGo;
        private System.Windows.Forms.Label lbTitleText;
        private System.Windows.Forms.Button btnSoDoKhachSan;
        private System.Windows.Forms.Button btnDoanhThu;
        private System.Windows.Forms.Button btnDichVu;
        private System.Windows.Forms.Button btnLoaiPhong;
        private System.Windows.Forms.Button btnKhachHang;
        private System.Windows.Forms.FlowLayoutPanel pnMenu;
        private System.Windows.Forms.Panel pnDoanhThu;
        private System.Windows.Forms.Button btnPhanTichBieuDo;
        private System.Windows.Forms.Button btnDoanhThuGanDay;
        private System.Windows.Forms.Button btnChiTietDoanhThu;
        private System.Windows.Forms.Timer tmDanhThu;
        private System.Windows.Forms.Panel pnBody;
        private System.Windows.Forms.Panel pnKhachHang;
        private System.Windows.Forms.Button btnKhachHangDangDat;
        private System.Windows.Forms.Button btnKhachHangDangO;
        private System.Windows.Forms.Timer tmKhachHang;
        private System.Windows.Forms.Button btnKhachHangCu;
        private System.Windows.Forms.Label lbDangXuat;
        private System.Windows.Forms.Label lbTaiKhoan;
        private System.Windows.Forms.Panel pnTaiKhoan;
        private System.Windows.Forms.Button btnQuanLyTaiKhoan;
        private System.Windows.Forms.Button btnDoiMatKhau;
        private System.Windows.Forms.Button btnTaiKhoan;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Timer tmTaiKhoan;
        private System.Windows.Forms.ComboBox cbbChangeTheme;
    }
}