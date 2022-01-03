using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TSysCusMerg
    {
        public int PkId { get; set; }
        public int? FkKh { get; set; }
        public int? FkNewKh { get; set; }
        public string CMakh { get; set; }
        public string CTenkh { get; set; }
        public int? FkCreateUser { get; set; }
        public string CMaNew { get; set; }
        public string CTenNew { get; set; }
        public DateTime? CDatetime { get; set; }
        public string CNote { get; set; }
    }
}
