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
    
    public partial class Tbl_HoiDong
    {
        public long ID { get; set; }
        public Nullable<long> GiaoVien_ID { get; set; }
        public string NhanXet { get; set; }
        public Nullable<int> Loai { get; set; }
        public Nullable<long> HDCham_ID { get; set; }
    
        public virtual Tbl_GiaoVien Tbl_GiaoVien { get; set; }
        public virtual Tbl_HDCham Tbl_HDCham { get; set; }
    }
}
