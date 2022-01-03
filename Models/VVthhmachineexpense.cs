using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class VVthhmachineexpense
    {
        public int FkVthh { get; set; }
        public short FkKmp { get; set; }
        public decimal? CSotien { get; set; }
        public short CStt { get; set; }
    }
}
