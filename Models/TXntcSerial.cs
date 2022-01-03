using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TXntcSerial
    {
        public string CSerial { get; set; }
        public int FkVthh { get; set; }
        public int? FkNhap { get; set; }
        public int? FkXuat { get; set; }
        public string CSerial2 { get; set; }
        public string CSerial3 { get; set; }
    }
}
