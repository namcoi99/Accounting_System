using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TSysUserlog
    {
        public string CComputername { get; set; }
        public string CIpaddress { get; set; }
        public string CUsername { get; set; }
        public DateTime? CLogintime { get; set; }
        public DateTime? CLogouttime { get; set; }
        public bool? CExported { get; set; }
        public string CVersion { get; set; }
    }
}
