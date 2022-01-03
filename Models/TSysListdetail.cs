using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TSysListdetail
    {
        public short PkId { get; set; }
        public short? CSeq { get; set; }
        public short FkList { get; set; }
        public string CName { get; set; }
        public string CVietnamese { get; set; }
        public string CEnglish { get; set; }
        public byte? CCase { get; set; }
        public int CWidth { get; set; }
        public string CFromtable { get; set; }
        public string CFromfield { get; set; }
        public string CFilterfield { get; set; }
        public string CFromlist { get; set; }
        public decimal? CNdecimal { get; set; }
        public string CDropsql { get; set; }
        public string CDropcaption { get; set; }
        public byte? CAlign { get; set; }
        public bool? CVisible { get; set; }
        public bool? CReadonly { get; set; }
        public string CMask { get; set; }
        public string CFormat { get; set; }
        public string CPermit { get; set; }
        public string CCodefield { get; set; }
        public string CLevelfield { get; set; }
        public bool? CTreefield { get; set; }
        public bool? CIdentity { get; set; }
        public bool? CAllownull { get; set; }
        public bool? CUnique { get; set; }
        public string CAlias { get; set; }
        public string CDropcaptionen { get; set; }
        public bool? CExported { get; set; }
        public bool? CView { get; set; }
        public string CFilterfield2 { get; set; }
        public string CAlias2 { get; set; }
        public short? CWidth2 { get; set; }
    }
}
