namespace PresentationLayer
{
	partial class QuanlyTaiKhoan
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanlyTaiKhoan));
			this.panel1 = new System.Windows.Forms.Panel();
			this.pnLoai = new System.Windows.Forms.Panel();
			this.gridNhanVien = new System.Windows.Forms.DataGridView();
			this.panel2 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.pnChitiet = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.label11 = new System.Windows.Forms.Label();
			this.rbNu = new System.Windows.Forms.RadioButton();
			this.rbNam = new System.Windows.Forms.RadioButton();
			this.txtSDT = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.txtTen = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.btnCapnhat = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.cbmChucvu = new System.Windows.Forms.ComboBox();
			this.btnThem = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.txtTaiKhoan = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.dtpkNgaySinh = new System.Windows.Forms.DateTimePicker();
			this.txtDiaChi = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.Ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Maloainhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Mataikhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Ma1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tendangnhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Matkhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pnLoai.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridNhanVien)).BeginInit();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.pnChitiet.SuspendLayout();
			this.panel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.AutoSize = true;
			this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(834, 0);
			this.panel1.TabIndex = 12;
			// 
			// pnLoai
			// 
			this.pnLoai.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnLoai.Controls.Add(this.gridNhanVien);
			this.pnLoai.Location = new System.Drawing.Point(10, 333);
			this.pnLoai.Name = "pnLoai";
			this.pnLoai.Size = new System.Drawing.Size(809, 263);
			this.pnLoai.TabIndex = 14;
			// 
			// gridNhanVien
			// 
			this.gridNhanVien.AllowUserToAddRows = false;
			this.gridNhanVien.AllowUserToDeleteRows = false;
			this.gridNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.gridNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma,
            this.Maloainhanvien,
            this.Ten,
            this.SDT,
            this.DiaChi,
            this.Gioitinh,
            this.Ngaysinh,
            this.Mataikhoan,
            this.Ma1,
            this.Tendangnhap,
            this.Matkhau});
			this.gridNhanVien.Location = new System.Drawing.Point(0, 3);
			this.gridNhanVien.Name = "gridNhanVien";
			this.gridNhanVien.ReadOnly = true;
			this.gridNhanVien.RowHeadersVisible = false;
			this.gridNhanVien.Size = new System.Drawing.Size(806, 260);
			this.gridNhanVien.TabIndex = 0;
			this.gridNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridNhanVien_CellClick);
			// 
			// panel2
			// 
			this.panel2.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
			this.panel2.AutoSize = true;
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(36)))), ((int)(((byte)(170)))));
			this.panel2.Controls.Add(this.button1);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(835, 31);
			this.panel2.TabIndex = 11;
			// 
			// button1
			// 
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.Location = new System.Drawing.Point(23, 0);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(23, 28);
			this.button1.TabIndex = 1;
			this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.button1.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(52, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(122, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Quản lý tài khoản";
			// 
			// panel3
			// 
			this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(226)))), ((int)(((byte)(225)))));
			this.panel3.Controls.Add(this.pnChitiet);
			this.panel3.Controls.Add(this.panel1);
			this.panel3.Location = new System.Drawing.Point(1, 32);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(834, 631);
			this.panel3.TabIndex = 12;
			// 
			// pnChitiet
			// 
			this.pnChitiet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnChitiet.Controls.Add(this.label7);
			this.pnChitiet.Controls.Add(this.panel4);
			this.pnChitiet.Controls.Add(this.pnLoai);
			this.pnChitiet.Location = new System.Drawing.Point(3, 29);
			this.pnChitiet.Name = "pnChitiet";
			this.pnChitiet.Size = new System.Drawing.Size(828, 599);
			this.pnChitiet.TabIndex = 31;
			// 
			// panel4
			// 
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel4.Controls.Add(this.txtDiaChi);
			this.panel4.Controls.Add(this.label5);
			this.panel4.Controls.Add(this.dtpkNgaySinh);
			this.panel4.Controls.Add(this.label4);
			this.panel4.Controls.Add(this.txtTaiKhoan);
			this.panel4.Controls.Add(this.label3);
			this.panel4.Controls.Add(this.label11);
			this.panel4.Controls.Add(this.rbNu);
			this.panel4.Controls.Add(this.rbNam);
			this.panel4.Controls.Add(this.txtSDT);
			this.panel4.Controls.Add(this.label10);
			this.panel4.Controls.Add(this.txtTen);
			this.panel4.Controls.Add(this.label9);
			this.panel4.Controls.Add(this.btnCapnhat);
			this.panel4.Controls.Add(this.label2);
			this.panel4.Controls.Add(this.cbmChucvu);
			this.panel4.Controls.Add(this.btnThem);
			this.panel4.Controls.Add(this.btnReset);
			this.panel4.Controls.Add(this.label6);
			this.panel4.Location = new System.Drawing.Point(10, 3);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(809, 285);
			this.panel4.TabIndex = 0;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
			this.label11.Location = new System.Drawing.Point(50, 151);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(61, 16);
			this.label11.TabIndex = 70;
			this.label11.Text = "Giới tính :";
			// 
			// rbNu
			// 
			this.rbNu.AutoSize = true;
			this.rbNu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
			this.rbNu.Location = new System.Drawing.Point(217, 151);
			this.rbNu.Name = "rbNu";
			this.rbNu.Size = new System.Drawing.Size(39, 17);
			this.rbNu.TabIndex = 61;
			this.rbNu.Text = "Nữ";
			this.rbNu.UseVisualStyleBackColor = true;
			// 
			// rbNam
			// 
			this.rbNam.AutoSize = true;
			this.rbNam.Checked = true;
			this.rbNam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
			this.rbNam.Location = new System.Drawing.Point(134, 151);
			this.rbNam.Name = "rbNam";
			this.rbNam.Size = new System.Drawing.Size(47, 17);
			this.rbNam.TabIndex = 60;
			this.rbNam.TabStop = true;
			this.rbNam.Text = "Nam";
			this.rbNam.UseVisualStyleBackColor = true;
			// 
			// txtSDT
			// 
			this.txtSDT.BackColor = System.Drawing.Color.White;
			this.txtSDT.Location = new System.Drawing.Point(123, 101);
			this.txtSDT.MaxLength = 50;
			this.txtSDT.Name = "txtSDT";
			this.txtSDT.Size = new System.Drawing.Size(186, 20);
			this.txtSDT.TabIndex = 59;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
			this.label10.Location = new System.Drawing.Point(25, 102);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(92, 16);
			this.label10.TabIndex = 58;
			this.label10.Text = "Số điện thoại :";
			// 
			// txtTen
			// 
			this.txtTen.BackColor = System.Drawing.Color.White;
			this.txtTen.Location = new System.Drawing.Point(534, 32);
			this.txtTen.MaxLength = 50;
			this.txtTen.Name = "txtTen";
			this.txtTen.Size = new System.Drawing.Size(208, 20);
			this.txtTen.TabIndex = 57;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
			this.label9.Location = new System.Drawing.Point(441, 33);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(38, 16);
			this.label9.TabIndex = 56;
			this.label9.Text = "Tên :";
			// 
			// btnCapnhat
			// 
			this.btnCapnhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(0)))), ((int)(((byte)(114)))));
			this.btnCapnhat.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCapnhat.FlatAppearance.BorderSize = 0;
			this.btnCapnhat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(0)))), ((int)(((byte)(114)))));
			this.btnCapnhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCapnhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
			this.btnCapnhat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnCapnhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCapnhat.Location = new System.Drawing.Point(229, 228);
			this.btnCapnhat.Name = "btnCapnhat";
			this.btnCapnhat.Size = new System.Drawing.Size(143, 30);
			this.btnCapnhat.TabIndex = 53;
			this.btnCapnhat.Text = "Đổi thông tin";
			this.btnCapnhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCapnhat.UseVisualStyleBackColor = false;
			this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
			this.label2.Location = new System.Drawing.Point(25, 67);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 16);
			this.label2.TabIndex = 52;
			this.label2.Text = "Chức vụ :";
			// 
			// cbmChucvu
			// 
			this.cbmChucvu.BackColor = System.Drawing.Color.White;
			this.cbmChucvu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbmChucvu.FormattingEnabled = true;
			this.cbmChucvu.Location = new System.Drawing.Point(123, 66);
			this.cbmChucvu.Name = "cbmChucvu";
			this.cbmChucvu.Size = new System.Drawing.Size(186, 21);
			this.cbmChucvu.TabIndex = 51;
			// 
			// btnThem
			// 
			this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(0)))), ((int)(((byte)(114)))));
			this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnThem.FlatAppearance.BorderSize = 0;
			this.btnThem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(0)))), ((int)(((byte)(114)))));
			this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
			this.btnThem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnThem.Location = new System.Drawing.Point(39, 228);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(144, 30);
			this.btnThem.TabIndex = 48;
			this.btnThem.Text = "Thêm tài khoản";
			this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnThem.UseVisualStyleBackColor = false;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// btnReset
			// 
			this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(0)))), ((int)(((byte)(114)))));
			this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnReset.FlatAppearance.BorderSize = 0;
			this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(0)))), ((int)(((byte)(114)))));
			this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
			this.btnReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnReset.Location = new System.Drawing.Point(424, 228);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(144, 30);
			this.btnReset.TabIndex = 41;
			this.btnReset.Text = "Reset mật khẩu";
			this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnReset.UseVisualStyleBackColor = false;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
			this.label6.Location = new System.Drawing.Point(5, 7);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(196, 13);
			this.label6.TabIndex = 33;
			this.label6.Text = "Thông tin nhân viên và tài khoản";
			// 
			// txtTaiKhoan
			// 
			this.txtTaiKhoan.BackColor = System.Drawing.Color.White;
			this.txtTaiKhoan.Location = new System.Drawing.Point(123, 32);
			this.txtTaiKhoan.MaxLength = 50;
			this.txtTaiKhoan.Name = "txtTaiKhoan";
			this.txtTaiKhoan.Size = new System.Drawing.Size(186, 20);
			this.txtTaiKhoan.TabIndex = 72;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
			this.label3.Location = new System.Drawing.Point(25, 33);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(74, 16);
			this.label3.TabIndex = 71;
			this.label3.Text = "Tài khoản :";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
			this.label4.Location = new System.Drawing.Point(441, 68);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(74, 16);
			this.label4.TabIndex = 73;
			this.label4.Text = "Ngày sinh :";
			// 
			// dtpkNgaySinh
			// 
			this.dtpkNgaySinh.Location = new System.Drawing.Point(534, 64);
			this.dtpkNgaySinh.Name = "dtpkNgaySinh";
			this.dtpkNgaySinh.Size = new System.Drawing.Size(208, 20);
			this.dtpkNgaySinh.TabIndex = 74;
			// 
			// txtDiaChi
			// 
			this.txtDiaChi.BackColor = System.Drawing.Color.White;
			this.txtDiaChi.Location = new System.Drawing.Point(534, 102);
			this.txtDiaChi.MaxLength = 50;
			this.txtDiaChi.Multiline = true;
			this.txtDiaChi.Name = "txtDiaChi";
			this.txtDiaChi.Size = new System.Drawing.Size(208, 66);
			this.txtDiaChi.TabIndex = 76;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
			this.label5.Location = new System.Drawing.Point(441, 102);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(54, 16);
			this.label5.TabIndex = 75;
			this.label5.Text = "Địa chỉ :";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(10, 314);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(115, 13);
			this.label7.TabIndex = 15;
			this.label7.Text = "Danh sách nhân viên :";
			// 
			// Ma
			// 
			this.Ma.DataPropertyName = "Ma";
			this.Ma.HeaderText = "Column1";
			this.Ma.Name = "Ma";
			this.Ma.ReadOnly = true;
			this.Ma.Visible = false;
			// 
			// Maloainhanvien
			// 
			this.Maloainhanvien.DataPropertyName = "Maloainhanvien";
			this.Maloainhanvien.HeaderText = "Loại nhân viên";
			this.Maloainhanvien.Name = "Maloainhanvien";
			this.Maloainhanvien.ReadOnly = true;
			this.Maloainhanvien.Visible = false;
			// 
			// Ten
			// 
			this.Ten.DataPropertyName = "Ten";
			this.Ten.HeaderText = "Tên";
			this.Ten.Name = "Ten";
			this.Ten.ReadOnly = true;
			// 
			// SDT
			// 
			this.SDT.DataPropertyName = "SDT";
			this.SDT.HeaderText = "Số điện thoại";
			this.SDT.Name = "SDT";
			this.SDT.ReadOnly = true;
			this.SDT.Visible = false;
			// 
			// DiaChi
			// 
			this.DiaChi.DataPropertyName = "DiaChi";
			this.DiaChi.HeaderText = "địa chỉ";
			this.DiaChi.Name = "DiaChi";
			this.DiaChi.ReadOnly = true;
			this.DiaChi.Visible = false;
			// 
			// Gioitinh
			// 
			this.Gioitinh.DataPropertyName = "Gioitinh";
			this.Gioitinh.HeaderText = "Giới tính";
			this.Gioitinh.Name = "Gioitinh";
			this.Gioitinh.ReadOnly = true;
			this.Gioitinh.Visible = false;
			// 
			// Ngaysinh
			// 
			this.Ngaysinh.DataPropertyName = "Ngaysinh";
			this.Ngaysinh.HeaderText = "Ngày sinh";
			this.Ngaysinh.Name = "Ngaysinh";
			this.Ngaysinh.ReadOnly = true;
			this.Ngaysinh.Visible = false;
			// 
			// Mataikhoan
			// 
			this.Mataikhoan.DataPropertyName = "Mataikhoan";
			this.Mataikhoan.HeaderText = "Mã tài khoản";
			this.Mataikhoan.Name = "Mataikhoan";
			this.Mataikhoan.ReadOnly = true;
			this.Mataikhoan.Visible = false;
			// 
			// Ma1
			// 
			this.Ma1.DataPropertyName = "Ma1";
			this.Ma1.HeaderText = "Mã TK";
			this.Ma1.Name = "Ma1";
			this.Ma1.ReadOnly = true;
			this.Ma1.Visible = false;
			// 
			// Tendangnhap
			// 
			this.Tendangnhap.DataPropertyName = "Tendangnhap";
			this.Tendangnhap.HeaderText = "Tên đăng nhập";
			this.Tendangnhap.Name = "Tendangnhap";
			this.Tendangnhap.ReadOnly = true;
			// 
			// Matkhau
			// 
			this.Matkhau.DataPropertyName = "Matkhau";
			this.Matkhau.HeaderText = "Mật khẩu";
			this.Matkhau.Name = "Matkhau";
			this.Matkhau.ReadOnly = true;
			this.Matkhau.Visible = false;
			// 
			// QuanlyTaiKhoan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(835, 663);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel3);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "QuanlyTaiKhoan";
			this.Text = "QuanlyTaiKhoan";
			this.pnLoai.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridNhanVien)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.pnChitiet.ResumeLayout(false);
			this.pnChitiet.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel pnLoai;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel pnChitiet;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.RadioButton rbNu;
		private System.Windows.Forms.RadioButton rbNam;
		private System.Windows.Forms.TextBox txtSDT;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtTen;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button btnCapnhat;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cbmChucvu;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DataGridView gridNhanVien;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtDiaChi;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker dtpkNgaySinh;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtTaiKhoan;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Ma;
		private System.Windows.Forms.DataGridViewTextBoxColumn Maloainhanvien;
		private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
		private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
		private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
		private System.Windows.Forms.DataGridViewTextBoxColumn Gioitinh;
		private System.Windows.Forms.DataGridViewTextBoxColumn Ngaysinh;
		private System.Windows.Forms.DataGridViewTextBoxColumn Mataikhoan;
		private System.Windows.Forms.DataGridViewTextBoxColumn Ma1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tendangnhap;
		private System.Windows.Forms.DataGridViewTextBoxColumn Matkhau;
	}
}