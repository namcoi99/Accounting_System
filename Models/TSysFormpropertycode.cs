using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TSysFormpropertycode
    {
        public short PkId { get; set; }
        public string FkFormname { get; set; }
        public string CLabel { get; set; }
        public string CControl { get; set; }
        public short CSeq { get; set; }
        public bool? CExported { get; set; }
    }
}
