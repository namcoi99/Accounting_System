using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class VSanPhamHoanThanh
    {
        public int? Years { get; set; }
        public int? Months { get; set; }
        public short? SanphamId { get; set; }
        public string FkTkno { get; set; }
        public string FkTkco { get; set; }
        public string CDiengiai { get; set; }
        public short? FkChungtu { get; set; }
        public double? Soluong { get; set; }
        public double? Rate { get; set; }
        public double? Tonghoanthanh { get; set; }
    }
}
