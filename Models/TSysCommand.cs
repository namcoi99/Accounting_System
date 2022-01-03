using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TSysCommand
    {
        public short PkId { get; set; }
        public string CMenuparent { get; set; }
        public byte? CMenulevel { get; set; }
        public string CMenu { get; set; }
        public decimal? CMenuindex { get; set; }
        public string CCommand { get; set; }
        public string CShortcut { get; set; }
        public string CSubcommand { get; set; }
        public byte? CFormtype { get; set; }
        public string CObject { get; set; }
        public string CTablename { get; set; }
        public string CChungtu { get; set; }
        public string CReport { get; set; }
        public string CRead { get; set; }
        public string CWrite { get; set; }
        public string CVisible { get; set; }
        public string CDescription { get; set; }
        public string CDescriptionen { get; set; }
        public string CMenuen { get; set; }
        public bool? CExported { get; set; }
        public byte? CImageIndex { get; set; }
        public bool? CTreeMenu { get; set; }
        public bool? CStdMenu { get; set; }
        public byte? CType { get; set; }
        public bool? CIsGroup { get; set; }
    }
}
