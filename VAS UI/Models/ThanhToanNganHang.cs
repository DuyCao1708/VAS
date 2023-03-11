using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VAS_UI.Models
{
    public partial class ThanhToanNganHang
    {
        public System.Guid ID_Cua_hang { get; set; }
        public System.Guid ID_Thanh_toan { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập tên người nhận")]
        public string Ten_nguoi_nhan { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập tên ngân hàng")]
        public string Ten_ngan_hang { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập số tài khoản ngân hàng")]
        public string So_tai_khoan { get; set; }

        public virtual CuaHangVatTu CuaHangVatTu { get; set; }
    }
}