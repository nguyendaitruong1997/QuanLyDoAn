//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLDoAn.Models.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_HeDaoTao
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_HeDaoTao()
        {
            this.Tbl_Lop = new HashSet<Tbl_Lop>();
            this.Tbl_SinhVien = new HashSet<Tbl_SinhVien>();
        }
    
        public long ID { get; set; }
        public string TenHe { get; set; }
        public string MaHe { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Lop> Tbl_Lop { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_SinhVien> Tbl_SinhVien { get; set; }
    }
}
