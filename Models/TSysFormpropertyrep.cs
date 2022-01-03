using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TSysFormpropertyrep
    {
        public short PkId { get; set; }
        public string CFormname { get; set; }
        public string CFilename { get; set; }
        public bool? CDefault { get; set; }
        public string CDescription { get; set; }
        public bool? CExported { get; set; }
        public string CPrinterName { get; set; }
        public string CPageSize { get; set; }
        public bool? CPortrait { get; set; }
    }
}
