using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiem
{
    public partial class frmDiemHP_GiaoVu : DevExpress.XtraEditors.XtraForm
    {
        public frmDiemHP_GiaoVu()
        {
            InitializeComponent();
        }

        QuanLiDiemEntities db = new QuanLiDiemEntities();

        private void frmDiemHP_Load(object sender, EventArgs e)
        {
            lopBindingSource.DataSource = db.Lop.ToList();
            luHK.Properties.DataSource = db.HocKy.ToList();
            luHK.Properties.ForceInitialize();
            //
            luHK1.Properties.DataSource = db.HocKy.ToList();

            btnLuuHK.Enabled = false;
            btnLuuHP.Enabled = false;
        }

        public void showAll(Boolean show)
        {

        }

        private void luHK_EditValueChanged(object sender, EventArgs e)
        {
            if (db.MonHP_SelectByHK(luHK.EditValue.ToString()).Count() > 0)
            {
                luHP.Properties.DataSource = db.MonHP_SelectByHK(luHK.EditValue.ToString());
                luHP.Properties.ValueMember = "MaMonHP";
                luHP.Properties.DisplayMember = "TenMonHP";
                luHP.Properties.ForceInitialize();
            }
            
            //load mới
            monHPSelectByHKResultBindingSource.ResetBindings(false);
            txtMaHK.Text = luHK.GetColumnValue("MaHK").ToString();
            txtTenHK.Text = luHK.GetColumnValue("TenHK").ToString();
            //

            //luLop.EditValue = db.Lop.Select(a => a.MaLop).First().ToString();

        }
        private void luHP_EditValueChanged(object sender, EventArgs e)
        {
            txtMaMonHP.Text = luHP.GetColumnValue("MaMonHP").ToString();
            txtTenMonHP.Text = luHP.GetColumnValue("TenMonHP").ToString();
            txtSoTin.Text = luHP.GetColumnValue("SoTin").ToString();
            txtTietLT.Text = luHP.GetColumnValue("TietLT").ToString();
            txtTietTH.Text = luHP.GetColumnValue("TietTH").ToString();

            //
            gcDiem.DataSource = db.BangDiemHP(luLop1.EditValue.ToString(), luHP.EditValue.ToString());

        }


        bool ThemHK = false, ThemHP = false;
        private void btnThemHK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            hocKyBindingSource.AddNew();
            txtTenHK.Focus();
            ThemHK = true;
        }

        private void btnLuuHK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtTenHK.Text = frmLopSinhVien.maHoa(txtTenHK.Text);

            if (ThemHK == true)
            {
                db.HocKyInsert(txtTenHK.Text);
                XtraMessageBox.Show("Thêm dữ liệu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ThemHK = false;
            }
            else
            {
                db.HocKyUpdate(txtMaHK.Text, txtTenHK.Text);
                XtraMessageBox.Show("Sửa dữ liệu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            frmDiemHP_Load(sender, e);
        }

        private void btnXoaHK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult x = XtraMessageBox.Show("Bạn có chắc muốn xóa : " + txtTenHK.Text + "?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (x == DialogResult.Yes)
            {
                db.HocKyDelete(txtMaHK.Text);
                XtraMessageBox.Show("Xóa dữ liệu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            frmDiemHP_Load(sender, e);
        }

        private void btnHuyHK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDiemHP_Load(sender, e);
            txtTenHK.Focus();
            ThemHK = false;
        }

        private void btnLuuHP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtTenMonHP.Text = frmLopSinhVien.maHoa(txtTenMonHP.Text);

            if (ThemHP == true)
            {
                try
                {
                    db.MonHPInsert(txtTenMonHP.Text, Convert.ToByte(txtSoTin.Text), Convert.ToByte(txtTietLT.Text), Convert.ToByte(txtTietTH.Text), luHK.EditValue.ToString());
                    XtraMessageBox.Show("Thêm dữ liệu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception)
                {

                    XtraMessageBox.Show("Thêm dữ liệu thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            else
            {
                try
                {
                    db.MonHPUpdate(luHP.EditValue.ToString(), txtTenMonHP.Text, Convert.ToByte(txtSoTin.Text), Convert.ToByte(txtTietLT.Text), Convert.ToByte(txtTietTH.Text));
                    XtraMessageBox.Show("Sửa dữ liệu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ThemHP = false;
                }
                catch (Exception)
                {

                    XtraMessageBox.Show("Sửa dữ liệu thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            ThemHP = false;

            frmDiemHP_Load(sender, e);
        }

        private void btnXoaHP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult x = XtraMessageBox.Show("Bạn có chắc muốn xóa : " + txtTenMonHP.Text + "?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (x == DialogResult.Yes)
            {
                db.MonHPDelete(txtMaMonHP.Text);
                XtraMessageBox.Show("Xóa dữ liệu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            luHK_EditValueChanged(sender, e);
        }

        private void btnHuyHP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtSoTin.Text = null;
            txtTietLT.Text = null;
            txtTietTH.Text = null;
            txtTenMonHP.Text = null;
            txtMaMonHP.Text = null;

            txtTenMonHP.Focus();
            ThemHP = false;
        }

        private void btnThemHP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            monHPSelectByHKResultBindingSource.AddNew();
            txtTenMonHP.Focus();
            ThemHP = true;
        }

        private void btnCapNhatTheoLop_Click(object sender, EventArgs e)
        {
            if (luLop.EditValue != null)
            {
                if (XtraMessageBox.Show("Các môn mới / chưa đăng ký sẽ thêm vào lớp " + luLop.Properties.GetDisplayText(luLop.EditValue) + ". Đồng ý ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    foreach (var mon in db.MonHPSelectAll().ToList())
                    {
                        foreach (var sv in db.SinhVienSelectAllByLop(luLop.EditValue.ToString()).ToList())
                        {
                            if (db.DiemHPSearch(mon.MaMonHP, sv.MaSV).Count() == 0)
                            {
                                db.DiemHPInsert_1(mon.MaMonHP, sv.MaSV);
                            }
                        }
                    }
                    XtraMessageBox.Show("Cập nhật thành công dữ liệu cho điểm học phần !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                XtraMessageBox.Show("vui lòng chọn lớp !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                luLop.ShowPopup();
            }

        }

        private void btnCapNhatTungMonTheoLop_Click(object sender, EventArgs e)
        {
            if (luHK1.EditValue != null)
            {
                if (luHP.EditValue == null)
                {
                    XtraMessageBox.Show("Vui lòng chọn Học Phần !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    luHP.ShowPopup();
                    return;
                }

                if (XtraMessageBox.Show("Môn " + luHP.Properties.GetDisplayText(luHP.EditValue) + " sẽ thêm vào lớp " + luLop1.Properties.GetDisplayText(luLop1.EditValue) + ". Đồng ý ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    foreach (var mon in db.MonHPOnlySelect(luHP.EditValue.ToString()).ToList())
                    {
                        foreach (var sv in db.SinhVienSelectAllByLop(luLop1.EditValue.ToString()).ToList())
                        {
                            if (db.DiemHPSearch(mon.MaMonHP, sv.MaSV).Count() == 0)
                            {
                                db.DiemHPInsert_1(mon.MaMonHP, sv.MaSV);
                            }
                        }
                    }
                    XtraMessageBox.Show("Cập nhật thành công dữ liệu cho điểm học phần !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                XtraMessageBox.Show("Vui lòng chọn Học Kỳ !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                luHK1.ShowPopup();
            }

        }

        // cap nhat mon moi, duyet qua tung sinh vien chua co mon nay Them vao 
        private void btnCapNhatAll_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Tất cả các môn mới sẽ thêm vào tất cả các lớp. Đồng ý ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                foreach (var mon in db.MonHPSelectAll().ToList())
                {
                    foreach (var sv in db.SinhVienSelectAll().ToList())
                    {
                        if (db.DiemHPSearch(mon.MaMonHP, sv.MaSV).Count() == 0)
                        {
                            db.DiemHPInsert_1(mon.MaMonHP, sv.MaSV);
                        }
                    }
                }
                XtraMessageBox.Show("Cập nhật thành công dữ liệu cho điểm học phần !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        //
        private void luHK1_EditValueChanged(object sender, EventArgs e)
        {
            if (db.MonHP_SelectByHK(luHK1.EditValue.ToString()).Count() > 0)
            {
                luHP.Properties.DataSource = db.MonHP_SelectByHK(luHK1.EditValue.ToString());
                luHP.Properties.ValueMember = "MaMonHP";
                luHP.Properties.DisplayMember = "TenMonHP";
                luHP.Properties.ForceInitialize();
            }

            monHPSelectByHKResultBindingSource.ResetBindings(false);

            //bắt lớp default
            luLop1.EditValue = db.Lop.Select(a => a.MaLop).First().ToString();
        }

        private void gridView1_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            if (gridView1.FocusedColumn.FieldName == "ChuyenCan")
            {
                float chuyenCan = 0;
                
                if (chuyenCan < 0 || chuyenCan > 100)
                {
                    e.Valid = false;
                    e.ErrorText = "Điểm không hợp lệ !";
                }
                
            }
            if (gridView1.FocusedColumn.FieldName == "GiuaKi")
            {
                float giuaKy = 0;

                if (giuaKy <0 || giuaKy > 100)
                {
                    e.Valid = false;
                    e.ErrorText = "Điểm không hợp lệ !";
                }
                
            }
            if (gridView1.FocusedColumn.FieldName == "DiemLan1")
            {
                float diemLan1 = 0;

                if (diemLan1 < 0 || diemLan1 > 100)
                {
                    e.Valid = false;
                    e.ErrorText = "Điểm không hợp lệ !";
                }
                
            }
            if (gridView1.FocusedColumn.FieldName == "DiemLan2")
            {
                float diemLan2 = 0;

                if (diemLan2 < 0 || diemLan2 > 100)
                {
                    e.Valid = false;
                    e.ErrorText = "Điểm không hợp lệ !";
                }

            }
        }


        //con trỏ thoát khỏi 1 dòng thì sẽ phát sinh sự kiện
        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView view = sender as GridView;
            //kiểm tra nếu dòng null thì default trống
            double? check = null;
            try
            {
                double? chuyenCan = view.GetRowCellValue(e.RowHandle, "ChuyenCan") == null ? check : Convert.ToDouble(view.GetRowCellValue(e.RowHandle, "ChuyenCan"));
                double? giuaKi = view.GetRowCellValue(e.RowHandle, "GiuaKi") == null ? check : Convert.ToDouble(view.GetRowCellValue(e.RowHandle, "GiuaKi"));
                double? diemLan1 = view.GetRowCellValue(e.RowHandle, "DiemLan1") == null ? check : Convert.ToDouble(view.GetRowCellValue(e.RowHandle, "DiemLan1"));
                double? diemLan2 = view.GetRowCellValue(e.RowHandle, "DiemLan2") == null ? check : Convert.ToDouble(view.GetRowCellValue(e.RowHandle, "DiemLan2"));

                if (diemLan1 > 10 && diemLan1 < 100)
                {
                    diemLan1 /= 10;
                    db.DiemHPUpdate(chuyenCan, giuaKi, diemLan1, diemLan2, view.GetRowCellValue(e.RowHandle, "MaSV").ToString(), luHP.EditValue.ToString());
                }
                if (giuaKi > 10 && giuaKi < 100)
                {
                    giuaKi /= 10;
                    db.DiemHPUpdate(chuyenCan, giuaKi, diemLan1, diemLan2, view.GetRowCellValue(e.RowHandle, "MaSV").ToString(), luHP.EditValue.ToString());
                }
                if (chuyenCan > 10 && chuyenCan < 100)
                {
                    chuyenCan /= 10;
                    db.DiemHPUpdate(chuyenCan, giuaKi, diemLan1, diemLan2, view.GetRowCellValue(e.RowHandle, "MaSV").ToString(), luHP.EditValue.ToString());
                }
                else
                {
                    db.DiemHPUpdate(chuyenCan, giuaKi, diemLan1, diemLan2, view.GetRowCellValue(e.RowHandle, "MaSV").ToString(), luHP.EditValue.ToString());
                }
            }

            catch (Exception err)
            {
                XtraMessageBox.Show("Có lỗi xảy ra !\n" + err, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            luHP_EditValueChanged(sender, e);
        }

        private void gridView1_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }

        //load lớp khác
        private void luLop1_EditValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaMonHP.Text))
            {
                luHP_EditValueChanged(sender, e);
            }
            
        }

        private void txtTenHK_TextChanged(object sender, EventArgs e)
        {
            this.btnHuyHK.Enabled = !String.IsNullOrWhiteSpace(this.txtTenHK.Text);
            this.btnLuuHK.Enabled = !String.IsNullOrWhiteSpace(this.txtTenHK.Text);
            this.btnXoaHK.Enabled = !String.IsNullOrWhiteSpace(this.txtTenHK.Text);
        }

        private void txtTenMonHP_TextChanged(object sender, EventArgs e)
        {
            this.btnLuuHP.Enabled = !String.IsNullOrWhiteSpace(this.txtTenMonHP.Text);
            this.btnHuyHP.Enabled = !String.IsNullOrWhiteSpace(this.txtTenMonHP.Text);
            this.btnXoaHP.Enabled = !String.IsNullOrWhiteSpace(this.txtTenMonHP.Text);
        }

        private void gcDiem_DoubleClick(object sender, EventArgs e)
        {
            XtraMessageBox.Show("Giáo vụ chú ý : điểm sẽ cập nhật tự động cập nhật trên mỗi dòng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }


        //private void gcDiem_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        //{
        //    if (e.Button.ButtonType == DevExpress.XtraEditors.NavigatorButtonType.Remove)
        //    {
        //        if (XtraMessageBox.Show("Bạn có chắc muốn xóa dòng này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
        //        {
        //            gridView1.DeleteRow(gridView1.FocusedRowHandle);
        //            XtraMessageBox.Show("Đã xóa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //        e.Handled = true;
        //    }
        //}

    }
}