using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TDmVthhnl
    {
        public TDmVthhnl()
        {
            TDmVthhnlct = new HashSet<TDmVthhnlct>();
        }

        public int PkId { get; set; }
        public short FkDvcs { get; set; }
        public string CMa { get; set; }
        public byte? CMaphu { get; set; }
        public DateTime CNgaylap { get; set; }
        public byte? CSogia { get; set; }
        public string CGhichu { get; set; }
        public byte FkTrangthai { get; set; }
        public short? FkUser { get; set; }
        public short? FkModifyuser { get; set; }
        public DateTime? CDatetime { get; set; }
        public decimal? CSltp { get; set; }
        public short? FkDvttp { get; set; }

        public virtual ICollection<TDmVthhnlct> TDmVthhnlct { get; set; }
    }
}
