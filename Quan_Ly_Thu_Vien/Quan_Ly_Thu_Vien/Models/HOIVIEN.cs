//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Quan_Ly_Thu_Vien.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HOIVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOIVIEN()
        {
            this.PHIEUMUONSACHes = new HashSet<PHIEUMUONSACH>();
        }
    
        public string MaHV { get; set; }
        public string TenHV { get; set; }
        public string SDT { get; set; }
        public System.DateTime NgayLapThe { get; set; }
        public string TinhTrang { get; set; }
        public int DangMuon { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUMUONSACH> PHIEUMUONSACHes { get; set; }
    }
}
