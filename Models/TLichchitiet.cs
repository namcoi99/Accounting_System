using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TLichchitiet
    {
        public short FkLich { get; set; }
        public DateTime CNgay { get; set; }
        public string CGhiChu { get; set; }

        public virtual TLich FkLichNavigation { get; set; }
    }
}
