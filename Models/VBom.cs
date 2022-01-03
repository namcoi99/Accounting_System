using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class VBom
    {
        public int PkId { get; set; }
        public string CMa { get; set; }
        public byte? CMaphu { get; set; }
        public DateTime CNgaylap { get; set; }
        public string CTrangthai { get; set; }
        public byte? CSogia { get; set; }
        public string CGhichu { get; set; }
        public DateTime? CDatetime { get; set; }
        public string CDvcs { get; set; }
        public string CUser { get; set; }
    }
}
