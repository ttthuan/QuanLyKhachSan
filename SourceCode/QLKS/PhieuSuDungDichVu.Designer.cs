namespace PresentationLayer
{
	partial class PhieuSuDungDichVu
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
			this.dataGridViewImageColumn4 = new System.Windows.Forms.DataGridViewImageColumn();
			this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
			this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
			this.bntHuy = new System.Windows.Forms.Button();
			this.cbmLoaiDV = new System.Windows.Forms.ComboBox();
			this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
			this.label4 = new System.Windows.Forms.Label();
			this.gridDSDV = new System.Windows.Forms.DataGridView();
			this.clThemDV = new System.Windows.Forms.DataGridViewImageColumn();
			this.label5 = new System.Windows.Forms.Label();
			this.gridDVdangSD = new System.Windows.Forms.DataGridView();
			this.clThem = new System.Windows.Forms.DataGridViewImageColumn();
			this.clGiam = new System.Windows.Forms.DataGridViewImageColumn();
			this.clXoa = new System.Windows.Forms.DataGridViewImageColumn();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panlTieuDe = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.dataGridViewImageColumn5 = new System.Windows.Forms.DataGridViewImageColumn();
			this.dataGridViewImageColumn6 = new System.Windows.Forms.DataGridViewImageColumn();
			this.dataGridViewImageColumn7 = new System.Windows.Forms.DataGridViewImageColumn();
			this.dataGridViewImageColumn8 = new System.Windows.Forms.DataGridViewImageColumn();
			((System.ComponentModel.ISupportInitialize)(this.gridDSDV)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridDVdangSD)).BeginInit();
			this.panel1.SuspendLayout();
			this.panlTieuDe.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridViewImageColumn4
			// 
			this.dataGridViewImageColumn4.HeaderText = "Bớt";
			this.dataGridViewImageColumn4.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
			this.dataGridViewImageColumn4.Name = "dataGridViewImageColumn4";
			// 
			// dataGridViewImageColumn2
			// 
			this.dataGridViewImageColumn2.HeaderText = "Bớt";
			this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
			this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
			// 
			// dataGridViewImageColumn1
			// 
			this.dataGridViewImageColumn1.HeaderText = "Thêm";
			this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
			this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
			// 
			// bntHuy
			// 
			this.bntHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(30)))), ((int)(((byte)(163)))));
			this.bntHuy.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bntHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bntHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.bntHuy.ForeColor = System.Drawing.Color.Snow;
			this.bntHuy.Location = new System.Drawing.Point(312, 477);
			this.bntHuy.Name = "bntHuy";
			this.bntHuy.Size = new System.Drawing.Size(94, 28);
			this.bntHuy.TabIndex = 41;
			this.bntHuy.Text = "Đóng";
			this.bntHuy.UseVisualStyleBackColor = false;
			this.bntHuy.Click += new System.EventHandler(this.bntHuy_Click);
			// 
			// cbmLoaiDV
			// 
			this.cbmLoaiDV.FormattingEnabled = true;
			this.cbmLoaiDV.Location = new System.Drawing.Point(100, 36);
			this.cbmLoaiDV.Name = "cbmLoaiDV";
			this.cbmLoaiDV.Size = new System.Drawing.Size(136, 21);
			this.cbmLoaiDV.TabIndex = 2;
			this.cbmLoaiDV.SelectedIndexChanged += new System.EventHandler(this.cbmLoaiDV_SelectedIndexChanged);
			// 
			// dataGridViewImageColumn3
			// 
			this.dataGridViewImageColumn3.HeaderText = "Thêm";
			this.dataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
			this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
			this.dataGridViewImageColumn3.Width = 613;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
			this.label4.Location = new System.Drawing.Point(9, 40);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(85, 16);
			this.label4.TabIndex = 0;
			this.label4.Text = "Loại dịch vụ :";
			// 
			// gridDSDV
			// 
			this.gridDSDV.AllowUserToAddRows = false;
			this.gridDSDV.AllowUserToDeleteRows = false;
			this.gridDSDV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gridDSDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridDSDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clThemDV});
			this.gridDSDV.Location = new System.Drawing.Point(13, 76);
			this.gridDSDV.Name = "gridDSDV";
			this.gridDSDV.ReadOnly = true;
			this.gridDSDV.RowHeadersVisible = false;
			this.gridDSDV.Size = new System.Drawing.Size(752, 161);
			this.gridDSDV.TabIndex = 1;
			this.gridDSDV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDSDV_CellClick);
			// 
			// clThemDV
			// 
			this.clThemDV.HeaderText = "Thêm";
			this.clThemDV.Image = global::PresentationLayer.Properties.Resources.library_plus;
			this.clThemDV.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
			this.clThemDV.Name = "clThemDV";
			this.clThemDV.ReadOnly = true;
			this.clThemDV.Width = 613;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
			this.label5.Location = new System.Drawing.Point(3, 15);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(158, 16);
			this.label5.TabIndex = 0;
			this.label5.Text = "Danh sách tất cả dịch vụ :\r\n";
			// 
			// gridDVdangSD
			// 
			this.gridDVdangSD.AllowUserToAddRows = false;
			this.gridDVdangSD.AllowUserToDeleteRows = false;
			this.gridDVdangSD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gridDVdangSD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridDVdangSD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clThem,
            this.clGiam,
            this.clXoa});
			this.gridDVdangSD.Location = new System.Drawing.Point(14, 22);
			this.gridDVdangSD.Name = "gridDVdangSD";
			this.gridDVdangSD.ReadOnly = true;
			this.gridDVdangSD.RowHeadersVisible = false;
			this.gridDVdangSD.Size = new System.Drawing.Size(752, 155);
			this.gridDVdangSD.TabIndex = 1;
			this.gridDVdangSD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDVdangSD_CellClick);
			// 
			// clThem
			// 
			this.clThem.HeaderText = "Thêm";
			this.clThem.Image = global::PresentationLayer.Properties.Resources.library_plus;
			this.clThem.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
			this.clThem.Name = "clThem";
			this.clThem.ReadOnly = true;
			// 
			// clGiam
			// 
			this.clGiam.HeaderText = "Bớt";
			this.clGiam.Image = global::PresentationLayer.Properties.Resources.minus_box;
			this.clGiam.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
			this.clGiam.Name = "clGiam";
			this.clGiam.ReadOnly = true;
			// 
			// clXoa
			// 
			this.clXoa.HeaderText = "Xóa";
			this.clXoa.Image = global::PresentationLayer.Properties.Resources.ic_close_black_48dp;
			this.clXoa.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
			this.clXoa.Name = "clXoa";
			this.clXoa.ReadOnly = true;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(226)))), ((int)(((byte)(225)))));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.gridDVdangSD);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Location = new System.Drawing.Point(0, 41);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(781, 184);
			this.panel1.TabIndex = 38;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
			this.label3.Location = new System.Drawing.Point(3, 5);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(207, 16);
			this.label3.TabIndex = 0;
			this.label3.Text = "Danh sách dịch vụ đang sử dụng :\r\n";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.label1.Location = new System.Drawing.Point(274, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(163, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Phiếu sử dụng dịch vụ";
			this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panlTieuDe_MouseDown);
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
			this.panlTieuDe.Size = new System.Drawing.Size(781, 40);
			this.panlTieuDe.TabIndex = 37;
			this.panlTieuDe.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panlTieuDe_MouseDown);
			// 
			// panel3
			// 
			this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(226)))), ((int)(((byte)(225)))));
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel3.Controls.Add(this.cbmLoaiDV);
			this.panel3.Controls.Add(this.label4);
			this.panel3.Controls.Add(this.gridDSDV);
			this.panel3.Controls.Add(this.label5);
			this.panel3.Location = new System.Drawing.Point(0, 231);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(781, 240);
			this.panel3.TabIndex = 39;
			// 
			// dataGridViewImageColumn5
			// 
			this.dataGridViewImageColumn5.HeaderText = "Thêm";
			this.dataGridViewImageColumn5.Image = global::PresentationLayer.Properties.Resources.library_plus;
			this.dataGridViewImageColumn5.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
			this.dataGridViewImageColumn5.Name = "dataGridViewImageColumn5";
			this.dataGridViewImageColumn5.Width = 613;
			// 
			// dataGridViewImageColumn6
			// 
			this.dataGridViewImageColumn6.HeaderText = "Thêm";
			this.dataGridViewImageColumn6.Image = global::PresentationLayer.Properties.Resources.library_plus;
			this.dataGridViewImageColumn6.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
			this.dataGridViewImageColumn6.Name = "dataGridViewImageColumn6";
			// 
			// dataGridViewImageColumn7
			// 
			this.dataGridViewImageColumn7.HeaderText = "Bớt";
			this.dataGridViewImageColumn7.Image = global::PresentationLayer.Properties.Resources.minus_box;
			this.dataGridViewImageColumn7.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
			this.dataGridViewImageColumn7.Name = "dataGridViewImageColumn7";
			// 
			// dataGridViewImageColumn8
			// 
			this.dataGridViewImageColumn8.HeaderText = "Xóa";
			this.dataGridViewImageColumn8.Image = global::PresentationLayer.Properties.Resources.ic_close_black_48dp;
			this.dataGridViewImageColumn8.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
			this.dataGridViewImageColumn8.Name = "dataGridViewImageColumn8";
			// 
			// PhieuSuDungDichVu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(780, 514);
			this.Controls.Add(this.bntHuy);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panlTieuDe);
			this.Controls.Add(this.panel3);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "PhieuSuDungDichVu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "PhieuSuDungDichVu";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PhieuSuDungDichVu_FormClosed);
			this.Load += new System.EventHandler(this.PhieuSuDungDichVu_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridDSDV)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridDVdangSD)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panlTieuDe.ResumeLayout(false);
			this.panlTieuDe.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn4;
		private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
		private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
		private System.Windows.Forms.Button bntHuy;
		private System.Windows.Forms.ComboBox cbmLoaiDV;
		private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridView gridDSDV;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DataGridView gridDVdangSD;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panlTieuDe;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.DataGridViewImageColumn clThemDV;
		private System.Windows.Forms.DataGridViewImageColumn clThem;
		private System.Windows.Forms.DataGridViewImageColumn clGiam;
		private System.Windows.Forms.DataGridViewImageColumn clXoa;
		private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn5;
		private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn6;
		private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn7;
		private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn8;
	}
}