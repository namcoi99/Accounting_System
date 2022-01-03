using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TSysReportdetailcolprop
    {
        public int PkId { get; set; }
        public int FkReport { get; set; }
        public string CColname { get; set; }
        public short CWidth { get; set; }
        public byte? CDecimaldigits { get; set; }
        public bool? CExported { get; set; }
    }
}
