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
    public partial class frmPhanCongGiaoVien : DevExpress.XtraEditors.XtraForm
    {
        public frmPhanCongGiaoVien()
        {
            InitializeComponent();
        }

        private void frmGiaoVienPhanCong_Load(object sender, EventArgs e)
        {
            frmLoad();
        }

        QuanLiDiemEntities db = new QuanLiDiemEntities();
        public void frmLoad()
        {
            loadHK();
            loadTenGV();
            loadPhanCong();
            hideColumn();
            binding();
        }

        public void loadPhanCong()
        {
            var KetQua = from a in db.GV_PhanCong join b in db.GiaoVien on a.MaGV equals b.MaGV
                         join c in db.Lop on a.MaLop equals c.MaLop
                         join d in db.MonHP on a.MaMonHP equals d.MaMonHP
                         select new
                         {
                             a.MaGV, a.MaLop, a.MaMonHP,
                             Tên_GV = b.TenGV,
                             Tên_Lớp = c.TenLop,
                             Tên_MH = d.TenMonHP,
                             Ngày_BD = a.NgayBD,
                             Ngày_KT = a.NgayKT
                         };
            gcPhanCong.DataSource = KetQua.ToList();

            var GV = db.GiaoVien.Select(a => a);
            var Lop = from c in db.Lop select c;
            var Mon = from b in db.MonHP select b;

            luLop.Properties.DataSource = Lop.Select(a => a.TenLop).Distinct().ToList();
            luTenGV.Properties.DataSource = GV.Select(a => a.TenGV).Distinct().ToList();
            luTenMH.Properties.DataSource = Mon.Select(a => a.TenMonHP).Distinct().ToList();
            //luTenMH.Properties.DataSource = Mon.Select(a => a.TenMonHP).ToList();

        }

        public void loadHK()
        {
            var KetQua = from a in db.HocKy select a;
            luTheoHK.Properties.DataSource = KetQua.ToList();
            luTheoHK.Properties.DisplayMember = "TenHK";
            luTheoHK.Properties.ValueMember = "MaHK";

        }
        public void loadTenGV()
        {
            var KetQua = from a in db.GiaoVien select a;
            luTheoTenGV.Properties.DataSource = KetQua.ToList();
            luTheoTenGV.Properties.DisplayMember = "TenGV";
            luTheoTenGV.Properties.ValueMember = "MaGV";
        }

        public void loadTheoHK()
        {
            var KetQua = from a in db.GV_PhanCong
                         join b in db.GiaoVien on a.MaGV equals b.MaGV
                         join c in db.Lop on a.MaLop equals c.MaLop
                         join d in db.MonHP on a.MaMonHP equals d.MaMonHP
                         join e in db.HocKy on d.MaHK equals e.MaHK
                         where e.MaHK == luTheoHK.EditValue.ToString()
                         select new
                         {
                             Tên_GV = b.TenGV,
                             Tên_Lớp = c.TenLop,
                             Tên_MH = d.TenMonHP,
                             Ngày_BD = a.NgayBD,
                             Ngày_KT = a.NgayKT
                         };
            gcPhanCong.DataSource = KetQua.ToList();

            var result = db.MonHP.Where(b => b.MaHK == luTheoHK.EditValue.ToString())
                                             .Select(a => a.TenMonHP);
            if (result.Any())
            {
                luTenMH.Properties.DataSource = result.ToList();
            }
            else
            {
                XtraMessageBox.Show("Học kỳ này chưa phân công môn học !" , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //return;
                luTheoHK.EditValue = "HK0001";

            }

        }

        public void loadTheoTenGV()
        {
            var KetQua = from a in db.GV_PhanCong
                         join b in db.GiaoVien on a.MaGV equals b.MaGV
                         join c in db.Lop on a.MaLop equals c.MaLop
                         join d in db.MonHP on a.MaMonHP equals d.MaMonHP
                         where a.MaGV == luTheoTenGV.EditValue.ToString()
                         select new
                         {
                             Tên_GV = b.TenGV,
                             Tên_Lớp = c.TenLop,
                             Tên_MH = d.TenMonHP,
                             Ngày_BD = a.NgayBD,
                             Ngày_KT = a.NgayKT
                         };
            gcPhanCong.DataSource = KetQua.ToList();
        }

        public void hideColumn()
        {
            for (int i = 0; i <= 2; i++)
            {
                this.gridView1.Columns[i].Visible = false;
            }
        }
        public void binding()
        {
            luLop.DataBindings.Clear();
            luLop.DataBindings.Add("EditValue", gcPhanCong.DataSource, "Tên_Lớp", true);
            luTenGV.DataBindings.Clear();
            luTenGV.DataBindings.Add("EditValue", gcPhanCong.DataSource, "Tên_GV");
            luTenMH.DataBindings.Clear();
            luTenMH.DataBindings.Add("EditValue", gcPhanCong.DataSource, "Tên_MH");
            dateBegin.DataBindings.Clear();
            dateBegin.DataBindings.Add("Text", gcPhanCong.DataSource, "Ngày_BD", true, DataSourceUpdateMode.OnPropertyChanged);
            dateEnd.DataBindings.Clear();
            dateEnd.DataBindings.Add("Text", gcPhanCong.DataSource, "Ngày_KT", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void luTheoHK_EditValueChanged(object sender, EventArgs e)
        {
            loadTheoHK();
            binding();
        }

        private void luTheoTenGV_EditValueChanged(object sender, EventArgs e)
        {
            loadTheoTenGV();
            binding();
        }

        bool addPC = false;
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            luLop.EditValue = null;
            luTenMH.EditValue = null;
            luTenGV.EditValue = null;
            dateBegin.EditValue = null;
            dateEnd.EditValue = null;
            addPC = true;
        }

        //fail
        public void ThemPC()
        {
            GV_PhanCong Them = new GV_PhanCong()
            {
                MaGV = luTenGV.EditValue.ToString(),
                MaLop = luLop.EditValue.ToString(),
                MaMonHP = luTenMH.EditValue.ToString(),
                NgayBD = Convert.ToDateTime(dateBegin.Text),
                NgayKT = Convert.ToDateTime(dateEnd.Text),
            };
            db.GV_PhanCong.Add(Them);
            db.SaveChanges();
            loadPhanCong();
            addPC = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var TenSV = (luTenGV.EditValue == null) ? "" : luTenGV.EditValue.ToString();
            var Mon = (luTenMH.EditValue == null) ? "" : luTenMH.EditValue.ToString();
            var Lop = (luLop.EditValue == null) ? "" : luLop.EditValue.ToString();

            if (addPC == true)
            {
                try
                {
                    db.GVPhanCong_Insert(TenSV, Mon, Lop, Convert.ToDateTime(dateBegin.Text), Convert.ToDateTime(dateEnd.Text));
                    XtraMessageBox.Show("Thêm dữ liệu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception)
                {

                    XtraMessageBox.Show("Thêm dữ liệu thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }

            }
            else
            {
                db.GVPhanCong_Update(luTenGV.EditValue.ToString(), luTenMH.EditValue.ToString(), luLop.EditValue.ToString(), Convert.ToDateTime(dateBegin.Text), Convert.ToDateTime(dateEnd.Text));
                XtraMessageBox.Show("Sửa dữ liệu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            frmLoad();
            addPC = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            db.GVPhanCong_Delete(luTenGV.EditValue.ToString(), luTenMH.EditValue.ToString(), luLop.EditValue.ToString());
            XtraMessageBox.Show("Xóa dữ liệu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadPhanCong();
            addPC = false;
            binding();
        }

    }
}