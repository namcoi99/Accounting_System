using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TDmDtcpthoigian
    {
        public int PkId { get; set; }
        public DateTime CDate { get; set; }
        public int FkDtcp { get; set; }
        public decimal? CCat1 { get; set; }
        public decimal? CCat2 { get; set; }
        public decimal? CCat3 { get; set; }
        public decimal? CCat4 { get; set; }
        public decimal? CCat5 { get; set; }
        public decimal? CCat6 { get; set; }
        public decimal? CCat7 { get; set; }
        public short? FkProstatus { get; set; }
    }
}
