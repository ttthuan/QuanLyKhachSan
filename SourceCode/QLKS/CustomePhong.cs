using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataTranferObject;
using BusinessLayer;

namespace PresentationLayer
{
    public partial class CustomePhong : UserControl
    {
        public Color MOUSE_HOVER;
        public Color PRIMERY;
        public PhongDTO Phong { get; set; }
        public List<ToolStripItem> listToolTripItem = new List<ToolStripItem>();
        public ContextMenuStrip ctmnt = new ContextMenuStrip();
        public PhieuThuePhongBUS phieuThuePhongBUS = new PhieuThuePhongBUS();


        public event EventHandler<ProcessEventArgs> EventNhanPhong = null;
        public event EventHandler<ProcessEventArgs> EventDatPhong = null;
        public event EventHandler<ProcessEventArgs> EventThanhToanPhong = null;

        public CustomePhong(PhongDTO phong)
        {
            InitializeComponent();
            this.Phong = phong;
            lbCenter.Text = phong.Ten;

            ToolStripItem tsDatPhong = new ToolStripButton();
            tsDatPhong.Text = "Đặt phòng";
            tsDatPhong.Size = new Size(100, 15);
            tsDatPhong.Name = "tsDatPhong";
            tsDatPhong.TextAlign = ContentAlignment.MiddleLeft;
            tsDatPhong.ImageAlign = ContentAlignment.MiddleLeft;
            tsDatPhong.Click += TsDatPhong_Click;

            ToolStripItem tsThanhToanPhong = new ToolStripButton();
            tsThanhToanPhong.Text = "Thanh toán phòng";
            tsThanhToanPhong.Size = new Size(100, 15);
            tsThanhToanPhong.Name = "tsThanhToanPhong";
            tsThanhToanPhong.TextAlign = ContentAlignment.MiddleLeft;
            tsThanhToanPhong.ImageAlign = ContentAlignment.MiddleLeft;
            tsThanhToanPhong.Click += TsThanhToanPhong_Click;

            ToolStripItem tsNhanPhong = new ToolStripButton();
            tsNhanPhong.Text = "Nhận phòng";
            tsNhanPhong.Size = new Size(100, 15);
            tsNhanPhong.Name = "tsNhanPhong";
            tsNhanPhong.TextAlign = ContentAlignment.MiddleLeft;
            tsNhanPhong.ImageAlign = ContentAlignment.MiddleLeft;
            tsNhanPhong.Click += TsNhanPhong_Click;
            

            listToolTripItem.Add(tsDatPhong); // 0
            listToolTripItem.Add(tsThanhToanPhong); // 1
            listToolTripItem.Add(tsNhanPhong); // 2
        }
        
        private void TsNhanPhong_Click(object sender, EventArgs e)
        {
            Console.WriteLine("nhận phòng");
            if(EventNhanPhong != null)
            {
                EventNhanPhong(this, new ProcessEventArgs(Phong));
            }
        }

        private void TsThanhToanPhong_Click(object sender, EventArgs e)
        {
            Console.WriteLine("thanh toan phòng");
            if(EventThanhToanPhong != null)
            {
                EventThanhToanPhong(this, new ProcessEventArgs(Phong));
            }
        }

        private void TsDatPhong_Click(object sender, EventArgs e)
        {
            Console.WriteLine("đặt phòng");
            if(EventDatPhong != null)
            {
                EventDatPhong(this, new ProcessEventArgs(Phong));
            }
        }

        public void TaiToolTripItem(int[] idx)
        {
            ctmnt.Items.Clear();
            int n = idx.Length;
            
            for (int i = 0; i < n; i++)
            {
                if(i < listToolTripItem.Count)
                {
                    ctmnt.Items.Add(listToolTripItem[idx[i]]);
                }
            }
            
            this.ContextMenuStrip = ctmnt;
        }
        
        public void ThayDoiTrangThaiDangO(string time, string name)
        {
            lbTop.Text = time;
            lbBotton.Text = name;

            this.BackColor = CSS.RED;
            PRIMERY = CSS.RED;
            MOUSE_HOVER = CSS.LIGHTRED;

            TaiToolTripItem(new int[] {1}); // tsThanhToan
        }

        public void ThayDoiTrangThaiDaDat(string time, string name)
        {
            lbTop.Text = time;
            lbBotton.Text = name;

            this.BackColor = CSS.ORANGE;
            PRIMERY = CSS.ORANGE;
            MOUSE_HOVER = CSS.LIGHTORANGE;

            TaiToolTripItem(new int[] { 2 }); // tsNhanPhong
            
        }

        public void ThayDoiTrangThaiQuaHan(string time, string name)
        {
            lbTop.Text = time;
            lbBotton.Text = name;

            this.BackColor = CSS.BROWN;
            PRIMERY = CSS.BROWN;
            MOUSE_HOVER = CSS.LIGHTBROWN;

            TaiToolTripItem(new int[] { 1 }); // tsThanhToan
        }

        public void ThayDoiTrangThaiTrong()
        {
            lbTop.Text = "";
            lbBotton.Text = "";

            this.BackColor = CSS.GREEN;
            PRIMERY = CSS.GREEN;
            MOUSE_HOVER = CSS.LIGHTGREEN;

            TaiToolTripItem(new int[] { 0 }); // tsDatPhong
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

    public class ProcessEventArgs: EventArgs
    {
        public PhongDTO PHONG { get; set; }
        public ProcessEventArgs(PhongDTO phong)
        {
            PHONG = phong;
        }
    }
}
