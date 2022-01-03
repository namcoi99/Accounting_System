using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TLsxnl
    {
        public TLsxnl()
        {
            TLsxnlct = new HashSet<TLsxnlct>();
        }

        public int FkLsxct { get; set; }
        public string CMa { get; set; }
        public byte? CMaphu { get; set; }
        public DateTime CNgaylap { get; set; }
        public byte? CSogia { get; set; }
        public string CGhichu { get; set; }
        public byte FkTrangthai { get; set; }
        public short? FkUser { get; set; }
        public short? FkModifyuser { get; set; }
        public DateTime? CDatetime { get; set; }
        public decimal? CLtoffset { get; set; }
        public decimal? CScrapPercent { get; set; }
        public short? FkChucnang { get; set; }
        public decimal? CSltp { get; set; }
        public short? FkDvttp { get; set; }

        public virtual ICollection<TLsxnlct> TLsxnlct { get; set; }
    }
}
