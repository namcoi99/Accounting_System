using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TXntclichtt
    {
        public int PkId { get; set; }
        public int FkOrder { get; set; }
        public short CStt { get; set; }
        public DateTime CNgay { get; set; }
        public decimal? CPsno { get; set; }
        public decimal? CPsno2 { get; set; }
        public bool? CDatt { get; set; }
        public bool? CNhacno { get; set; }
        public string CGhichu { get; set; }
        public string CGhichu02 { get; set; }
    }
}
