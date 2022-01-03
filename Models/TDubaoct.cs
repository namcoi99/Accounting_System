using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TDubaoct
    {
        public TDubaoct()
        {
            TDubaoctngay = new HashSet<TDubaoctngay>();
        }

        public int PkId { get; set; }
        public int FkDubao { get; set; }
        public int FkVthh { get; set; }
        public short FkDvban { get; set; }
        public decimal CSoluong { get; set; }

        public virtual TDubao FkDubaoNavigation { get; set; }
        public virtual ICollection<TDubaoctngay> TDubaoctngay { get; set; }
    }
}
