using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
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

        QuanLiDiemEntities db;
        private void frmSinhVienHinhAnh_Load(object sender, EventArgs e)
        {
            db = new QuanLiDiemEntities();
           // db.SinhVienHA_SelectALL().ToList();
            sinhVienHASelectALLResultBindingSource.DataSource = db.SinhVienHA_SelectALL().ToList();
            lopBindingSource.DataSource = db.Lop.ToList();
        }

        private void luChonTheoLop_EditValueChanged(object sender, EventArgs e)
        {
            gcSVHA.DataSource = db.SinhVienHA_SelectByLop(luChonTheoLop.EditValue.ToString());
           
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

        byte[] ConvertImageToBytes(Image img)
        {
            using(MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        public Image ConvertByteArrayToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }
        
        private void btnDuongDan_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Image files(*.jpg;*.jpeg)|*.jpg;*.jpeg", Multiselect = false})
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    imgSV.Image = Image.FromFile(ofd.FileName);
                    txtFile.Text = ofd.FileName;
                    db.SinhVienHA_Update(txtIDsvIMG.Text, ConvertImageToBytes(imgSV.Image), txtFile.Text);
                    XtraMessageBox.Show("Tải ảnh Sinh Viên thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmSinhVienHinhAnh_Load(sender, e);
                }
            }
        }
    }
}