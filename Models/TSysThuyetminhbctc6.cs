using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Accounting_System.Models
{
    public partial class TSysThuyetminhbctc6
    {
        public int? COrder { get; set; }
        public byte? CCap { get; set; }
        public string CChitieu { get; set; }
        public string CLabelen { get; set; }
        public decimal? CKehoach { get; set; }
        public decimal? CKynay { get; set; }
        public decimal? CKytruoc { get; set; }
        public int PkId { get; set; }
        public bool? CExported { get; set; }
    }
}
