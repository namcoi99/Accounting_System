using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TDmCuocvanchuyenct
    {
        public int PkId { get; set; }
        public short FkKhdiachi { get; set; }
        public int FkHangvanchuyen { get; set; }
        public double CGiacuoc { get; set; }
        public byte FkLoaixe { get; set; }
        public DateTime CTungay { get; set; }
        public DateTime CDenngay { get; set; }
        public int? FkVthh { get; set; }
        public short? FkUser { get; set; }
    }
}
