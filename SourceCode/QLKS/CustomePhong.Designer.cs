namespace PresentationLayer
{
    partial class CustomePhong
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbBotton = new System.Windows.Forms.Label();
            this.lbCenter = new System.Windows.Forms.Label();
            this.lbTop = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbBotton
            // 
            this.lbBotton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBotton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbBotton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBotton.ForeColor = System.Drawing.Color.White;
            this.lbBotton.Location = new System.Drawing.Point(3, 57);
            this.lbBotton.Name = "lbBotton";
            this.lbBotton.Size = new System.Drawing.Size(155, 13);
            this.lbBotton.TabIndex = 0;
            this.lbBotton.Text = "trịnh thanh thuận";
            this.lbBotton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbBotton.MouseEnter += new System.EventHandler(this.CustomePhong_MouseEnter);
            this.lbBotton.MouseLeave += new System.EventHandler(this.CustomePhong_MouseLeave);
            // 
            // lbCenter
            // 
            this.lbCenter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCenter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbCenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCenter.ForeColor = System.Drawing.Color.White;
            this.lbCenter.Location = new System.Drawing.Point(3, 20);
            this.lbCenter.Margin = new System.Windows.Forms.Padding(3);
            this.lbCenter.Name = "lbCenter";
            this.lbCenter.Size = new System.Drawing.Size(155, 28);
            this.lbCenter.TabIndex = 1;
            this.lbCenter.Text = "101";
            this.lbCenter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbCenter.MouseEnter += new System.EventHandler(this.CustomePhong_MouseEnter);
            this.lbCenter.MouseLeave += new System.EventHandler(this.CustomePhong_MouseLeave);
            // 
            // lbTop
            // 
            this.lbTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTop.ForeColor = System.Drawing.Color.White;
            this.lbTop.Location = new System.Drawing.Point(0, 0);
            this.lbTop.Name = "lbTop";
            this.lbTop.Size = new System.Drawing.Size(158, 13);
            this.lbTop.TabIndex = 2;
            this.lbTop.Text = "ngày 28-30/5";
            this.lbTop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbTop.MouseEnter += new System.EventHandler(this.CustomePhong_MouseEnter);
            this.lbTop.MouseHover += new System.EventHandler(this.CustomePhong_MouseLeave);
            // 
            // CustomePhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.Controls.Add(this.lbTop);
            this.Controls.Add(this.lbCenter);
            this.Controls.Add(this.lbBotton);
            this.Name = "CustomePhong";
            this.Size = new System.Drawing.Size(161, 71);
            this.MouseEnter += new System.EventHandler(this.CustomePhong_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.CustomePhong_MouseLeave);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbBotton;
        private System.Windows.Forms.Label lbCenter;
        private System.Windows.Forms.Label lbTop;
    }
}
