using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TXntcdichdanh
    {
        public int PkId { get; set; }
        public int FkNhap { get; set; }
        public int FkXuat { get; set; }
        public double CSoluong { get; set; }
        public int? FkOrderxuat { get; set; }
        public string CPhieunhap { get; set; }
        public int? FkVthh { get; set; }
        public decimal? CDongia { get; set; }
    }
}
