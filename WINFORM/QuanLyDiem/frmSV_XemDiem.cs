using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiem
{
    public partial class frmSV_XemDiem : DevExpress.XtraEditors.XtraForm
    {
        public frmSV_XemDiem()
        {
            InitializeComponent();
            loadHK();
        }
        QuanLiDiemEntities db = new QuanLiDiemEntities();
        XuLyDiem xl = new XuLyDiem();

        #region not used
        private Image GetImageFromResource(string fileName)
        {
            var value = Properties.Resources.ResourceManager.GetObject(fileName, Properties.Resources.Culture);
            return value as Image;
        }

        private byte[] GetImageData(string fileName)
        {
            Image img = GetImageFromResource(fileName);
            using (var mem = new MemoryStream())
            {
                img.Save(mem, System.Drawing.Imaging.ImageFormat.Bmp);
                return mem.GetBuffer();
            }
        }
        #endregion

        private DataTable createTable()
        {
            DataTable table = new DataTable();
            DataColumnCollection col = table.Columns;
            if (!col.Contains("MaMonHP"))
                table.Columns.Add("MaMonHP", typeof(String));
            if (!col.Contains("TenMonHP"))
                table.Columns.Add("TenMonHP", typeof(String));
            if (!col.Contains("SoTin"))
                table.Columns.Add("SoTin", typeof(String));
            if (!col.Contains("ChuyenCan"))
                table.Columns.Add("ChuyenCan", typeof(double));
            if (!col.Contains("GiuaKi"))
                table.Columns.Add("GiuaKi", typeof(double));
            if (!col.Contains("CuoiKy"))
                table.Columns.Add("CuoiKy", typeof(double));
            if (!col.Contains("DiemHP"))
                table.Columns.Add("DiemHP", typeof(double));
            if (!col.Contains("DiemChu"))
                table.Columns.Add("DiemChu", typeof(String));
            if (!col.Contains("DiemHe4"))
                table.Columns.Add("DiemHe4", typeof(String));
            if (!col.Contains("KetQua"))
                table.Columns.Add("KetQua", typeof(String));
            if (!col.Contains("Check"))
                table.Columns.Add("Check", typeof(int));

            double TongDiem = 0;
            int TongSoTin = 0, TongTinDat = 0;

            var MaSV = from a in db.TaiKhoan
                       join b in db.SinhVien
                       on a.UserName equals b.MaSV
                       where a.UserName == ClassTaiKhoan.TaiKhoan /*"190001"*/
                       select b.MaSV;

            foreach (var m in db.MonHPSelectBySV(MaSV.FirstOrDefault()))
            {
                DataRow row = table.NewRow();
                row["MaMonHP"] = m.MaMonHP;
                row["TenMonHP"] = m.TenMonHP;
                row["SoTin"] = m.SoTin;

                foreach (var n in db.DiemHPSearch(m.MaMonHP, MaSV.FirstOrDefault()))
                {
                    //biến check tổng null !DBNULL.VALUE
                    double? x = null;
                    string cc = n.ChuyenCan.ToString();
                    string gk = n.GiuaKi.ToString();
                    string d1 = n.DiemLan1.ToString();
                    string d2 = n.DiemLan2.ToString();

                    if (n.DiemLan2 == x)
                    {
                        //error the same with frmDiemHP
                        //row["ChuyenCan"] = n.ChuyenCan.ToString() == "" ? (double?)0.0f : double.Parse(n.ChuyenCan.ToString());

                        // gridview chỉ cho phép hiển thị Format Rule khi dữ liệu là số thực hoặc nguyên
                        // giá trị số thực null từ database đồng bộ sang gridview phải là DBNULL
                        // gridview set null sẽ tự nhận là chuỗi => xuất hiện số 0 thay vì NULL

                        //error language version đang xài cũ
                        //row["ChuyenCan"] = string.IsNullOrEmpty(cc) ? DBNull.Value : double.Parse(n.ChuyenCan.ToString());
                       
                        if (string.IsNullOrEmpty(cc))
                        {
                            row["ChuyenCan"] = DBNull.Value;
                        }
                        else
                        {
                            row["ChuyenCan"] = double.Parse(n.ChuyenCan.ToString());
                        }

                        if (string.IsNullOrEmpty(gk))
                        {
                            row["GiuaKi"] = DBNull.Value;
                        }
                        else
                        {
                            row["GiuaKi"] = double.Parse(n.ChuyenCan.ToString());
                        }

                        if (string.IsNullOrEmpty(d1))
                        {
                            row["Cuoiky"] = DBNull.Value;
                        }
                        else
                        {
                            row["Cuoiky"] = double.Parse(n.DiemLan1.ToString());
                        }
                        
                        //vi các cột điểm chưa có nên ko cho tính, check = 4 get icon trong gridview
                        if (n.ChuyenCan == x || n.GiuaKi == x || n.DiemLan1 == x)
                        {
                            row["DiemHP"] = DBNull.Value;
                            row["DiemChu"] = DBNull.Value;
                            row["DiemHe4"] = DBNull.Value;
                            row["KetQua"] = DBNull.Value;
                            row["Check"] = 4;
                        }
                        else
                        {
                            row["DiemHP"] = xl.DiemHP(Convert.ToDouble(n.ChuyenCan), Convert.ToDouble(n.GiuaKi), Convert.ToDouble(n.DiemLan1));
                            row["DiemChu"] = xl.DiemChu(xl.DiemHP(Convert.ToDouble(n.ChuyenCan), Convert.ToDouble(n.GiuaKi), Convert.ToDouble(n.DiemLan1)));
                            row["DiemHe4"] = xl.DiemHe4(xl.DiemHP(Convert.ToDouble(n.ChuyenCan), Convert.ToDouble(n.GiuaKi), Convert.ToDouble(n.DiemLan1)));
                            
                            var kq = xl.KetQua(Convert.ToDouble(n.DiemLan2), xl.DiemHP(Convert.ToDouble(n.ChuyenCan), Convert.ToDouble(n.GiuaKi), Convert.ToDouble(n.DiemLan1)));
                            row["KetQua"] = kq;
                            
                            if (kq.CompareTo("Đậu") == 0)
                            {
                                row["Check"] = 1;
                            }
                            if ((kq.CompareTo("Rớt") == 0))
                            {
                                row["Check"] = 2;
                            }
                            if ((kq.CompareTo("Thi lại") == 0))
                            {
                                row["Check"] = 3;
                            }

                            TongDiem += xl.DiemHP(Convert.ToDouble(n.ChuyenCan), Convert.ToDouble(n.GiuaKi), Convert.ToDouble(n.DiemLan1)) * Convert.ToByte(m.SoTin);
                            TongTinDat += xl.checkTinChiDat(xl.DiemHP(Convert.ToDouble(n.ChuyenCan), Convert.ToDouble(n.GiuaKi), Convert.ToDouble(n.DiemLan1)), Convert.ToByte(m.SoTin));
                            TongSoTin += Convert.ToByte(m.SoTin); //bỏ lên đầu foreach (var m in db.MonHPSelectBySV(e.Node.Name)) sẽ lỗi tính điểm
                        }

                    }
                    else
                    {
                        //TH điểm lần 2 có mà các cột điểm còn lại chưa có, điểm lần 2 nhập trước lần 1, 
                        //hoặc thi lần 1 đậu rồi thì lần 2 ko nhập => tất cả RB trong CSDL

                        if (string.IsNullOrEmpty(cc))
                        {
                            row["ChuyenCan"] = DBNull.Value;
                        }
                        else
                        {
                            row["ChuyenCan"] = double.Parse(n.ChuyenCan.ToString());
                        }

                        if (string.IsNullOrEmpty(gk))
                        {
                            row["GiuaKi"] = DBNull.Value;
                        }
                        else
                        {
                            row["GiuaKi"] = double.Parse(n.ChuyenCan.ToString());
                        }

                        if (string.IsNullOrEmpty(d1))
                        {
                            row["Cuoiky"] = DBNull.Value;
                        }
                        else
                        {
                            row["Cuoiky"] = double.Parse(n.DiemLan2.ToString());
                        }

                        if (n.ChuyenCan == x || n.GiuaKi == x || n.DiemLan2 == x)
                        {
                            row["DiemHP"] = DBNull.Value;
                            row["DiemChu"] = DBNull.Value;
                            row["DiemHe4"] = DBNull.Value;
                            row["KetQua"] = DBNull.Value;
                            row["Check"] = 4;
                        }
                        else
                        {
                            row["DiemHP"] = xl.DiemHP(Convert.ToDouble(n.ChuyenCan), Convert.ToDouble(n.GiuaKi), Convert.ToDouble(n.DiemLan2));
                            row["DiemChu"] = xl.DiemChu(xl.DiemHP(Convert.ToDouble(n.ChuyenCan), Convert.ToDouble(n.GiuaKi), Convert.ToDouble(n.DiemLan2)));
                            row["DiemHe4"] = xl.DiemHe4(xl.DiemHP(Convert.ToDouble(n.ChuyenCan), Convert.ToDouble(n.GiuaKi), Convert.ToDouble(n.DiemLan2)));

                            var kq = xl.KetQua(Convert.ToDouble(n.DiemLan2), xl.DiemHP(Convert.ToDouble(n.ChuyenCan), Convert.ToDouble(n.GiuaKi), Convert.ToDouble(n.DiemLan2)));
                            row["KetQua"] = kq;

                            if (kq.CompareTo("Đậu") == 0)
                            {
                                row["Check"] = 1;
                            }
                            if ((kq.CompareTo("Rớt") == 0))
                            {
                                row["Check"] = 2;
                            }
                            if ((kq.CompareTo("Thi lại") == 0))
                            {
                                row["Check"] = 3;
                            }

                            TongDiem += xl.DiemHP(Convert.ToDouble(n.ChuyenCan), Convert.ToDouble(n.GiuaKi), Convert.ToDouble(n.DiemLan2)) * Convert.ToByte(m.SoTin) * Convert.ToByte(m.SoTin);
                            TongTinDat += xl.checkTinChiDat(xl.DiemHP(Convert.ToDouble(n.ChuyenCan), Convert.ToDouble(n.GiuaKi), Convert.ToDouble(n.DiemLan2)), Convert.ToByte(m.SoTin));
                            TongSoTin += Convert.ToByte(m.SoTin);
                        }
                    }
                }

                table.Rows.Add(row);
            }

            return table;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            gcXemDiem.DataSource = createTable();

            var tenSV = from a in db.TaiKhoan
                        join b in db.SinhVien
                        on a.UserName equals b.MaSV
                        where a.UserName == ClassTaiKhoan.TaiKhoan/*"190001"*/
                        select b.HoLot + " " + b.Ten;

            lbTenSV.Text = tenSV.FirstOrDefault();

            lbTenSV.Focus();
        }

        public void loadHK()
        {
            var kq = from a in db.HocKy select a.TenHK;
            if (kq.Any())
            {
                luHK.Properties.DataSource = kq.ToList();
            }
        }
        private void luHK_EditValueChanged(object sender, EventArgs e)
        {
            DataTable data = createTable();
            var result = from a in data.AsEnumerable()
                         join b in db.MonHP on a.Field<String>("MaMonHP") equals b.MaMonHP
                         where b.HocKy.TenHK == luHK.EditValue.ToString()
                         select new
                         {
                             MaMonHP = a.Field<String>("MaMonHP"),
                             TenMonHP = a.Field<String>("TenMonHP"),
                             SoTin = a.Field<String>("SoTin"),
                             ChuyenCan = a.Field<double?>("ChuyenCan"),
                             GiuaKi = a.Field<double?>("GiuaKi"),
                             CuoiKy = a.Field<double?>("CuoiKy"),
                             DiemHP = a.Field<double?>("DiemHP"),
                             DiemChu = a.Field<String>("DiemChu"),
                             DiemHe4 = a.Field<String>("DiemHe4"),
                             KetQua = a.Field<String>("KetQua"),
                             Check = a.Field<int>("Check")
                         };

            gcXemDiem.DataSource = result.ToList();

        }
    }
}