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
    
    public partial class tBaoTri
    {
        public string SoThuTu { get; set; }
        public string SoXe { get; set; }
        public string NgayBaoTri { get; set; }
        public string ThanhTien { get; set; }
    
        public virtual tXe tXe { get; set; }
    }
}
