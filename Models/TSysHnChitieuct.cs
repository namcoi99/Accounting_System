using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TSysHnChitieuct
    {
        public int PkId { get; set; }
        public string FkHnSysChitieu { get; set; }
        public int? CStt { get; set; }
        public string CTenct { get; set; }
        public string CDvt { get; set; }
        public string CGhichu { get; set; }

        public virtual TSysHnChitieu FkHnSysChitieuNavigation { get; set; }
    }
}
