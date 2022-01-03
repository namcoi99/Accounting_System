using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class THnDuongtpct
    {
        public int PkId { get; set; }
        public int FkHnDuongtp { get; set; }
        public string CGiothuchien { get; set; }
        public string CSluongnoinau { get; set; }
        public decimal CTltks { get; set; }
        public decimal CTlsks { get; set; }
        public decimal CTlmatdi { get; set; }
        public decimal CPerw { get; set; }
        public decimal CPolqs { get; set; }
        public decimal CNhietdo { get; set; }
        public decimal CPersacc { get; set; }
        public decimal CRs { get; set; }
        public decimal? CPertapchat { get; set; }
        public decimal? CIu { get; set; }
        public string CGhichu { get; set; }

        public virtual THnDuongtp FkHnDuongtpNavigation { get; set; }
    }
}
