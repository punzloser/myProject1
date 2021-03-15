using DevExpress.XtraEditors;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraTreeList.Nodes;
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
    public partial class frmBangDiemFull : DevExpress.XtraEditors.XtraForm
    {
        public frmBangDiemFull()
        {
            InitializeComponent();
        }

        QuanLiDiemEntities db = new QuanLiDiemEntities();
        XuLyDiem xl = new XuLyDiem();


        private void frmBangDiemFull_Load(object sender, EventArgs e)
        {
            lopSelectAllResultBindingSource.DataSource = db.LopSelectAll().ToList();
        }

        private void luLop_EditValueChanged(object sender, EventArgs e)
        {
            treeSV.Nodes.Clear();
            foreach (var r in db.SinhVienSelectAllByLop(luLop.EditValue.ToString()))
            {
                TreeNode node = new TreeNode();
                node.Name = r.MaSV;
                node.Text = r.HoLot + " " + r.Ten;
                treeSV.Nodes.Add(node);
            }
            treeSV.ExpandAll();
        }

        private void treeSV_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            foreach (var r in db.SinhVienSelectAllByID(e.Node.Name))
            {
                lbMaSV.Text = e.Node.Name;
                lbTenSV.Text = r.HoTen;
                lbNgaySinh.Text = Convert.ToDateTime(r.NgaySinh).ToString("dd-MM-yyyy");
                lbNoiSinh.Text = r.NoiSinh;
                lbGioiTinh.Text = r.GioiTinh;
                lbDanToc.Text = r.DanToc;
            }
            DataTable table = new DataTable();
            DataColumnCollection col = table.Columns;
            if (!col.Contains("MaMonHP"))
                table.Columns.Add("MaMonHP", typeof(String));
            if (!col.Contains("TenMonHP"))
                table.Columns.Add("TenMonHP", typeof(String));
            if (!col.Contains("SoTin"))
                table.Columns.Add("SoTin", typeof(String));
            if (!col.Contains("ChuyenCan"))
                table.Columns.Add("ChuyenCan", typeof(String));
            if (!col.Contains("GiuaKi"))
                table.Columns.Add("GiuaKi", typeof(String));
            if (!col.Contains("CuoiKy"))
                table.Columns.Add("CuoiKy", typeof(String));
            if (!col.Contains("DiemHP"))
                table.Columns.Add("DiemHP", typeof(String));
            if (!col.Contains("DiemChu"))
                table.Columns.Add("DiemChu", typeof(String));
            if (!col.Contains("DiemHe4"))
                table.Columns.Add("DiemHe4", typeof(String));
            if (!col.Contains("KetQua"))
                table.Columns.Add("KetQua", typeof(String));

            double TongDiem = 0;
            int TongSoTin = 0, TongTinDat = 0;

            foreach (var m in db.MonHPSelectBySV(e.Node.Name))
            {
                DataRow row = table.NewRow();
                row["MaMonHP"] = m.MaMonHP;
                row["TenMonHP"] = m.TenMonHP;
                row["SoTin"] = m.SoTin;

                foreach (var n in db.DiemHPSearch(m.MaMonHP, e.Node.Name))
                {
                    if (n.DiemLan2 == null)
                    {
                        row["ChuyenCan"] = n.ChuyenCan;
                        row["GiuaKi"] = n.GiuaKi;
                        row["Cuoiky"] = n.DiemLan1;
                        Double ? x = null;
                        if (n.ChuyenCan == x || n.GiuaKi == x || n.DiemLan1 == x)
                        {
                            row["DiemHP"] = "Chưa cập nhật";
                            row["DiemChu"] = "-/-";
                            row["DiemHe4"] = "-/-";
                            row["KetQua"] = "-/-";
                        }
                        else
                        {
                            row["DiemHP"] = xl.DiemHP(Convert.ToDouble(n.ChuyenCan), Convert.ToDouble(n.GiuaKi), Convert.ToDouble(n.DiemLan1));
                            row["DiemChu"] = xl.DiemChu(xl.DiemHP(Convert.ToDouble(n.ChuyenCan), Convert.ToDouble(n.GiuaKi), Convert.ToDouble(n.DiemLan1)));
                            row["DiemHe4"] = xl.DiemHe4(xl.DiemHP(Convert.ToDouble(n.ChuyenCan), Convert.ToDouble(n.GiuaKi), Convert.ToDouble(n.DiemLan1)));
                            row["KetQua"] = xl.KetQua(Convert.ToDouble(n.DiemLan2), xl.DiemHP(Convert.ToDouble(n.ChuyenCan), Convert.ToDouble(n.GiuaKi), Convert.ToDouble(n.DiemLan1)));
                            
                            TongDiem += xl.DiemHP(Convert.ToDouble(n.ChuyenCan), Convert.ToDouble(n.GiuaKi), Convert.ToDouble(n.DiemLan1)) * Convert.ToByte(m.SoTin);
                            TongTinDat += xl.checkTinChiDat(xl.DiemHP(Convert.ToDouble(n.ChuyenCan), Convert.ToDouble(n.GiuaKi), Convert.ToDouble(n.DiemLan1)), Convert.ToByte(m.SoTin));
                            TongSoTin += Convert.ToByte(m.SoTin); //bỏ lên đầu foreach (var m in db.MonHPSelectBySV(e.Node.Name)) sẽ lỗi tính điểm
                        }

                    }
                    else
                    {
                        row["ChuyenCan"] = n.ChuyenCan;
                        row["GiuaKi"] = n.GiuaKi;
                        row["Cuoiky"] = n.DiemLan2;

                        Double? x = null;
                        if (n.ChuyenCan != x && n.GiuaKi != x) // && n.DiemLan2 <= n.DiemLan1 err
                        {
                            row["DiemHP"] = xl.DiemHP(Convert.ToDouble(n.ChuyenCan), Convert.ToDouble(n.GiuaKi), Convert.ToDouble(n.DiemLan2));
                            row["DiemChu"] = xl.DiemChu(xl.DiemHP(Convert.ToDouble(n.ChuyenCan), Convert.ToDouble(n.GiuaKi), Convert.ToDouble(n.DiemLan2)));
                            row["DiemHe4"] = xl.DiemHe4(xl.DiemHP(Convert.ToDouble(n.ChuyenCan), Convert.ToDouble(n.GiuaKi), Convert.ToDouble(n.DiemLan2)));
                            row["KetQua"] = xl.KetQua(Convert.ToDouble(n.DiemLan2), xl.DiemHP(Convert.ToDouble(n.ChuyenCan), Convert.ToDouble(n.GiuaKi), Convert.ToDouble(n.DiemLan2)));

                            TongDiem += xl.DiemHP(Convert.ToDouble(n.ChuyenCan), Convert.ToDouble(n.GiuaKi), Convert.ToDouble(n.DiemLan2)) * Convert.ToByte(m.SoTin) * Convert.ToByte(m.SoTin);
                            TongTinDat += xl.checkTinChiDat(xl.DiemHP(Convert.ToDouble(n.ChuyenCan), Convert.ToDouble(n.GiuaKi), Convert.ToDouble(n.DiemLan2)), Convert.ToByte(m.SoTin));
                            TongSoTin += Convert.ToByte(m.SoTin);
                        }
                        else
                        {
                            XtraMessageBox.Show("Error !");
                            return;
                        }
                    }
                }

                table.Rows.Add(row);
            }
            Double t = Math.Round(TongDiem / TongSoTin, 2);
            
            lblTB.Text = t.ToString();
            lblXL.Text = xl.XepLoaiTK(t);
            lblTinChiDat.Text = TongTinDat.ToString();
            gcDiemCT.DataSource = table;
        }

        //Excel thô
        public void ExportExcelGoc()
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Excel (2003)(.xls)|*.xls|Excel (2010) (.xlsx)|*.xlsx |RichText File (.rtf)|*.rtf |Pdf File (.pdf)|*.pdf |Html File (.html)|*.html";
                if (saveDialog.ShowDialog() != DialogResult.Cancel)
                {
                    string exportFilePath = saveDialog.FileName;
                    string fileExtenstion = new FileInfo(exportFilePath).Extension;

                    switch (fileExtenstion)
                    {
                        case ".xls":
                            gcDiemCT.ExportToXls(exportFilePath);
                            break;
                        case ".xlsx":
                            gcDiemCT.ExportToXlsx(exportFilePath);
                            break;
                        case ".rtf":
                            gcDiemCT.ExportToRtf(exportFilePath);
                            break;
                        case ".pdf":
                            gcDiemCT.ExportToPdf(exportFilePath);
                            break;
                        case ".html":
                            gcDiemCT.ExportToHtml(exportFilePath);
                            break;
                        case ".mht":
                            gcDiemCT.ExportToMht(exportFilePath);
                            break;
                        default:
                            break;
                    }

                    if (File.Exists(exportFilePath))
                    {
                        try
                        {
                            //Try to open the file and let windows decide how to open it.
                            System.Diagnostics.Process.Start(exportFilePath);
                        }
                        catch
                        {
                            String msg = "The file could not be opened." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                            MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        String msg = "The file could not be saved." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                        MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
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
        // cho vô báo cáo
        app1:
            try
            {
                //luu
                //app.ActiveWorkbook.SaveCopyAs(Application.StartupPath + "\\BangDiem.xlsx");
                //app.ActiveWorkbook.Saved = true;
                //đổ dữ liệu vào sheet
                worksheet.Cells[1, 1] = "BẢNG TỔNG HỢP ĐIỂM CHI TIẾT SINH VIÊN";
                worksheet.Cells[3, 2] = "Mã SV : " + lbMaSV.Text;
                worksheet.Cells[4, 2] = "Tên SV : " + lbTenSV.Text;
                worksheet.Cells[3, 4] = "Ngày sinh : " + lbNgaySinh.Text;
                worksheet.Cells[4, 4] = "Giới tính : " + lbGioiTinh.Text;
                worksheet.Cells[3, 7] = "Nơi sinh : " + lbNoiSinh.Text;
                worksheet.Cells[4, 7] = "Dân tộc : " + lbDanToc.Text;
                worksheet.Cells[6, 1] = "STT";
                worksheet.Cells[6, 2] = "Mã môn HP";
                worksheet.Cells[6, 3] = "Tên môn HP";
                worksheet.Cells[6, 4] = "Số tín";
                worksheet.Cells[6, 5] = "Chuyên cần";
                worksheet.Cells[6, 6] = "Giữa kì";
                worksheet.Cells[6, 7] = "Cuối kỳ";
                worksheet.Cells[6, 8] = "Điểm HP";
                worksheet.Cells[6, 9] = "Điểm chữ";
                worksheet.Cells[6, 10] = "Điểm hệ 4";
                worksheet.Cells[6, 11] = "Kết quả";

                //vòng lặp i row - in từ hàng 0 tới số hàng hiện có
                for (int i = 0; i < gridView2.RowCount; i++)
                {
                    // vòng lặp j column in từ cột 0 tới cột hiện có
                    for (int j = 0; j < gridView2.Columns.Count; j++)
                    {
                        //worksheet.Cells[9, 1] = "STT" hàng 9 cột 1 
                        // bắt đầu đổ STT i 0 - vị trí row 0 + 10, cột 1 = 0 + 1 (số)  v.v...
                        worksheet.Cells[i + 7, 1] = i + 1;

                        // tương tự đổ dữ liệu từ gridview
                        worksheet.Cells[i + 7, j + 2] = gridView2.GetRowCellValue(i, gridView2.Columns[j]);
                    }
                }
                //ExportExcelGoc();

                int setViTri = gridView2.RowCount;
                worksheet.Cells[setViTri + 7, 1] = "Chú ý : _Những môn có dấu (*) sẽ không tính điểm trung bình mà chỉ là môn điều kiện";
                worksheet.Cells[setViTri + 9, 1] = "Trung bình toàn khóa : " + lblTB.Text;
                worksheet.Cells[setViTri + 10, 1] = "Xếp loại toàn khóa : " + lblXL.Text;
                worksheet.Cells[setViTri + 11, 1] = "Tổng số tín chỉ đạt : " + lblTinChiDat.Text;

                //định dạng trang

                worksheet.PageSetup.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlLandscape;
                worksheet.PageSetup.PaperSize = Microsoft.Office.Interop.Excel.XlPaperSize.xlPaperA4;
                worksheet.PageSetup.BottomMargin = 0;
                worksheet.PageSetup.LeftMargin = 0;
                worksheet.PageSetup.RightMargin = 0;
                worksheet.PageSetup.TopMargin = 0;
                worksheet.PageSetup.HeaderMargin = 0;
                worksheet.PageSetup.FooterMargin = 0;
                //định dạng cột

                worksheet.Range["A1"].ColumnWidth = 10;
                worksheet.Range["B1"].ColumnWidth = 13;
                worksheet.Range["C1"].ColumnWidth = 35;
                worksheet.Range["D1"].ColumnWidth = 10;
                worksheet.Range["E1"].ColumnWidth = 12;
                worksheet.Range["F1"].ColumnWidth = 10;
                worksheet.Range["G1"].ColumnWidth = 10;
                worksheet.Range["H1"].ColumnWidth = 14;
                worksheet.Range["I1"].ColumnWidth = 10;
                worksheet.Range["J1"].ColumnWidth = 10;
                worksheet.Range["K1"].ColumnWidth = 10;

                //định dạng font

                worksheet.Range["A1", "K100"].Font.Name = "Times News Roman";
                worksheet.Range["A1", "K100"].Font.Size = 12;
                worksheet.Range["A1", "K1"].MergeCells = true;
                worksheet.Range["A" + (setViTri + 7), "K" + (setViTri + 7)].MergeCells = true;
                worksheet.Range["A1", "K1"].Font.Bold = true;
                worksheet.Range["A6", "K6"].Font.Bold = true;
                worksheet.Range["A" + (setViTri + 9), "A" + (setViTri + 11)].Font.Bold = true;
                worksheet.Range["A" + (setViTri + 9), "A" + (setViTri + 11)].Font.Italic = true;
                worksheet.Range["A1", "K1"].Font.Size = 16;
                worksheet.Range["A1", "K1"].Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red);
                worksheet.Range["B3", "H4"].Font.Italic = true;
                //kẻ bảng 

                worksheet.Range["A6", "K" + (setViTri + 7)].Borders.LineStyle = 1;

                //định dạng all dòng text ra giữa

                worksheet.Range["A1", "K1"].HorizontalAlignment = 3;
                worksheet.Range["A6", "K" + (setViTri + 7)].HorizontalAlignment = 3;
                worksheet.Range["A" + (setViTri + 7), "K" + (setViTri + 7)].HorizontalAlignment = 3;
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Cứ từ từ Excel đang làm đẹp !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                goto app1;
            }
        }
    }
}