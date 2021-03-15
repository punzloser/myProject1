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
    public partial class frmXemPhanCong : DevExpress.XtraEditors.XtraForm
    {
        public frmXemPhanCong()
        {
            InitializeComponent();
            loadHK();
        }
        QuanLiDiemEntities db = new QuanLiDiemEntities();

        private void frmXemPhanCong_Load(object sender, EventArgs e)
        {
            //gVPhanCongBindingSource.DataSource = db.GV_PhanCong.ToList();

            var result = from a in db.GV_PhanCong
                         join b in db.GiaoVien on a.MaGV equals b.MaGV
                         join c in db.MonHP on a.MaMonHP equals c.MaMonHP
                         join d in db.TaiKhoan on b.MaGV equals d.UserName
                         where d.UserName == ClassTaiKhoan.TaiKhoan/*"GV0125"*/
                         select a;
            gcXemPC.DataSource = result.ToList();

            var tenGV = from a in result
                        join b in db.GiaoVien on a.MaGV equals b.MaGV
                        select b.TenGV;

            lbTenGV.Text = tenGV.FirstOrDefault();
        }

        public void loadHK()
        {
            var kq = from a in db.HocKy select a.TenHK;
            if (kq.Any())
            {
                luHK.Properties.DataSource = kq.ToList();
            }
        }

        private void Query()
        {
            //var 
        }

        private void luHK_EditValueChanged(object sender, EventArgs e)
        {
            var result = from a in db.GV_PhanCong
                         join b in db.GiaoVien on a.MaGV equals b.MaGV
                         join c in db.MonHP on a.MaMonHP equals c.MaMonHP
                         join d in db.TaiKhoan on b.MaGV equals d.UserName
                         where d.UserName == ClassTaiKhoan.TaiKhoan && c.HocKy.TenHK == luHK.EditValue.ToString()/*"GV0125"*/
                         select a;

            gcXemPC.DataSource = result.ToList();
        }
    }
}