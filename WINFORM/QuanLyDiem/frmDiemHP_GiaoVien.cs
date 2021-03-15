using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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
    public partial class frmDiemHP_GiaoVien : DevExpress.XtraEditors.XtraForm
    {
        public frmDiemHP_GiaoVien()
        {
            InitializeComponent();
        }
        QuanLiDiemEntities db = new QuanLiDiemEntities();
        private void frmDiemHP_GiaoVien_Load(object sender, EventArgs e)
        {
            getTenGV();
            loadHK();
            lopBindingSource.DataSource = db.Lop.ToList();
        }

        public void getTenGV()
        {
            var kq = from a in db.TaiKhoan join b in db.GiaoVien
                     on a.UserName equals b.MaGV
                     where a.UserName == ClassTaiKhoan.TaiKhoan/*"GV0125"*/
                     && ClassTaiKhoan.TaiKhoan == b.MaGV
                     select a.FullName;

            lbTenGV.Text = kq.ToList().SingleOrDefault();
        }

        public void loadHK()
        {
            var kq = from hk in db.HocKy
                     join monhp in db.MonHP on hk.MaHK equals monhp.MaHK
                     join pc in db.GV_PhanCong on monhp.MaMonHP equals pc.MaMonHP
                     where pc.MaGV == ClassTaiKhoan.TaiKhoan
                     select new 
                     {
                         hk.MaHK,
                         hk.TenHK
                     };
            if (kq.Any())
            {
                luChonHK.Properties.DataSource = kq.Distinct().ToList();
                luChonHK.Properties.DisplayMember = "TenHK";
                luChonHK.Properties.ValueMember = "MaHK";
                luChonHK.Properties.ForceInitialize();
            }

        }

        private void luChonHK_EditValueChanged(object sender, EventArgs e)
        {
            //if (db.MonHP_SelectByHK(luChonHK.EditValue.ToString()).Count() > 0 )
            //{
            //    luHocPhan.Properties.DataSource = db.MonHP_SelectByHK(luChonHK.EditValue.ToString());
            //    luHocPhan.Properties.ValueMember = "MaMonHP";
            //    luHocPhan.Properties.DisplayMember = "TenMonHP";
            //    luHocPhan.Properties.ForceInitialize();

            //    luLop.EditValue = "L00001";

            //}

            var MonHP_SelectByHK = from monhp in db.MonHP
                             join pc in db.GV_PhanCong on monhp.MaMonHP equals pc.MaMonHP
                             where monhp.MaHK == luChonHK.EditValue.ToString() && pc.MaGV == ClassTaiKhoan.TaiKhoan/*"GV0125"*/
                             select new
                             {
                                 monhp.MaMonHP,
                                 monhp.TenMonHP,
                                 monhp.SoTin
                             };

            if (MonHP_SelectByHK.Any())
            {
                luHocPhan.Properties.DataSource = MonHP_SelectByHK.ToList();
                luHocPhan.Properties.ValueMember = "MaMonHP";
                luHocPhan.Properties.DisplayMember = "TenMonHP";
                luHocPhan.Properties.ForceInitialize();
            }

            luLop.EditValue = db.Lop.Select(a => a.MaLop).First().ToString();
            //luHocPhan.EditValue = MonHP_SelectByHK.Select(a => a.TenMonHP).First().ToString();
        }

        private void luHocPhan_EditValueChanged(object sender, EventArgs e)
        {
            
            object row = luHocPhan.Properties.GetDataSourceRowByKeyValue(luHocPhan.EditValue);

            if (row != null)
            {
                txtSoTin.Text = luHocPhan.GetColumnValue("SoTin").ToString();
                txtTenHP.Text = luHocPhan.GetColumnValue("TenMonHP").ToString();
                txtMaMonHP.Text = luHocPhan.GetColumnValue("MaMonHP").ToString();
                dateNhap.EditValue = DateTime.Now;
            }
            
            //
            

            var kq = (from pc in db.GV_PhanCong
                      join hp in db.DiemHP on pc.MaMonHP equals hp.MaMonHP
                      join sv in db.SinhVien on hp.MaSV equals sv.MaSV
                      where pc.MaLop == luLop.EditValue.ToString() && pc.MaMonHP == luHocPhan.EditValue.ToString()
                      select new GV_NhapDiem
                      {
                          MaSV = sv.MaSV,
                          HoTenSV = sv.HoLot + " " + sv.Ten,
                          NgaySinh = sv.NgaySinh,
                          ChuyenCan = hp.ChuyenCan,
                          GiuaKi = hp.GiuaKi,
                          DiemLan1 = hp.DiemLan1,
                          DiemLan2 = hp.DiemLan2
                      }).ToList();

            gcNhapDiem.DataSource = kq;
            //gcNhapDiem.DataSource = db.BangDiemHP(luLop.EditValue.ToString(), luHocPhan.EditValue.ToString());
        }

        private void luLop_EditValueChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtMaMonHP.Text))
            {
                luHocPhan_EditValueChanged(sender, e);
            }
        }

        private void gridView1_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            if (gridView1.FocusedColumn.FieldName == "ChuyenCan")
            {
                float chuyenCan = 0;
                
                if (chuyenCan >= 100)
                {
                    e.Valid = false;
                    e.ErrorText = "Điểm không hợp lệ !";
                }

            }
            if (gridView1.FocusedColumn.FieldName == "GiuaKi")
            {
                float giuaKy = 0;

                if (giuaKy >= 100)
                {
                    e.Valid = false;
                    e.ErrorText = "Điểm không hợp lệ !";
                }

            }
            if (gridView1.FocusedColumn.FieldName == "DiemLan1")
            {
                float diemLan1 = 0;

                if (diemLan1 >= 100)
                {
                    e.Valid = false;
                    e.ErrorText = "Điểm không hợp lệ !";
                }

            }
            if (gridView1.FocusedColumn.FieldName == "DiemLan2")
            {
                float diemLan2 = 0;

                if (diemLan2 >= 100)
                {
                    e.Valid = false;
                    e.ErrorText = "Điểm không hợp lệ !";
                }

            }
        }


        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView view = sender as GridView;

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
                    db.DiemHPUpdate(chuyenCan, giuaKi, diemLan1, diemLan2, view.GetRowCellValue(e.RowHandle, "MaSV").ToString(), luHocPhan.EditValue.ToString());
                }
                if (giuaKi > 10 && giuaKi < 100)
                {
                    giuaKi /= 10;
                    db.DiemHPUpdate(chuyenCan, giuaKi, diemLan1, diemLan2, view.GetRowCellValue(e.RowHandle, "MaSV").ToString(), luHocPhan.EditValue.ToString());
                }
                if (chuyenCan > 10 && chuyenCan < 100)
                {
                    chuyenCan /= 10;
                    db.DiemHPUpdate(chuyenCan, giuaKi, diemLan1, diemLan2, view.GetRowCellValue(e.RowHandle, "MaSV").ToString(), luHocPhan.EditValue.ToString());
                }
                else
                {
                    db.DiemHPUpdate(chuyenCan, giuaKi, diemLan1, diemLan2, view.GetRowCellValue(e.RowHandle, "MaSV").ToString(), luHocPhan.EditValue.ToString());
                }
            }

            catch (Exception err)
            {
                XtraMessageBox.Show("Có lỗi xảy ra !\n" + err, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            luHocPhan_EditValueChanged(sender, e);
        }

        private void gridView1_InvalidRowException_1(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;

        }
    }
    public class GV_NhapDiem
    {
        public String MaSV { get; set; }
        public String HoTenSV { get; set; }
        public DateTime? NgaySinh { get; set; }
        public Double? ChuyenCan { get; set; }
        public Double? GiuaKi { get; set; }
        public Double? DiemLan1 { get; set; }
        public Double? DiemLan2 { get; set; }
    }
}