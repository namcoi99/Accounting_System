using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TSysAlert
    {
        public int PkId { get; set; }
        public int FkNotificationConfig { get; set; }
        public DateTime? CFromdate { get; set; }
        public DateTime? CTodate { get; set; }
        public int? CKey01 { get; set; }
        public int? CKey02 { get; set; }
        public decimal? CEventStart { get; set; }
        public string CUserlist { get; set; }
        public DateTime? CDatetime { get; set; }
    }
}
