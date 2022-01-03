using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class VLsx
    {
        public int PkId { get; set; }
        public string CMa { get; set; }
        public DateTime? CNgaylap { get; set; }
        public DateTime? CNgaykt { get; set; }
        public string CMota { get; set; }
        public string CMakh { get; set; }
        public string CTenkh { get; set; }
        public string CDiachi { get; set; }
        public bool? CKttc { get; set; }
        public bool? CKtsx { get; set; }
        public string CDvcs { get; set; }
    }
}
