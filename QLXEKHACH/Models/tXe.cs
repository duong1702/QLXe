//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLXEKHACH.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tXe
    {
        public tXe()
        {
            this.tBaoTris = new HashSet<tBaoTri>();
            this.tChuyens = new HashSet<tChuyen>();
            this.tPhieuNhienLieux = new HashSet<tPhieuNhienLieu>();
        }
    
        public string SoXe { get; set; }
        public string HangSanXuat { get; set; }
        public string NamSanXuat { get; set; }
        public string SoLuongChoNgoi { get; set; }
    
        public virtual ICollection<tBaoTri> tBaoTris { get; set; }
        public virtual ICollection<tChuyen> tChuyens { get; set; }
        public virtual ICollection<tPhieuNhienLieu> tPhieuNhienLieux { get; set; }
    }
}
