using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class VDoituongPhanBoLaiCpVl
    {
        public string CSophieu { get; set; }
        public DateTime? CNgaylap { get; set; }
        public string CMa { get; set; }
        public short? FkVthh { get; set; }
        public double? CSoluong { get; set; }
        public short? FkDtpb { get; set; }
    }
}
