using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiem
{
    class XuLyDiem
    {
        public int checkTinChiDat(Double DiemHP, byte SoTin)
        {
            int sum = 0;
            if (DiemHP >= 5)
            {
                sum += SoTin;
            }
            return sum;
        }
        public Double DiemHP(Double ChuyenCan, Double GiuaKy, Double CuoiKy)
        {
            Double a = (ChuyenCan + GiuaKy * 3 + CuoiKy * 6) / 10;
            return a;
        }

        public String KetQua(Double Diem2, Double DiemHP)
        {
            string b = null;
            if (DiemHP >= 5)
            {
                b = "Đậu";
            }
            if (DiemHP < 5 && Diem2 == 0 ) //.toString() == null err
            {
                b = "Thi lại";
            }
            if (DiemHP < 5 && Diem2 != 0)
            {
                b = "Rớt";
            }
            return b;
        }
        public Double DiemHe4 (Double Diem)
        {
            int d;
            if (Diem >= 8.5) 
            {
                d = 4;
            }
            else if (Diem >= 7)
            {
                d = 3;
            }
            else if (Diem >= 5.5)
            {
                d = 2;
            }
            else if (Diem >= 4)
            {
                d = 1;
            }
            else
            {
                d = 0;
            }
            return d;
        }

        public String DiemChu(Double Diem)
        {
            string d;
            if (Diem >= 8.5)
            {
                d = "A";
            }
            else if (Diem >= 7.5)
            {
                d = "B";
            }
            else if (Diem >= 5.5)
            {
                d = "C";
            }
            else
            {
                d = "F";
            }
            return d;
        }

        public String XepLoaiTK (Double a)
        {
            String x;
            if (a >= 9)
            {
                x = "Xuất sắc";
            }
            else if (a >= 8)
            {
                x = "Giỏi";
            }
            else if (a >= 7)
            {
                x = "Khá";
            }
            else if (a >= 6)
            {
                x = "TB-khá";
            }
            else if (a >= 5)
            {
                x = "Trung bình";
            }
            else
            {
                x = "Yếu";
            }
            return x;
        }
    }
}
