using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TCpodata
    {
        public long PkId { get; set; }
        public int FkMrpoption { get; set; }
        public int? FkDondathangct { get; set; }
        public int? FkLsxct { get; set; }
        public long? FkCpo { get; set; }
        public int FkVthh { get; set; }
        public double CSlyeucau { get; set; }
        public double? CSlcungcap { get; set; }
        public double? CSlconthieu { get; set; }
        public double? CSldalap { get; set; }
        public DateTime? CNgaybd { get; set; }
        public DateTime CNgaynhan { get; set; }
        public byte FkNguon { get; set; }
        public bool? CConvert { get; set; }
        public int? FkGiaydathang { get; set; }
    }
}
