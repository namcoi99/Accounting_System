using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TCposchedule
    {
        public int FkMrpoption { get; set; }
        public short? CStt { get; set; }
        public int FkPhanxuong { get; set; }
        public int? FkChucnang { get; set; }
        public long FkCpodata { get; set; }
        public short? FkCa { get; set; }
        public DateTime? CNgay { get; set; }
        public DateTime CTugio { get; set; }
        public DateTime CDengio { get; set; }
        public double CSoluong { get; set; }
        public bool? CConvert { get; set; }
        public int? FkLsx { get; set; }
        public int? FkGiaydathang { get; set; }
    }
}
