namespace PresentationLayer
{
	partial class SoLuongDVthem
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
			this.bntOk = new System.Windows.Forms.Button();
			this.txtSL = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// bntOk
			// 
			this.bntOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(30)))), ((int)(((byte)(163)))));
			this.bntOk.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bntOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bntOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.bntOk.ForeColor = System.Drawing.Color.Snow;
			this.bntOk.Location = new System.Drawing.Point(242, 8);
			this.bntOk.Name = "bntOk";
			this.bntOk.Size = new System.Drawing.Size(40, 23);
			this.bntOk.TabIndex = 40;
			this.bntOk.Text = "Ok";
			this.bntOk.UseVisualStyleBackColor = false;
			this.bntOk.Click += new System.EventHandler(this.bntOk_Click);
			// 
			// txtSL
			// 
			this.txtSL.Location = new System.Drawing.Point(170, 10);
			this.txtSL.Name = "txtSL";
			this.txtSL.Size = new System.Drawing.Size(49, 20);
			this.txtSL.TabIndex = 39;
			this.txtSL.Text = "0";
			this.txtSL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSL_KeyPress);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
			this.label2.Location = new System.Drawing.Point(20, 10);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(142, 16);
			this.label2.TabIndex = 38;
			this.label2.Text = "Nhập số lượng Dịch vụ";
			// 
			// SoLuongDVthem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(303, 38);
			this.Controls.Add(this.bntOk);
			this.Controls.Add(this.txtSL);
			this.Controls.Add(this.label2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "SoLuongDVthem";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SoLuongDVthem";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SoLuongDVthem_KeyDown);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button bntOk;
		private System.Windows.Forms.TextBox txtSL;
		private System.Windows.Forms.Label label2;
	}
}