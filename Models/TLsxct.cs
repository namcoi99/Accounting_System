using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TLsxct
    {
        public TLsxct()
        {
            TLsxctkh = new HashSet<TLsxctkh>();
        }

        public int PkId { get; set; }
        public int FkLsx { get; set; }
        public byte CStt { get; set; }
        public int FkVthh { get; set; }
        public double? CSoluong { get; set; }
        public short? FkDvt { get; set; }
        public DateTime? CNgaygh { get; set; }
        public DateTime? CNgayht { get; set; }
        public DateTime? CNgaybd { get; set; }
        public bool? CPheduyet { get; set; }
        public string FkTkno { get; set; }
        public bool? CHtsx { get; set; }
        public decimal? CSlhoanthanh { get; set; }

        public virtual ICollection<TLsxctkh> TLsxctkh { get; set; }
    }
}
