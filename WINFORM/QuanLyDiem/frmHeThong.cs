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
    public partial class frmHeThong : DevExpress.XtraEditors.XtraForm
    {
        public frmHeThong()
        {
            InitializeComponent();
        }
        QuanLiDiemEntities db = new QuanLiDiemEntities();
        private void frmHeThong_Load(object sender, EventArgs e)
        {
            thongTinBindingSource.DataSource = db.ThongTin.ToList();
        }

        private void circularButton1_Click(object sender, EventArgs e)
        {
            db.ThongTinUpdate(txtMTT.Text, txtDonVi.Text, txtTenTruong.Text, txtTinh.Text, txtKhoaHoc.Text, txtNganh.Text, txtChuyenNganh.Text);
            XtraMessageBox.Show("Cập nhật thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}