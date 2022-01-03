using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TSysAllfield
    {
        public int PkId { get; set; }
        public string CTable { get; set; }
        public string CField { get; set; }
        public string CVietnamese { get; set; }
        public string CEnglish { get; set; }
        public string CDiscription { get; set; }
        public bool? CExported { get; set; }
    }
}
