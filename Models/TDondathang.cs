using System;
using System.Collections.Generic;

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
        public short FkDvcs { get; set; }
        public string CSophieu { get; set; }
        public DateTime CNgaylap { get; set; }
        public DateTime? CNgaynhan { get; set; }
        public DateTime? CNgayhethan { get; set; }
        public int? FkKhachhang { get; set; }
        public int? FkNguoilh { get; set; }
        public short FkLoaitien { get; set; }
        public decimal? CTigia { get; set; }
        public string CDiengiai { get; set; }
        public short? FkVuviec { get; set; }
        public short? FkPhongban { get; set; }
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
        public double? CVat { get; set; }
        public int? FkLoaibg { get; set; }
        public short? FkPpvc { get; set; }
        public int? FkDondathang { get; set; }
        public short? FkSoxe { get; set; }
        public short? FkCuocvanchuyen { get; set; }
        public short? FkSochuyen { get; set; }
        public int? FkHangvanchuyen { get; set; }
        public string CNguoivanchuyen { get; set; }
        public string CField1 { get; set; }
        public string CField2 { get; set; }
        public int? FkModifyuser { get; set; }
        public short? FkPttt { get; set; }

        public virtual ICollection<TDondathangdk> TDondathangdk { get; set; }
    }
}
