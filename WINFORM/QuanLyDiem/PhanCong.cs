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
    
    public partial class PhanCong
    {
        public string MaGV { get; set; }
        public string MaMonHP { get; set; }
        public string MaLop { get; set; }
    
        public virtual GiaoVien GiaoVien { get; set; }
        public virtual Lop Lop { get; set; }
        public virtual MonHP MonHP { get; set; }
    }
}
