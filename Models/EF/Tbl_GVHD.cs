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
    
    public partial class Tbl_GVHD
    {
        public long ID { get; set; }
        public Nullable<long> DoAn_ID { get; set; }
        public Nullable<long> GiaoVien_ID { get; set; }
        public string HuongNghienCuu { get; set; }
        public Nullable<System.DateTime> NgayTao { get; set; }
    }
}
