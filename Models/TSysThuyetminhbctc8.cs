using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TSysThuyetminhbctc8
    {
        public int? COrder { get; set; }
        public byte? CCap { get; set; }
        public string CChitieu { get; set; }
        public string CLabelen { get; set; }
        public decimal? CSodau { get; set; }
        public decimal? CTang { get; set; }
        public decimal? CGiam { get; set; }
        public decimal? CSocuoi { get; set; }
        public decimal? CKetqua { get; set; }
        public int PkId { get; set; }
        public bool? CExported { get; set; }
    }
}
