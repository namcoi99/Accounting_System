using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class VTyLePhanBoCp
    {
        public int? Y { get; set; }
        public int? M { get; set; }
        public short? FkDtpb { get; set; }
        public short? FkVthh { get; set; }
        public double? SoluongRc { get; set; }
        public double? TongsoHt { get; set; }
        public double? Rate { get; set; }
    }
}
