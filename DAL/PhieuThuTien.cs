//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class PhieuThuTien
    {
        public int MaPhieuThu { get; set; }
        public Nullable<int> MaDaiLy { get; set; }
        public Nullable<System.DateTime> NgayThu { get; set; }
        public Nullable<double> SoTienThu { get; set; }
        public Nullable<int> MaNhanVien { get; set; }
    
        public virtual DaiLy DaiLy { get; set; }
        public virtual NguoiDung NguoiDung { get; set; }
    }
}
