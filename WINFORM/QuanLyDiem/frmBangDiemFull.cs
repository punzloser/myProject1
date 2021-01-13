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
    }
}