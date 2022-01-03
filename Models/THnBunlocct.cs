using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class THnBunlocct
    {
        public int PkId { get; set; }
        public int FkHnBunloc { get; set; }
        public string CGiothuchien { get; set; }
        public decimal CTlkhay { get; set; }
        public decimal CTlbun { get; set; }
        public decimal CTltks { get; set; }
        public decimal CTlsks { get; set; }
        public decimal CPerw { get; set; }
        public decimal CPolqs { get; set; }
        public decimal CPolcc { get; set; }
        public decimal? CPolkho { get; set; }
        public string CGhichu { get; set; }

        public virtual THnBunloc FkHnBunlocNavigation { get; set; }
    }
}
