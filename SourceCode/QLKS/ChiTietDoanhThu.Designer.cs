namespace PresentationLayer
{
    partial class ChiTietDoanhThu
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbloadding = new System.Windows.Forms.PictureBox();
            this.btnGhiFile = new System.Windows.Forms.Button();
            this.btnRefesh = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbThoiGian = new System.Windows.Forms.Label();
            this.btnChonThoiGian = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbNumber = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtgvHoaDon = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbIndex = new System.Windows.Forms.Label();
            this.lbMax = new System.Windows.Forms.Label();
            this.lbSum = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.txtSearching = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.lbLuotThue = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorkerApp = new System.ComponentModel.BackgroundWorker();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.lb10 = new System.Windows.Forms.Label();
            this.lbDichVu = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbloadding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHoaDon)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(30)))), ((int)(((byte)(163)))));
            this.panel2.Controls.Add(this.pbloadding);
            this.panel2.Controls.Add(this.btnGhiFile);
            this.panel2.Controls.Add(this.btnRefesh);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(805, 40);
            this.panel2.TabIndex = 3;
            // 
            // pbloadding
            // 
            this.pbloadding.Image = global::PresentationLayer.Properties.Resources.loading;
            this.pbloadding.Location = new System.Drawing.Point(696, 9);
            this.pbloadding.Name = "pbloadding";
            this.pbloadding.Size = new System.Drawing.Size(24, 24);
            this.pbloadding.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbloadding.TabIndex = 4;
            this.pbloadding.TabStop = false;
            this.pbloadding.Visible = false;
            // 
            // btnGhiFile
            // 
            this.btnGhiFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGhiFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGhiFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(30)))), ((int)(((byte)(163)))));
            this.btnGhiFile.FlatAppearance.BorderSize = 0;
            this.btnGhiFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(30)))), ((int)(((byte)(163)))));
            this.btnGhiFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(30)))), ((int)(((byte)(163)))));
            this.btnGhiFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGhiFile.Font = new System.Drawing.Font("Noto Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGhiFile.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGhiFile.Image = global::PresentationLayer.Properties.Resources.arrow_down_bold_circle_outline;
            this.btnGhiFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGhiFile.Location = new System.Drawing.Point(722, 0);
            this.btnGhiFile.Name = "btnGhiFile";
            this.btnGhiFile.Size = new System.Drawing.Size(81, 40);
            this.btnGhiFile.TabIndex = 3;
            this.btnGhiFile.Text = "Xuất file";
            this.btnGhiFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGhiFile.UseVisualStyleBackColor = true;
            this.btnGhiFile.Click += new System.EventHandler(this.btnGhiFile_Click);
            // 
            // btnRefesh
            // 
            this.btnRefesh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRefesh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefesh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(30)))), ((int)(((byte)(163)))));
            this.btnRefesh.FlatAppearance.BorderSize = 0;
            this.btnRefesh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(30)))), ((int)(((byte)(163)))));
            this.btnRefesh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(30)))), ((int)(((byte)(163)))));
            this.btnRefesh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefesh.Font = new System.Drawing.Font("Noto Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefesh.ForeColor = System.Drawing.Color.White;
            this.btnRefesh.Image = global::PresentationLayer.Properties.Resources.replay;
            this.btnRefesh.Location = new System.Drawing.Point(172, 6);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(23, 24);
            this.btnRefesh.TabIndex = 2;
            this.btnRefesh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRefesh.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Noto Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::PresentationLayer.Properties.Resources.dark_cash_multiple;
            this.button1.Location = new System.Drawing.Point(5, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 24);
            this.button1.TabIndex = 1;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi Tiết Doanh Thu";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Thống kê hóa đơn đã Checkin từ";
            // 
            // lbThoiGian
            // 
            this.lbThoiGian.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbThoiGian.AutoSize = true;
            this.lbThoiGian.Font = new System.Drawing.Font("Noto Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThoiGian.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbThoiGian.Location = new System.Drawing.Point(325, 55);
            this.lbThoiGian.Name = "lbThoiGian";
            this.lbThoiGian.Size = new System.Drawing.Size(194, 20);
            this.lbThoiGian.TabIndex = 5;
            this.lbThoiGian.Text = "10/05/2017 - 20/05/2017 ";
            // 
            // btnChonThoiGian
            // 
            this.btnChonThoiGian.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnChonThoiGian.AutoSize = true;
            this.btnChonThoiGian.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChonThoiGian.Font = new System.Drawing.Font("Noto Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonThoiGian.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnChonThoiGian.Location = new System.Drawing.Point(525, 55);
            this.btnChonThoiGian.Name = "btnChonThoiGian";
            this.btnChonThoiGian.Size = new System.Drawing.Size(156, 20);
            this.btnChonThoiGian.TabIndex = 6;
            this.btnChonThoiGian.Text = "[Chọn thời gian khác]";
            this.btnChonThoiGian.Click += new System.EventHandler(this.btnChonThoiGian_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Noto Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(504, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tìm kiếm tất cả dữ liệu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Noto Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 100);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Hiển thị";
            // 
            // cbbNumber
            // 
            this.cbbNumber.FormattingEnabled = true;
            this.cbbNumber.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40"});
            this.cbbNumber.Location = new System.Drawing.Point(60, 98);
            this.cbbNumber.Name = "cbbNumber";
            this.cbbNumber.Size = new System.Drawing.Size(40, 23);
            this.cbbNumber.TabIndex = 11;
            this.cbbNumber.Text = "10";
            this.cbbNumber.SelectedIndexChanged += new System.EventHandler(this.cbbNumber_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Noto Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(103, 100);
            this.label6.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "hóa đơn";
            // 
            // dtgvHoaDon
            // 
            this.dtgvHoaDon.AllowUserToAddRows = false;
            this.dtgvHoaDon.AllowUserToDeleteRows = false;
            this.dtgvHoaDon.AllowUserToResizeColumns = false;
            this.dtgvHoaDon.AllowUserToResizeRows = false;
            this.dtgvHoaDon.BackgroundColor = System.Drawing.Color.Snow;
            this.dtgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHoaDon.Location = new System.Drawing.Point(15, 140);
            this.dtgvHoaDon.Name = "dtgvHoaDon";
            this.dtgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvHoaDon.Size = new System.Drawing.Size(790, 243);
            this.dtgvHoaDon.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Noto Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(357, 413);
            this.label7.Margin = new System.Windows.Forms.Padding(1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Hiển thị";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Noto Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(437, 413);
            this.label8.Margin = new System.Windows.Forms.Padding(1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "tới";
            // 
            // lbIndex
            // 
            this.lbIndex.AutoSize = true;
            this.lbIndex.Font = new System.Drawing.Font("Noto Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIndex.Location = new System.Drawing.Point(410, 413);
            this.lbIndex.Margin = new System.Windows.Forms.Padding(1);
            this.lbIndex.Name = "lbIndex";
            this.lbIndex.Size = new System.Drawing.Size(15, 17);
            this.lbIndex.TabIndex = 16;
            this.lbIndex.Text = "1";
            // 
            // lbMax
            // 
            this.lbMax.AutoSize = true;
            this.lbMax.Font = new System.Drawing.Font("Noto Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMax.Location = new System.Drawing.Point(461, 413);
            this.lbMax.Margin = new System.Windows.Forms.Padding(1);
            this.lbMax.Name = "lbMax";
            this.lbMax.Size = new System.Drawing.Size(15, 17);
            this.lbMax.TabIndex = 17;
            this.lbMax.Text = "4";
            // 
            // lbSum
            // 
            this.lbSum.AutoSize = true;
            this.lbSum.Font = new System.Drawing.Font("Noto Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSum.Location = new System.Drawing.Point(572, 413);
            this.lbSum.Margin = new System.Windows.Forms.Padding(1);
            this.lbSum.Name = "lbSum";
            this.lbSum.Size = new System.Drawing.Size(53, 17);
            this.lbSum.TabIndex = 18;
            this.lbSum.Text = "hóa đơn";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Noto Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(488, 413);
            this.label12.Margin = new System.Windows.Forms.Padding(1);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 17);
            this.label12.TabIndex = 19;
            this.label12.Text = "trong tổng số";
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnShow.FlatAppearance.BorderSize = 0;
            this.btnShow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Noto Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnShow.Location = new System.Drawing.Point(701, 410);
            this.btnShow.Margin = new System.Windows.Forms.Padding(1);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(22, 23);
            this.btnShow.TabIndex = 22;
            this.btnShow.Text = "1";
            this.btnShow.UseVisualStyleBackColor = false;
            // 
            // txtSearching
            // 
            this.txtSearching.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtSearching.Location = new System.Drawing.Point(646, 102);
            this.txtSearching.Name = "txtSearching";
            this.txtSearching.Size = new System.Drawing.Size(146, 22);
            this.txtSearching.TabIndex = 34;
            this.txtSearching.TextChanged += new System.EventHandler(this.txtSearching_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Controls.Add(this.lbLuotThue, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label17, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label9, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label11, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbTongTien, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lb10, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbDichVu, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 594);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 76);
            this.tableLayoutPanel1.TabIndex = 35;
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTongTien.Location = new System.Drawing.Point(583, 38);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(189, 37);
            this.lbTongTien.TabIndex = 9;
            this.lbTongTien.Text = "100";
            this.lbTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbLuotThue
            // 
            this.lbLuotThue.AutoSize = true;
            this.lbLuotThue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbLuotThue.Location = new System.Drawing.Point(197, 38);
            this.lbLuotThue.Name = "lbLuotThue";
            this.lbLuotThue.Size = new System.Drawing.Size(186, 37);
            this.lbLuotThue.TabIndex = 8;
            this.lbLuotThue.Text = "4";
            this.lbLuotThue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Location = new System.Drawing.Point(4, 38);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(186, 37);
            this.label17.TabIndex = 7;
            this.label17.Text = "Tổng kết";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(583, 1);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(189, 36);
            this.label11.TabIndex = 2;
            this.label11.Text = "Tổng Tiền";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(197, 1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(186, 36);
            this.label9.TabIndex = 0;
            this.label9.Text = "Lượt thuê";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Noto Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(278, 478);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(324, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Tổng doanh thu theo các hóa đơn ở bảng trên";
            // 
            // backgroundWorkerApp
            // 
            this.backgroundWorkerApp.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerApp_DoWork);
            this.backgroundWorkerApp.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerApp_ProgressChanged);
            this.backgroundWorkerApp.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerApp_RunWorkerCompleted);
            // 
            // btnRight
            // 
            this.btnRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btnRight.FlatAppearance.BorderSize = 0;
            this.btnRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRight.Image = global::PresentationLayer.Properties.Resources.chevron_right;
            this.btnRight.Location = new System.Drawing.Point(725, 410);
            this.btnRight.Margin = new System.Windows.Forms.Padding(1, 1, 0, 1);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(22, 23);
            this.btnRight.TabIndex = 24;
            this.btnRight.UseVisualStyleBackColor = false;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btnLast.FlatAppearance.BorderSize = 0;
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast.Image = global::PresentationLayer.Properties.Resources.page_last;
            this.btnLast.Location = new System.Drawing.Point(747, 410);
            this.btnLast.Margin = new System.Windows.Forms.Padding(0, 1, 1, 1);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(22, 23);
            this.btnLast.TabIndex = 23;
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btnFirst.FlatAppearance.BorderSize = 0;
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst.Image = global::PresentationLayer.Properties.Resources.page_first;
            this.btnFirst.Location = new System.Drawing.Point(655, 410);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(1, 1, 0, 1);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(22, 23);
            this.btnFirst.TabIndex = 21;
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btnLeft.FlatAppearance.BorderSize = 0;
            this.btnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeft.Image = global::PresentationLayer.Properties.Resources.chevron_left;
            this.btnLeft.Location = new System.Drawing.Point(677, 410);
            this.btnLeft.Margin = new System.Windows.Forms.Padding(0, 1, 1, 1);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(22, 23);
            this.btnLeft.TabIndex = 20;
            this.btnLeft.UseVisualStyleBackColor = false;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // lb10
            // 
            this.lb10.AutoSize = true;
            this.lb10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb10.Location = new System.Drawing.Point(390, 1);
            this.lb10.Name = "lb10";
            this.lb10.Size = new System.Drawing.Size(186, 36);
            this.lb10.TabIndex = 10;
            this.lb10.Text = "Dịch vụ";
            this.lb10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDichVu
            // 
            this.lbDichVu.AutoSize = true;
            this.lbDichVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDichVu.Location = new System.Drawing.Point(390, 38);
            this.lbDichVu.Name = "lbDichVu";
            this.lbDichVu.Size = new System.Drawing.Size(186, 37);
            this.lbDichVu.TabIndex = 11;
            this.lbDichVu.Text = "100";
            this.lbDichVu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChiTietDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 700);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.txtSearching);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbSum);
            this.Controls.Add(this.lbMax);
            this.Controls.Add(this.lbIndex);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtgvHoaDon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbbNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnChonThoiGian);
            this.Controls.Add(this.lbThoiGian);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Noto Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChiTietDoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChiTietDoanhThu";
            this.Load += new System.EventHandler(this.ChiTietDoanhThu_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbloadding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHoaDon)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRefesh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGhiFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbThoiGian;
        private System.Windows.Forms.Label btnChonThoiGian;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dtgvHoaDon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbIndex;
        private System.Windows.Forms.Label lbMax;
        private System.Windows.Forms.Label lbSum;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.TextBox txtSearching;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.Label lbLuotThue;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorkerApp;
        private System.Windows.Forms.PictureBox pbloadding;
        private System.Windows.Forms.Label lb10;
        private System.Windows.Forms.Label lbDichVu;
    }
}