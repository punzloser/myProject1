using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyDiem
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            Update_Region();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            Update_Region();
        }

        private void Update_Region()
        {
            Region prevRgn = Region;
            Region = new Region(CreateFormRegion(8));
            if (prevRgn != null)
                prevRgn.Dispose();
        }

        // bo góc form tròn
        public GraphicsPath CreateFormRegion(int cornerRadius)
        {
            GraphicsPath GrpRect = new GraphicsPath();
            int width = Width + 1;
            int height = Height + 1;
            GrpRect.AddArc(new Rectangle(0, 0, cornerRadius * 2, cornerRadius * 2), 180f, 90f);//left-top
            GrpRect.AddArc(new Rectangle((width - cornerRadius * 2) - 1, 0, cornerRadius * 2, cornerRadius * 2), -90f, 90f);//right-top
            GrpRect.AddArc(new Rectangle((width - cornerRadius * 2) - 1, (height - cornerRadius * 2) - 1, cornerRadius * 2, cornerRadius * 2), 0f, 90f);//right-bottom
            GrpRect.AddArc(new Rectangle(0, (height - cornerRadius * 2) - 1, cornerRadius * 2, cornerRadius * 2), 90f, 90f);//left-bottom
            GrpRect.CloseAllFigures();
            return GrpRect;
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelControl1.Controls.Clear();
            frmLopSinhVien frm = new frmLopSinhVien();
            frm.TopLevel = false;
            panelControl1.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            frm.Show();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelControl1.Controls.Clear();
            frmDiemHP frm = new frmDiemHP();
            frm.TopLevel = false;
            panelControl1.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            frm.Show();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelControl1.Controls.Clear();
            frmBangDiemFull frm = new frmBangDiemFull();
            frm.TopLevel = false;
            panelControl1.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            //frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            frm.Show();
        }
    }
}
