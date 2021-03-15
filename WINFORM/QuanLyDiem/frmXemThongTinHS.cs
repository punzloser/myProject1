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
    public partial class frmXemThongTinHS : DevExpress.XtraEditors.XtraForm
    {
        public frmXemThongTinHS()
        {
            InitializeComponent();
        }
        QuanLiDiemEntities db = new QuanLiDiemEntities();

        // better than any function 
        //public static byte[] ConvertImageToByteArray(System.Drawing.Image imageToConvert, ImageFormat formatOfImage)
        //{
        //    byte[] Ret;
        //    try
        //    {
        //        using (MemoryStream ms = new MemoryStream())
        //        {
        //            imageToConvert.Save(ms, formatOfImage);
        //            Ret = ms.ToArray();
        //        }
        //    }
        //    catch (Exception) { throw; }
        //    return Ret;
        //}

        byte[] ConvertImageToBytes(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

                return ms.ToArray();
            }
        }

        public Image ConvertByteArrayToImage(byte[] data)
        {
            if (data != null)
            {
                using (MemoryStream ms = new MemoryStream(data, 0, data.Length))
                {
                    return Image.FromStream(ms, true);
                }
            }
            return null;
        }

        private void frmThongTinHS_Load(object sender, EventArgs e)
        {
            try
            {
                var kq = from a in db.SinhVien
                         where a.MaSV == ClassTaiKhoan.TaiKhoan
                         join b in db.SinhVien_HinhAnh on a.MaSV equals b.MaSV
                         select new
                         {
                             a.MaSV,
                             HoTen = a.HoLot + " " + a.Ten,
                             a.NgaySinh,
                             a.GioiTinh,
                             a.NoiSinh,
                             a.DanToc,
                             a.Lop.TenLop,
                             a.TinhTrang.TinhTrang1,
                             b.IMG
                         };

                if (kq.Any())
                {
                    txtMaSV.Text = kq.Select(a => a.MaSV).FirstOrDefault();
                    txtHoTen.Text = kq.Select(a => a.HoTen).FirstOrDefault();
                    dateNgaySinh.EditValue = kq.Select(a => a.NgaySinh).FirstOrDefault();
                    txtGioiTinh.Text = kq.Select(a => a.GioiTinh).FirstOrDefault();
                    txtNoiSinh.Text = kq.Select(a => a.NoiSinh).FirstOrDefault();
                    txtDanToc.Text = kq.Select(a => a.DanToc).FirstOrDefault();
                    txtTenLop.Text = kq.Select(a => a.TenLop).FirstOrDefault();
                    txtTinhTrang.Text = kq.Select(a => a.TinhTrang1).FirstOrDefault();

                    var result = ConvertByteArrayToImage(kq.Select(a => a.IMG).FirstOrDefault());
                   
                    pictureSV.Image = result;

                }
                else
                {
                    XtraMessageBox.Show("Thông tin dành cho sinh viên !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataLayoutControl1.Hide();
                }



            }
            catch (Exception)
            {

                XtraMessageBox.Show("Lỗi !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }
    }
}