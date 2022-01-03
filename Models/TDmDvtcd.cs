using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TDmDvtcd
    {
        public short PkId { get; set; }
        public byte? FkDvcs { get; set; }
        public string CMa { get; set; }
        public short FkDvvao { get; set; }
        public short FkDvra { get; set; }
        public double CTile { get; set; }
        public string CMota { get; set; }
        public DateTime? CLastexport { get; set; }
    }
}
