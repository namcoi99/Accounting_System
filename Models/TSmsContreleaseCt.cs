using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TSmsContreleaseCt
    {
        public int PkId { get; set; }
        public int? FkContrelease { get; set; }
        public int? FkCont { get; set; }
        public decimal? CSoluong { get; set; }
        public int? FkCommodity { get; set; }
        public string CNote { get; set; }
        public bool? CPacked { get; set; }
        public string CSeal { get; set; }
    }
}
