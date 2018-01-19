namespace PresentationLayer
{
	partial class DichVuvaLoaiDichVu
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DichVuvaLoaiDichVu));
			this.pnLoai = new System.Windows.Forms.Panel();
			this.gridLoai = new System.Windows.Forms.DataGridView();
			this.MaLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TenLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bntThemLoai = new System.Windows.Forms.Button();
			this.panel5 = new System.Windows.Forms.Panel();
			this.txtDonvi = new System.Windows.Forms.TextBox();
			this.cbmLoai = new System.Windows.Forms.ComboBox();
			this.label11 = new System.Windows.Forms.Label();
			this.txtGia = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.bntThemDV = new System.Windows.Forms.Button();
			this.bntCapNhatDV = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.txtTenDV = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.bntCapNhatLoai = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.pnChitiet = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.txtTenLoai = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.rbTatca = new System.Windows.Forms.RadioButton();
			this.rbLoai = new System.Windows.Forms.RadioButton();
			this.label3 = new System.Windows.Forms.Label();
			this.pnDV = new System.Windows.Forms.Panel();
			this.gridDV = new System.Windows.Forms.DataGridView();
			this.Ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Donvitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Maloaidichvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
			this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
			this.pnLoai.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridLoai)).BeginInit();
			this.panel5.SuspendLayout();
			this.panel3.SuspendLayout();
			this.pnChitiet.SuspendLayout();
			this.panel4.SuspendLayout();
			this.pnDV.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridDV)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnLoai
			// 
			this.pnLoai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnLoai.Controls.Add(this.gridLoai);
			this.pnLoai.Location = new System.Drawing.Point(325, 3);
			this.pnLoai.Name = "pnLoai";
			this.pnLoai.Size = new System.Drawing.Size(503, 257);
			this.pnLoai.TabIndex = 14;
			// 
			// gridLoai
			// 
			this.gridLoai.AllowUserToAddRows = false;
			this.gridLoai.AllowUserToDeleteRows = false;
			this.gridLoai.AllowUserToOrderColumns = true;
			this.gridLoai.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.gridLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridLoai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLoai,
            this.TenLoai});
			this.gridLoai.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridLoai.Location = new System.Drawing.Point(0, 0);
			this.gridLoai.Name = "gridLoai";
			this.gridLoai.ReadOnly = true;
			this.gridLoai.RowHeadersVisible = false;
			this.gridLoai.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.gridLoai.Size = new System.Drawing.Size(503, 257);
			this.gridLoai.TabIndex = 0;
			this.gridLoai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridLoai_CellClick);
			// 
			// MaLoai
			// 
			this.MaLoai.DataPropertyName = "Ma";
			this.MaLoai.HeaderText = "Mã";
			this.MaLoai.Name = "MaLoai";
			this.MaLoai.ReadOnly = true;
			this.MaLoai.Visible = false;
			// 
			// TenLoai
			// 
			this.TenLoai.DataPropertyName = "Ten";
			this.TenLoai.HeaderText = "Tên Loại";
			this.TenLoai.Name = "TenLoai";
			this.TenLoai.ReadOnly = true;
			// 
			// bntThemLoai
			// 
			this.bntThemLoai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(30)))), ((int)(((byte)(163)))));
			this.bntThemLoai.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bntThemLoai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bntThemLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.bntThemLoai.ForeColor = System.Drawing.Color.Snow;
			this.bntThemLoai.Location = new System.Drawing.Point(165, 127);
			this.bntThemLoai.Name = "bntThemLoai";
			this.bntThemLoai.Size = new System.Drawing.Size(89, 28);
			this.bntThemLoai.TabIndex = 37;
			this.bntThemLoai.Text = "Thêm mới";
			this.bntThemLoai.UseVisualStyleBackColor = false;
			this.bntThemLoai.Click += new System.EventHandler(this.bntThemLoai_Click);
			// 
			// panel5
			// 
			this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel5.Controls.Add(this.txtDonvi);
			this.panel5.Controls.Add(this.cbmLoai);
			this.panel5.Controls.Add(this.label11);
			this.panel5.Controls.Add(this.txtGia);
			this.panel5.Controls.Add(this.label10);
			this.panel5.Controls.Add(this.bntThemDV);
			this.panel5.Controls.Add(this.bntCapNhatDV);
			this.panel5.Controls.Add(this.label9);
			this.panel5.Controls.Add(this.txtTenDV);
			this.panel5.Controls.Add(this.label8);
			this.panel5.Controls.Add(this.label7);
			this.panel5.Location = new System.Drawing.Point(13, 345);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(309, 272);
			this.panel5.TabIndex = 1;
			// 
			// txtDonvi
			// 
			this.txtDonvi.BackColor = System.Drawing.Color.White;
			this.txtDonvi.Location = new System.Drawing.Point(71, 82);
			this.txtDonvi.MaxLength = 50;
			this.txtDonvi.Name = "txtDonvi";
			this.txtDonvi.Size = new System.Drawing.Size(72, 20);
			this.txtDonvi.TabIndex = 48;
			// 
			// cbmLoai
			// 
			this.cbmLoai.FormattingEnabled = true;
			this.cbmLoai.Location = new System.Drawing.Point(71, 152);
			this.cbmLoai.Name = "cbmLoai";
			this.cbmLoai.Size = new System.Drawing.Size(115, 21);
			this.cbmLoai.TabIndex = 46;
			this.cbmLoai.SelectedIndexChanged += new System.EventHandler(this.cbmLoai_SelectedIndexChanged);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
			this.label11.Location = new System.Drawing.Point(18, 152);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(33, 13);
			this.label11.TabIndex = 45;
			this.label11.Text = "Loại :";
			// 
			// txtGia
			// 
			this.txtGia.BackColor = System.Drawing.Color.White;
			this.txtGia.Location = new System.Drawing.Point(71, 116);
			this.txtGia.MaxLength = 50;
			this.txtGia.Name = "txtGia";
			this.txtGia.Size = new System.Drawing.Size(72, 20);
			this.txtGia.TabIndex = 44;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
			this.label10.Location = new System.Drawing.Point(21, 116);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(29, 13);
			this.label10.TabIndex = 43;
			this.label10.Text = "Giá :";
			// 
			// bntThemDV
			// 
			this.bntThemDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(30)))), ((int)(((byte)(163)))));
			this.bntThemDV.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bntThemDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bntThemDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.bntThemDV.ForeColor = System.Drawing.Color.Snow;
			this.bntThemDV.Location = new System.Drawing.Point(165, 192);
			this.bntThemDV.Name = "bntThemDV";
			this.bntThemDV.Size = new System.Drawing.Size(89, 28);
			this.bntThemDV.TabIndex = 39;
			this.bntThemDV.Text = "Thêm mới";
			this.bntThemDV.UseVisualStyleBackColor = false;
			this.bntThemDV.Click += new System.EventHandler(this.bntThemDV_Click);
			// 
			// bntCapNhatDV
			// 
			this.bntCapNhatDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(30)))), ((int)(((byte)(163)))));
			this.bntCapNhatDV.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bntCapNhatDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bntCapNhatDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.bntCapNhatDV.ForeColor = System.Drawing.Color.Snow;
			this.bntCapNhatDV.Location = new System.Drawing.Point(68, 192);
			this.bntCapNhatDV.Name = "bntCapNhatDV";
			this.bntCapNhatDV.Size = new System.Drawing.Size(89, 28);
			this.bntCapNhatDV.TabIndex = 38;
			this.bntCapNhatDV.Text = "Cập nhật";
			this.bntCapNhatDV.UseVisualStyleBackColor = false;
			this.bntCapNhatDV.Click += new System.EventHandler(this.bntCapNhatDV_Click);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
			this.label9.Location = new System.Drawing.Point(18, 82);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(44, 13);
			this.label9.TabIndex = 37;
			this.label9.Text = "Đơn vị :";
			// 
			// txtTenDV
			// 
			this.txtTenDV.BackColor = System.Drawing.Color.White;
			this.txtTenDV.Location = new System.Drawing.Point(71, 47);
			this.txtTenDV.MaxLength = 50;
			this.txtTenDV.Name = "txtTenDV";
			this.txtTenDV.Size = new System.Drawing.Size(186, 20);
			this.txtTenDV.TabIndex = 36;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
			this.label8.Location = new System.Drawing.Point(18, 50);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(32, 13);
			this.label8.TabIndex = 35;
			this.label8.Text = "Tên :";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
			this.label7.Location = new System.Drawing.Point(13, 16);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(51, 13);
			this.label7.TabIndex = 34;
			this.label7.Text = "Dịch vụ";
			// 
			// bntCapNhatLoai
			// 
			this.bntCapNhatLoai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(30)))), ((int)(((byte)(163)))));
			this.bntCapNhatLoai.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bntCapNhatLoai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bntCapNhatLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.bntCapNhatLoai.ForeColor = System.Drawing.Color.Snow;
			this.bntCapNhatLoai.Location = new System.Drawing.Point(54, 127);
			this.bntCapNhatLoai.Name = "bntCapNhatLoai";
			this.bntCapNhatLoai.Size = new System.Drawing.Size(89, 28);
			this.bntCapNhatLoai.TabIndex = 36;
			this.bntCapNhatLoai.Text = "Cập nhật";
			this.bntCapNhatLoai.UseVisualStyleBackColor = false;
			this.bntCapNhatLoai.Click += new System.EventHandler(this.bntCapNhatLoai_Click);
			// 
			// panel3
			// 
			this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(226)))), ((int)(((byte)(225)))));
			this.panel3.Controls.Add(this.panel5);
			this.panel3.Controls.Add(this.pnChitiet);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Controls.Add(this.rbTatca);
			this.panel3.Controls.Add(this.rbLoai);
			this.panel3.Controls.Add(this.label3);
			this.panel3.Controls.Add(this.pnDV);
			this.panel3.Controls.Add(this.panel1);
			this.panel3.Location = new System.Drawing.Point(-2, 30);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(834, 633);
			this.panel3.TabIndex = 11;
			// 
			// pnChitiet
			// 
			this.pnChitiet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnChitiet.Controls.Add(this.panel4);
			this.pnChitiet.Controls.Add(this.pnLoai);
			this.pnChitiet.Location = new System.Drawing.Point(3, 29);
			this.pnChitiet.Name = "pnChitiet";
			this.pnChitiet.Size = new System.Drawing.Size(831, 276);
			this.pnChitiet.TabIndex = 31;
			// 
			// panel4
			// 
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel4.Controls.Add(this.bntThemLoai);
			this.panel4.Controls.Add(this.bntCapNhatLoai);
			this.panel4.Controls.Add(this.txtTenLoai);
			this.panel4.Controls.Add(this.label5);
			this.panel4.Controls.Add(this.label6);
			this.panel4.Location = new System.Drawing.Point(10, 3);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(309, 257);
			this.panel4.TabIndex = 0;
			// 
			// txtTenLoai
			// 
			this.txtTenLoai.BackColor = System.Drawing.Color.White;
			this.txtTenLoai.Location = new System.Drawing.Point(70, 54);
			this.txtTenLoai.MaxLength = 50;
			this.txtTenLoai.Name = "txtTenLoai";
			this.txtTenLoai.Size = new System.Drawing.Size(186, 20);
			this.txtTenLoai.TabIndex = 35;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
			this.label5.Location = new System.Drawing.Point(32, 57);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(32, 13);
			this.label5.TabIndex = 34;
			this.label5.Text = "Tên :";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
			this.label6.Location = new System.Drawing.Point(7, 9);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(79, 13);
			this.label6.TabIndex = 33;
			this.label6.Text = "Loại Dịch vụ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
			this.label2.Location = new System.Drawing.Point(325, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(168, 16);
			this.label2.TabIndex = 28;
			this.label2.Text = "Danh sách loại dịch vụ:";
			// 
			// rbTatca
			// 
			this.rbTatca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rbTatca.AutoSize = true;
			this.rbTatca.Checked = true;
			this.rbTatca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
			this.rbTatca.Location = new System.Drawing.Point(629, 315);
			this.rbTatca.Name = "rbTatca";
			this.rbTatca.Size = new System.Drawing.Size(114, 17);
			this.rbTatca.TabIndex = 30;
			this.rbTatca.TabStop = true;
			this.rbTatca.Text = "Xem tất cả dịch vụ";
			this.rbTatca.UseVisualStyleBackColor = true;
			this.rbTatca.CheckedChanged += new System.EventHandler(this.rbTatca_CheckedChanged);
			// 
			// rbLoai
			// 
			this.rbLoai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rbLoai.AutoSize = true;
			this.rbLoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
			this.rbLoai.Location = new System.Drawing.Point(513, 315);
			this.rbLoai.Name = "rbLoai";
			this.rbLoai.Size = new System.Drawing.Size(89, 17);
			this.rbLoai.TabIndex = 29;
			this.rbLoai.Text = "Xem theo loại";
			this.rbLoai.UseVisualStyleBackColor = true;
			this.rbLoai.CheckedChanged += new System.EventHandler(this.rbTatca_CheckedChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
			this.label3.Location = new System.Drawing.Point(325, 315);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(134, 16);
			this.label3.TabIndex = 27;
			this.label3.Text = "Danh sách dịch vụ";
			// 
			// pnDV
			// 
			this.pnDV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnDV.Controls.Add(this.gridDV);
			this.pnDV.Location = new System.Drawing.Point(328, 345);
			this.pnDV.Name = "pnDV";
			this.pnDV.Size = new System.Drawing.Size(503, 272);
			this.pnDV.TabIndex = 15;
			// 
			// gridDV
			// 
			this.gridDV.AllowUserToAddRows = false;
			this.gridDV.AllowUserToDeleteRows = false;
			this.gridDV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.gridDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma,
            this.Ten,
            this.Donvitinh,
            this.Gia,
            this.Maloaidichvu});
			this.gridDV.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridDV.Location = new System.Drawing.Point(0, 0);
			this.gridDV.Name = "gridDV";
			this.gridDV.RowHeadersVisible = false;
			this.gridDV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.gridDV.Size = new System.Drawing.Size(503, 272);
			this.gridDV.TabIndex = 0;
			this.gridDV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDV_CellClick);
			// 
			// Ma
			// 
			this.Ma.DataPropertyName = "Ma";
			this.Ma.HeaderText = "Mã";
			this.Ma.Name = "Ma";
			this.Ma.ReadOnly = true;
			this.Ma.Visible = false;
			// 
			// Ten
			// 
			this.Ten.DataPropertyName = "Ten";
			this.Ten.HeaderText = "Tên";
			this.Ten.Name = "Ten";
			this.Ten.ReadOnly = true;
			// 
			// Donvitinh
			// 
			this.Donvitinh.DataPropertyName = "Donvitinh";
			this.Donvitinh.HeaderText = "Đơn vị tính";
			this.Donvitinh.Name = "Donvitinh";
			this.Donvitinh.ReadOnly = true;
			// 
			// Gia
			// 
			this.Gia.DataPropertyName = "Gia";
			this.Gia.HeaderText = "Giá";
			this.Gia.Name = "Gia";
			this.Gia.ReadOnly = true;
			// 
			// Maloaidichvu
			// 
			this.Maloaidichvu.DataPropertyName = "Maloaidichvu";
			this.Maloaidichvu.HeaderText = "Loại dịch vụ";
			this.Maloaidichvu.Name = "Maloaidichvu";
			this.Maloaidichvu.ReadOnly = true;
			this.Maloaidichvu.Visible = false;
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
			this.panel2.TabIndex = 10;
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
			this.label1.Size = new System.Drawing.Size(59, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Dịch Vụ";
			// 
			// dataGridViewImageColumn1
			// 
			this.dataGridViewImageColumn1.HeaderText = "Xóa";
			this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
			this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
			// 
			// dataGridViewImageColumn2
			// 
			this.dataGridViewImageColumn2.HeaderText = "Xóa";
			this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
			this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
			// 
			// DichVuvaLoaiDichVu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(835, 663);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "DichVuvaLoaiDichVu";
			this.Text = "DichVuvaLoaiDichVu";
			this.Load += new System.EventHandler(this.DichVuvaLoaiDichVu_Load);
			this.pnLoai.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridLoai)).EndInit();
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.pnChitiet.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.pnDV.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridDV)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel pnLoai;
		private System.Windows.Forms.DataGridView gridLoai;
		private System.Windows.Forms.Button bntThemLoai;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.TextBox txtDonvi;
		private System.Windows.Forms.ComboBox cbmLoai;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtGia;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button bntThemDV;
		private System.Windows.Forms.Button bntCapNhatDV;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtTenDV;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button bntCapNhatLoai;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel pnChitiet;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.TextBox txtTenLoai;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RadioButton rbTatca;
		private System.Windows.Forms.RadioButton rbLoai;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel pnDV;
		private System.Windows.Forms.DataGridView gridDV;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
		private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaLoai;
		private System.Windows.Forms.DataGridViewTextBoxColumn TenLoai;
		private System.Windows.Forms.DataGridViewTextBoxColumn Ma;
		private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
		private System.Windows.Forms.DataGridViewTextBoxColumn Donvitinh;
		private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
		private System.Windows.Forms.DataGridViewTextBoxColumn Maloaidichvu;
	}
}