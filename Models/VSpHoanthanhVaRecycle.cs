using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class VSpHoanthanhVaRecycle
    {
        public DateTime? CNgaylap { get; set; }
        public string CSophieu { get; set; }
        public short? Spid { get; set; }
        public string MaSp { get; set; }
        public string TenSp { get; set; }
        public double? SlSpht { get; set; }
        public double SlRec { get; set; }
    }
}
