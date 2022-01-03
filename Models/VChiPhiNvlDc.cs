using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class VChiPhiNvlDc
    {
        public int? Y { get; set; }
        public int? M { get; set; }
        public short? FkVthh { get; set; }
        public short? FkDvt { get; set; }
        public short? FkDtcp { get; set; }
        public string FkTkno { get; set; }
        public string FkTkco { get; set; }
        public string CDiengiai { get; set; }
        public string CDiengiai2 { get; set; }
        public int? FkDtpb { get; set; }
        public double? CTigia { get; set; }
        public short? FkKhoxuat { get; set; }
        public short? FkPhanxuong { get; set; }
        public decimal CPsno { get; set; }
        public double CSoluong { get; set; }
    }
}
