//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyDiem
{
    using System;
    using System.Collections.Generic;
    
    public partial class GiaoVien_HinhAnh
    {
        public short ID { get; set; }
        public string GV_IMG { get; set; }
        public byte[] IMG { get; set; }
        public string MaGV { get; set; }
        public string FileIMG2 { get; set; }
    
        public virtual GiaoVien GiaoVien { get; set; }
    }
}
