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
    public partial class frmDanhSachLop : DevExpress.XtraEditors.XtraForm
    {
        public frmDanhSachLop()
        {
            InitializeComponent();
        }

        QuanLiDiemEntities db = new QuanLiDiemEntities();
        private void frmDanhSachLop_Load(object sender, EventArgs e)
        {
            lopBindingSource.DataSource = db.Lop.ToList();
            sinhVienSelectAllDetailResultBindingSource.DataSource = db.SinhVienSelectAllDetail().ToList();
        }

        private void luLop_EditValueChanged(object sender, EventArgs e)
        {
            gcDanhSachLop.DataSource = db.SinhVienSelectAllByLopDetail(luLop.EditValue.ToString());
            sinhVienSelectAllDetailResultBindingSource.ResetBindings(false);
        }
    }
}