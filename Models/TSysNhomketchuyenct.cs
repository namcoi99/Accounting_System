using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TSysNhomketchuyenct
    {
        public short PkId { get; set; }
        public short FkNhomketchuyen { get; set; }
        public string CTutaikhoan { get; set; }
        public string CSangtaikhoan { get; set; }
        public string CGhichu { get; set; }
        public bool? CUpdate { get; set; }
        public string CGiatri { get; set; }
        public string CTentruong { get; set; }
        public bool? CExported { get; set; }
    }
}
