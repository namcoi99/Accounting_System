using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TSysReporttable
    {
        public short FkReport { get; set; }
        public string CTablename { get; set; }
        public bool? CExported { get; set; }
    }
}
