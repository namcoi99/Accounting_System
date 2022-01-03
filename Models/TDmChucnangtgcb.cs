using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TDmChucnangtgcb
    {
        public int PkId { get; set; }
        public short FkPhanxuong { get; set; }
        public short FkChucnang { get; set; }
        public byte FkTrangthai { get; set; }
        public int? FkVthh { get; set; }
        public double CThoigian { get; set; }
    }
}
