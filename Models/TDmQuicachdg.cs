﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TDmQuicachdg
    {
        public int PkId { get; set; }
        public string CMa { get; set; }
        public string CMota { get; set; }
        public decimal? CTile { get; set; }
        public int? FkDvt { get; set; }
        public int? FkDvcs { get; set; }
        public DateTime? CLastexport { get; set; }
    }
}
