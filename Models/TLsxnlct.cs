using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TLsxnlct
    {
        public int PkId { get; set; }
        public int FkLsxct { get; set; }
        public short CStt { get; set; }
        public int FkVthh { get; set; }
        public double CSoluong { get; set; }
        public short? FkChucnang { get; set; }
        public short? FkDvt { get; set; }
        public decimal? CLtoffset { get; set; }
        public decimal? CScrapPercent { get; set; }
        public byte? CPromotionType { get; set; }
        public decimal? CSoluong2 { get; set; }

        public virtual TLsxnl FkLsxctNavigation { get; set; }
    }
}
