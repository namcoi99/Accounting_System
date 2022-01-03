using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TDmNs
    {
        public short PkId { get; set; }
        public byte FkDvcs { get; set; }
        public string CMa { get; set; }
        public string CHoten { get; set; }
        public byte? FkPhongban { get; set; }
        public bool? CKiemtra { get; set; }
        public bool? CPhantich { get; set; }
        public bool? CMuahang { get; set; }
        public bool? CBanhang { get; set; }
        public bool? CPheduyet { get; set; }
        public bool? CNguyenlieu { get; set; }
    }
}
