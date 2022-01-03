using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TKetchuyen
    {
        public short PkId { get; set; }
        public string CTutk { get; set; }
        public string CSangtk { get; set; }
        public byte? CLanthu { get; set; }
        public string CDiengiai { get; set; }
        public byte? CTuben { get; set; }
    }
}
