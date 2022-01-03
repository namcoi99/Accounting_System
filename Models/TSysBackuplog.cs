using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TSysBackuplog
    {
        public int PkId { get; set; }
        public string CPath { get; set; }
        public DateTime? CDatetime { get; set; }
        public bool CStatus { get; set; }
        public bool? CExported { get; set; }
    }
}
