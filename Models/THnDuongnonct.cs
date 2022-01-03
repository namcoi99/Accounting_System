using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class THnDuongnonct
    {
        public int PkId { get; set; }
        public int FkHnDuongnon { get; set; }
        public int FkDmMauHn { get; set; }
        public string CGiothuchien { get; set; }
        public int CSonoi { get; set; }
        public decimal CThetich { get; set; }
        public string CGionha { get; set; }
        public decimal CBxqs { get; set; }
        public decimal CNhietdo { get; set; }
        public decimal CBxcc { get; set; }
        public decimal CPolqs { get; set; }
        public decimal CPolcc { get; set; }
        public decimal CAp { get; set; }
        public string CGhichu { get; set; }

        public virtual TDmMauHn FkDmMauHnNavigation { get; set; }
        public virtual THnDuongnon FkHnDuongnonNavigation { get; set; }
    }
}
