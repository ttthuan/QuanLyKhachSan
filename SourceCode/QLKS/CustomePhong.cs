﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class CustomePhong : UserControl
    {
        public Color MOUSE_HOVER;
        public Color PRIMERY;

        public CustomePhong()
        {
            InitializeComponent();
        }
        
        public void ThayDoiTrangThaiDangO(string time, string name)
        {
            lbTop.Text = time;
            lbBotton.Text = name;

            this.BackColor = CSS.RED;
            PRIMERY = CSS.RED;
            MOUSE_HOVER = CSS.LIGHTRED;
        }

        public void ThayDoiTrangThaiDaDat(string time, string name)
        {
            lbTop.Text = time;
            lbBotton.Text = name;

            this.BackColor = CSS.ORANGE;
            PRIMERY = CSS.ORANGE;
            MOUSE_HOVER = CSS.LIGHTORANGE;
        }

        public void ThayDoiTrangThaiQuaHan(string time, string name)
        {
            lbTop.Text = time;
            lbBotton.Text = name;

            this.BackColor = CSS.BROWN;
            PRIMERY = CSS.BROWN;
            MOUSE_HOVER = CSS.LIGHTBROWN;
        }

        public void ThayDoiTrangThaiTrong()
        {
            lbTop.Text = "";
            lbBotton.Text = "";

            this.BackColor = CSS.GREEN;
            PRIMERY = CSS.GREEN;
            MOUSE_HOVER = CSS.LIGHTGREEN;
        }

        private void CustomePhong_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = MOUSE_HOVER;
        }

        private void CustomePhong_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = PRIMERY;
        }
    }
}
