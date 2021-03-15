using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiem
{
    public partial class frmSinhVienHinhAnh : DevExpress.XtraEditors.XtraForm
    {
        public frmSinhVienHinhAnh()
        {
            InitializeComponent();
        }

        QuanLiDiemEntities db = new QuanLiDiemEntities();
        private void frmSinhVienHinhAnh_Load(object sender, EventArgs e)
        {
            frmLoad();
        }

        private void frmLoad()
        {
            chonSVTheoLop();
            SinhVienHA_SelectALL();
            addBinding();
        }

        private void addBinding()
        {
            txtMaSV.DataBindings.Clear();
            txtMaSV.DataBindings.Add("Text", gcSVHA.DataSource, "MaSV");
            imgSV.DataBindings.Clear();
            imgSV.DataBindings.Add("Image", gcSVHA.DataSource, "IMG", true, DataSourceUpdateMode.OnPropertyChanged);
            txtIDsvIMG.DataBindings.Clear();
            txtIDsvIMG.DataBindings.Add("Text", gcSVHA.DataSource, "SV_IMG");
            luHoTenSV.DataBindings.Clear();
            luHoTenSV.DataBindings.Add("Text", gcSVHA.DataSource, "HoTenSV");
            txtFile.DataBindings.Clear();
            txtFile.DataBindings.Add("Text", gcSVHA.DataSource, "FileIMG");
        }

        private void SinhVienHA_SelectALL()
        {
            var kq = from a in db.SinhVien
                     join b in db.SinhVien_HinhAnh on a.MaSV equals b.MaSV
                     orderby a.MaSV
                     select new
                     {
                         a.MaSV,
                         HoTenSV = a.HoLot + " " + a.Ten,
                         b.IMG,
                         b.FileIMG,
                         b.SV_IMG
                     };
            gcSVHA.DataSource = kq.ToList();
        }

        private void chonSVTheoLop()
        {
            var kq = (from a in db.Lop select a.TenLop);

            luChonLop.Properties.DataSource = kq.ToList();
        }      
        
        private void btnDuongDan_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Image files(*.jpg;*.jpeg)|*.jpg;*.jpeg", Multiselect = false})
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    imgSV.Image = Image.FromFile(ofd.FileName);
                    txtFile.Text = ofd.FileName;
                    HinhAnh_Update();
                    XtraMessageBox.Show("Tải ảnh Sinh Viên thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmSinhVienHinhAnh_Load(sender, e);
                }
            }
        }

        public void HinhAnh_Update()
        {
            SinhVien_HinhAnh SuaHA = db.SinhVien_HinhAnh.Where(a => a.SV_IMG.Equals(txtIDsvIMG.Text)).SingleOrDefault();
            SuaHA.IMG = frmGiaoVienHinhAnh.ConvertImageToBytes(imgSV.Image);
            SuaHA.FileIMG = txtFile.Text;
            db.SaveChanges();
        }
        public void HinhAnh_Delete()
        {
            SinhVien_HinhAnh SuaHA = db.SinhVien_HinhAnh.Where(a => a.SV_IMG.Equals(txtIDsvIMG.Text)).SingleOrDefault();
            SuaHA.IMG = frmGiaoVienHinhAnh.ConvertImageToBytes(imgSV.Image);
            SuaHA.FileIMG = txtFile.Text;
            db.SaveChanges();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SinhVien_HinhAnh XoaHA = db.SinhVien_HinhAnh.Where(a => a.SV_IMG.Equals(txtIDsvIMG.Text)).SingleOrDefault();
            XoaHA.FileIMG = null;
            XoaHA.IMG = null;
            db.SaveChanges();
            XtraMessageBox.Show("Xóa ảnh Sinh Viên thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmLoad();
        }

        private void luChonLop_EditValueChanged(object sender, EventArgs e)
        {
            var kq = from a in db.Lop
                     where a.TenLop == luChonLop.EditValue.ToString()
                     select a.MaLop;

            gcSVHA.DataSource = db.SinhVienHA_SelectByLop(kq.ToList().First());
            addBinding();
        }
    }
}