using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TSysHnChitieu
    {
        public TSysHnChitieu()
        {
            TSysHnChitieuct = new HashSet<TSysHnChitieuct>();
        }

        public string PkId { get; set; }
        public string CGhichu { get; set; }

        public virtual ICollection<TSysHnChitieuct> TSysHnChitieuct { get; set; }
    }
}
