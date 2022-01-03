using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TDubaoctngay
    {
        public int PkId { get; set; }
        public int FkDubaoct { get; set; }
        public DateTime CNgay { get; set; }
        public decimal CSoluong { get; set; }

        public virtual TDubaoct FkDubaoctNavigation { get; set; }
    }
}
