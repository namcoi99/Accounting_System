using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TDmPtvt
    {
        public string PkBienso { get; set; }
        public string CLaixe { get; set; }
        public string CDiachi { get; set; }
        public string CDienthoai { get; set; }
        public string CTenxe { get; set; }
        public decimal? CTrongtai { get; set; }
        public decimal? CDmthnl { get; set; }
        public bool? CTinhtrang { get; set; }
    }
}
