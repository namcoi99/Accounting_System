using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TSysDynamicReportField
    {
        public int PkId { get; set; }
        public int FkReport { get; set; }
        public short COrder { get; set; }
        public string CTableName { get; set; }
        public string CFieldName { get; set; }
        public string CFieldCaption { get; set; }
        public string CSortType { get; set; }
        public byte? CSortOrder { get; set; }
        public byte? CGroupOrder { get; set; }
        public string CFunction { get; set; }
        public string CFormula { get; set; }
        public string COperand { get; set; }
        public string CPrefix { get; set; }
        public string CPostfix { get; set; }
    }
}
