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
            frmLoad();

            btnSua.Enabled = false;
        }

        public void MaHoa()
        {
            txtTenGV.Text = frmLopSinhVien.maHoa(txtTenGV.Text);
            txtTrinhDo.Text = frmLopSinhVien.maHoa(txtTrinhDo.Text);
            txtDanToc.Text = frmLopSinhVien.maHoa(txtDanToc.Text);
            txtNoiSinh.Text = frmLopSinhVien.maHoa(txtNoiSinh.Text);
        }
        public void frmLoad()
        {
            //normal
            // giaoVienBindingSource.DataSource = db.GiaoVien.ToList();

            //expression
            //giaoVienBindingSource.DataSource = db.GiaoVien.Where(a => a.ID.CompareTo(1) == 1).OrderBy(p=>p.TrinhDo).ToList();

            // linq
            var result = from a in db.GiaoVien
                         orderby a.ID 
                         select a;
            giaoVienBindingSource.DataSource = result.ToList();
        }

        bool ThemGV = false;
        private void btnThem_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            giaoVienBindingSource.AddNew();
            txtTenGV.Focus();
            ThemGV = true;

            //
            btnXoa.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (XtraMessageBox.Show("Xóa Giáo Viên : "+txtTenGV.Text+" ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    var XoaGV = from a in db.GiaoVien
                                where a.MaGV == txtMaGV.Text
                                select a;
                    GiaoVien gv = XoaGV.SingleOrDefault();
                    //the same 
                    //GiaoVien gv = db.GiaoVien.Find(txtMaGV.Text);
                    //GiaoVien gv = db.GiaoVien.Where(a => a.MaGV == txtMaGV.Text).SingleOrDefault();
                    db.GiaoVien.Remove(gv);
                    db.SaveChanges();
                    XtraMessageBox.Show("Xóa Giáo Viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            catch (Exception)
            {

                XtraMessageBox.Show("Xóa Giáo Viên thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            //test the same

            frmLoad();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ThemGV == true)
            {
                MaHoa();
                try
                {
                    GiaoVien gv = new GiaoVien();
                    //the same
                    //{
                    //    TenGV = txtTenGV.Text,
                    //    TrinhDo = txtTrinhDo.Text,
                    //    NgaySinh = ns,
                    //    GioiTinh = txtGioiTinh.Text,
                    //    NoiSinh = txtNoiSinh.Text,
                    //    DanToc = txtDanToc.Text,
                    //    ChucVu = txtChucVu.Text
                    //};
                    //DateTime? ns = (DateTime?)gridView1.GetFocusedRowCellValue("Ngaysinh");

                    gv.TenGV = txtTenGV.Text;
                    gv.TrinhDo = txtTrinhDo.Text;
                    gv.NgaySinh = Convert.ToDateTime(dateNgaySinh.Text);
                    gv.GioiTinh = txtGioiTinh.Text;
                    gv.NoiSinh = txtNoiSinh.Text;
                    gv.DanToc = txtDanToc.Text;
                    gv.ChucVu = txtChucVu.Text;

                    db.GiaoVien.Add(gv);
                    db.SaveChanges();

                    XtraMessageBox.Show("Thêm Giáo Viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {

                    XtraMessageBox.Show("Vui lòng nhập đầy đủ thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                frmLoad();
                ThemGV = false;
            }
            else
            {
                MaHoa();
                try
                {
                    string MaGV = gridView1.GetFocusedRowCellValue("MaGV").ToString();
                    GiaoVien gv = db.GiaoVien.Where(a => a.MaGV == MaGV).SingleOrDefault();
                    gv.TenGV = txtTenGV.Text;
                    gv.TrinhDo = txtTrinhDo.Text;
                    gv.NgaySinh = Convert.ToDateTime(dateNgaySinh.Text);
                    gv.GioiTinh = txtGioiTinh.Text;
                    gv.NoiSinh = txtNoiSinh.Text;
                    gv.DanToc = txtDanToc.Text;
                    gv.ChucVu = txtChucVu.Text;
                    db.SaveChanges();

                    XtraMessageBox.Show("Sửa thông tin thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception)
                {

                    XtraMessageBox.Show("Sửa thông tin thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                frmLoad();
            }
        }

        private void txtTenGV_TextChanged(object sender, EventArgs e)
        {
            this.btnSua.Enabled = !String.IsNullOrWhiteSpace(this.txtTenGV.Text);
            this.btnXoa.Enabled = !String.IsNullOrWhiteSpace(this.txtTenGV.Text);
        }
    }
}