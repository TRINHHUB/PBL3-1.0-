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
    
    public partial class acountt
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public acountt()
        {
            this.docgias = new HashSet<docgia>();
        }
    
        public int ID_User { get; set; }
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public string Gmail { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<docgia> docgias { get; set; }
    }
}