//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyMu
{
    using System;
    using System.Collections.Generic;
    
    public partial class NhaXe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhaXe()
        {
            this.LuotThuMuas = new HashSet<LuotThuMua>();
        }
    
        public int Id { get; set; }
        public string Ten { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LuotThuMua> LuotThuMuas { get; set; }
    }
}
