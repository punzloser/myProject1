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
            sinhVienSelectAllDetailResultBindingSource.ResetBindings(true);
        }

        private void luLop_EditValueChanged(object sender, EventArgs e)
        {
            gcDanhSachLop.DataSource = db.SinhVienSelectAllByLopDetail(luLop.EditValue.ToString());

            txtMaSV.DataBindings.Clear();
            txtMaSV.DataBindings.Add("Text", gcDanhSachLop.DataSource, "MaSV");
            txtHoTen.DataBindings.Clear();
            txtHoTen.DataBindings.Add("Text", gcDanhSachLop.DataSource, "HoTen");
            txtDanToc.DataBindings.Clear();
            txtDanToc.DataBindings.Add("Text", gcDanhSachLop.DataSource, "DanToc");
            txtGioiTinh.DataBindings.Clear();
            txtGioiTinh.DataBindings.Add("Text", gcDanhSachLop.DataSource, "GioiTinh");
            txtNoiSinh.DataBindings.Clear();
            txtNoiSinh.DataBindings.Add("Text", gcDanhSachLop.DataSource, "NoiSinh");
            dateNgaySinh.DataBindings.Clear();
            dateNgaySinh.DataBindings.Add("Text", gcDanhSachLop.DataSource, "NgaySinh", true, DataSourceUpdateMode.OnPropertyChanged, "", "dd/MM/yyyy");
            //dateNgaySinh.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", gcDanhSachLop.DataSource, "NgaySinh", true));
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            //khởi tạo excel
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            //khởi tạo workbook
            Microsoft.Office.Interop.Excel.Workbook workbook = app.Workbooks.Add(Type.Missing);
            //khởi tạo worksheet, chạy excel
            Microsoft.Office.Interop.Excel.Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            //worksheet.Columns.AutoFit();
            //worksheet.Rows.AutoFit();
            app.WindowState = Microsoft.Office.Interop.Excel.XlWindowState.xlMaximized;
            app.Visible = true;

            //luu
            //ExcelApp.ActiveWorkbook.SaveCopyAs(Application.StartupPath + "\\HaulerInfo.xlsx");
            //ExcelApp.ActiveWorkbook.Saved = true;
            //đổ dữ liệu vào sheet

        }
    }
}