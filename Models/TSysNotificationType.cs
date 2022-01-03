using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TSysNotificationType
    {
        public int PkId { get; set; }
        public string CCode { get; set; }
        public string CDescription { get; set; }
        public bool? CFromdate { get; set; }
        public bool? CTodate { get; set; }
        public bool? CAccount { get; set; }
        public bool? CCustomer { get; set; }
        public bool? CVessel { get; set; }
        public bool? CVoyage { get; set; }
        public bool? CFromport { get; set; }
        public bool? CToport { get; set; }
        public bool? CBookingnote { get; set; }
        public bool? CDtcp { get; set; }
        public bool? CKmp { get; set; }
        public bool? CKho { get; set; }
        public bool? CVuviec { get; set; }
        public string CReportcode { get; set; }
        public int? FkCreator { get; set; }
        public DateTime? CDatetime { get; set; }
        public bool? CAlert { get; set; }
        public string CMessage { get; set; }
        public int? CObject { get; set; }
        public string CEvent { get; set; }
    }
}
