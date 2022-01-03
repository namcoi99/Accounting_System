using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TDmXe
    {
        public int PkId { get; set; }
        public string CSoxe { get; set; }
        public string CLaixe { get; set; }
        public int? FkKh { get; set; }
        public byte? FkLoaixe { get; set; }
    }
}
