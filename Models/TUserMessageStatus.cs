using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TUserMessageStatus
    {
        public int PkId { get; set; }
        public int FkUser { get; set; }
        public int? CNewNotif { get; set; }
        public int? COldNotif { get; set; }
        public int? CDeletedNotif { get; set; }
        public int? CNewAlert { get; set; }
        public int? COldAlert { get; set; }
        public int? CDeletedAlert { get; set; }
        public DateTime? CDatetime { get; set; }
        public string CAlertText { get; set; }
    }
}
