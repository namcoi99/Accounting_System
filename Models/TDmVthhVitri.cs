using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TDmVthhVitri
    {
        public int PkId { get; set; }
        public int FkVthh { get; set; }
        public int FkVitri { get; set; }
        public decimal? CSoluong { get; set; }
        public int? FkCreateuser { get; set; }
        public DateTime? CDatetime { get; set; }
    }
}
