using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class THnBanghieuchinh
    {
        public int PkId { get; set; }
        public decimal CNhietdo { get; set; }
        public decimal CBxqs { get; set; }
        public decimal CGiaTri { get; set; }
        public string CGhichu { get; set; }
    }
}
