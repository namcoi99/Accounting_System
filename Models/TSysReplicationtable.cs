using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TSysReplicationtable
    {
        public short? CSeq { get; set; }
        public string CTablename { get; set; }
        public bool? CAllowimport { get; set; }
        public bool? CAllowexport { get; set; }
        public DateTime? CLastimporttime { get; set; }
        public DateTime? CLastexporttime { get; set; }
        public string CUniquefield1 { get; set; }
        public string CUniquefield2 { get; set; }
        public string CUniquefield3 { get; set; }
        public bool? CExported { get; set; }
        public DateTime? CTimefield { get; set; }
    }
}
