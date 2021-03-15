using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiem
{
    public partial class frmGiaoVienHinhAnh : DevExpress.XtraEditors.XtraForm
    {
        public frmGiaoVienHinhAnh()
        {
            InitializeComponent();
        }
        QuanLiDiemEntities db = new QuanLiDiemEntities();


        private void frmGiaoVienHinhAnh_Load(object sender, EventArgs e)
        {
            frmLoad();
        }

        public void frmLoad()
        {
            GiaoVien_SelectCV();
            GiaoVienHA_SelectAll();
            //hideColumn();
            addBinding();

        }

        public static byte[] ConvertImageToBytes(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
        public void GiaoVien_SelectCV()
        {
            var KetQua = (from a in db.GiaoVien
                          select a.ChucVu).Distinct();
            
            luChonTheoCV.Properties.DataSource = KetQua.ToList();
            //luChonTheoCV.EditValue = KetQua.Select(a => a).First();

        }

        public void addBinding()
        {
            txtMaGV.DataBindings.Clear();
            txtMaGV.DataBindings.Add("Text", gcGV.DataSource, "MaGV");
            imgGV.DataBindings.Clear();
            imgGV.DataBindings.Add("Image", gcGV.DataSource, "IMG", true, DataSourceUpdateMode.OnPropertyChanged);
            txtIDgvIMG.DataBindings.Clear();
            txtIDgvIMG.DataBindings.Add("Text", gcGV.DataSource, "GV_IMG");
            luTenGV.DataBindings.Clear();
            luTenGV.DataBindings.Add("Text", gcGV.DataSource, "TenGV");
            txtFile.DataBindings.Clear();
            txtFile.DataBindings.Add("Text", gcGV.DataSource, "FileIMG2");
        }

        public void hideColumn()
        {
            this.gridView1.Columns[3].Visible = false;
            this.gridView1.Columns[4].Visible = false;
        }
        public void GiaoVienHA_SelectAll()
        {
            var KetQua = from a in db.GiaoVien_HinhAnh
                         join b in db.GiaoVien on a.MaGV equals b.MaGV
                         select new
                         {
                             b.TenGV,
                             a.IMG,
                             a.MaGV,
                             a.GV_IMG,
                             a.FileIMG2
                         };
            gcGV.DataSource = KetQua.ToList();
        }

        public void HinhAnh_Update()
        {
            GiaoVien_HinhAnh SuaHA = db.GiaoVien_HinhAnh.Where(a => a.GV_IMG.Equals(txtIDgvIMG.Text)).SingleOrDefault();
            SuaHA.IMG = ConvertImageToBytes(imgGV.Image);
            SuaHA.FileIMG2 = txtFile.Text;
            db.SaveChanges();

        }

        public void HinhAnh_Delete()
        {

            GiaoVien_HinhAnh XoaHA = db.GiaoVien_HinhAnh.Where(a => a.GV_IMG.Equals(txtIDgvIMG.Text)).SingleOrDefault();
            XoaHA.FileIMG2 = null;
            XoaHA.IMG = null;
            db.SaveChanges();
            XtraMessageBox.Show("Xóa ảnh Giáo Viên thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmLoad();
        }

        private void luChonTheoCV_EditValueChanged(object sender, EventArgs e)
        {
            gcGV.DataSource = db.GiaoVienHA_SelectByCV(luChonTheoCV.EditValue.ToString());

            addBinding();
        }

        private void btnLink_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Image files(*.jpg;*.jpeg)|*.jpg;*.jpeg", Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    imgGV.Image = Image.FromFile(ofd.FileName);
                    txtFile.Text = ofd.FileName;
                    HinhAnh_Update();
                    //db.GiaoVienHA_Update(txtIDgvIMG.Text, ConvertImageToBytes(imgGV.Image), txtFile.Text);
                    XtraMessageBox.Show("Tải ảnh Giáo Viên thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmLoad();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            HinhAnh_Delete();
        }
    }
}