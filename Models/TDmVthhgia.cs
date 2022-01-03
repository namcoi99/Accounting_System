using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TDmVthhgia
    {
        public int PkId { get; set; }
        public int FkVthh { get; set; }
        public DateTime CNgay { get; set; }
        public decimal? CCpnl { get; set; }
        public decimal? CCpmc { get; set; }
        public decimal? CCpnc { get; set; }
        public decimal? CCpntb { get; set; }
        public decimal? CCpnnc { get; set; }
    }
}
