//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PBL3_1._0_
{
    using System;
    using System.Collections.Generic;
    
    public partial class sach
    {
        public int masach { get; set; }
        public string tensach { get; set; }
        public Nullable<int> namxb { get; set; }
        public Nullable<int> manxb { get; set; }
        public Nullable<int> matheloai { get; set; }
        public Nullable<int> matacgia { get; set; }
        public Nullable<int> soluong { get; set; }
        public string ghichu { get; set; }
        public string khusach { get; set; }
        public Nullable<int> giatien { get; set; }
        public byte[] image { get; set; }
    
        public virtual nxb nxb { get; set; }
        public virtual sachmua sachmua { get; set; }
        public virtual tacgia tacgia { get; set; }
        public virtual theloai theloai { get; set; }
    }
}