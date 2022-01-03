using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class VDubaots
    {
        public int PkId { get; set; }
        public string CDvcs { get; set; }
        public string CMa { get; set; }
        public string CGhichu { get; set; }
        public DateTime CTungay { get; set; }
        public DateTime CDenngay { get; set; }
        public double CHeso { get; set; }
        public byte? CSokytruoc { get; set; }
        public bool? CKytruoc { get; set; }
        public bool? CTheokh { get; set; }
        public DateTime? CDatetime { get; set; }
        public string CUser { get; set; }
    }
}
