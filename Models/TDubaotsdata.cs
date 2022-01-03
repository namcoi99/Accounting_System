using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TDubaotsdata
    {
        public int PkId { get; set; }
        public int FkDubaots { get; set; }
        public int? FkKhachhang { get; set; }
        public int FkVthh { get; set; }
        public short FkDvban { get; set; }
        public decimal CSlban { get; set; }
        public short FkDvtk { get; set; }
        public decimal CSltk { get; set; }
        public double? CHeso { get; set; }

        public virtual TDubaots FkDubaotsNavigation { get; set; }
    }
}
