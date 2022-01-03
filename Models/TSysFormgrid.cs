using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TSysFormgrid
    {
        public string PkFormname { get; set; }
        public string CGridname { get; set; }
        public string CColumnname { get; set; }
        public string CVietnamese { get; set; }
        public string CEnglish { get; set; }
        public byte? CCase { get; set; }
        public byte? CAlign { get; set; }
        public short CWidth { get; set; }
        public bool? CHidden { get; set; }
        public bool? CReadonly { get; set; }
        public string CFormat { get; set; }
        public string CMaskinput { get; set; }
        public bool? CExported { get; set; }
    }
}
