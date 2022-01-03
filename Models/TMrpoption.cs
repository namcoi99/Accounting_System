using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TMrpoption
    {
        public int PkId { get; set; }
        public byte FkDvcs { get; set; }
        public short? FkUser { get; set; }
        public DateTime? CDatetime { get; set; }
        public string CCode { get; set; }
        public byte? CVersion { get; set; }
        public DateTime CFromdate { get; set; }
        public DateTime CTodate { get; set; }
        public string CDescription { get; set; }
        public bool? CSafetystock { get; set; }
        public bool? CForecast { get; set; }
        public bool? COnhand { get; set; }
        public bool? CSalesorder { get; set; }
        public bool? CPurchaseorder { get; set; }
        public bool? CSupplyworkorder { get; set; }
        public bool? CDemandworkorder { get; set; }
        public bool? CCheckpoint { get; set; }
        public byte? CScheduletype { get; set; }
        public DateTime? CLastupdate { get; set; }
    }
}
