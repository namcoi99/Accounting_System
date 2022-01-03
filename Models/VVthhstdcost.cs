using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class VVthhstdcost
    {
        public int FkVthh { get; set; }
        public int FkKmp { get; set; }
        public string CMa { get; set; }
        public string CMota { get; set; }
        public decimal CSotien { get; set; }
        public DateTime CRollupdate { get; set; }
    }
}
