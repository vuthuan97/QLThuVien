//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLThuVien.Data.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class PhieuMuon
    {
        public int MaPhieu { get; set; }
        public Nullable<int> MaSV { get; set; }
        public Nullable<int> MaSach { get; set; }
        public Nullable<System.DateTime> NgayMuon { get; set; }
        public Nullable<System.DateTime> NgayTra { get; set; }
    
        public virtual Sach Sach { get; set; }
        public virtual SinhVien SinhVien { get; set; }
    }
}
