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
    
    public partial class PhieuXuatHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhieuXuatHang()
        {
            this.CTPhieuXuatHangs = new HashSet<CTPhieuXuatHang>();
        }
    
        public int MaPhieuXuat { get; set; }
        public Nullable<int> MaDaiLy { get; set; }
        public Nullable<System.DateTime> NgayXuat { get; set; }
        public Nullable<double> TongTien { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTPhieuXuatHang> CTPhieuXuatHangs { get; set; }
        public virtual DaiLy DaiLy { get; set; }
    }
}
