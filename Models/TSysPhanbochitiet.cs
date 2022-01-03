using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TSysPhanbochitiet
    {
        public byte PkId { get; set; }
        public bool CChon { get; set; }
        public string CTen { get; set; }
        public string CTentruong { get; set; }
        public string CHienthi { get; set; }
        public string CBang { get; set; }
        public bool? CExported { get; set; }
    }
}
