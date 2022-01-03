using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TTurYeucauChiphikhac
    {
        public int PkId { get; set; }
        public int FkYeucau { get; set; }
        public short FkKmp { get; set; }
        public decimal CPsno { get; set; }
        public decimal CPsno2 { get; set; }
        public string CGhichu { get; set; }
    }
}
