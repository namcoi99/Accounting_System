using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TSysReplicationconfig
    {
        public byte CDatabasetype { get; set; }
        public string CDatabasefolder { get; set; }
        public string CServername { get; set; }
        public string CDatabasename { get; set; }
        public string CUsername { get; set; }
        public string CPassword { get; set; }
        public bool? CExported { get; set; }
    }
}
