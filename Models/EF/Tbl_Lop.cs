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
    
    public partial class Tbl_Lop
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_Lop()
        {
            this.Tbl_SinhVien = new HashSet<Tbl_SinhVien>();
        }
    
        public long ID { get; set; }
        public string TenLop { get; set; }
        public string MaLop { get; set; }
        public Nullable<long> ChuyenNganh_ID { get; set; }
        public Nullable<long> HeDaoTao_ID { get; set; }
        public Nullable<int> SiSo { get; set; }
    
        public virtual Tbl_HeDaoTao Tbl_HeDaoTao { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_SinhVien> Tbl_SinhVien { get; set; }
    }
}
