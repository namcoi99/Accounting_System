using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TDmDvt
    {
        public short PkId { get; set; }
        public byte? FkDvcs { get; set; }
        public string CMa { get; set; }
        public string CMota { get; set; }
        public DateTime? CLastexport { get; set; }
        public int? CSmsUnit { get; set; }
        public byte? CChoxoa { get; set; }
    }
}
