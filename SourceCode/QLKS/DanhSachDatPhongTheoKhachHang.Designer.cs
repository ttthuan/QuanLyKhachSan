namespace PresentationLayer
{
	partial class DanhSachDatPhongTheoKhachHang
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
			this.label1 = new System.Windows.Forms.Label();
			this.btnChiTiet = new System.Windows.Forms.Button();
			this.bntHuy = new System.Windows.Forms.Button();
			this.panlTieuDe = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.gridDanhsachphong = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnNhanPhong = new System.Windows.Forms.Button();
			this.panlTieuDe.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridDanhsachphong)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.label1.Location = new System.Drawing.Point(216, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(162, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Danh sách đặt phòng";
			// 
			// btnChiTiet
			// 
			this.btnChiTiet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
			this.btnChiTiet.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnChiTiet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnChiTiet.ForeColor = System.Drawing.Color.Snow;
			this.btnChiTiet.Location = new System.Drawing.Point(126, 265);
			this.btnChiTiet.Name = "btnChiTiet";
			this.btnChiTiet.Size = new System.Drawing.Size(89, 28);
			this.btnChiTiet.TabIndex = 45;
			this.btnChiTiet.Text = "Xem chi tiết";
			this.btnChiTiet.UseVisualStyleBackColor = false;
			this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
			// 
			// bntHuy
			// 
			this.bntHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
			this.bntHuy.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bntHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bntHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.bntHuy.ForeColor = System.Drawing.Color.Snow;
			this.bntHuy.Location = new System.Drawing.Point(373, 265);
			this.bntHuy.Name = "bntHuy";
			this.bntHuy.Size = new System.Drawing.Size(94, 28);
			this.bntHuy.TabIndex = 46;
			this.bntHuy.Text = "Đóng";
			this.bntHuy.UseVisualStyleBackColor = false;
			this.bntHuy.Click += new System.EventHandler(this.bntHuy_Click);
			// 
			// panlTieuDe
			// 
			this.panlTieuDe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panlTieuDe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
			this.panlTieuDe.Controls.Add(this.label1);
			this.panlTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.panlTieuDe.Location = new System.Drawing.Point(0, 0);
			this.panlTieuDe.Margin = new System.Windows.Forms.Padding(0);
			this.panlTieuDe.Name = "panlTieuDe";
			this.panlTieuDe.Size = new System.Drawing.Size(593, 40);
			this.panlTieuDe.TabIndex = 42;
			this.panlTieuDe.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panlTieuDe_MouseDown);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(226)))), ((int)(((byte)(225)))));
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel2.Controls.Add(this.gridDanhsachphong);
			this.panel2.Location = new System.Drawing.Point(-1, 40);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(594, 202);
			this.panel2.TabIndex = 44;
			// 
			// gridDanhsachphong
			// 
			this.gridDanhsachphong.AllowUserToAddRows = false;
			this.gridDanhsachphong.AllowUserToDeleteRows = false;
			this.gridDanhsachphong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridDanhsachphong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
			this.gridDanhsachphong.Location = new System.Drawing.Point(0, -2);
			this.gridDanhsachphong.Name = "gridDanhsachphong";
			this.gridDanhsachphong.ReadOnly = true;
			this.gridDanhsachphong.Size = new System.Drawing.Size(592, 200);
			this.gridDanhsachphong.TabIndex = 27;
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "Ma";
			this.Column1.HeaderText = "Column1";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Visible = false;
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "Tenphong";
			this.Column2.HeaderText = "Phòng";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			// 
			// Column3
			// 
			this.Column3.DataPropertyName = "Thoigiannhanphong";
			this.Column3.HeaderText = "Thời gian nhận phòng";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			// 
			// Column4
			// 
			this.Column4.DataPropertyName = "Thoigiantraphong";
			this.Column4.HeaderText = "Thời gian trả";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			// 
			// Column5
			// 
			this.Column5.DataPropertyName = "Tenkhachhang";
			this.Column5.HeaderText = "Tên khách hàng";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			this.Column5.Visible = false;
			// 
			// btnNhanPhong
			// 
			this.btnNhanPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
			this.btnNhanPhong.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNhanPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNhanPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnNhanPhong.ForeColor = System.Drawing.Color.Snow;
			this.btnNhanPhong.Location = new System.Drawing.Point(251, 265);
			this.btnNhanPhong.Name = "btnNhanPhong";
			this.btnNhanPhong.Size = new System.Drawing.Size(89, 28);
			this.btnNhanPhong.TabIndex = 47;
			this.btnNhanPhong.Text = "Nhận phòng";
			this.btnNhanPhong.UseVisualStyleBackColor = false;
			this.btnNhanPhong.Click += new System.EventHandler(this.btnNhanPhong_Click);
			// 
			// DanhSachDatPhongTheoKhachHang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(593, 310);
			this.Controls.Add(this.btnNhanPhong);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.btnChiTiet);
			this.Controls.Add(this.bntHuy);
			this.Controls.Add(this.panlTieuDe);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "DanhSachDatPhongTheoKhachHang";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "DanhSachThuePhongTheoKhachHang";
			this.Load += new System.EventHandler(this.DanhSachDatPhongTheoKhachHang_Load);
			this.panlTieuDe.ResumeLayout(false);
			this.panlTieuDe.PerformLayout();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridDanhsachphong)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnChiTiet;
		private System.Windows.Forms.Button bntHuy;
		private System.Windows.Forms.Panel panlTieuDe;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGridView gridDanhsachphong;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.Button btnNhanPhong;
	}
}