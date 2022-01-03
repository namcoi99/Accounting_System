using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TSysThuyetminhbctc3
    {
        public int? COrder { get; set; }
        public byte? CCap { get; set; }
        public string CChitieu { get; set; }
        public string CLabelen { get; set; }
        public string CMaso { get; set; }
        public decimal? CSotien { get; set; }
        public int PkId { get; set; }
        public bool? CExported { get; set; }
    }
}
