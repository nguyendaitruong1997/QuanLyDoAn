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
    
    public partial class Tbl_NienKhoa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_NienKhoa()
        {
            this.Tbl_SinhVien = new HashSet<Tbl_SinhVien>();
        }
    
        public long ID { get; set; }
        public string NienKhoa { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_SinhVien> Tbl_SinhVien { get; set; }
    }
}
