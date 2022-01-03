using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TSysNotificationConfig
    {
        public int PkId { get; set; }
        public int? FkNotificationType { get; set; }
        public int? CSender { get; set; }
        public string CReceiver { get; set; }
        public bool? CDeleteAfterReceive { get; set; }
        public bool? CEffective { get; set; }
        public int? FkCreateUser { get; set; }
        public DateTime? CDatetime { get; set; }
        public bool? CAlert { get; set; }
        public decimal? CDaily { get; set; }
        public string CMessage { get; set; }
        public int? CDelayTime { get; set; }
        public int? CDuration { get; set; }
        public int? CStartTime { get; set; }
    }
}
