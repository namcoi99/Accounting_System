using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TSysBackuprestore
    {
        public string CPath { get; set; }
        public bool? CMon { get; set; }
        public bool? CTue { get; set; }
        public bool? CWed { get; set; }
        public bool? CThu { get; set; }
        public bool? CFri { get; set; }
        public bool? CSat { get; set; }
        public bool? CSun { get; set; }
        public bool? CExported { get; set; }
    }
}
