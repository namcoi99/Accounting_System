using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TSysDynamicReportTemplate
    {
        public int PkId { get; set; }
        public string CGroupName { get; set; }
        public string CTableName { get; set; }
        public string CTableCaption { get; set; }
        public string CFieldName { get; set; }
        public string CFieldCaption { get; set; }
    }
}
