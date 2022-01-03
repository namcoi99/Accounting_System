using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TSysReportpara
    {
        public int PkId { get; set; }
        public int FkReport { get; set; }
        public string CParamertname { get; set; }
        public string CCaption { get; set; }
        public string CCaptionen { get; set; }
        public string CDatatype { get; set; }
        public string CSql { get; set; }
        public bool? CNotop { get; set; }
        public string CColsize { get; set; }
        public string CDisplayfield { get; set; }
        public decimal? CWidth { get; set; }
        public string CKeycontrol { get; set; }
        public string CNamecontrol { get; set; }
        public string CBrowlist { get; set; }
        public string CKeyfield { get; set; }
        public string CCodefield { get; set; }
        public string CNamefield { get; set; }
        public bool? CSamerow { get; set; }
        public bool? CTagvalue { get; set; }
        public string CDefaultvalue { get; set; }
        public string CWhereclause { get; set; }
        public bool? CMultivalue { get; set; }
        public bool? CExported { get; set; }
        public string CNamefield2 { get; set; }
        public bool? CUpper { get; set; }
        public bool? CContinuous { get; set; }
        public bool? CHidden { get; set; }
        public bool? CNotprint { get; set; }
    }
}
