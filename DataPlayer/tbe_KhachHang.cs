//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataPlayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbe_KhachHang
    {
        public tbe_KhachHang()
        {
            this.tbe_HoaDon = new HashSet<tbe_HoaDon>();
        }
    
        public string MaKhachHang { get; set; }
        public string TenKhachHang { get; set; }
        public string GioiTinh { get; set; }
    
        public virtual ICollection<tbe_HoaDon> tbe_HoaDon { get; set; }
    }
}
