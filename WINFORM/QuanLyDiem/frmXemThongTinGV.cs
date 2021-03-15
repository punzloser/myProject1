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
    public partial class frmXemThongTinGV : DevExpress.XtraEditors.XtraForm
    {
        public frmXemThongTinGV()
        {
            InitializeComponent();
        }
        QuanLiDiemEntities db = new QuanLiDiemEntities();

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

        private void frmXemThongTinGV_Load(object sender, EventArgs e)
        {
            try
            {
                var query = from a in db.GiaoVien
                            join b in db.GiaoVien_HinhAnh on a.MaGV equals b.MaGV
                            where a.MaGV == ClassTaiKhoan.TaiKhoan/*"GV0126"*/
                            select new
                            {
                                a.MaGV,
                                a.TenGV,
                                a.TrinhDo,
                                a.NgaySinh,
                                a.GioiTinh,
                                a.NoiSinh,
                                a.DanToc,
                                a.ChucVu,
                                b.IMG
                            };

                if (query.Any())
                {
                    txtMaGV.Text = query.Select(a => a.MaGV).FirstOrDefault();
                    txtHoTen.Text = query.Select(a => a.TenGV).FirstOrDefault();
                    dateNgaySinh.EditValue = query.Select(a => a.NgaySinh).FirstOrDefault();
                    txtGioiTinh.Text = query.Select(a => a.GioiTinh).FirstOrDefault();
                    txtTrinhDo.Text = query.Select(a => a.TrinhDo).FirstOrDefault();
                    txtNoiSinh.Text = query.Select(a => a.NoiSinh).FirstOrDefault();
                    txtDanToc.Text = query.Select(a => a.DanToc).FirstOrDefault();
                    txtChucVu.Text = query.Select(a => a.ChucVu).FirstOrDefault();

                    var result = ConvertByteArrayToImage(query.Select(a => a.IMG).FirstOrDefault());
                  
                    pictureGV.Image = result;
                }
                else
                {
                    XtraMessageBox.Show("Thông tin chỉ dành cho giáo viên !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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