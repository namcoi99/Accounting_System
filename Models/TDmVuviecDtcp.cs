using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TDmVuviecDtcp
    {
        public int PkId { get; set; }
        public int? FkVuviec { get; set; }
        public int? FkDtcp { get; set; }
        public DateTime? CNgay { get; set; }
        public decimal? CTile { get; set; }
        public decimal? CSanluong { get; set; }
        public string CMota { get; set; }
        public int? FkDvcs { get; set; }
    }
}
