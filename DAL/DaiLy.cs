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
    
    public partial class DaiLy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DaiLy()
        {
            this.PhieuThuTiens = new HashSet<PhieuThuTien>();
            this.PhieuXuatHangs = new HashSet<PhieuXuatHang>();
        }
    
        public int MaDaiLy { get; set; }
        public string TenDaiLy { get; set; }
        public Nullable<int> Loai { get; set; }
        public string DiaChi { get; set; }
        public string Quan { get; set; }
        public Nullable<System.DateTime> NgayTiepNhan { get; set; }
        public string Email { get; set; }
        public Nullable<double> TienNo { get; set; }
        public Nullable<int> TinhTrang { get; set; }
    
        public virtual LoaiDaiLy LoaiDaiLy { get; set; }
        public virtual Quan Quan1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuThuTien> PhieuThuTiens { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuXuatHang> PhieuXuatHangs { get; set; }
    }
}
