using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TDmTscdtl
    {
        public int PkId { get; set; }
        public int FkTscd { get; set; }
        public string CTen { get; set; }
        public byte? FkDvt { get; set; }
        public double? CSoluong { get; set; }
        public short? FkMdsd { get; set; }
        public byte? FkNuocsx { get; set; }
        public short? CNamsx { get; set; }
        public string CSerialno { get; set; }
        public string CSohd { get; set; }
        public int? CStt { get; set; }
        public decimal? CGiatri { get; set; }
        public decimal? CGiatri2 { get; set; }
        public DateTime? CNgay { get; set; }
    }
}
