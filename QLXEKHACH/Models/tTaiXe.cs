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
    
    public partial class tTaiXe
    {
        public tTaiXe()
        {
            this.tChuyens = new HashSet<tChuyen>();
        }
    
        public string MaTaiXe { get; set; }
        public string TenTaiXe { get; set; }
        public string LoaiBangLaiXe { get; set; }
        public string DiaChi { get; set; }
        public string GhiChu { get; set; }
    
        public virtual ICollection<tChuyen> tChuyens { get; set; }
    }
}
