//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class DiaChi
    {
        public System.Guid ID_Cua_hang { get; set; }
        public System.Guid ID_Dia_chi { get; set; }
        public string So { get; set; }
        public string Duong { get; set; }
        public string Phuong { get; set; }
        public string Quan { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập địa chỉ cửa hàng")]
        public string Thanh_pho { get; set; }

        public virtual CuaHangVatTu CuaHangVatTu { get; set; }
    }
}
