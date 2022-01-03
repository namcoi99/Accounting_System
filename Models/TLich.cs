using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TLich
    {
        public short PkId { get; set; }
        public byte FkDvcs { get; set; }
        public short CNam { get; set; }
        public bool CThuHai { get; set; }
        public bool CThuBa { get; set; }
        public bool CThuTu { get; set; }
        public bool CThuNam { get; set; }
        public bool CThuSau { get; set; }
        public bool CThuBay { get; set; }
        public bool CChuNhat { get; set; }
        public short? FkUser { get; set; }
        public DateTime? CDatetime { get; set; }
    }
}
