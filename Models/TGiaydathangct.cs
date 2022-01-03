using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TGiaydathangct
    {
        public int PkId { get; set; }
        public int FkGiaydathang { get; set; }
        public short CStt { get; set; }
        public int FkVthh { get; set; }
        public DateTime? CNgaynhan { get; set; }
        public double CSoluong { get; set; }
        public short FkDvmua { get; set; }
        public decimal? CDongia { get; set; }
        public bool? CPheduyet { get; set; }
        public short? FkNguoipd { get; set; }
        public short? FkTrangthai { get; set; }
        public decimal? CDongia2 { get; set; }
        public bool? CDamua { get; set; }
        public bool? CStopRemind { get; set; }
    }
}
