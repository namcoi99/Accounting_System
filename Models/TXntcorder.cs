using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TXntcorder
    {
        public int PkId { get; set; }
        public string CSophieu { get; set; }
        public short FkDvcs { get; set; }
        public string CTtkhuyenmai { get; set; }
        public int? FkOrder { get; set; }
    }
}
