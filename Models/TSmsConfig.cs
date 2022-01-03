using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TSmsConfig
    {
        public int PkId { get; set; }
        public byte FkDvcs { get; set; }
        public int? FkPhongban { get; set; }
        public decimal? CVat { get; set; }
        public int? FkLoaitien { get; set; }
    }
}
