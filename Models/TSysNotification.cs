using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TSysNotification
    {
        public int PkId { get; set; }
        public int FkNotificationConfig { get; set; }
        public DateTime? CValiddate { get; set; }
        public DateTime? CFromdate { get; set; }
        public DateTime? CTodate { get; set; }
        public int? FkAccount { get; set; }
        public int? FkCustomer { get; set; }
        public int? FkVessel { get; set; }
        public int? FkVoyage { get; set; }
        public int? FkFromport { get; set; }
        public int? FkToport { get; set; }
        public int? FkBookingnote { get; set; }
        public int? FkDtcp { get; set; }
        public int? FkKmp { get; set; }
        public int? FkKho { get; set; }
        public int? FkVuviec { get; set; }
        public string CUserlist { get; set; }
        public string COpenlist { get; set; }
        public int? FkSender { get; set; }
        public DateTime? CDatetime { get; set; }
        public string CKey { get; set; }
    }
}
