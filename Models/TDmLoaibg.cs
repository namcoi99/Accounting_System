using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TDmLoaibg
    {
        public int PkId { get; set; }
        public int CMa { get; set; }
        public string CMota { get; set; }
        public string CPrefix { get; set; }
        public string CSeparator { get; set; }
        public int? CLength { get; set; }
        public string CWrite { get; set; }
        public string CRead { get; set; }
        public string CVisible { get; set; }
    }
}
