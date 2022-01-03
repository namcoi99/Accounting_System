using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TDmTscdnv
    {
        public short PkId { get; set; }
        public int FkTscd { get; set; }
        public decimal? CGiatri { get; set; }
        public short? FkNguonvon { get; set; }
    }
}
