using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TDmHuyen
    {
        public int PkId { get; set; }
        public string CMa { get; set; }
        public string CTen { get; set; }
        public short FkTtp { get; set; }
    }
}
