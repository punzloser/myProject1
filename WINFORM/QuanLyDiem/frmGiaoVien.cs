using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiem
{
    public partial class frmGiaoVien : DevExpress.XtraEditors.XtraForm
    {
        public frmGiaoVien()
        {
            InitializeComponent();
        }

        QuanLiDiemEntities db = new QuanLiDiemEntities();
        private void frmGiaoVien_Load(object sender, EventArgs e)
        {
            //normal
            // giaoVienBindingSource.DataSource = db.GiaoVien.ToList();

            //expression
            //giaoVienBindingSource.DataSource = db.GiaoVien.Where(a => a.ID.CompareTo(1) == 1).OrderBy(p=>p.TrinhDo).ToList();

            // linq
            giaoVienBindingSource.DataSource = (from a in db.GiaoVien
                                                orderby a.ID descending
                                                select a).ToList();
        }
        bool ThemGV = false;
        private void btnThem_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            giaoVienBindingSource.AddNew();
            txtTenGV.Focus();
            ThemGV = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GiaoVien gv = db.GiaoVien.Where(a => a.MaGV == txtMaGV.Text).SingleOrDefault();
            db.GiaoVien.Remove(gv);
            db.SaveChanges();
            frmGiaoVien_Load(sender, e);
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ThemGV == true)
            {
                GiaoVien gv = new GiaoVien()
                {
                    TenGV = txtTenGV.Text,
                    TrinhDo = txtTrinhDo.Text,
                    NgaySinh = Convert.ToDateTime(dateNgaySinh.Text),
                    GioiTinh = txtGioiTinh.Text,
                    NoiSinh = txtNoiSinh.Text,
                    DanToc = txtDanToc.Text,
                    ChucVu = txtChucVu.Text
                };
                db.GiaoVien.Add(gv);
                db.SaveChanges();
                frmGiaoVien_Load(sender, e);
                ThemGV = false;
            }
            else
            {
                //string MaGV = gridView1.GetFocusedRowCellValue("MaGV").ToString();
                GiaoVien gv = db.GiaoVien.Find(txtMaGV.Text);
                gv.TenGV = txtTenGV.Text;
                gv.TrinhDo = txtTrinhDo.Text;
                gv.NgaySinh = Convert.ToDateTime(dateNgaySinh.Text);
                gv.GioiTinh = txtGioiTinh.Text;
                gv.NoiSinh = txtNoiSinh.Text;
                gv.DanToc = txtDanToc.Text;
                gv.ChucVu = txtChucVu.Text;
                db.SaveChanges();
                frmGiaoVien_Load(sender, e);
            }
        }
    }
}