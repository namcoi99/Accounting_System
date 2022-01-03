﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TYeucaumuahang
    {
        public int PkId { get; set; }
        public short FkDvcs { get; set; }
        public string CSophieu { get; set; }
        public DateTime CNgaylap { get; set; }
        public int? FkKhachhang { get; set; }
        public short? FkNguoilh { get; set; }
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
        public int? FkNguoiyc { get; set; }
        public int? FkNguoimh { get; set; }
        public int? FkModifyuser { get; set; }
    }
}
