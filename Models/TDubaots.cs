using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TDubaots
    {
        public TDubaots()
        {
            TDubaotsdata = new HashSet<TDubaotsdata>();
        }

        public int PkId { get; set; }
        public byte FkDvcs { get; set; }
        public string CMa { get; set; }
        public string CGhichu { get; set; }
        public DateTime CTungay { get; set; }
        public DateTime CDenngay { get; set; }
        public double CHeso { get; set; }
        public byte? CSokytruoc { get; set; }
        public bool? CKytruoc { get; set; }
        public bool? CTheokh { get; set; }
        public short? FkUser { get; set; }
        public DateTime? CDatetime { get; set; }
        public short? FkModifyuser { get; set; }

        public virtual ICollection<TDubaotsdata> TDubaotsdata { get; set; }
    }
}
