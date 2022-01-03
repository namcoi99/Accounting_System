using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TDmCtkmct
    {
        public short PkId { get; set; }
        public short FkCtkm { get; set; }
        public int FkVthh { get; set; }
        public decimal? CSoluong { get; set; }
        public decimal? CDoanhthu { get; set; }
        public decimal? CButtoan { get; set; }
        public int? FkVthh2 { get; set; }
        public decimal? CSoluong2 { get; set; }
        public decimal? CDoanhthu2 { get; set; }
        public int? CAndor { get; set; }
        public int? FkDvt { get; set; }
        public int? FkDvt2 { get; set; }
    }
}
