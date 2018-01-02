namespace PresentationLayer
{
	partial class MessageBoxDS
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
			this.txtthongbao = new System.Windows.Forms.TextBox();
			this.panlTieuDe = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.bntDangNhap = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panlTieuDe.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// txtthongbao
			// 
			this.txtthongbao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(226)))), ((int)(((byte)(225)))));
			this.txtthongbao.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtthongbao.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.txtthongbao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txtthongbao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
			this.txtthongbao.Location = new System.Drawing.Point(30, 52);
			this.txtthongbao.Multiline = true;
			this.txtthongbao.Name = "txtthongbao";
			this.txtthongbao.ReadOnly = true;
			this.txtthongbao.Size = new System.Drawing.Size(304, 53);
			this.txtthongbao.TabIndex = 38;
			this.txtthongbao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
			this.panlTieuDe.Size = new System.Drawing.Size(429, 40);
			this.panlTieuDe.TabIndex = 37;
			this.panlTieuDe.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panlTieuDe_MouseDown);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.label1.Location = new System.Drawing.Point(168, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(85, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Thông báo";
			// 
			// bntDangNhap
			// 
			this.bntDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(0)))), ((int)(((byte)(114)))));
			this.bntDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bntDangNhap.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.bntDangNhap.FlatAppearance.BorderSize = 0;
			this.bntDangNhap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(0)))), ((int)(((byte)(114)))));
			this.bntDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bntDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
			this.bntDangNhap.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.bntDangNhap.Location = new System.Drawing.Point(163, 111);
			this.bntDangNhap.Name = "bntDangNhap";
			this.bntDangNhap.Size = new System.Drawing.Size(97, 30);
			this.bntDangNhap.TabIndex = 36;
			this.bntDangNhap.Text = "Đóng";
			this.bntDangNhap.UseVisualStyleBackColor = false;
			this.bntDangNhap.Click += new System.EventHandler(this.bntDangNhap_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(351, 52);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(52, 53);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 39;
			this.pictureBox1.TabStop = false;
			// 
			// MessageBoxDS
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(429, 153);
			this.Controls.Add(this.txtthongbao);
			this.Controls.Add(this.panlTieuDe);
			this.Controls.Add(this.bntDangNhap);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MessageBoxDS";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "MessageBoxDS";
			this.Load += new System.EventHandler(this.MessageBoxDS_Load);
			this.panlTieuDe.ResumeLayout(false);
			this.panlTieuDe.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtthongbao;
		private System.Windows.Forms.Panel panlTieuDe;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button bntDangNhap;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}