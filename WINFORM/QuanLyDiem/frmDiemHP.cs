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
    public partial class frmDiemHP : DevExpress.XtraEditors.XtraForm
    {
        public frmDiemHP()
        {
            InitializeComponent();
        }

        QuanLiDiemEntities db = new QuanLiDiemEntities();
        private void frmDiemHP_Load(object sender, EventArgs e)
        {
            lopBindingSource.DataSource = db.Lop.ToList();
            luHK.Properties.DataSource = db.HocKy.ToList();
            //hocKyBindingSource.DataSource = db.HocKy.ToList();
            luHK.Properties.ForceInitialize();

            //
            luHK1.Properties.DataSource = db.HocKy.ToList();

        }

        private void luHK_EditValueChanged(object sender, EventArgs e)
        {
            luHP.Properties.DataSource = db.MonHP_SelectByHK(luHK.EditValue.ToString());
            luHP.Properties.ValueMember = "MaMonHP";
            luHP.Properties.DisplayMember = "TenMonHP";
            luHP.Properties.ForceInitialize();
            //load mới
            monHPSelectByHKResultBindingSource.ResetBindings(false);

            txtMaHK.Text = luHK.GetColumnValue("MaHK").ToString();
            txtTenHK.Text = luHK.GetColumnValue("TenHK").ToString();
            //

            luLop.EditValue = "L00001";
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
            if (ThemHP == true)
            {
                db.MonHPInsert(txtTenMonHP.Text, Convert.ToByte(txtSoTin.Text), Convert.ToByte(txtTietLT.Text), Convert.ToByte(txtTietTH.Text), luHK.EditValue.ToString());
                XtraMessageBox.Show("Thêm dữ liệu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ThemHP = false;
            }
            else
            {
                db.MonHPUpdate(luHP.EditValue.ToString(), txtTenMonHP.Text, Convert.ToByte(txtSoTin.Text), Convert.ToByte(txtTietLT.Text), Convert.ToByte(txtTietTH.Text));
                XtraMessageBox.Show("Sửa dữ liệu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ThemHP = false;
            }
            luHK_EditValueChanged(sender, e);
            luHP_EditValueChanged(sender, e);
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

        private void btnCapNhatTungMonTheoLop_Click(object sender, EventArgs e)
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

        //
        private void luHK1_EditValueChanged(object sender, EventArgs e)
        {
            luHP.Properties.DataSource = db.MonHP_SelectByHK(luHK1.EditValue.ToString());
            luHP.Properties.ValueMember = "MaMonHP";
            luHP.Properties.DisplayMember = "TenMonHP";
            luHP.Properties.ForceInitialize();

            monHPSelectByHKResultBindingSource.ResetBindings(false);

            //bắt lớp default
            luLop1.EditValue = "L00001";
        }

        private void gridView1_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            if (gridView1.FocusedColumn.FieldName == "ChuyenCan")
            {
                float chuyenCan = 0;
                if (!float.TryParse(e.Value as String, out chuyenCan))
                {
                    e.Valid = false;
                    e.ErrorText = "Điểm không đúng định dạng !";
                }
                else if (chuyenCan > 10 || chuyenCan < 0)
                {
                    e.Valid = false;
                    e.ErrorText = "Điểm không hợp lệ !";
                }
                else if (!float.TryParse(e.Value as String, out chuyenCan))
                {
                    e.Valid = false;
                    e.ErrorText = "Điểm không đúng định dạng !";
                }
                else if (String.IsNullOrEmpty(chuyenCan.ToString()))
                {
                    e.Valid = false;
                    e.ErrorText = "Trống !";
                }
            }
        }


        //con trỏ thoát khỏi 1 dòng thì sẽ phát sinh sự kiện
        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView view = sender as GridView;

            //Kiểm tra đây là dòng dữ liệu mới hay cũ, nếu là dòng mới ko có gì thì thoi :)
            if (view.IsNewItemRow(e.RowHandle))
            {
                return;
            }
            //Cũ thì update
            else
            {
                try
                {
                    // bỏ chấp nhận làm frm mới cập nhật điểm lần 2 riêng
                    //if (gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns["ChuyenCan"]) == null||
                    //    gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns["GiuaKy"]) == null||
                    //    gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns["DiemLan1"]) == null)
                    //{
                    //    XtraMessageBox.Show("Lỗi !");
                    //    luHP_EditValueChanged(sender, e);
                    //    return;
                            
                    //}
                   db.DiemLan1Update(Convert.ToDouble(view.GetRowCellValue(e.RowHandle, view.Columns[3])),
                   Convert.ToDouble(view.GetRowCellValue(e.RowHandle, view.Columns[4])),
                   Convert.ToDouble(view.GetRowCellValue(e.RowHandle, view.Columns[5])),
                   view.GetRowCellValue(e.RowHandle, view.Columns[0]).ToString(),
                   luHP.EditValue.ToString());
                }
                catch (Exception err)
                {

                    XtraMessageBox.Show("Không được để trống !\n" + err, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void gridView1_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
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


        // cap nhat mon moi, duyet qua tung sinh vien chua co mon nay Them vao 
        private void btnCapNhatAll_Click(object sender, EventArgs e)
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
}