using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TSysReportrelation
    {
        public int PkId { get; set; }
        public short FkReport { get; set; }
        public string CTablename1 { get; set; }
        public string CTablename2 { get; set; }
        public string CFieldname1 { get; set; }
        public string CFieldname2 { get; set; }
        public string CJointype { get; set; }
        public bool? CExported { get; set; }
    }
}
