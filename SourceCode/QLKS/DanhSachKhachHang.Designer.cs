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
			this.bntChiTietPhong = new System.Windows.Forms.Button();
			this.bntThemMoi = new System.Windows.Forms.Button();
			this.bntChiTiet = new System.Windows.Forms.Button();
			this.bntUpdateDS = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.gridKhachHang = new System.Windows.Forms.DataGridView();
			this.ctMenuGv = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.chitietKhachHang = new System.Windows.Forms.ToolStripMenuItem();
			this.chitietPhongdangthue = new System.Windows.Forms.ToolStripMenuItem();
			this.txtTimKH = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
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
			this.bntDatPhong.Location = new System.Drawing.Point(23, 232);
			this.bntDatPhong.Name = "bntDatPhong";
			this.bntDatPhong.Size = new System.Drawing.Size(106, 42);
			this.bntDatPhong.TabIndex = 30;
			this.bntDatPhong.Text = "Đặt Phòng";
			this.bntDatPhong.UseVisualStyleBackColor = false;
			this.bntDatPhong.Visible = false;
			// 
			// bntChiTietPhong
			// 
			this.bntChiTietPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(30)))), ((int)(((byte)(163)))));
			this.bntChiTietPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bntChiTietPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.bntChiTietPhong.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.bntChiTietPhong.Location = new System.Drawing.Point(23, 232);
			this.bntChiTietPhong.Name = "bntChiTietPhong";
			this.bntChiTietPhong.Size = new System.Drawing.Size(106, 42);
			this.bntChiTietPhong.TabIndex = 29;
			this.bntChiTietPhong.Text = "  Chi tiết \r\nThuê phòng";
			this.bntChiTietPhong.UseVisualStyleBackColor = false;
			this.bntChiTietPhong.Visible = false;
			// 
			// bntThemMoi
			// 
			this.bntThemMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(30)))), ((int)(((byte)(163)))));
			this.bntThemMoi.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bntThemMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bntThemMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.bntThemMoi.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.bntThemMoi.Location = new System.Drawing.Point(23, 170);
			this.bntThemMoi.Name = "bntThemMoi";
			this.bntThemMoi.Size = new System.Drawing.Size(106, 42);
			this.bntThemMoi.TabIndex = 28;
			this.bntThemMoi.Text = " Thêm mới \r\nKhách hàng";
			this.bntThemMoi.UseVisualStyleBackColor = false;
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
			// 
			// bntUpdateDS
			// 
			this.bntUpdateDS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.bntUpdateDS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(30)))), ((int)(((byte)(163)))));
			this.bntUpdateDS.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bntUpdateDS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bntUpdateDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.bntUpdateDS.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.bntUpdateDS.Location = new System.Drawing.Point(23, 438);
			this.bntUpdateDS.Name = "bntUpdateDS";
			this.bntUpdateDS.Size = new System.Drawing.Size(106, 42);
			this.bntUpdateDS.TabIndex = 23;
			this.bntUpdateDS.Text = "Cập nhật";
			this.bntUpdateDS.UseVisualStyleBackColor = false;
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
			this.gridKhachHang.ContextMenuStrip = this.ctMenuGv;
			this.gridKhachHang.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.gridKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridKhachHang.Location = new System.Drawing.Point(0, 0);
			this.gridKhachHang.Name = "gridKhachHang";
			this.gridKhachHang.Size = new System.Drawing.Size(681, 402);
			this.gridKhachHang.TabIndex = 0;
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
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(52, 5);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(129, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tất cả khách hàng";
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
			this.panel2.Controls.Add(this.label1);
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
			this.Controls.Add(this.bntDatPhong);
			this.Controls.Add(this.bntChiTietPhong);
			this.Controls.Add(this.bntThemMoi);
			this.Controls.Add(this.bntChiTiet);
			this.Controls.Add(this.bntUpdateDS);
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
		private System.Windows.Forms.Button bntChiTietPhong;
		private System.Windows.Forms.Button bntThemMoi;
		private System.Windows.Forms.Button bntChiTiet;
		private System.Windows.Forms.Button bntUpdateDS;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.DataGridView gridKhachHang;
		private System.Windows.Forms.ContextMenuStrip ctMenuGv;
		private System.Windows.Forms.ToolStripMenuItem chitietKhachHang;
		private System.Windows.Forms.ToolStripMenuItem chitietPhongdangthue;
		private System.Windows.Forms.TextBox txtTimKH;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel1;
	}
}