using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TSysList
    {
        public short PkId { get; set; }
        public short CSeq { get; set; }
        public string CTable { get; set; }
        public string CVietnamese { get; set; }
        public string CEnglish { get; set; }
        public string CKeyfield { get; set; }
        public string CSortclause { get; set; }
        public int? CHeight { get; set; }
        public bool? CVisible { get; set; }
        public string CDeletetrigger { get; set; }
        public bool? CViewtype { get; set; }
        public decimal? CLabelsize { get; set; }
        public decimal? CTextsize { get; set; }
        public string CRead { get; set; }
        public string CWrite { get; set; }
        public bool? CAdvanced { get; set; }
        public bool? CExported { get; set; }
        public string CParent { get; set; }
        public bool? CIsgroup { get; set; }
        public short? CRootId { get; set; }
        public string CDescription { get; set; }
        public string CDescriptionen { get; set; }
    }
}
