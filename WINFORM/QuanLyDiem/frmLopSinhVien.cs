﻿using DevExpress.XtraEditors;
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
    public partial class frmLopSinhVien : DevExpress.XtraEditors.XtraForm
    {
        public frmLopSinhVien()
        {
            InitializeComponent();
        }

        QuanLiDiemEntities db = new QuanLiDiemEntities();
        private void frmLopSinhVien_Load(object sender, EventArgs e)
        {
            db = new QuanLiDiemEntities();
            db.SinhVien.Load();
            sinhVienBindingSource.DataSource = db.SinhVien.Local;
            lopBindingSource.DataSource = db.Lop.ToList();
            // truy vấn với entity
            //var result = from c in db.SinhVien
            //             where c.ID <= 1
            //             select c;
            //gvSinhVien.DataSource = result.ToList();
        }

        bool ThemSV = false;
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            sinhVienBindingSource.AddNew();
            txtHo.Focus();
            ThemSV = true;
        }
        public void txtMaHoa()
        {
            txtHo.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(txtHo.Text.ToLower().Trim()).Replace("     ", " ").Replace("    ", " ").Replace("   ", " ").Replace("  ", " ");
            txtTen.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(txtTen.Text.ToLower().Trim()).Replace("     ", " ").Replace("    ", " ").Replace("   ", " ").Replace("  ", " ");
            txtNoiSinh.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(txtNoiSinh.Text.ToLower().Replace("     ", " ").Trim()).Replace("    ", " ").Replace("   ", " ").Replace("  ", " ");
        }
        public void updateSV()
        {

            db.SinhVienUpdate(txtMaSV.Text, txtHo.Text, txtTen.Text, Convert.ToDateTime(dateNgaySinh.Text), txtGioiTinh.Text, txtNoiSinh.Text, txtDanToc.Text);
            XtraMessageBox.Show("Sửa dữ liệu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ThemSV == true)
            {
                txtMaHoa();
                db.SinhVienInsert(txtHo.Text, txtTen.Text, Convert.ToDateTime(dateNgaySinh.Text), txtGioiTinh.Text, txtNoiSinh.Text, txtDanToc.Text, luLop.EditValue.ToString(), txtMTT.Text);
                XtraMessageBox.Show("Thêm dữ liệu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ThemSV = false;
            }
            else
            {
                txtMaHoa();
                updateSV();
                ThemSV = false;
            }

            frmLopSinhVien_Load(sender, e);
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmLopSinhVien_Load(sender, e);
            txtHo.Focus();
            ThemSV = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult x = XtraMessageBox.Show("Bạn có chắc muốn xóa Sinh viên : " + txtHo.Text + " " + txtTen.Text + "?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (x == DialogResult.Yes)
            {
                db.SinhVienDelete(txtMaSV.Text);
                XtraMessageBox.Show("Xóa dữ liệu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            frmLopSinhVien_Load(sender, e);
        }

        //reset binding update form phát sinh
        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            sinhVienBindingSource.ResetBindings(true);
            txtMaHoa();
            updateSV();
            frmLopSinhVien_Load(sender, e);
        }
    }
}