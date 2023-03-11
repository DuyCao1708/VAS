using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VAS_UI.Models
{
    public class CuaHangVatTu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CuaHangVatTu()
        {
            this.DiaChi = new HashSet<DiaChi>();
            this.ThanhToanNganHang = new HashSet<ThanhToanNganHang>();
            this.ThanhToanTrucTiep = new HashSet<ThanhToanTrucTiep>();
            this.BaoGiaVatTu = new HashSet<BaoGiaVatTu>();
        }

        public System.Guid ID_Cua_hang { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập mã cửa hàng")]
        public string Ma_cua_hang { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập tên cửa hàng")]
        public string Ten_cua_hang { get; set; }
        public string Ghi_chu { get; set; }
        public System.DateTime Thoi_gian { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DiaChi> DiaChi { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThanhToanNganHang> ThanhToanNganHang { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThanhToanTrucTiep> ThanhToanTrucTiep { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BaoGiaVatTu> BaoGiaVatTu { get; set; }
    }
}