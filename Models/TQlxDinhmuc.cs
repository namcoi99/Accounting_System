using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TQlxDinhmuc
    {
        public int PkId { get; set; }
        public DateTime? CNgaytao { get; set; }
        public DateTime? CNgayupdate { get; set; }
        public string CDtcp { get; set; }
        public string CTenDinhmuc { get; set; }
        public string CDvdm { get; set; }
        public decimal? CSldm { get; set; }
        public int? FkCreateuser { get; set; }
        public DateTime? CDatetime { get; set; }
        public byte? CChoxoa { get; set; }
    }
}
