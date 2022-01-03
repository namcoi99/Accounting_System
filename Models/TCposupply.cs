using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TCposupply
    {
        public short FkMrpoption { get; set; }
        public DateTime CNgay { get; set; }
        public int FkVthh { get; set; }
        public double CSoluong { get; set; }
        public byte? FkNguon { get; set; }
    }
}
