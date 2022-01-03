using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TSmsScheduleSlotAllocation
    {
        public int PkId { get; set; }
        public int? FkSchedule { get; set; }
        public int? FkContType { get; set; }
        public decimal? CSoluong { get; set; }
        public bool? CLaden { get; set; }
        public bool? CCocsoc { get; set; }
        public decimal? CTaitrong { get; set; }
        public int? FkPol { get; set; }
        public int? FkPod { get; set; }
        public int? FkDepartment { get; set; }
    }
}
