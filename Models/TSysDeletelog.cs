using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TSysDeletelog
    {
        public int PkId { get; set; }
        public DateTime CDatetime { get; set; }
        public string CUsername { get; set; }
        public byte CForm { get; set; }
        public string CCode { get; set; }
        public string CDescription { get; set; }
        public string CDescription2 { get; set; }
    }
}
