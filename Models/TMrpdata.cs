using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TMrpdata
    {
        public long PkId { get; set; }
        public int FkMrpoption { get; set; }
        public DateTime? CStartdate { get; set; }
        public DateTime? CDuedate { get; set; }
        public byte? FkSource { get; set; }
        public int? FkProduct { get; set; }
        public byte? CConverted { get; set; }
        public int? FkWorkorder { get; set; }
        public int? FkPurchaseorder { get; set; }
        public decimal? CDemandwo { get; set; }
        public decimal? CDemandso { get; set; }
        public decimal? CDemandsafety { get; set; }
        public decimal? CDemandforecast { get; set; }
        public decimal? CSupplywo { get; set; }
        public decimal? CSupplypo { get; set; }
        public decimal? CSupplystock { get; set; }
        public decimal? COrder { get; set; }
    }
}
