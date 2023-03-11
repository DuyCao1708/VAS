namespace VAS_UI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class ThanhToanTrucTiep
    {
        public System.Guid ID_Cua_hang { get; set; }
        public System.Guid ID_Thanh_toan { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập tên người nhận")]
        public string Ten_nguoi_nhan { get; set; }
        public string Dia_chi { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập thông tin liên lạc")]
        public string So_dien_thoai { get; set; }

        public virtual CuaHangVatTu CuaHangVatTu { get; set; }
    }
}