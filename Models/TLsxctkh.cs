using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TLsxctkh
    {
        public long PkId { get; set; }
        public int FkLsxct { get; set; }
        public short CStt { get; set; }
        public short FkPhanxuong { get; set; }
        public short? FkChucnang { get; set; }
        public short FkCa { get; set; }
        public DateTime CNgaybd { get; set; }
        public DateTime CNgayht { get; set; }
        public double? CSoluong { get; set; }
        public double? CSoluongtot { get; set; }
        public double? CSoluonghong { get; set; }
        public bool? CHtsx { get; set; }

        public virtual TLsxct FkLsxctNavigation { get; set; }
    }
}
