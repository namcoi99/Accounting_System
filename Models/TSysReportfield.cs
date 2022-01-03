using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TSysReportfield
    {
        public int Id { get; set; }
        public short FkReport { get; set; }
        public byte? CSeq { get; set; }
        public bool? CSelected { get; set; }
        public string CTablefield { get; set; }
        public string CFieldname { get; set; }
        public string CCaption { get; set; }
        public float? CWidth { get; set; }
        public bool? CCondition { get; set; }
        public bool? CFormula { get; set; }
        public string CGroupby { get; set; }
        public string COrderby { get; set; }
        public string CAlignment { get; set; }
        public string CFormat { get; set; }
        public string CDatatype { get; set; }
        public bool? CExported { get; set; }
    }
}
