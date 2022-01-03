using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TDmDvcs
    {
        public short PkId { get; set; }
        public string CMa { get; set; }
        public string CMota { get; set; }
        public string CDiachi { get; set; }
        public string CMst { get; set; }
        public string CTaikhoan { get; set; }
        public string CDienthoai { get; set; }
        public string CFax { get; set; }
        public bool? CDefault { get; set; }
        public string CEmail { get; set; }
        public string CKetoantruong { get; set; }
        public string CGiamdoc { get; set; }
    }
}
