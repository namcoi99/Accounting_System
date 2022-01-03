using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TDmKhvthh
    {
        public int PkId { get; set; }
        public int? FkVthh { get; set; }
        public int? FkKh { get; set; }
        public decimal? CDongia { get; set; }
        public int? FkDvt { get; set; }
        public int? FkNhomgia { get; set; }
        public int? FkNhomkh { get; set; }
        public int? FkVung { get; set; }
        public string CCongthuc { get; set; }
        public int? FkDvcs { get; set; }
        public DateTime? CTungay { get; set; }
        public DateTime? CDenngay { get; set; }
        public DateTime? CDatetime { get; set; }
        public int? FkUser { get; set; }
        public decimal? CCk { get; set; }
        public decimal? CGiamgia { get; set; }
        public decimal? CDongiathue { get; set; }
        public bool? CKhuyenmai { get; set; }
    }
}
