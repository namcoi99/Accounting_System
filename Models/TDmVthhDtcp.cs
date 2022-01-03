using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TDmVthhDtcp
    {
        public int PkId { get; set; }
        public byte FkDvcs { get; set; }
        public int? FkVthh { get; set; }
        public int? FkDtcp { get; set; }
        public decimal? CTyle { get; set; }
        public short? FkUser { get; set; }
        public short? FkModifyuser { get; set; }
    }
}
