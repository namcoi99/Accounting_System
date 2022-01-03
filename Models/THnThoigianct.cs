using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class THnThoigianct
    {
        public int PkId { get; set; }
        public int FkHnThoigian { get; set; }
        public string CGiothuchien { get; set; }
        public int? CTgepmia { get; set; }
        public int? CTgngungep { get; set; }
        public int? CTgktradinhky { get; set; }
        public int? CTgchomia { get; set; }
        public int? CTghongmaycd { get; set; }
        public int? CTgxulycongnghe { get; set; }
        public int? CTghongmaycdluyen { get; set; }
        public int? CTgsucolohoi { get; set; }
        public int? CTgkhac { get; set; }
        public decimal CDothieudien { get; set; }
        public decimal CDothieunuoc { get; set; }
        public decimal CDothieunhienlieu { get; set; }
        public short? FkUser { get; set; }
        public DateTime? CCreatetime { get; set; }
        public short? FkModifyuser { get; set; }
        public DateTime? CDatetime { get; set; }
        public string FkVuep { get; set; }
        public int? FkDvcs { get; set; }
        public string CGhichu { get; set; }

        public virtual THnThoigian FkHnThoigianNavigation { get; set; }
    }
}
