using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class THnBasxct
    {
        public int PkId { get; set; }
        public int FkHnBasx { get; set; }
        public string CGiothuchien { get; set; }
        public decimal CTlmauN { get; set; }
        public decimal CTlnoinau { get; set; }
        public decimal CTltkn { get; set; }
        public decimal CTlskn { get; set; }
        public decimal CTlddBaSkn { get; set; }
        public decimal CPolqs { get; set; }
        public decimal CPolcc { get; set; }
        public decimal CTlkhay { get; set; }
        public decimal CTlmauS { get; set; }
        public decimal CTltks { get; set; }
        public decimal CTlsks { get; set; }
        public decimal CPerw { get; set; }
        public decimal? CTlnuocthamthau { get; set; }
        public decimal? CNhietdonctt { get; set; }
        public string CGhichu { get; set; }

        public virtual THnBasx FkHnBasxNavigation { get; set; }
    }
}
