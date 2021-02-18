using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace QuanLyDiem
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        QuanLiDiemEntities db = new QuanLiDiemEntities();
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
            lblDate.Text = changeDate(DateTime.Now.DayOfWeek.ToString()) + ", " + DateTime.Now.Day.ToString() 
                + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();
            lblQuyen.Caption = ClassTaiKhoan.TaiKhoan;
            setQuyen();
        }

        private void setQuyen()
        {
            var result = from a in db.ChucNang_TaiKhoan
                         join b in db.ChucNang on a.Menu equals b.Menu
                         where b.App == "Quyen" && a.UserName == ClassTaiKhoan.TaiKhoan
                         select a;

            foreach (RibbonPage page in ribbonControl1.Pages)
            {
                foreach (var item in result)
                {
                    if (item.Menu == page.Name && item.Cam == true)
                    {
                        page.Visible = false;
                    }
                }
                foreach (RibbonPageGroup pageGroup in page.Groups)
                {
                    foreach (var item in result)
                    {
                        if (item.Menu == pageGroup.Name && item.Cam == true)
                        {
                            pageGroup.Enabled = false;
                        }
                    }
                    foreach (BarItemLink barItemLink in pageGroup.ItemLinks)
                    {
                        foreach (var item in result)
                        {
                            if (item.Menu == barItemLink.Item.Name && item.Cam == true)
                            {
                                barItemLink.Item.Enabled = false;
                            }
                        }
                    }
                }
               
            }
        }

        //not work
        private void setDeleteRibbonControl()
        {
            var result = from a in db.ChucNang
                         select a;

            foreach (RibbonPage page in ribbonControl1.Pages)
            {
                foreach (var item in result)
                {
                    if (item.Menu != page.Name)
                    {
                        //var x = from a in db.ChucNang where a.Menu
                        db.ChucNang.Remove(item);
                    }
                    db.SaveChanges();
                }
                //foreach (RibbonPageGroup pageGroup in page.Groups)
                //{
                //    foreach (var item in result)
                //    {
                //        if (item.Menu == pageGroup.Name)
                //        {
                //            pageGroup.Enabled = false;
                //        }
                //    }
                //    foreach (BarItemLink barItemLink in pageGroup.ItemLinks)
                //    {
                //        foreach (var item in result)
                //        {
                //            if (item.Menu == barItemLink.Item.Name)
                //            {
                //                barItemLink.Item.Enabled = false;
                //            }
                //        }
                //    }
                //}

            }
        }

        private String changeDate(String name)
        {
            String date = "";
            switch (name)
            {
                case "Monday": 
                    date = "Thứ hai";
                    break;
                case "Tuesday": 
                    date = "Thứ ba";
                    break;
                case "Webnesday": 
                    date = "Thứ tư";
                    break;
                case "Thurday":
                    date = "Thứ năm";
                    break;
                case "Friday":
                    date = "Thứ sáu";
                    break;
                case "Saturday":
                    date = "Thứ bảy";
                    break;
                default:
                    date = "Chủ nhật";
                    break;
            }
            return date;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.Hour.ToString() + " : " + DateTime.Now.Minute.ToString() + " : " +
                DateTime.Now.Second.ToString();
        }

        private void barButtonItem23_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelControl1.Controls.Clear();
            frmHeThong frm = new frmHeThong();
            frm.TopLevel = false;
            panelControl1.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            frm.Show();
        }

        //info student
        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        //login
        private void md010101_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        //register
        private void md010102_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        //close
        private void md010103_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

        //save db
        private void md010201_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelControl1.Controls.Clear();
            frmSaoLuu frm = new frmSaoLuu();
            frm.TopLevel = false;
            panelControl1.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            frm.Show();
        }

        //sv xem diem
        private void md020102_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        //info teacher
        private void md030101_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        //GV xem phan cong
        private void md030102_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        //ds lop
        private void md030103_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelControl1.Controls.Clear();
            frmDanhSachLop frm = new frmDanhSachLop();
            frm.TopLevel = false;
            panelControl1.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            frm.Show();
        }

        //cham diem
        private void md030104_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        //giao vu quan li thong tin giao vien
        private void md040101_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelControl1.Controls.Clear();
            frmGiaoVien frm = new frmGiaoVien();
            frm.TopLevel = false;
            panelControl1.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            frm.Show();
        }

        //giao vu quan li lop-sv
        private void md040102_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelControl1.Controls.Clear();
            frmLopSinhVien frm = new frmLopSinhVien();
            frm.TopLevel = false;
            panelControl1.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            frm.Show();
        }

        //giao vu quan li hoc ky, hoc phan, mon hp, nhap diem
        private void md040103_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelControl1.Controls.Clear();
            frmDiemHP frm = new frmDiemHP();
            frm.TopLevel = false;
            panelControl1.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            frm.Show();
        }

        //giao vu thao tac voi bang diem
        private void md040104_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        //gvu quan li HA sv
        private void md040201_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelControl1.Controls.Clear();
            frmSinhVienHinhAnh frm = new frmSinhVienHinhAnh();
            frm.TopLevel = false;
            panelControl1.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            frm.Show();
        }

        // gvu quan li HA GV
        private void md040202_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelControl1.Controls.Clear();
            frmGiaoVienHinhAnh frm = new frmGiaoVienHinhAnh();
            frm.TopLevel = false;
            panelControl1.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            frm.Show();
        }

        //gvu phan cong GV
        private void md040301_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelControl1.Controls.Clear();
            frmPhanCongGiaoVien frm = new frmPhanCongGiaoVien();
            frm.TopLevel = false;
            panelControl1.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            frm.Show();
        }

        //doi mk
        private void md010104_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        //phan quyen
        private void md010301_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelControl1.Controls.Clear();
            frmQuyen frm = new frmQuyen();
            frm.TopLevel = false;
            panelControl1.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            frm.Show();

            getQuyen();
        }

        private void getQuyen()
        {
            foreach (RibbonPage page in ribbonControl1.Pages)
            {
                ChucNang a = new ChucNang()
                {
                    Menu = page.Name,
                    App = "Quyen",
                    Detail = page.Text,
                    ParentMenu = null
                };
                db.ChucNang.AddOrUpdate(a);

                foreach (RibbonPageGroup pageGroup in page.Groups)
                {
                    ChucNang b = new ChucNang()
                    {
                        Menu = pageGroup.Name,
                        App = "Quyen",
                        Detail = pageGroup.Text,
                        ParentMenu = page.Name
                    };
                    db.ChucNang.AddOrUpdate(b);

                    foreach (BarItemLink barItemLink in pageGroup.ItemLinks)
                    {
                        ChucNang c = new ChucNang()
                        {
                            Menu = barItemLink.Item.Name,
                            App = "Quyen",
                            Detail = barItemLink.Caption,
                            ParentMenu = pageGroup.Name
                        };
                        db.ChucNang.AddOrUpdate(c);

                    }
                }
                db.SaveChanges();
            }
        }

        //lich su
        private void md010302_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
