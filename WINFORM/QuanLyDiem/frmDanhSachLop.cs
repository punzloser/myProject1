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
using System.Data.OleDb;

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
            sinhVienSelectAllDetail1ResultBindingSource.DataSource = db.SinhVienSelectAllDetail_1().ToList();
            sinhVienSelectAllDetail1ResultBindingSource.ResetBindings(true);
        }

        private void luLop_EditValueChanged(object sender, EventArgs e)
        {
            gcDanhSachLop.DataSource = db.SinhVienSelectAllByLop(luLop.EditValue.ToString());

            txtMaSV.DataBindings.Clear();
            txtMaSV.DataBindings.Add("Text", gcDanhSachLop.DataSource, "MaSV");
            txtHoLot.DataBindings.Clear();
            txtHoLot.DataBindings.Add("Text", gcDanhSachLop.DataSource, "HoLot");
            txtTen.DataBindings.Clear();
            txtTen.DataBindings.Add("Text", gcDanhSachLop.DataSource, "Ten");
            txtDanToc.DataBindings.Clear();
            txtDanToc.DataBindings.Add("Text", gcDanhSachLop.DataSource, "DanToc");
            txtGioiTinh.DataBindings.Clear();
            txtGioiTinh.DataBindings.Add("Text", gcDanhSachLop.DataSource, "GioiTinh");
            txtNoiSinh.DataBindings.Clear();
            txtNoiSinh.DataBindings.Add("Text", gcDanhSachLop.DataSource, "NoiSinh");
            dateNgaySinh.DataBindings.Clear();
            dateNgaySinh.DataBindings.Add("Text", gcDanhSachLop.DataSource, "NgaySinh", true, DataSourceUpdateMode.OnPropertyChanged, "", "dd/MM/yyyy");
            dateNgaySinh.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", gcDanhSachLop.DataSource, "NgaySinh", true));
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

            //đổ dữ liệu vào sheet
            //worksheet.Cells[1, 1] = "BẢNG DANH SÁCH SINH VIÊN";

            //if (luLop.Text == "")
            //{
            //    worksheet.Cells[2, 7] = "Toàn khối";
            //}
            //else
            //{
            //    worksheet.Cells[2, 8] = "Lớp : " + luLop.Text;
            //}

            worksheet.Cells[1, 1] = "STT";
            worksheet.Cells[1, 2] = "Mã SV";
            worksheet.Cells[1, 3] = "Họ tên";
            worksheet.Cells[1, 5] = "Ngày sinh";
            worksheet.Cells[1, 6] = "Giới tính";
            worksheet.Cells[1, 7] = "Nơi sinh";
            worksheet.Cells[1, 8] = "Dân tộc";

            for (int i = 0; i < gridView1.RowCount; i++)
            {
                for (int j = 0; j < gridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, 1] = i + 1;
                    worksheet.Cells[i + 2, j + 2] = gridView1.GetRowCellValue(i, gridView1.Columns[j]);
                }
            }

            //định dạng trang

            //định dạng cột

            //định dạng font

            //kẻ bảng 

            //định dạng all dòng text ra giữa
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            sinhVienSelectAllDetail1ResultBindingSource.ResetBindings(true);
            db.SinhVienUpdate(txtMaSV.Text, txtHoLot.Text, txtTen.Text, Convert.ToDateTime(dateNgaySinh.Text), txtGioiTinh.Text, txtNoiSinh.Text, txtDanToc.Text);
            XtraMessageBox.Show("Sửa dữ liệu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmDanhSachLop_Load(sender, e);
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Test\DanhSachSV.xlsx;Extended Properties='Excel 8.0;HDR=YES'");
                DataTable table = new DataTable();
                OleDbDataAdapter dap = new OleDbDataAdapter("SELECT * FROM [Sheet1$]", conn);
                dap.Fill(table);
                conn.Close();

                //XtraMessageBox.Show("Kết nối thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                foreach (DataRow a in table.Rows)
                {
                    if (db.SinhVienSelectAllByID(a[1].ToString()).Count() == 0)
                    {
                        if (luLop.EditValue is null)
                        {
                            XtraMessageBox.Show("Vui lòng chọn lớp !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            return;
                        }
                        db.SinhVienInsert_1(a[2].ToString(), a[3].ToString(), Convert.ToDateTime(a[4]), a[5].ToString(), a[6].ToString(), a[7].ToString(), luLop.EditValue.ToString());
                    }
                }
                luLop_EditValueChanged(sender, e);
            }
            catch (Exception er)
            {

                XtraMessageBox.Show("Cập nhật dữ liệu thất bại !\n" + er, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}