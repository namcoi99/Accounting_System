using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TLuongNhanvienBhxh
    {
        public short PkId { get; set; }
        public string CMaso { get; set; }
        public string CDiengiai { get; set; }
        public DateTime? CNgay { get; set; }
        public int? CSongay { get; set; }
        public int? CSongayBh { get; set; }
        public decimal? CHeso { get; set; }
        public decimal? CMucluong { get; set; }
        public int? CPhantram { get; set; }
        public decimal? CTienDntra { get; set; }
        public decimal? CTienBhtra { get; set; }
    }
}
