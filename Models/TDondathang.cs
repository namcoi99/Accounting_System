using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TDondathang
    {
        public TDondathang()
        {
            TDondathangdk = new HashSet<TDondathangdk>();
        }

        public int PkId { get; set; }
        [DisplayName("ĐVCS")]
        [Required(ErrorMessage = "ĐVCS là trường bắt buộc")]
        public short FkDvcs { get; set; }
        [Required(ErrorMessage = "Số phiếu là trường bắt buộc")]
        [DisplayName("Số phiếu")]
        public string CSophieu { get; set; }
        [DisplayName("Ngày lập")]
        [Required(ErrorMessage = "Ngày lập là trường bắt buộc")]
        public DateTime CNgaylap { get; set; }
        [DisplayName("Ngày nhận")]
        public DateTime? CNgaynhan { get; set; }
        [DisplayName("Ngày hết hạn")]
        public DateTime? CNgayhethan { get; set; }
        [DisplayName("Khách hàng")]
        public int? FkKhachhang { get; set; }
        [DisplayName("Người LH")]
        public int? FkNguoilh { get; set; }
        [DisplayName("Loại tiền")]
        [Required(ErrorMessage = "Loại tiền là trường bắt buộc")]
        public short FkLoaitien { get; set; }
        [DisplayName("Tỉ giá")]
        public decimal? CTigia { get; set; }
        [DisplayName("Diễn giải")]
        public string CDiengiai { get; set; }
        [DisplayName("Vụ việc")]
        public short? FkVuviec { get; set; }
        [DisplayName("Phòng ban")]
        public short? FkPhongban { get; set; }
        [DisplayName("Phân xưởng")]
        public short? FkPhanxuong { get; set; }
        public short? FkDtcp { get; set; }
        public short? FkKmp { get; set; }
        public string CKhdk { get; set; }
        public string CKhdkdc { get; set; }
        public string CKhdkdt { get; set; }
        public string CKhdkemail { get; set; }
        public string CKhdknlh { get; set; }
        public string CKhdkfax { get; set; }
        public short? FkUser { get; set; }
        public DateTime? CDatetime { get; set; }
        public short? FkDdct { get; set; }
        public bool? CDaban { get; set; }
        [DisplayName("% Vat")]
        public double? CVat { get; set; }
        [DisplayName("Loại phiếu")]
        public int? FkLoaibg { get; set; }
        public short? FkPpvc { get; set; }
        public int? FkDondathang { get; set; }
        [DisplayName("Xe VC")]
        public short? FkSoxe { get; set; }
        public short? FkCuocvanchuyen { get; set; }
        [DisplayName("Số chuyến")]
        public short? FkSochuyen { get; set; }
        public int? FkHangvanchuyen { get; set; }
        [DisplayName("Người VC")]
        public string CNguoivanchuyen { get; set; }
        public string CField1 { get; set; }
        public string CField2 { get; set; }
        public int? FkModifyuser { get; set; }
        [DisplayName("PTTT")]
        public short? FkPttt { get; set; }

        public virtual ICollection<TDondathangdk> TDondathangdk { get; set; }
    }
}
