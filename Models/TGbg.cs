using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TGbg
    {
        public int PkId { get; set; }
        public string CSophieu { get; set; }
        public short FkDvcs { get; set; }
        public DateTime? CNgaylap { get; set; }
        public DateTime? CTungay { get; set; }
        public DateTime? CDenngay { get; set; }
        public int? FkKhachhang { get; set; }
        public int? FkNguoilh { get; set; }
        public short? FkDdct { get; set; }
        public short? FkLoaitien { get; set; }
        public bool? CDamua { get; set; }
        public string FkHdbh { get; set; }
        public short? FkVuviec { get; set; }
        public short? FkPhongban { get; set; }
        public short? FkUser { get; set; }
        public DateTime? CDatetime { get; set; }
        public decimal? CTigia { get; set; }
        public double? CVat { get; set; }
        public string CKhdk { get; set; }
        public string CKhdkdc { get; set; }
        public string CKhdkdt { get; set; }
        public string CKhdkemail { get; set; }
        public string CKhdkfax { get; set; }
        public string CKhdknlh { get; set; }
        public string CNguoilh { get; set; }
    }
}
