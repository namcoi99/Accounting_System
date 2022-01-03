using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TDmTscdpt
    {
        public int PkId { get; set; }
        public int FkTscd { get; set; }
        public int? CStt { get; set; }
        public string CQuycach { get; set; }
        public byte? FkDvt { get; set; }
        public double? CSoluong { get; set; }
        public decimal? CGiatri { get; set; }
    }
}
