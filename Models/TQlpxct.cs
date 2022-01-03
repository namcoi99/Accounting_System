using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TQlpxct
    {
        public int PkId { get; set; }
        public int FkQlpx { get; set; }
        public int FkLsx { get; set; }
        public int FkLsxct { get; set; }
        public byte? CCa { get; set; }
        public double? CSoluongvao { get; set; }
        public double? CSoluong { get; set; }
        public byte? CStt { get; set; }
        public short? FkChucnang { get; set; }
        public DateTime? CNgaybd { get; set; }
        public DateTime? CNgayht { get; set; }
    }
}
