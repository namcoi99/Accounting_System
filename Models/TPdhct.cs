using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TPdhct
    {
        public int PkId { get; set; }
        public int FkPdh { get; set; }
        public short CStt { get; set; }
        public int FkVthh { get; set; }
        public DateTime? CNgaynhan { get; set; }
        public double CSoluong { get; set; }
        public short FkDvmua { get; set; }
        public decimal? CGia { get; set; }
        public byte? CTrangthai { get; set; }
    }
}
