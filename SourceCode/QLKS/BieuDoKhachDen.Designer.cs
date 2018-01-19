namespace PresentationLayer
{
    partial class BieuDoKhachDen
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbMonth = new System.Windows.Forms.ComboBox();
            this.btnXem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbYear = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbLuotKhach = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.chartLuotKhach = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.backgroundWorkerApp = new System.ComponentModel.BackgroundWorker();
            this.errorProviderApp = new System.Windows.Forms.ErrorProvider(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.btnRefesh = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartLuotKhach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApp)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(30)))), ((int)(((byte)(163)))));
            this.panel2.Controls.Add(this.btnRefesh);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(835, 40);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Biểu đồ khách đến";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbbMonth);
            this.panel1.Controls.Add(this.btnXem);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbbYear);
            this.panel1.Location = new System.Drawing.Point(0, 41);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 52);
            this.panel1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(244, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "tháng:";
            // 
            // cbbMonth
            // 
            this.cbbMonth.FormattingEnabled = true;
            this.cbbMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbbMonth.Location = new System.Drawing.Point(305, 9);
            this.cbbMonth.Margin = new System.Windows.Forms.Padding(1);
            this.cbbMonth.MaxLength = 2;
            this.cbbMonth.Name = "cbbMonth";
            this.cbbMonth.Size = new System.Drawing.Size(45, 26);
            this.cbbMonth.TabIndex = 4;
            this.cbbMonth.TextChanged += new System.EventHandler(this.cbbMonth_TextChanged);
            this.cbbMonth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbMonth_KeyPress);
            this.cbbMonth.Validating += new System.ComponentModel.CancelEventHandler(this.cbbMonth_Validating);
            // 
            // btnXem
            // 
            this.btnXem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(30)))), ((int)(((byte)(163)))));
            this.btnXem.FlatAppearance.BorderSize = 0;
            this.btnXem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXem.Font = new System.Drawing.Font("Noto Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnXem.Location = new System.Drawing.Point(382, 12);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(75, 24);
            this.btnXem.TabIndex = 3;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = false;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chọn năm:";
            // 
            // cbbYear
            // 
            this.cbbYear.FormattingEnabled = true;
            this.cbbYear.ItemHeight = 18;
            this.cbbYear.Items.AddRange(new object[] {
            "2015",
            "2016",
            "2017",
            "2018"});
            this.cbbYear.Location = new System.Drawing.Point(151, 11);
            this.cbbYear.Margin = new System.Windows.Forms.Padding(1);
            this.cbbYear.MaxLength = 4;
            this.cbbYear.Name = "cbbYear";
            this.cbbYear.Size = new System.Drawing.Size(75, 26);
            this.cbbYear.TabIndex = 0;
            this.cbbYear.TextChanged += new System.EventHandler(this.cbbYear_TextChanged);
            this.cbbYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbYear_KeyPress);
            this.cbbYear.Validating += new System.ComponentModel.CancelEventHandler(this.cbbYear_Validating);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.tbLuotKhach);
            this.panel3.Location = new System.Drawing.Point(0, 96);
            this.panel3.Margin = new System.Windows.Forms.Padding(1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(835, 235);
            this.panel3.TabIndex = 5;
            // 
            // tbLuotKhach
            // 
            this.tbLuotKhach.ColumnCount = 2;
            this.tbLuotKhach.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbLuotKhach.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbLuotKhach.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbLuotKhach.Location = new System.Drawing.Point(12, 3);
            this.tbLuotKhach.Name = "tbLuotKhach";
            this.tbLuotKhach.RowCount = 2;
            this.tbLuotKhach.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbLuotKhach.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbLuotKhach.Size = new System.Drawing.Size(811, 203);
            this.tbLuotKhach.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.chartLuotKhach);
            this.panel4.Location = new System.Drawing.Point(0, 333);
            this.panel4.Margin = new System.Windows.Forms.Padding(1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(835, 297);
            this.panel4.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Biểu đồ lượt khách đến chekin";
            // 
            // chartLuotKhach
            // 
            this.chartLuotKhach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chartLuotKhach.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartLuotKhach.Legends.Add(legend1);
            this.chartLuotKhach.Location = new System.Drawing.Point(12, 34);
            this.chartLuotKhach.Name = "chartLuotKhach";
            this.chartLuotKhach.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "ThueNgay";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "QuaDem";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "ThueGio";
            this.chartLuotKhach.Series.Add(series1);
            this.chartLuotKhach.Series.Add(series2);
            this.chartLuotKhach.Series.Add(series3);
            this.chartLuotKhach.Size = new System.Drawing.Size(811, 251);
            this.chartLuotKhach.TabIndex = 0;
            this.chartLuotKhach.Text = "Biểu đồ lượt khách đến checkin";
            // 
            // backgroundWorkerApp
            // 
            this.backgroundWorkerApp.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerApp_DoWork);
            this.backgroundWorkerApp.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerApp_ProgressChanged);
            this.backgroundWorkerApp.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerApp_RunWorkerCompleted);
            // 
            // errorProviderApp
            // 
            this.errorProviderApp.ContainerControl = this;
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Noto Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::PresentationLayer.Properties.Resources.calendar_clock;
            this.button2.Location = new System.Drawing.Point(4, 3);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 47);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnRefesh
            // 
            this.btnRefesh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRefesh.FlatAppearance.BorderSize = 0;
            this.btnRefesh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefesh.Font = new System.Drawing.Font("Noto Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefesh.ForeColor = System.Drawing.Color.White;
            this.btnRefesh.Image = global::PresentationLayer.Properties.Resources.replay;
            this.btnRefesh.Location = new System.Drawing.Point(186, 3);
            this.btnRefesh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(31, 33);
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
            this.button1.Image = global::PresentationLayer.Properties.Resources.dark_chart_bar;
            this.button1.Location = new System.Drawing.Point(4, 3);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 33);
            this.button1.TabIndex = 1;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BieuDoKhachDen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 640);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BieuDoKhachDen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BieuDoKhachDen";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartLuotKhach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRefesh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbYear;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tbLuotKhach;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLuotKhach;
        private System.ComponentModel.BackgroundWorker backgroundWorkerApp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbMonth;
        private System.Windows.Forms.ErrorProvider errorProviderApp;
    }
}