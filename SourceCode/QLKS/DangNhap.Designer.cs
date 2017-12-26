namespace PresentationLayer
{
	partial class DangNhap
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
			this.lbThongBao = new System.Windows.Forms.Label();
			this.lbMK = new System.Windows.Forms.Label();
			this.lbTK = new System.Windows.Forms.Label();
			this.txtTaiKhoan = new System.Windows.Forms.TextBox();
			this.txtMatKhau = new System.Windows.Forms.TextBox();
			this.bntDangNhap = new System.Windows.Forms.Button();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.picReset = new System.Windows.Forms.PictureBox();
			this.picClose = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picReset)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.SuspendLayout();
			// 
			// lbThongBao
			// 
			this.lbThongBao.AutoSize = true;
			this.lbThongBao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(188)))), ((int)(((byte)(229)))));
			this.lbThongBao.Location = new System.Drawing.Point(4, 152);
			this.lbThongBao.Name = "lbThongBao";
			this.lbThongBao.Size = new System.Drawing.Size(190, 13);
			this.lbThongBao.TabIndex = 33;
			this.lbThongBao.Text = "(*) : Thông tin bắt buộc phải cung cấp.";
			// 
			// lbMK
			// 
			this.lbMK.AutoSize = true;
			this.lbMK.ForeColor = System.Drawing.SystemColors.Control;
			this.lbMK.Location = new System.Drawing.Point(341, 75);
			this.lbMK.Name = "lbMK";
			this.lbMK.Size = new System.Drawing.Size(17, 13);
			this.lbMK.TabIndex = 32;
			this.lbMK.Text = "(*)";
			// 
			// lbTK
			// 
			this.lbTK.AutoSize = true;
			this.lbTK.ForeColor = System.Drawing.SystemColors.Control;
			this.lbTK.Location = new System.Drawing.Point(341, 39);
			this.lbTK.Name = "lbTK";
			this.lbTK.Size = new System.Drawing.Size(17, 13);
			this.lbTK.TabIndex = 31;
			this.lbTK.Text = "(*)";
			// 
			// txtTaiKhoan
			// 
			this.txtTaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txtTaiKhoan.Location = new System.Drawing.Point(85, 31);
			this.txtTaiKhoan.Multiline = true;
			this.txtTaiKhoan.Name = "txtTaiKhoan";
			this.txtTaiKhoan.Size = new System.Drawing.Size(250, 30);
			this.txtTaiKhoan.TabIndex = 29;
			this.txtTaiKhoan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTaiKhoan_KeyDown);
			this.txtTaiKhoan.MouseEnter += new System.EventHandler(this.txtTaiKhoan_MouseEnter);
			this.txtTaiKhoan.MouseLeave += new System.EventHandler(this.txtTaiKhoan_MouseLeave);
			// 
			// txtMatKhau
			// 
			this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txtMatKhau.Location = new System.Drawing.Point(85, 67);
			this.txtMatKhau.Multiline = true;
			this.txtMatKhau.Name = "txtMatKhau";
			this.txtMatKhau.PasswordChar = '*';
			this.txtMatKhau.Size = new System.Drawing.Size(250, 30);
			this.txtMatKhau.TabIndex = 30;
			this.txtMatKhau.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMatKhau_KeyDown);
			this.txtMatKhau.MouseEnter += new System.EventHandler(this.txtMatKhau_MouseEnter);
			this.txtMatKhau.MouseLeave += new System.EventHandler(this.txtMatKhau_MouseLeave);
			// 
			// bntDangNhap
			// 
			this.bntDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(0)))), ((int)(((byte)(153)))));
			this.bntDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bntDangNhap.FlatAppearance.BorderSize = 0;
			this.bntDangNhap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(31)))), ((int)(((byte)(162)))));
			this.bntDangNhap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(31)))), ((int)(((byte)(162)))));
			this.bntDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bntDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
			this.bntDangNhap.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.bntDangNhap.Location = new System.Drawing.Point(120, 114);
			this.bntDangNhap.Name = "bntDangNhap";
			this.bntDangNhap.Size = new System.Drawing.Size(145, 30);
			this.bntDangNhap.TabIndex = 28;
			this.bntDangNhap.Text = "Đăng Nhập";
			this.bntDangNhap.UseVisualStyleBackColor = false;
			this.bntDangNhap.Click += new System.EventHandler(this.bntDangNhap_Click);
			this.bntDangNhap.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bntDangNhap_KeyDown);
			// 
			// pictureBox5
			// 
			this.pictureBox5.BackColor = System.Drawing.Color.White;
			this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox5.Image = global::PresentationLayer.Properties.Resources.eye;
			this.pictureBox5.Location = new System.Drawing.Point(303, 71);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(27, 23);
			this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox5.TabIndex = 38;
			this.pictureBox5.TabStop = false;
			this.pictureBox5.WaitOnLoad = true;
			this.pictureBox5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox5_MouseDown);
			this.pictureBox5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox5_MouseUp);
			// 
			// picReset
			// 
			this.picReset.Cursor = System.Windows.Forms.Cursors.Hand;
			this.picReset.Image = ((System.Drawing.Image)(resources.GetObject("picReset.Image")));
			this.picReset.Location = new System.Drawing.Point(319, 143);
			this.picReset.Name = "picReset";
			this.picReset.Size = new System.Drawing.Size(30, 30);
			this.picReset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picReset.TabIndex = 37;
			this.picReset.TabStop = false;
			this.picReset.WaitOnLoad = true;
			this.picReset.Click += new System.EventHandler(this.picReset_Click);
			// 
			// picClose
			// 
			this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.picClose.Image = ((System.Drawing.Image)(resources.GetObject("picClose.Image")));
			this.picClose.Location = new System.Drawing.Point(355, 143);
			this.picClose.Name = "picClose";
			this.picClose.Size = new System.Drawing.Size(30, 30);
			this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picClose.TabIndex = 36;
			this.picClose.TabStop = false;
			this.picClose.WaitOnLoad = true;
			this.picClose.Click += new System.EventHandler(this.picClose_Click);
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(49, 67);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(30, 30);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox4.TabIndex = 35;
			this.pictureBox4.TabStop = false;
			this.pictureBox4.WaitOnLoad = true;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(49, 31);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(30, 30);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 34;
			this.pictureBox3.TabStop = false;
			this.pictureBox3.WaitOnLoad = true;
			// 
			// DangNhap
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(31)))), ((int)(((byte)(162)))));
			this.ClientSize = new System.Drawing.Size(387, 174);
			this.Controls.Add(this.pictureBox5);
			this.Controls.Add(this.picReset);
			this.Controls.Add(this.picClose);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.lbThongBao);
			this.Controls.Add(this.lbMK);
			this.Controls.Add(this.lbTK);
			this.Controls.Add(this.txtTaiKhoan);
			this.Controls.Add(this.txtMatKhau);
			this.Controls.Add(this.bntDangNhap);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "DangNhap";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "DangNhap";
			this.Load += new System.EventHandler(this.DangNhap_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picReset)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox picReset;
		private System.Windows.Forms.PictureBox picClose;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Label lbThongBao;
		private System.Windows.Forms.Label lbMK;
		private System.Windows.Forms.Label lbTK;
		private System.Windows.Forms.TextBox txtTaiKhoan;
		private System.Windows.Forms.TextBox txtMatKhau;
		private System.Windows.Forms.Button bntDangNhap;
	}
}