using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TDmVthhdvt
    {
        public int PkId { get; set; }
        public int FkVthh { get; set; }
        public int FkDvt { get; set; }
        public bool? CHidden { get; set; }
    }
}
