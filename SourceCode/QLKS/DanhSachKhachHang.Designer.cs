namespace PresentationLayer
{
	partial class DanhSachKhachHang
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhSachKhachHang));
			this.bntDatPhong = new System.Windows.Forms.Button();
			this.bntChiTietThuePhong = new System.Windows.Forms.Button();
			this.bntChiTiet = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.gridKhachHang = new System.Windows.Forms.DataGridView();
			this.Ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SoCMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Quoctich = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ctMenuGv = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.chitietKhachHang = new System.Windows.Forms.ToolStripMenuItem();
			this.chitietPhongdangthue = new System.Windows.Forms.ToolStripMenuItem();
			this.txtTimKH = new System.Windows.Forms.TextBox();
			this.lbTittle = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.bntTraPhong = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridKhachHang)).BeginInit();
			this.ctMenuGv.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// bntDatPhong
			// 
			this.bntDatPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(30)))), ((int)(((byte)(163)))));
			this.bntDatPhong.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bntDatPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bntDatPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.bntDatPhong.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.bntDatPhong.Location = new System.Drawing.Point(23, 184);
			this.bntDatPhong.Name = "bntDatPhong";
			this.bntDatPhong.Size = new System.Drawing.Size(106, 42);
			this.bntDatPhong.TabIndex = 30;
			this.bntDatPhong.Text = "Đặt Phòng";
			this.bntDatPhong.UseVisualStyleBackColor = false;
			this.bntDatPhong.Visible = false;
			this.bntDatPhong.Click += new System.EventHandler(this.bntDatPhong_Click);
			// 
			// bntChiTietThuePhong
			// 
			this.bntChiTietThuePhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(30)))), ((int)(((byte)(163)))));
			this.bntChiTietThuePhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bntChiTietThuePhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.bntChiTietThuePhong.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.bntChiTietThuePhong.Location = new System.Drawing.Point(23, 184);
			this.bntChiTietThuePhong.Name = "bntChiTietThuePhong";
			this.bntChiTietThuePhong.Size = new System.Drawing.Size(106, 42);
			this.bntChiTietThuePhong.TabIndex = 29;
			this.bntChiTietThuePhong.Text = "  Chi tiết \r\nThuê phòng";
			this.bntChiTietThuePhong.UseVisualStyleBackColor = false;
			this.bntChiTietThuePhong.Visible = false;
			this.bntChiTietThuePhong.Click += new System.EventHandler(this.bntChiTietThuePhong_Click);
			// 
			// bntChiTiet
			// 
			this.bntChiTiet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(30)))), ((int)(((byte)(163)))));
			this.bntChiTiet.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bntChiTiet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bntChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.bntChiTiet.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.bntChiTiet.Location = new System.Drawing.Point(23, 109);
			this.bntChiTiet.Name = "bntChiTiet";
			this.bntChiTiet.Size = new System.Drawing.Size(106, 42);
			this.bntChiTiet.TabIndex = 27;
			this.bntChiTiet.Text = "  Chi tiết\r\n Khách hàng";
			this.bntChiTiet.UseVisualStyleBackColor = false;
			this.bntChiTiet.Click += new System.EventHandler(this.bntChiTiet_Click);
			// 
			// panel3
			// 
			this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel3.Controls.Add(this.gridKhachHang);
			this.panel3.Location = new System.Drawing.Point(151, 78);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(681, 402);
			this.panel3.TabIndex = 26;
			// 
			// gridKhachHang
			// 
			this.gridKhachHang.AllowUserToAddRows = false;
			this.gridKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma,
            this.Ten,
            this.Diachi,
            this.Sdt,
            this.Gioitinh,
            this.SoCMND,
            this.Quoctich});
			this.gridKhachHang.ContextMenuStrip = this.ctMenuGv;
			this.gridKhachHang.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.gridKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridKhachHang.Location = new System.Drawing.Point(0, 0);
			this.gridKhachHang.Name = "gridKhachHang";
			this.gridKhachHang.Size = new System.Drawing.Size(681, 402);
			this.gridKhachHang.TabIndex = 0;
			// 
			// Ma
			// 
			this.Ma.DataPropertyName = "Ma";
			this.Ma.HeaderText = "Mã";
			this.Ma.Name = "Ma";
			this.Ma.ReadOnly = true;
			// 
			// Ten
			// 
			this.Ten.DataPropertyName = "Ten";
			this.Ten.HeaderText = "Tên";
			this.Ten.Name = "Ten";
			this.Ten.ReadOnly = true;
			// 
			// Diachi
			// 
			this.Diachi.DataPropertyName = "DiaChi";
			this.Diachi.HeaderText = "Địa chỉ";
			this.Diachi.Name = "Diachi";
			this.Diachi.ReadOnly = true;
			this.Diachi.Visible = false;
			// 
			// Sdt
			// 
			this.Sdt.DataPropertyName = "Sdt";
			this.Sdt.HeaderText = "Số điện thoại";
			this.Sdt.Name = "Sdt";
			this.Sdt.ReadOnly = true;
			// 
			// Gioitinh
			// 
			this.Gioitinh.DataPropertyName = "GioiTinh";
			this.Gioitinh.HeaderText = "Giới tính";
			this.Gioitinh.Name = "Gioitinh";
			this.Gioitinh.ReadOnly = true;
			this.Gioitinh.Visible = false;
			// 
			// SoCMND
			// 
			this.SoCMND.DataPropertyName = "Scmnd";
			this.SoCMND.HeaderText = "Số CMND";
			this.SoCMND.Name = "SoCMND";
			this.SoCMND.ReadOnly = true;
			// 
			// Quoctich
			// 
			this.Quoctich.DataPropertyName = "QuocTich";
			this.Quoctich.HeaderText = "Quốc tịch";
			this.Quoctich.Name = "Quoctich";
			this.Quoctich.ReadOnly = true;
			this.Quoctich.Visible = false;
			// 
			// ctMenuGv
			// 
			this.ctMenuGv.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chitietKhachHang,
            this.chitietPhongdangthue});
			this.ctMenuGv.Name = "ctMenuGv";
			this.ctMenuGv.Size = new System.Drawing.Size(179, 48);
			// 
			// chitietKhachHang
			// 
			this.chitietKhachHang.Name = "chitietKhachHang";
			this.chitietKhachHang.Size = new System.Drawing.Size(178, 22);
			this.chitietKhachHang.Text = "Chi tiết Khách hàng";
			// 
			// chitietPhongdangthue
			// 
			this.chitietPhongdangthue.Name = "chitietPhongdangthue";
			this.chitietPhongdangthue.Size = new System.Drawing.Size(178, 22);
			this.chitietPhongdangthue.Text = "Chi tiết thuê Phòng";
			// 
			// txtTimKH
			// 
			this.txtTimKH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.txtTimKH.Location = new System.Drawing.Point(103, 13);
			this.txtTimKH.Name = "txtTimKH";
			this.txtTimKH.Size = new System.Drawing.Size(198, 20);
			this.txtTimKH.TabIndex = 13;
			// 
			// lbTittle
			// 
			this.lbTittle.AutoSize = true;
			this.lbTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTittle.ForeColor = System.Drawing.Color.White;
			this.lbTittle.Location = new System.Drawing.Point(52, 5);
			this.lbTittle.Name = "lbTittle";
			this.lbTittle.Size = new System.Drawing.Size(129, 18);
			this.lbTittle.TabIndex = 0;
			this.lbTittle.Text = "Tất cả khách hàng";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
			this.label3.Location = new System.Drawing.Point(20, 14);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(69, 16);
			this.label3.TabIndex = 12;
			this.label3.Text = "Tìm kiếm :";
			// 
			// panel2
			// 
			this.panel2.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
			this.panel2.AutoSize = true;
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(36)))), ((int)(((byte)(170)))));
			this.panel2.Controls.Add(this.button1);
			this.panel2.Controls.Add(this.lbTittle);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(835, 31);
			this.panel2.TabIndex = 24;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.AutoSize = true;
			this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.panel1.Controls.Add(this.txtTimKH);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Location = new System.Drawing.Point(0, 37);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(835, 41);
			this.panel1.TabIndex = 25;
			// 
			// bntTraPhong
			// 
			this.bntTraPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(30)))), ((int)(((byte)(163)))));
			this.bntTraPhong.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bntTraPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bntTraPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.bntTraPhong.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.bntTraPhong.Location = new System.Drawing.Point(23, 257);
			this.bntTraPhong.Name = "bntTraPhong";
			this.bntTraPhong.Size = new System.Drawing.Size(106, 42);
			this.bntTraPhong.TabIndex = 31;
			this.bntTraPhong.Text = "Trả phòng";
			this.bntTraPhong.UseVisualStyleBackColor = false;
			this.bntTraPhong.Visible = false;
			this.bntTraPhong.Click += new System.EventHandler(this.bntTraPhong_Click);
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
			this.button1.TabIndex = 10;
			this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.button1.UseVisualStyleBackColor = true;
			// 
			// DanhSachKhachHang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(835, 486);
			this.Controls.Add(this.bntTraPhong);
			this.Controls.Add(this.bntDatPhong);
			this.Controls.Add(this.bntChiTietThuePhong);
			this.Controls.Add(this.bntChiTiet);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "DanhSachKhachHang";
			this.Text = "DanhSachKhachHang";
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridKhachHang)).EndInit();
			this.ctMenuGv.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button bntDatPhong;
		private System.Windows.Forms.Button bntChiTietThuePhong;
		private System.Windows.Forms.Button bntChiTiet;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.DataGridView gridKhachHang;
		private System.Windows.Forms.ContextMenuStrip ctMenuGv;
		private System.Windows.Forms.ToolStripMenuItem chitietKhachHang;
		private System.Windows.Forms.ToolStripMenuItem chitietPhongdangthue;
		private System.Windows.Forms.TextBox txtTimKH;
		private System.Windows.Forms.Label lbTittle;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Ma;
		private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
		private System.Windows.Forms.DataGridViewTextBoxColumn Diachi;
		private System.Windows.Forms.DataGridViewTextBoxColumn Sdt;
		private System.Windows.Forms.DataGridViewTextBoxColumn Gioitinh;
		private System.Windows.Forms.DataGridViewTextBoxColumn SoCMND;
		private System.Windows.Forms.DataGridViewTextBoxColumn Quoctich;
		private System.Windows.Forms.Button bntTraPhong;
	}
}