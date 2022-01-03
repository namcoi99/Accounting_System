using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TQlpx
    {
        public int PkId { get; set; }
        public short FkDvcs { get; set; }
        public string CSophieu { get; set; }
        public DateTime CNgaylap { get; set; }
        public short? FkUser { get; set; }
        public DateTime? CDatetime { get; set; }
        public bool? CTheolsx { get; set; }
    }
}
